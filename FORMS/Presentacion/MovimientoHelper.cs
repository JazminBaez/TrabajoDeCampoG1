using seguridad_barrios_privados.Logica;
using seguridad_barrios_privados.Modelos;
using seguridad_barrios_privados.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seguridad_barrios_privados.Presentacion
{
    public class MovimientoHelper
    {
        private EgresosRepositorio egresosRepositorio;
        private IngresosRepositorio ingresosRepositorio;
        private List<IngresoConDetalle>Ingresos;
        private List<EgresoConDetalle> Egresos;
        private List<Movimiento> movimientos;

        public MovimientoHelper()
        {
            egresosRepositorio = new EgresosRepositorio();
            ingresosRepositorio = new IngresosRepositorio();
            Ingresos = new List<IngresoConDetalle>();
            Egresos = new List<EgresoConDetalle>();
            movimientos = new List<Movimiento>();
        }

        public List<Movimiento> ObtenerMovimientos()
        {
            Egresos = egresosRepositorio.ObtenerEgresos();
            Ingresos = ingresosRepositorio.ObtenerIngresos();

            foreach (EgresoConDetalle egreso in Egresos)
            {
                Movimiento movimiento = new Movimiento()
                {
                    TipoMovimiento = "Egreso",
                    NombreUsuario = egreso.NombreCompletoUsuario,
                    DniUsuario = egreso.usuario_dni,
                    NombreVisitante = egreso.NombreCompletoVisitante,
                    DniVisitante = egreso.visitante_dni,
                    Fecha = egreso.egreso_fecha,
                    Observaciones = egreso.observaciones
                };
                movimientos.Add(movimiento);
            }

            foreach (IngresoConDetalle ingreso in Ingresos)
            {
                Movimiento movimiento = new Movimiento()
                {
                    TipoMovimiento = "Ingreso",
                    NombreUsuario = ingreso.NombreCompletoUsuario,
                    DniUsuario = ingreso.usuario_dni,
                    NombreVisitante = ingreso.NombreCompletoVisitante,
                    DniVisitante = ingreso.visitante_dni,
                    Fecha = ingreso.ingreso_fecha,
                    Observaciones = "-"
                };
                movimientos.Add(movimiento);
            }

        
            movimientos = movimientos.OrderBy(m => m.Fecha).ToList();

            return movimientos;

        }
    }
}
