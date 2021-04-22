using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BlazorInputFile;
using Microsoft.JSInterop;
using Newtonsoft.Json;

namespace Proyecto.Pages
{
    public class Funciones
    {
        IJSRuntime JS;
        HttpClient http = new HttpClient();
     
       public MultipartFormDataContent data;
        public string url = "https://api.imgbb.com/1/upload?expiration=3000000&key=d3892a5dd5edc697fa0f0b9411f78edc";
       
        
        /// IMAGEN
        public async Task CargarImagen(IFileListEntry[] files)
        {
         

            var file = files.FirstOrDefault();
            if(file != null)
            {
                var ms = new MemoryStream();
                await file.Data.CopyToAsync(ms);
                data = new MultipartFormDataContent
                {
                    {new ByteArrayContent(ms.GetBuffer()), "image", file.Name}
                };
                

            }



        }

        public async Task<string> ObtenerURL()
        {
            var response = await http.PostAsync(url, data);
            if (response.IsSuccessStatusCode)
            {
                var hola = JsonConvert.DeserializeObject<Root>(await response.Content.ReadAsStringAsync());
                return hola.data.url;
            }
            else
            {
                return "";
            }
         


        }



        /// MAPA






    }




    public class Image
    {
        public string filename { get; set; }
        public string name { get; set; }
        public string mime { get; set; }
        public string extension { get; set; }
        public string url { get; set; }
    }

    public class Thumb
    {
        public string filename { get; set; }
        public string name { get; set; }
        public string mime { get; set; }
        public string extension { get; set; }
        public string url { get; set; }
    }

    public class Data
    {
        public string id { get; set; }
        public string title { get; set; }
        public string url_viewer { get; set; }
        public string url { get; set; }
        public string display_url { get; set; }
        public int size { get; set; }
        public string time { get; set; }
        public string expiration { get; set; }
        public Image image { get; set; }
        public Thumb thumb { get; set; }
        public string delete_url { get; set; }
    }

    public class Root
    {
        public Data data { get; set; }
        public bool success { get; set; }
        public int status { get; set; }
    }










}
