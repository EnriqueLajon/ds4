using Prof.Models;
using ProF.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace ProF.Controllers
{
    [RoutePrefix("api/tareas")]
    public class TareasApiController : ApiController
    {
        private AccesoTareas db = new AccesoTareas();

        // GET: api/tareas
        [HttpGet]
        [Route("")]
        public IHttpActionResult ObtenerTodas()
        {
            try
            {
                var tareas = db.ObtenerTodas();
                return Ok(tareas);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // GET: api/tareas/5
        [HttpGet]
        [Route("{id:int}")]
        public IHttpActionResult ObtenerPorId(int id)
        {
            try
            {
                var tarea = db.ObtenerPorId(id);
                if (tarea == null)
                {
                    return NotFound();
                }
                return Ok(tarea);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // GET: api/tareas/estado/0
        [HttpGet]
        [Route("estado/{estado:int}")]
        public IHttpActionResult ObtenerPorEstado(int estado)
        {
            try
            {
                var tareas = db.ObtenerPorEstado((EstadoTarea)estado);
                return Ok(tareas);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // GET: api/tareas/prioridad/2
        [HttpGet]
        [Route("prioridad/{prioridad:int}")]
        public IHttpActionResult ObtenerPorPrioridad(int prioridad)
        {
            try
            {
                var tareas = db.ObtenerPorPrioridad((PrioridadTarea)prioridad);
                return Ok(tareas);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // GET: api/tareas/porvencer
        [HttpGet]
        [Route("porvencer")]
        public IHttpActionResult ObtenerTareasPorVencer()
        {
            try
            {
                var tareas = db.ObtenerTareasPorVencer();
                return Ok(tareas);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // GET: api/tareas/estadisticas
        [HttpGet]
        [Route("estadisticas")]
        public IHttpActionResult ObtenerEstadisticas()
        {
            try
            {
                var stats = db.ObtenerEstadisticas();
                return Ok(stats);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // POST: api/tareas
        [HttpPost]
        [Route("")]
        public IHttpActionResult Crear([FromBody] Tarea tarea)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                tarea.Estado = EstadoTarea.Pendiente;
                tarea.FechaCreacion = DateTime.Now;

                if (db.Insertar(tarea))
                {
                    return Ok(new { mensaje = "Tarea creada exitosamente" });
                }
                return BadRequest("Error al crear la tarea");
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // PUT: api/tareas/5
        [HttpPut]
        [Route("{id:int}")]
        public IHttpActionResult Actualizar(int id, [FromBody] Tarea tarea)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                tarea.Id = id;

                if (db.Actualizar(tarea))
                {
                    return Ok(new { mensaje = "Tarea actualizada exitosamente" });
                }
                return BadRequest("Error al actualizar la tarea");
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // DELETE: api/tareas/5
        [HttpDelete]
        [Route("{id:int}")]
        public IHttpActionResult Eliminar(int id)
        {
            try
            {
                if (db.Eliminar(id))
                {
                    return Ok(new { mensaje = "Tarea eliminada exitosamente" });
                }
                return BadRequest("Error al eliminar la tarea");
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // POST: api/tareas/5/cambiarestado
        [HttpPost]
        [Route("{id:int}/cambiarestado")]
        public IHttpActionResult CambiarEstado(int id)
        {
            try
            {
                var tarea = db.ObtenerPorId(id);
                if (tarea == null)
                {
                    return NotFound();
                }

                tarea.Estado = tarea.Estado == EstadoTarea.Pendiente ? EstadoTarea.Completada : EstadoTarea.Pendiente;

                if (db.Actualizar(tarea))
                {
                    return Ok(new { mensaje = "Estado actualizado", nuevoEstado = tarea.Estado });
                }
                return BadRequest("Error al cambiar el estado");
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}