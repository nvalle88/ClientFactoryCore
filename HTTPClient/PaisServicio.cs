using ClientFactoryCore.HTTPClient.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClientFactoryCore.HTTPClient
{
    public class PaisServicio : IPaisServicio
    {

        private readonly HttpClient _httpClient;
        private readonly string _remoteServiceBaseUrl;

        public PaisServicio(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<PaisDTO>> ObtenerPaisesPorNombre(string nombre, bool textoCompleto = false)
        {
            try
            {
                var parametroTextoCompleto = textoCompleto == true ? "?fullText=true" : string.Empty ;
                var uri= $"rest/v2/name/{nombre}";
                var parametros =$"{uri}{parametroTextoCompleto}";
                var resultado = await _httpClient.GetAsync(parametros);
                if (resultado.IsSuccessStatusCode)
                {
                    var res = resultado.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<List<PaisDTO>>(res);
                }
                return new List<PaisDTO>();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


        public async Task<List<PaisDTO>> ObtenerPaisesPorCodigo(string codigo)
        { 
            try
            {
                var uri = $"rest/v2/alpha/{codigo}";
                var resultado = await _httpClient.GetAsync(uri);
                if (resultado.IsSuccessStatusCode)
                {
                    var res = resultado.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<List<PaisDTO>>(res);
                }
                return new List<PaisDTO>();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }



        public async Task<List<PaisDTO>> ObtenerPaises()
        {
            try
            {
                var resultado = await _httpClient.GetAsync("rest/v2/all");
                if (resultado.IsSuccessStatusCode)
                {
                    var res = resultado.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<List<PaisDTO>>(res);
                }
                return new List<PaisDTO>();
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }
    }
}
