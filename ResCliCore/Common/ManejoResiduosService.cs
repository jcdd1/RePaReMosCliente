using ResCliCore.Common.Interface;
using ResCliCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ResCliCore.Common
{
    public class ManejoResiduosService : IManejoResiduosServiceInt
    {
        private JsonSerializerOptions options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        public async Task<List<DataInputDto>> ObtenerResiduos()
        {

            using (var client = new HttpClient())
            {
                var result = await client.GetAsync("https://residuosapi.herokuapp.com/api/Residuos/jsonsalida");
                var contentResult = result.Content.ReadAsStringAsync();
                //var a = JsonConvert.DeserializeObject<DataInput>(await contentResult,);
                var jsonResult = JsonSerializer.Deserialize<List<DataInputDto>>(contentResult.Result, options);

                //return CrearDataInput(JsonConvert.DeserializeObject());
                return jsonResult;

            }

        }
    }
}
