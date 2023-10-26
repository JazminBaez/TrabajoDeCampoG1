using seguridad_barrios_privados.Models;
using seguridad_barrios_privados.Util;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seguridad_barrios_privados.Repositorio
{
    public class SolicitudesRepositorio
    {
        private DbBarriosPrivadosContext barriosPrivadosContext;

        public SolicitudesRepositorio()
        {
            barriosPrivadosContext = Contexto.dbBarriosPrivadosContext!;
        }

        public List<Visitante> prueba() {

           
            return barriosPrivadosContext.Visitantes.ToList();
        }

        public List<Usuario> pruebaDos()
        {
            return barriosPrivadosContext.Usuarios.ToList();
        }

        public List<Solicitude> ObtenerSolicitudes()
        {
            var usuarios = pruebaDos();
            var visitantes = prueba();
            var solicitudes =  barriosPrivadosContext.Solicitudes.Include(s => s.IdUsuarioNavigation).Include(s => s.IdVisitanteNavigation).ToList();
            foreach(Solicitude solicitud in solicitudes)
            {
                foreach (Visitante visitante in visitantes)
                {
                    if(solicitud.IdVisitante == visitante.IdVisitante)
                    {
                        solicitud.IdVisitanteNavigation = visitante;
                    }
                }

                foreach (Usuario usuario in usuarios)
                {
                    if (solicitud.IdUsuario == usuario.IdUsuario)
                    {
                        solicitud.IdUsuarioNavigation = usuario;
                    }
                }
            }
            return solicitudes;
        }

        public void RegistrarSolicitud(int visitante, int usuario)
        {
            var solicitud = new Solicitude()
            {
                IdUsuario = usuario,
                IdVisitante = visitante,
                Baja = false,
                Estado = 0,
                Fecha = DateTime.Today
            };

            barriosPrivadosContext.Solicitudes.Add(solicitud);
            barriosPrivadosContext.SaveChanges();

        }

        public Solicitude ObtenerSolicitud(int id)
        {
            
            var solicitud = barriosPrivadosContext.Solicitudes
                .Where(s => s.IdSolicitud == id)
                .FirstOrDefault();

            return solicitud;
        }

     
        public void ActualizarSolicitud(Solicitude solicitud)
        {
            barriosPrivadosContext.Solicitudes.Update(solicitud);
            barriosPrivadosContext.SaveChanges();
        }
    }
}
