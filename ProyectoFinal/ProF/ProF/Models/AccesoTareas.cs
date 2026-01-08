using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Prof.Models
{
    public class AccesoTareas
    {
        private string conexion = ConfigurationManager.ConnectionStrings["GestorTareas"].ConnectionString;

        public List<Tarea> ObtenerTodas()
        {
            List<Tarea> lista = new List<Tarea>();
            using (SqlConnection con = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerTareas", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Tarea
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Nombre = dr["Nombre"].ToString(),
                        Descripcion = dr["Descripcion"].ToString(),
                        FechaLimite = Convert.ToDateTime(dr["FechaLimite"]),
                        Estado = (EstadoTarea)Convert.ToInt32(dr["Estado"]),
                        Prioridad = (PrioridadTarea)Convert.ToInt32(dr["Prioridad"]),
                        FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"]),
                        FechaCompletada = dr["FechaCompletada"] == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(dr["FechaCompletada"])
                    });
                }
            }
            return lista;
        }

        public List<Tarea> ObtenerPorEstado(EstadoTarea estado)
        {
            List<Tarea> lista = new List<Tarea>();
            using (SqlConnection con = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerTareasPorEstado", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Estado", (int)estado);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Tarea
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Nombre = dr["Nombre"].ToString(),
                        Descripcion = dr["Descripcion"].ToString(),
                        FechaLimite = Convert.ToDateTime(dr["FechaLimite"]),
                        Estado = (EstadoTarea)Convert.ToInt32(dr["Estado"]),
                        Prioridad = (PrioridadTarea)Convert.ToInt32(dr["Prioridad"]),
                        FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"]),
                        FechaCompletada = dr["FechaCompletada"] == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(dr["FechaCompletada"])
                    });
                }
            }
            return lista;
        }

        public List<Tarea> ObtenerPorPrioridad(PrioridadTarea prioridad)
        {
            List<Tarea> lista = new List<Tarea>();
            using (SqlConnection con = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerTareasPorPrioridad", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Prioridad", (int)prioridad);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Tarea
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Nombre = dr["Nombre"].ToString(),
                        Descripcion = dr["Descripcion"].ToString(),
                        FechaLimite = Convert.ToDateTime(dr["FechaLimite"]),
                        Estado = (EstadoTarea)Convert.ToInt32(dr["Estado"]),
                        Prioridad = (PrioridadTarea)Convert.ToInt32(dr["Prioridad"]),
                        FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"]),
                        FechaCompletada = dr["FechaCompletada"] == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(dr["FechaCompletada"])
                    });
                }
            }
            return lista;
        }

        public Tarea ObtenerPorId(int id)
        {
            Tarea tarea = null;
            using (SqlConnection con = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Tareas WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("@Id", id);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    tarea = new Tarea
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Nombre = dr["Nombre"].ToString(),
                        Descripcion = dr["Descripcion"].ToString(),
                        FechaLimite = Convert.ToDateTime(dr["FechaLimite"]),
                        Estado = (EstadoTarea)Convert.ToInt32(dr["Estado"]),
                        Prioridad = (PrioridadTarea)Convert.ToInt32(dr["Prioridad"]),
                        FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"]),
                        FechaCompletada = dr["FechaCompletada"] == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(dr["FechaCompletada"])
                    };
                }
            }
            return tarea;
        }

        public bool Insertar(Tarea tarea)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    SqlCommand cmd = new SqlCommand("sp_InsertarTarea", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", tarea.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", tarea.Descripcion ?? "");
                    cmd.Parameters.AddWithValue("@FechaLimite", tarea.FechaLimite);
                    cmd.Parameters.AddWithValue("@Prioridad", (int)tarea.Prioridad);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Actualizar(Tarea tarea)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    SqlCommand cmd = new SqlCommand("sp_ActualizarTarea", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", tarea.Id);
                    cmd.Parameters.AddWithValue("@Nombre", tarea.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", tarea.Descripcion ?? "");
                    cmd.Parameters.AddWithValue("@FechaLimite", tarea.FechaLimite);
                    cmd.Parameters.AddWithValue("@Estado", (int)tarea.Estado);
                    cmd.Parameters.AddWithValue("@Prioridad", (int)tarea.Prioridad);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Eliminar(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    SqlCommand cmd = new SqlCommand("sp_EliminarTarea", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<TareaPorVencer> ObtenerTareasPorVencer()
        {
            List<TareaPorVencer> lista = new List<TareaPorVencer>();
            using (SqlConnection con = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM vw_TareasPorVencer", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new TareaPorVencer
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Nombre = dr["Nombre"].ToString(),
                        Descripcion = dr["Descripcion"].ToString(),
                        FechaLimite = Convert.ToDateTime(dr["FechaLimite"]),
                        Prioridad = (PrioridadTarea)Convert.ToInt32(dr["Prioridad"]),
                        DiasRestantes = Convert.ToInt32(dr["DiasRestantes"])
                    });
                }
            }
            return lista;
        }

        public Estadisticas ObtenerEstadisticas()
        {
            Estadisticas stats = new Estadisticas();
            using (SqlConnection con = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM vw_EstadisticasTareas", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    stats.TotalTareas = dr["TotalTareas"] == DBNull.Value ? 0 : Convert.ToInt32(dr["TotalTareas"]);
                    stats.TareasPendientes = dr["TareasPendientes"] == DBNull.Value ? 0 : Convert.ToInt32(dr["TareasPendientes"]);
                    stats.TareasCompletadas = dr["TareasCompletadas"] == DBNull.Value ? 0 : Convert.ToInt32(dr["TareasCompletadas"]);
                    stats.TareasAltaPrioridad = dr["TareasAltaPrioridad"] == DBNull.Value ? 0 : Convert.ToInt32(dr["TareasAltaPrioridad"]);
                }
            }
            return stats;
        }
    }

    public class TareaPorVencer
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaLimite { get; set; }
        public PrioridadTarea Prioridad { get; set; }
        public int DiasRestantes { get; set; }
    }

    public class Estadisticas
    {
        public int TotalTareas { get; set; }
        public int TareasPendientes { get; set; }
        public int TareasCompletadas { get; set; }
        public int TareasAltaPrioridad { get; set; }
    }
}