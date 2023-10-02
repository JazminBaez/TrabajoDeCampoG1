using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using seguridad_barrios_privados.Controls;
using seguridad_barrios_privados.Models;
using seguridad_barrios_privados.Presentacion;
using seguridad_barrios_privados.Repositorio;
using seguridad_barrios_privados.Util;
using seguridad_barrios_privados.Validators;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace seguridad_barrios_privados.Logica
{

    public class Validaciones
    {
        private UsuariosRepositorio? usuariosRepositorio;
        private VisitantesRepositorio? visitantesRepositorio;
        private SolicitudesRepositorio? solicitudesRepositorio;
        private IngresosRepositorio? ingresosRepositorio;
        public static bool IsNumber(char caracter)
        {
            return char.IsDigit(caracter);
        }

        public static bool IsLetter(char caracter)
        {
            return char.IsLetter(caracter);
        }

        public static bool CamposCompletos(params RJTextBox[] campos)
        {
            foreach (var campo in campos)
            {
                if (string.IsNullOrWhiteSpace(campo.Texts))
                {

                    return false;
                }
            }
            return true;
        }

        public static bool CoincideContrasena(RJTextBox contrasena, RJTextBox repetirContrasena)
        {
            if (contrasena.Texts != repetirContrasena.Texts)
            {

                return false;
            }
            return true;
        }

        public static void RestablecerFormulario(Label error, IconPictureBox errorIcon, params RJTextBox[] campos)
        {
            foreach (var campo in campos)
            {
                campo.Texts = string.Empty;
                campo.BorderColor = SystemColors.Window;
            }
            error.Visible = false;
            errorIcon.Visible = false;

        }

        public static void MostrarError(System.String mensaje, Label error, IconPictureBox errorIcon)
        {
            error.Text = mensaje;
            errorIcon.Visible = true;
            error.Visible = true;
        }


        public bool RegistrarUsuario(Usuario usuario, string repetirContrasena, Label errorMsg, IconPictureBox errorIcon, DataGridView usuarios)
        {
            var validator = new UsuarioValidators();
            var result = validator.Validate(usuario);
            usuariosRepositorio = new UsuariosRepositorio();

            if (!result.IsValid)
            {
                if (usuario.Contrasena != repetirContrasena)
                {
                    Validaciones.MostrarError("Las contraseñas no coinciden", errorMsg, errorIcon);

                }
                else
                {
                    Validaciones.MostrarError(result.Errors[0].ErrorMessage, errorMsg, errorIcon);
                }

                return false;
            }
            else
            {
                if (usuariosRepositorio.ExisteUsuario(usuario.Email))
                {
                    Validaciones.MostrarError("Correo ya registrado", errorMsg, errorIcon);
                    return false;
                }
                usuarios.Rows.Add(usuario.IdUsuario, usuario.Nombre, usuario.Apellido, usuario.Telefono, usuario.Direccion, usuario.Email, "Eliminar");

                //usuariosRepositorio.

                MessageBox.Show("Usuario registrado con exito", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;


            }
        }

        public bool RegistrarSolicitud(Visitante visitante, ComboBox propietario, Label errorMsg, IconPictureBox errorIcon, DataGridView usuarios)
        {
            var validator = new VisitanteValidators();
            var result = validator.Validate(visitante);
            visitantesRepositorio = new VisitantesRepositorio();
            solicitudesRepositorio = new SolicitudesRepositorio();

            if (!result.IsValid)
            {
                if (!(propietario.SelectedIndex != -1))
                {
                    Validaciones.MostrarError("Seleccione propietario responsable", errorMsg, errorIcon);
                }
                else
                {
                    Validaciones.MostrarError(result.Errors[0].ErrorMessage, errorMsg, errorIcon);
                }

                return false;
            }
            else
            {
                var IdVisitante = visitantesRepositorio.RegistrarVisitante(visitante);
                int IdPropietario = (int)propietario.SelectedValue;
                solicitudesRepositorio.RegistrarSolicitud(IdVisitante, IdPropietario);
                return true;
            }
        }

        public void AceptarSolicitud(DataGridView solicitudes)
        {
            int rowIndex = solicitudes.CurrentCell.RowIndex;
            int columnIndex = 0; // Índice de la columna que deseas
            ingresosRepositorio = new IngresosRepositorio();
            solicitudesRepositorio = new SolicitudesRepositorio();

            
                string cellValue = solicitudes.Rows[rowIndex].Cells[columnIndex].Value.ToString();
                 int idSolicitud = int.Parse(cellValue);

                if (cellValue != null)
                {
                   ingresosRepositorio.RegistrarIngreso(idSolicitud);
                   solicitudesRepositorio.CambiarEstado(idSolicitud, true);
                }
            
        }

    }
}
