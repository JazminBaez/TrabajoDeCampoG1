﻿using seguridad_barrios_privados.Modelos;
using seguridad_barrios_privados.Util;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seguridad_barrios_privados.Repositorio
{

    public class IngresosRepositorio
    {
        private DbBarriosPrivadosContext barriosPrivadosContext;

        public IngresosRepositorio()
        {
            barriosPrivadosContext = Contexto.dbBarriosPrivadosContext!;
        }

        public bool RegistrarIngreso(int solicitud)
        {
            //crea el ingreso y lo vincula con la solicitud correspondiente
            var ingreso = new Ingreso()
            {
                IdSolicitud = solicitud,
                Fecha = DateTime.Today
            };

            //lo registra
            try
            {
                barriosPrivadosContext.Ingresos.Add(ingreso);
                barriosPrivadosContext.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
           
        }

        public List<Visitante> prueba()
        {


            return barriosPrivadosContext.Visitantes.ToList();
        }

        public List<Solicitud> pruebaDos()
        {
            return barriosPrivadosContext.Solicitudes.ToList();
        }

        public List<Ingreso> ObtenerIngresos()
        {
            var solicitudes = pruebaDos();
            var visitantes = prueba();
            var usuarios = barriosPrivadosContext.Usuarios.ToList();
            var ingresos = barriosPrivadosContext.Ingresos.Include(i => i.IdSolicitudNavigation.IdUsuarioNavigation).ToList();
            foreach (Ingreso ingreso in ingresos)
            {
                foreach (Solicitud solicitud in solicitudes)
                {
                        if (ingreso.IdSolicitud == solicitud.IdSolicitud)
                        {
                            foreach (Usuario usuario in usuarios)
                            {
                                if (usuario.IdUsuario == solicitud.IdUsuario)
                                {
                                    solicitud.IdUsuarioNavigation = usuario;
                                }
                            }
                        ingreso.IdSolicitudNavigation = solicitud;
                        }
                }

            }
            return ingresos;
        }

        public List<Movimiento> ObtenerMovimientos()
        {
            var ingresos = barriosPrivadosContext.Ingresos
            .Include(i => i.IdSolicitudNavigation.IdUsuarioNavigation)
            .Include(i => i.IdSolicitudNavigation.IdVisitanteNavigation)
            .Where(i => i.Fecha != null)
            .Select(i => new Movimiento
            {
                TipoMovimiento = "Ingreso",
                NombreUsuario = i.IdSolicitudNavigation.IdUsuarioNavigation.NombreCompleto,
                DniUsuario = i.IdSolicitudNavigation.IdUsuarioNavigation.Dni,
                NombreVisitante = i.IdSolicitudNavigation.IdVisitanteNavigation.NombreCompleto,
                DniVisitante = i.IdSolicitudNavigation.IdVisitanteNavigation.Dni,
                Fecha = i.Fecha,
                Observaciones = "-",
            }).ToList();

            return ingresos;
        }

        //obtenerIngresoPorId
        public Ingreso ObtenerIngreso(int id)
        {
            var ingreso = barriosPrivadosContext.Ingresos.Include(i => i.IdSolicitudNavigation.IdUsuarioNavigation).FirstOrDefault(i => i.IdIngreso == id);
            return ingreso;
        }


    }
}
