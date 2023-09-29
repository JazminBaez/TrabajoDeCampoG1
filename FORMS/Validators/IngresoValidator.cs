//using fluentvalidation
using System;
using System.Text;
using FluentValidation;
using seguridad_barrios_privados.Models;
using seguridad_barrios_privados.Presentacion;

namespace seguridad_barrios_privados.Validators
{
    public class VisitanteValidators : AbstractValidator<Visitante>
    {

        public VisitanteValidators()
        {

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

            //validar dni
            RuleFor(x => x.Dni)
                .NotEmpty().WithMessage("Complete todos los campos")
                .Length(10, 10).WithMessage("Telefno no valido")
                ;
           
            //validar rol
            RuleFor(x => x.)
                .GreaterThan(-1)
                .WithMessage("Selecciona un rol")
               ;
        }


    }
}
