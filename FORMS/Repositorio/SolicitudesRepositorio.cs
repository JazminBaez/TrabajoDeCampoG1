using seguridad_barrios_privados.Modelos;
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

        public List<Solicitud> ObtenerSolicitudes()
        {
            var usuarios = pruebaDos();
            var visitantes = prueba();
            var solicitudes =  barriosPrivadosContext.Solicitudes.Include(s => s.IdUsuarioNavigation).Include(s => s.IdVisitanteNavigation).ToList();
            foreach(Solicitud solicitud in solicitudes)
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
