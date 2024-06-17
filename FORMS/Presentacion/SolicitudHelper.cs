using System;
using seguridad_barrios_privados;
using seguridad_barrios_privados.Logica;
using seguridad_barrios_privados.Modelos;
using seguridad_barrios_privados.Repositorio;

public class SolicitudHelper
{
    public static void CargarSolicitudes(DataGridView dgSolicitudes, List<SolicitudConDetalle> listaSolicitudes)
    {
        dgSolicitudes.Rows.Clear();
        dgSolicitudes.Refresh();

        foreach (SolicitudConDetalle solicitud in listaSolicitudes)
        {
            if (solicitud.solicitud_estado == 4)
            {
                continue;
            }

            string estadoSolicitud = ObtenerEstadoSolicitud(solicitud.solicitud_estado);

            switch (AppState.UsuarioActual.IdRol) {
                case 1:
                    AgregarFilaPropietario(dgSolicitudes, solicitud, estadoSolicitud);
                    break;
                case 2:
                    AgregarFilaAdmin(dgSolicitudes, solicitud, estadoSolicitud);
                    break;
                case 3:
                    AgregarFilaGuardia(dgSolicitudes, solicitud, estadoSolicitud);
                    break;
            }
           

            if (solicitud.solicitud_estado == 2)
            {
                AplicarEstiloRechazado(dgSolicitudes.Rows[dgSolicitudes.Rows.Count - 1]);
            }
        }
    }

    private static string ObtenerEstadoSolicitud(int estado)
    {
        return estado switch
        {
            1 => "aceptado",
            2 => "rechazado",
            _ => "pendiente"
        };
    }

    private static void AgregarFilaAdmin(DataGridView dgSolicitudes, SolicitudConDetalle solicitud, string estadoSolicitud)
    {
        dgSolicitudes.Rows.Add(
            solicitud.id_solicitud,
            estadoSolicitud,
            solicitud.NombreCompletoUsuario,
            solicitud.usuario_dni,
            solicitud.NombreCompletoVisitante,
            solicitud.visitante_dni,
            solicitud.solicitud_fecha
        );
    }

    private static void AgregarFilaPropietario(DataGridView dgSolicitudes, SolicitudConDetalle solicitud, string estadoSolicitud)
    {
        dgSolicitudes.Rows.Add(
            solicitud.id_solicitud,
            estadoSolicitud,
            solicitud.visitante_nombre,
            solicitud.usuario_apellido,
            solicitud.visitante_dni,
            solicitud.solicitud_fecha,
            "cancelar"
        );
    }

    private static void AgregarFilaGuardia(DataGridView dgSolicitudes, SolicitudConDetalle solicitud, string estadoSolicitud)
    {
        dgSolicitudes.Rows.Add(
            solicitud.id_solicitud,
            solicitud.NombreCompletoUsuario,
            solicitud.NombreCompletoVisitante,
            solicitud.visitante_dni,
            "Aceptar",
            "Rechazar",
            "Cancelar"
        );
    }

    private static void AplicarEstiloRechazado(DataGridViewRow fila)
    {
        Color colorOscuro = Color.FromArgb(25, 46, 71);
        fila.DefaultCellStyle.ForeColor = Color.LightGray;
        fila.DefaultCellStyle.BackColor = colorOscuro;
    }
}

