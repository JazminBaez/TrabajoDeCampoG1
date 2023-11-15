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
   
        public UsuarioValidators()
        {
        
            RuleFor(x => x.Nombre)
                .NotEmpty().WithMessage("Complete todos los campos")
                .Length(3, 50).WithMessage("El campo Nombre debe tener" + Environment.NewLine + " entre 3 y 50 caracteres")
                ;
            RuleFor(x => x.Apellido)
                .NotEmpty().WithMessage("Complete todos los campos")
                .Length(3, 50).WithMessage("El campo Apellido debe tener" + Environment.NewLine + " entre 3 y 50 caracteres")
                ;
            RuleFor(x => x.Telefono)
                .NotEmpty().WithMessage("Complete todos los campos")
                .Length(10, 10).WithMessage("Telefno no valido")
                ;
            RuleFor(x => x.Direccion)
                .NotEmpty().WithMessage("Complete todos los campos")
                .Length(3, 50).WithMessage("El campo Direccion debe tener" + Environment.NewLine + " entre 3 y 50 caracteres")
                ;
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Complete todos los campos")
                .EmailAddress().WithMessage("El campo Email no es valido");
            RuleFor(x => x.Dni)
                .NotEmpty().WithMessage("Complete todos los campos")
                .Length(8, 8).WithMessage("El campo Dni debe tener" + Environment.NewLine + " de 7 a 8 caracteres");
            RuleFor(x => x.Contrasena)
               .NotEmpty().WithMessage("Complete todos los campos")
                .Length(8, 50).WithMessage("La contrasena debe tener " + Environment.NewLine + "al menos 8 caracteres")
               ;
            RuleFor(x => x.IdRol)
                .GreaterThan(-1)
                .NotNull()
                .WithMessage("Selecciona un rol")
               ;
        }


    }
}
