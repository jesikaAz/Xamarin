using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TP_music
{
    class ChuckNorrisJokeSvc
    {
        HttpClient client = new HttpClient();

        public async Task<ChuckNorrisJoke> GetRandomChuckNorrisJokeAsync() { 
            var response = await client.GetStringAsync("https://api.chucknorris.io/jokes/random"); 
            var joke = JsonConvert.DeserializeObject<ChuckNorrisJoke>(response);
            return joke; 
        }
    }
}
