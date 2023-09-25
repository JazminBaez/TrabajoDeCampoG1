using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using FontAwesome.Sharp;
using seguridad_barrios_privados.Controls;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace seguridad_barrios_privados.Logica
{
    internal class Validaciones
    {
        public static bool IsNumber(char caracter)
        {
            return char.IsDigit(caracter);
        }

        public static bool IsLetter(char caracter)
        {
            return char.IsLetter(caracter);
        }

        public static bool CamposCompletos(Label error, IconPictureBox errorIcon, params RJTextBox[] campos)
        {
            foreach (var campo in campos)
            {
                if (string.IsNullOrWhiteSpace(campo.Texts))
                {
                    error.Text = "Complete todos los campos";
                    error.Visible = true;
                    errorIcon.Visible = true;
                    return false;
                }
            }
            return true;
        }

        public static bool CoincideContrasena(RJTextBox contrasena, RJTextBox repetirContrasena, Label error)
        {
            if (contrasena.Texts != repetirContrasena.Texts)
            {
                error.Text = "Las contraseñas no coinciden";
                error.Visible = true;
                repetirContrasena.BorderColor = Color.Red;
                return false;
            }
            return true;
        }

        public static void RestablecerFormulario(params RJTextBox[] campos)
        {
            foreach (var campo in campos)
            {
                campo.Texts = string.Empty;
                campo.BorderColor = SystemColors.Window;
            }


        }

        public static bool CorreoValido(RJTextBox direccionCorreo, Label error, IconPictureBox errorIcon)
        {
            // Expresión regular para validar direcciones de correo electrónico
            string patron = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";

            // Utiliza la expresión regular para verificar si la dirección es válida
            if (Regex.IsMatch(direccionCorreo.Texts, patron))
            {

                return true;
            }
            else
            {
                direccionCorreo.BorderColor = Color.Red;
                error.Text = "Ingrese un correo valido";
                error.Visible = true;
                return false;
            }
        }

        public static bool ContrasenaValida(RJTextBox tbContrasena, Label error, IconPictureBox errorIcon)
        {
            if (tbContrasena.Texts.Length >= 8)
            {
                tbContrasena.BorderColor = Color.Red;
                error.Text = "La contraseña debe tener al menos 8 caracteres";
                error.Visible = true;
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}