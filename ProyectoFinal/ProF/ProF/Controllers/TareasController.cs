using Prof.Models;
using ProF.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ProF.Controllers
{
    public class TareasController : Controller
    {
        private TareasApiService api = new TareasApiService();

        public async Task<ActionResult> Index(string filtro = "todas")
        {
            ViewBag.Filtro = filtro;
            ViewBag.TareasPorVencer = await api.ObtenerTareasPorVencer();

            switch (filtro)
            {
                case "pendientes":
                    return View(await api.ObtenerPorEstado(EstadoTarea.Pendiente));
                case "completadas":
                    return View(await api.ObtenerPorEstado(EstadoTarea.Completada));
                case "alta":
                    return View(await api.ObtenerPorPrioridad(PrioridadTarea.Alta));
                case "media":
                    return View(await api.ObtenerPorPrioridad(PrioridadTarea.Media));
                case "baja":
                    return View(await api.ObtenerPorPrioridad(PrioridadTarea.Baja));
                default:
                    return View(await api.ObtenerTodas());
            }
        }

        public ActionResult Crear()
        {
            ViewBag.Prioridades = new SelectList(Enum.GetValues(typeof(PrioridadTarea)));
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Crear(Tarea tarea)
        {
            if (ModelState.IsValid)
            {
                tarea.Estado = EstadoTarea.Pendiente;
                tarea.FechaCreacion = DateTime.Now;

                if (await api.Insertar(tarea))
                {
                    TempData["Mensaje"] = "Tarea creada exitosamente";
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Error al crear la tarea");
                }
            }
            ViewBag.Prioridades = new SelectList(Enum.GetValues(typeof(PrioridadTarea)));
            return View(tarea);
        }

        public async Task<ActionResult> Editar(int id)
        {
            Tarea tarea = await api.ObtenerPorId(id);
            if (tarea == null)
            {
                return HttpNotFound();
            }
            ViewBag.Prioridades = new SelectList(Enum.GetValues(typeof(PrioridadTarea)));
            ViewBag.Estados = new SelectList(Enum.GetValues(typeof(EstadoTarea)));
            return View(tarea);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Editar(Tarea tarea)
        {
            if (ModelState.IsValid)
            {
                if (await api.Actualizar(tarea))
                {
                    TempData["Mensaje"] = "Tarea actualizada exitosamente";
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Error al actualizar la tarea");
                }
            }
            ViewBag.Prioridades = new SelectList(Enum.GetValues(typeof(PrioridadTarea)));
            ViewBag.Estados = new SelectList(Enum.GetValues(typeof(EstadoTarea)));
            return View(tarea);
        }

        public async Task<ActionResult> Eliminar(int id)
        {
            Tarea tarea = await api.ObtenerPorId(id);
            if (tarea == null)
            {
                return HttpNotFound();
            }
            return View(tarea);
        }

        [HttpPost, ActionName("Eliminar")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ConfirmarEliminar(int id)
        {
            if (await api.Eliminar(id))
            {
                TempData["Mensaje"] = "Tarea eliminada exitosamente";
            }
            else
            {
                TempData["Error"] = "Error al eliminar la tarea";
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<JsonResult> CambiarEstado(int id)
        {
            try
            {
                if (await api.CambiarEstado(id))
                {
                    return Json(new { success = true });
                }
                return Json(new { success = false, mensaje = "Error al cambiar estado" });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, mensaje = ex.Message });
            }
        }

        public async Task<ActionResult> Reportes()
        {
            ViewBag.Estadisticas = await api.ObtenerEstadisticas();
            ViewBag.TareasPorVencer = await api.ObtenerTareasPorVencer();
            ViewBag.TodasTareas = await api.ObtenerTodas();
            return View();
        }
    }
}