﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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


        public bool RegistrarUsuario(Usuario usuario, Label error, IconPictureBox errorIcon,DataGridView usuarios)
        {
            var validator = new UsuarioValidators();
            var result = validator.Validate(usuario);
            usuariosRepositorio = new UsuariosRepositorio();

            if (!result.IsValid)
            {
                foreach (var errorcito in result.Errors)
                {
                    MessageBox.Show($"Error en {errorcito.PropertyName} {errorcito.ErrorMessage}", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                return false;
            }
            else
            {
                if (!usuariosRepositorio.ExisteUsuario(usuario.Email))
                {

                    usuarios.Rows.Add(usuario.IdUsuario, usuario.Nombre, usuario.Apellido, usuario.Telefono, usuario.Direccion, usuario.Email, "Eliminar");
                    MessageBox.Show("Usuario registrado con exito", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }

                Validaciones.MostrarError("Correo ya registrado", error, errorIcon);
                return false;
            }
        }

    }
}