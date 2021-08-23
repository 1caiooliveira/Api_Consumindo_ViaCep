using AutoMapper;
using TestBackEndApi.Domain.Queries.Cep.Get;
using TestBackEndApi.Infrastructure.Services.Contract;

namespace TestBackEndApi.Domain.Profiles
{
    public class GetCepQueryResponseProfile : Profile
    {
        public GetCepQueryResponseProfile()
        {
            CreateMap<GetCepQuery, CepRequest>().ReverseMap();
            CreateMap<GetCepQueryResponse, CepResponse>().ReverseMap();
            CreateMap<MensagemResponse, MensagemQueryResponse>().ReverseMap();

        }
    }
}
