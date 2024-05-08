using Microsoft.EntityFrameworkCore;
using seguridad_barrios_privados.Modelos;
using seguridad_barrios_privados.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seguridad_barrios_privados.Repositorio
{
    public class VisitantesRepositorio
    {
        private DbBarriosPrivadosContext barriosPrivadosContext;

        public VisitantesRepositorio()
        {
            barriosPrivadosContext = Contexto.dbBarriosPrivadosContext!;
        }

        public List<Visitante> ObtenerVisitantes()
        {
            return barriosPrivadosContext.Visitantes.ToList();
        }

        public Visitante ObtenerVisitante(int id)
        {
            var visitante = barriosPrivadosContext.Visitantes
                .Where(v => v.IdVisitante == id)
                .FirstOrDefault();

            return visitante; 
        }





        //----------------------------------------------------------------------------------------------------------------------------------------
        public void RegistrarVisitante(Visitante visitante)
        {
            try
            {
                barriosPrivadosContext.Visitantes.Add(visitante);
                barriosPrivadosContext.SaveChanges();
               
            }
            catch (DbUpdateException ex)
            {
                throw new Exception("Error al insertar visitante", ex);
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------







        public bool ExisteVisitante(string dni)
        {
            return barriosPrivadosContext.Visitantes.Any(u => u.Dni== dni);
        }

        public Visitante ObtenerVisitanteDni(string dni)
        {
            var visitante =  barriosPrivadosContext.Visitantes
                .Where(u => u.Dni == dni)
                .FirstOrDefault();

            return visitante;
        }

        
    }
}
