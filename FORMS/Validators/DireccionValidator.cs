//using fluentvalidation
using System;
using System.Text;
using FluentValidation;
using seguridad_barrios_privados.Modelos;
using seguridad_barrios_privados.Presentacion;

namespace seguridad_barrios_privados.Validators
{
    public class DireccionValidator : AbstractValidator<Direccion>
    {

        public DireccionValidator()
        {

            //validar nombre
            RuleFor(x => x.Calle)
                .NotEmpty().WithMessage("Complete todos los campos")
                .Length(3, 50).WithMessage("El campo Nombre debe tener" + Environment.NewLine + " entre 3 y 50 caracteres")
                ;
            //validar apellido
            RuleFor(x => x.Altura)
                .NotEmpty().WithMessage("Complete todos los campos")
                ;

        }


    }
}
