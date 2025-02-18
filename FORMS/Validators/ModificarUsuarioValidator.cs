﻿using System;
using System.Text;
using FluentValidation;
using seguridad_barrios_privados.Modelos;
using seguridad_barrios_privados.Presentacion;

namespace seguridad_barrios_privados.Validators
{
    public class ModificarUsuarioValidators : AbstractValidator<Usuario>
    {

        public ModificarUsuarioValidators()
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

            //validar telefono
            RuleFor(x => x.Telefono)
                .NotEmpty().WithMessage("Complete todos los campos")
                .Length(10, 10).WithMessage("Telefno no valido")
                ;
            //validar direccion
           
            //validar email
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Complete todos los campos")
                .EmailAddress().WithMessage("El campo Email no es valido")
                ;
           
            //validar rol
            RuleFor(x => x.IdRol)
                .GreaterThan(-1)
                .NotNull()
                .WithMessage("Selecciona un rol")
               ;
        }


    }
}
