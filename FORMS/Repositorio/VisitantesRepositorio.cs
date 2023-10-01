using Microsoft.EntityFrameworkCore;
using seguridad_barrios_privados.Models;
using seguridad_barrios_privados.Util;
using System;
using System.Collections.Generic;
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

        public async Task<Visitante> ObtenerVisitante(string Dni)
        {
            // Consulta LINQ para buscar un usuario por correo y contraseña
            var visitante = await barriosPrivadosContext.Visitantes
                .Where(v => v.Dni == Dni)
                .FirstOrDefaultAsync();

            return visitante;
        }




    }
 }
