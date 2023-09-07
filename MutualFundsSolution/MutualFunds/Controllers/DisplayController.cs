using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Contracts;
using System.Diagnostics.Metrics;
using System.Net;
using System.Reflection.Metadata;

namespace MutualFund.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisplayController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public DisplayController()
        {
            _httpClient = new HttpClient();
        }

        [HttpGet ("Display")]
        public async Task<ActionResult> Get()
        {
            HttpResponseMessage responseA = await _httpClient.GetAsync("https://api.mfapi.in/mf");
            responseA.EnsureSuccessStatusCode();
            var dataFromResponseA = await responseA.Content.ReadAsStringAsync();
            return Ok(dataFromResponseA);

        }
        [HttpGet("GetDisplay")]
        public async Task<ActionResult> Get(int value)  
        {
           
            var urlB = "https://api.mfapi.in/mf/"+ value;

           
            HttpResponseMessage responseB = await _httpClient.GetAsync(urlB);
            responseB.EnsureSuccessStatusCode();

            var responseBContent = await responseB.Content.ReadAsStringAsync();

            // Process responseBContent as needed

            return Ok(responseBContent);
        }
    }






    }

