using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        using (var client = new HttpClient())
        {
            //GET
            string url = "https://jsonplaceholder.typicode.com/posts/1";

            client.DefaultRequestHeaders.Clear();
            //client.DefaultRequestHeaders.Add("Authorization", "fjdhTRWfjkh234e34") autorizacion.
            var response = client.GetAsync(url).Result;

            var res = response.Content.ReadAsStringAsync().Result;
            dynamic r = JObject.Parse(res); 

            Console.WriteLine(r);
            //GET

            //POST

            string url2 = "https://jsonplaceholder.typicode.com/posts";

            client.DefaultRequestHeaders.Clear();

            string parametros = "{'title': 'sas', 'body': 'Bienvenuteee', 'userId': '23',}";
            dynamic jsonString = JObject.Parse(parametros);

            var httpContent = new StringContent(jsonString.ToString(), Encoding.UTF8, "application/json");
            var response2 = client.PostAsync(url2, httpContent).Result;
            var res2 = response2.Content.ReadAsStringAsync().Result;
            dynamic r2 = JObject.Parse(res2);

            Console.WriteLine(r2);

            //POST

            //PUT

            string url3 = "https://jsonplaceholder.typicode.com/posts/1";

            client.DefaultRequestHeaders.Clear();

            string parametros3 = "{'title': 'sas ses', 'body': 'Bienvenuteee', 'userId': '23',}";
            dynamic jsonString3 = JObject.Parse(parametros3);

            var httpContent3 = new StringContent(jsonString3.ToString(), Encoding.UTF8, "application/json");
            var response3 = client.PutAsync(url3, httpContent3).Result;
            var res3 = response3.Content.ReadAsStringAsync().Result;
            dynamic r3 = JObject.Parse(res3);

            Console.WriteLine(r3);

            //PUT

            //PATCH

            string url4 = "https://jsonplaceholder.typicode.com/posts/1";

            client.DefaultRequestHeaders.Clear();

            string parametros4 = "{'title': 'sas ses'}";
            dynamic jsonString4 = JObject.Parse(parametros4);

            var httpContent4 = new StringContent(jsonString4.ToString(), Encoding.UTF8, "application/json");
            var response4 = client.PatchAsync(url4, httpContent4).Result;
            var res4 = response4.Content.ReadAsStringAsync().Result;
            dynamic r4 = JObject.Parse(res4);

            Console.WriteLine(r4);

            //PATCH

        }
    }
}