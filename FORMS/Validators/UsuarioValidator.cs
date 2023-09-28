//using fluentvalidation
using System;
using System.Text;
using FluentValidation;
using seguridad_barrios_privados.Models;
using seguridad_barrios_privados.Presentacion;

namespace seguridad_barrios_privados.Validators
{
    public class UsuarioValidators : AbstractValidator<Usuario>
    {
        private FormGestionarUsuarios? form;
        public UsuarioValidators()
        {
            form = new FormGestionarUsuarios();
            MessageBox.Show(form.RepetirContrasena(), "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //validar nombre
            RuleFor(x => x.Nombre)
                .NotEmpty().WithMessage("Complete todos los campos")
                .Length(3, 50).WithMessage("El campo Nombre debe tener" + Environment.NewLine + " entre 3 y 50 caracteres")
                ;
            //validar apellido
            RuleFor(x => x.Apellido)
                .NotEmpty().WithMessage("Complete todos los campos")
                .Length(3, 50).WithMessage("El campo Apellido debe tener" + Environment.NewLine + " entre 3 y 50 caracteres")
                ;

            //validar telefono
            RuleFor(x => x.Telefono)
                .NotEmpty().WithMessage("Complete todos los campos")
                .Length(10, 10).WithMessage("Telefno no valido")
                ;
            //validar direccion
            RuleFor(x => x.Direccion)
                .NotEmpty().WithMessage("Complete todos los campos")
                .Length(3, 50).WithMessage("El campo Direccion debe tener" + Environment.NewLine + " entre 3 y 50 caracteres")
                ;
            //validar email
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Complete todos los campos")
                .EmailAddress().WithMessage("El campo Email no es valido")
                ;
            //validar contrasena
            RuleFor(x => x.Contrasena)
               .NotEmpty().WithMessage("Complete todos los campos")
               .Equal(form.RepetirContrasena()).WithMessage("Las contraseñas no coinciden")
                .Length(8, 50).WithMessage("La contrasena debe tener " + Environment.NewLine + "al menos 8 caracteres")
               ;
            //validar rol
            RuleFor(x => x.IdRol)
                .GreaterThan(-1)
                .WithMessage("Selecciona un rol")
               ;
        }


    }
}
