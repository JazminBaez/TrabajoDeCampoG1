using seguridad_barrios_privados.Modelos;
using seguridad_barrios_privados.Util;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace seguridad_barrios_privados.Repositorio
{
    public class SolicitudesRepositorio
    {
        private DbBarriosPrivadosContext barriosPrivadosContext;

        public SolicitudesRepositorio()
        {
            barriosPrivadosContext = Contexto.dbBarriosPrivadosContext!;
        }


        public List<SolicitudConDetalle> ObtenerSolicitudes()
        {
            try
            {
                var solicitudes = barriosPrivadosContext.SolicitudConDetalle
                    .FromSqlRaw("exec sp_ListarSolicitudesConDetalles")
                    .ToList();

                return solicitudes;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return new List<SolicitudConDetalle>(); // Devolver una lista vacía en caso de error
            }


        }

        public void RegistrarSolicitud(Solicitud solicitud)
        {
            try { 
             
                barriosPrivadosContext.Solicitudes.Add(solicitud);
                barriosPrivadosContext.SaveChanges();

            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }

        public Solicitud ObtenerSolicitud(int id)
        {
            
            var solicitud = barriosPrivadosContext.Solicitudes
                .Where(s => s.IdSolicitud == id)
                .FirstOrDefault();

            return solicitud;
        }

     
        public void ActualizarSolicitud(Solicitud solicitud)
        {
            barriosPrivadosContext.Solicitudes.Update(solicitud);
            barriosPrivadosContext.SaveChanges();
        }
    }
}
