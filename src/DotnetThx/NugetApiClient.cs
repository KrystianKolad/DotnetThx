using System;
using System.Collections.Generic;
using System.Net.Http;
using DotnetThx.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace DotnetThx
{
    public static class NugetApiClient
    {
        private static HttpClient _client;
        static NugetApiClient()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://api-v2v3search-0.nuget.org");
        }

        public static async System.Threading.Tasks.Task<List<Package>> GetPackagesAsync(string name)
        {
            var serializerSettings = new JsonSerializerSettings ();
            serializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver ();
            string url = "query?q=" + name;
            var content = (await (await _client.GetAsync (url)).Content.ReadAsStringAsync ());
            var response =  JsonConvert.DeserializeObject<Response> (await (await _client.GetAsync (url)).Content.ReadAsStringAsync (), serializerSettings);
            return response.data;
        }
    }

    public class Response{
        public List<Package> data { get; set; }
    }
}