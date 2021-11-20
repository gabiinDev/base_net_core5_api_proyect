using FluentValidation;

namespace Application.Features.Clientes.Commands.CreateClienteCommand
{
    public class CreateClienteCommandValidator : AbstractValidator<CreateClienteCommand>
    {
        public CreateClienteCommandValidator()
        {
            RuleFor(p => p.Nombre)
                .NotEmpty().WithMessage("{PropertyName} no puede ser vacio.")
                .MaximumLength(80).WithMessage("{PropertyName} no puede ser mayor a {MaxLength} caracteres.");

            RuleFor(p => p.Apellido)
                .NotEmpty().WithMessage("{PropertyName} no puede ser vacio.")
                .MaximumLength(80).WithMessage("{PropertyName} no puede ser mayor a {MaxLength} caracteres.");

            RuleFor(p => p.FechaNacimiento)
                .NotEmpty().WithMessage("Fecha de Nacimiento no puede ser vacio.");

            RuleFor(p => p.Telefono)
                .MaximumLength(9).WithMessage("{PropertyName} no puede ser mayor a {MaxLength} caracteres.")
                .Matches(@"^\d{4}-\d{4}$").WithMessage("{PropertyName} formato incorrecto. Formato 0000-0000");

            RuleFor(p => p.Email)
            .NotEmpty().WithMessage("{PropertyName} no puede ser vacio.")
            .EmailAddress().WithMessage("{PropertyName} debe ser una dirección de email válido.")
            .MaximumLength(100).WithMessage("{PropertyName} no puede ser mayor a {MaxLength} caracteres.");

            RuleFor(p => p.Direccion)
            .MaximumLength(120).WithMessage("{PropertyName} no puede ser mayor a {MaxLength} caracteres.");
        }
    }
}
