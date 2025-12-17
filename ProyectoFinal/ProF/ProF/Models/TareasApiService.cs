using Prof.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace ProF.Models
{
    public class TareasApiService
    {
        private static HttpClient client = new HttpClient();
        private string baseUrl;

        public TareasApiService()
        {
            var request = HttpContext.Current.Request;
            baseUrl = $"{request.Url.Scheme}://{request.Url.Authority}/api/tareas/";
        }

        public async Task<List<Tarea>> ObtenerTodas()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(baseUrl);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<List<Tarea>>();
                }
                return new List<Tarea>();
            }
            catch
            {
                return new List<Tarea>();
            }
        }

        public async Task<Tarea> ObtenerPorId(int id)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(baseUrl + id);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<Tarea>();
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<Tarea>> ObtenerPorEstado(EstadoTarea estado)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(baseUrl + "estado/" + (int)estado);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<List<Tarea>>();
                }
                return new List<Tarea>();
            }
            catch
            {
                return new List<Tarea>();
            }
        }

        public async Task<List<Tarea>> ObtenerPorPrioridad(PrioridadTarea prioridad)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(baseUrl + "prioridad/" + (int)prioridad);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<List<Tarea>>();
                }
                return new List<Tarea>();
            }
            catch
            {
                return new List<Tarea>();
            }
        }

        public async Task<List<TareaPorVencer>> ObtenerTareasPorVencer()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(baseUrl + "porvencer");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<List<TareaPorVencer>>();
                }
                return new List<TareaPorVencer>();
            }
            catch
            {
                return new List<TareaPorVencer>();
            }
        }

        public async Task<Estadisticas> ObtenerEstadisticas()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(baseUrl + "estadisticas");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<Estadisticas>();
                }
                return new Estadisticas();
            }
            catch
            {
                return new Estadisticas();
            }
        }

        public async Task<bool> Insertar(Tarea tarea)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync(baseUrl, tarea);
                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> Actualizar(Tarea tarea)
        {
            try
            {
                HttpResponseMessage response = await client.PutAsJsonAsync(baseUrl + tarea.Id, tarea);
                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> Eliminar(int id)
        {
            try
            {
                HttpResponseMessage response = await client.DeleteAsync(baseUrl + id);
                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> CambiarEstado(int id)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsync(baseUrl + id + "/cambiarestado", null);
                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }
    }
}