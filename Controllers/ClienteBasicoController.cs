using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ClientFactoryCore.HTTPClient;
using ClientFactoryCore.HTTPClient.Modelos;
using ClientFactoryCore.Modelos;
using GeoCode.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ClientFactoryCore.Controllers
{
    [Route("api/Catalogo")]
    [ApiController]
    public class ClienteBasicoController : ControllerBase
    {
        private IPaisServicio _paisServicio;
        public ClienteBasicoController(IHttpClientFactory httpClientFactory, IPaisServicio paisServicio)
        {
             _paisServicio=paisServicio;
        }

        [Route("ObtenerPaises")]
        public async Task<ActionResult<List<PaisDTO>>> ObtenerPaises()
        {

            try
            {
                return await _paisServicio.ObtenerPaises();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}