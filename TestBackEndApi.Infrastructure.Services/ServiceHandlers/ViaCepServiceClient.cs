using AutoMapper;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TestBackEndApi.Infrastructure.Services.Contract;
using TestBackEndApi.Infrastructure.Services.Interfaces;

namespace TestBackEndApi.Infrastructure.Services.ServiceHandlers
{
    public class ViaCepServiceClient : IViaCepServiceClient
    {
        private readonly HttpClient _Client = new HttpClient { BaseAddress = new Uri("https://viacep.com.br/ws/") };
        private readonly IMapper _mapper;

        public ViaCepServiceClient(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<CepResponse> ObterEnderecoPorCepAsync(CepRequest cepRequest)
        {
            try
            {
                string _uri = string.Format("{0}/{1}", cepRequest.Cep, "json");

                var response = await _Client.GetStringAsync(_uri);
                var cep = JsonConvert.DeserializeObject<CepResponse>(response);

                return cep;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        
    }
}
