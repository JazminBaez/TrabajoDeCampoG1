using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using seguridad_barrios_privados.Controls;
using seguridad_barrios_privados.Modelos;
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
        private DireccionRepositorio? direccionRepositorio;

        public Validaciones()
        {
            visitantesRepositorio = new VisitantesRepositorio();
            solicitudesRepositorio = new SolicitudesRepositorio();
            usuariosRepositorio = new UsuariosRepositorio();
            ingresosRepositorio = new IngresosRepositorio();
        }
      

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
            else
            {
                return true;
            }
            
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

        public static void MostrarError(System.String mensaje, Label error)
        {
            error.Text = mensaje;
           
            error.Visible = true;
        }
       
     

        public bool RegistrarUsuario(Usuario usuario,Direccion direccion, string repetirContrasena, Label errorMsg, IconPictureBox errorIcon, DataGridView usuarios)
        {
            var validator = new UsuarioValidators();
            var result = validator.Validate(usuario);
           

            if (!result.IsValid)
            {
                if (usuario.Contrasena != repetirContrasena || repetirContrasena == null)
                {
                    Validaciones.MostrarError("Las contraseñas no coinciden", errorMsg);

                }
                else
                {
                    Validaciones.MostrarError(result.Errors[0].ErrorMessage, errorMsg);
                }

                return false;
            }
            else
            {
               if(RegistrarDireccion(direccion, errorMsg)!= null)
                {
                    usuario.IdDireccion = RegistrarDireccion(direccion, errorMsg).IdDireccion;
                    this.usuariosRepositorio.InsertarUsuario(usuario);
                }

                return true;

            }
        }

        public bool ModificarUsuario(Usuario usuario, string dniOriginal, string correoOriginal, Label errorMsg, IconPictureBox errorIcon, DataGridView usuarios)
        {
            var validator = new ModificarUsuarioValidators();
            var result = validator.Validate(usuario);
            usuariosRepositorio = new UsuariosRepositorio();

            if (!result.IsValid)
            {
                Validaciones.MostrarError(result.Errors[0].ErrorMessage, errorMsg);
                return false;
            }
            else
            {
                string emailNuevo = usuario.Email;
                string dniNuevo = usuario.Dni;

                if (emailNuevo != correoOriginal)
                {
                    if (usuariosRepositorio.ExisteUsuario(usuario.Email))
                    {
                        Validaciones.MostrarError("Correo ya registrado", errorMsg);
                        return false;
                    }
                    return true;
                }

                if (dniNuevo != dniOriginal)
                {
                    if (usuariosRepositorio.ObtenerUsuariosPorDni(dniNuevo) != null)
                    {
                        Validaciones.MostrarError("Dni ya registrado", errorMsg);
                        return false;
                    }
                    return true;
                }
                return true;
            }
        }




        //----------------------------------------------------------------------------------------------------------------------
        public void VerificarSolicitud(Visitante visitante, DateTime fecha, ComboBox propietario, Label errorMsg)
        {
            var validator = new VisitanteValidators();
            var result = validator.Validate(visitante);
      
            int idVisitante;
            int idPropietario;

            //Verifica que si el que esta registrando la solicitud es un guardia entonces debio haber soleccionado un propietario responsable
            if (AppState.UsuarioActual.IdRol == 3 && (propietario == null || propietario.SelectedIndex == -1))
            {
                MostrarError("Seleccione propietario" + Environment.NewLine + " responsable", errorMsg);
            }

            //valida que esten correctos los datos de visitante
            if (!result.IsValid)
            {
                MostrarError(result.Errors[0].ErrorMessage, errorMsg);
            }
            else
            {
                //registra el visitante
                RegistrarVisitante(visitante);
                idVisitante = visitantesRepositorio.ObtenerVisitanteDni(visitante.Dni).IdVisitante;


                //Setea como responsable el porpietario seleccionado por el guardia
                if(AppState.UsuarioActual.IdRol == 3)
                {
                    idPropietario = (int)propietario.SelectedValue;
                }
                else
                {
                    //Setea como responsable al propietario que creo la solicitud
                    idPropietario = AppState.UsuarioActual.IdUsuario;
                }

                var solicitud = new Solicitud()
                {
                    IdUsuario =idPropietario,
                    IdVisitante = idVisitante,
                    Estado = 0,
                    Fecha = fecha
                };


                //Registra la solicitud

                try
                {
                    solicitudesRepositorio.RegistrarSolicitud(solicitud);
                    MessageBox.Show("Solicitud Registrada con exito");
           
                }catch(Exception ex)
                {
                    MessageBox.Show("No fue posible registrar la solicitud", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }





        //----------------------------------------------------------------------------------------------------------------------------------------------

        public void RegistrarVisitante(Visitante visitante)
        {
            int idVisitante;
            //verifica si ya existe ese visitante registrado
            if (visitantesRepositorio.ExisteVisitante(visitante.Dni))
            {

                var visitanteEncontrado = visitantesRepositorio.ObtenerVisitanteDni(visitante.Dni);

                //pide confirmar al guardia si el visitante que se encontro registrado es el que se pretendia seleccionar
                string mensaje = $"Visitante encontrado: {visitanteEncontrado.NombreCompleto}, DNI: {visitanteEncontrado.Dni}";
                DialogResult resultado = MessageBox.Show(mensaje, "Mensaje de Visitante", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (resultado == DialogResult.OK)
                {
                   idVisitante = visitanteEncontrado.IdVisitante;
                 
                }

            }
            else
            {
                visitantesRepositorio.RegistrarVisitante(visitante);
                idVisitante =  visitantesRepositorio.ObtenerVisitanteDni(visitante.Dni).IdVisitante;
            }
        }


        //--------------------------------------------------------------------------------------------------------------------------------------------

        public void AceptarSolicitud(Solicitud solicitud)
        {
            solicitud.Estado = 1;

            try
            {
                ingresosRepositorio.RegistrarIngreso(solicitud.IdSolicitud);
                solicitudesRepositorio.ActualizarSolicitud(solicitud);
                MessageBox.Show("Solicitud aceptada", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("No fue posible registrar el ingreso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RechazarSolicitud(Solicitud solicitud)
        {
            solicitud.Estado = 2;
            try
            {
                solicitudesRepositorio.ActualizarSolicitud(solicitud);
                MessageBox.Show("Solicitud aceptada", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("No fue posible rechazar la solicitud", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        
        public void cancelarSolicitud(Solicitud solicitud)
        {
            solicitud.Estado = 3;
            try
            {

                solicitudesRepositorio.ActualizarSolicitud(solicitud);
                MessageBox.Show("Solicitud cancelada", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }catch (Exception ex)
            {
                MessageBox.Show("No fue posible cancelar la solicitud", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    //-------------------------------------------------------------------------------------------------------------------------------------------------------------







        public Direccion RegistrarDireccion(Direccion direccion, Label errorMsg)
        {
            var validator = new DireccionValidator();
            var result = validator.Validate(direccion);
     
            if (!result.IsValid)
            {

                Validaciones.MostrarError(result.Errors[0].ErrorMessage, errorMsg);
                return null;
            }
            else
            {
                direccionRepositorio = new DireccionRepositorio();
               return direccionRepositorio.RegistrarDireccion(direccion);
                
            }
            
        }

    }
}
