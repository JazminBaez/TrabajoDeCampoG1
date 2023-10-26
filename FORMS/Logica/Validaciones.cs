using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

                return true;


            }
        }

        public bool ModificarUsuario(Usuario usuario, string repetirContrasena, Label errorMsg, IconPictureBox errorIcon, DataGridView usuarios)
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
                string emailAntiguo = usuariosRepositorio.ObtenerUsuarioPorId(usuario.IdUsuario).Email;

                if (emailAntiguo != usuario.Email && usuariosRepositorio.ExisteUsuario(usuario.Email))
                {
                    Validaciones.MostrarError("Correo ya registrado", errorMsg, errorIcon);
                    return false;
                }

                return true;


            }
        }


        public bool RegistrarSolicitud(Visitante visitante, ComboBox propietario, Label errorMsg, IconPictureBox errorIcon, DataGridView usuarios)
        {
            var validator = new VisitanteValidators();
            var result = validator.Validate(visitante);
            visitantesRepositorio = new VisitantesRepositorio();
            solicitudesRepositorio = new SolicitudesRepositorio();
            int IdVisitante;
            int IdPropietario;

            if (!result.IsValid)
            {


                Validaciones.MostrarError(result.Errors[0].ErrorMessage, errorMsg, errorIcon);


                return false;
            }

            if (propietario.SelectedIndex == -1)
            {
                Validaciones.MostrarError("Seleccione propietario" + Environment.NewLine + " responsable", errorMsg, errorIcon);
                return false;
            }

            else
            {
                if (visitantesRepositorio.ExisteVisitante(visitante.Dni))
                {

                    var visitanteEncontrado = visitantesRepositorio.ObtenerVisitanteDni(visitante.Dni);
                    string mensaje = $"Visitante encontrado: {visitanteEncontrado.NombreCompleto}, DNI: {visitanteEncontrado.Dni}";
                    DialogResult resultado = MessageBox.Show(mensaje, "Mensaje de Visitante", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (resultado == DialogResult.OK)
                    {
                        IdVisitante = visitanteEncontrado.IdVisitante;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    IdVisitante = visitantesRepositorio.RegistrarVisitante(visitante);
                }


                IdPropietario = (int)propietario.SelectedValue;
                solicitudesRepositorio.RegistrarSolicitud(IdVisitante, IdPropietario);

                return true;
            }
        }

      

    }
}
