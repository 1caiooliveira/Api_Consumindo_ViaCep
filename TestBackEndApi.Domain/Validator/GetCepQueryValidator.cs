using FluentValidation;
using TestBackEndApi.Domain.Queries.Cep.Get;

namespace TestBackEndApi.Domain.Queries.Cep.Validator
{
    public class GetCepQueryValidator : AbstractValidator<GetCepQuery>
    {
        public GetCepQueryValidator()
        {
            RuleFor(_request => _request.Cep).NotEmpty().WithMessage("Informe o Cep!")
                .Length(9).WithMessage("O campo CEP precisa ter 9 digitos!");
            RuleFor(_request => _request.Json).NotEmpty().WithMessage("Informe o tipo de retorno!");

        }
    }
}
