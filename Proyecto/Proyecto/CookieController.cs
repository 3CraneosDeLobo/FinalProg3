using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Proyecto.Models;


namespace Proyecto.Controllers
{
    [Route("/cookie")]
    [ApiController]
    public class CookieController : ControllerBase
    {
        HttpClient http = new HttpClient();

        [HttpPost]

        public async Task<ActionResult> Login([FromForm] string name,[FromForm] string pass)
        {

            var response = await http.GetAsync("https://finalprog3-930fc-default-rtdb.firebaseio.com/Users.json");

            if (response.IsSuccessStatusCode)
            {

               
                bool vof = false;

                var content = await response.Content.ReadAsStringAsync();

                var data = JsonConvert.DeserializeObject<Dictionary<string, Users>>(content).ToList();

                var data2 = from x in data
                            select new
                            {
                                UserName = x.Value.UserName,
                                Pwd = x.Value.Password
                            };

                foreach (var x in data2)
                {
                    if (name == x.UserName && pass == x.Pwd)
                    {
                        ClaimsIdentity claimsIdentity = new ClaimsIdentity(
                            new List<Claim>
                            {
                        new Claim(ClaimTypes.NameIdentifier, name)
                            },
                            "auth"
                            );
                        ClaimsPrincipal claims = new ClaimsPrincipal(claimsIdentity);
                        await HttpContext.SignInAsync(claims);
                        vof = true;
                    }
                    
                }
                if (vof)
                {
                    return Redirect("/");
                }
                else
                {
                    return Redirect("/");
                }
                
            }
            else
            {
                return Redirect("/");
            }
        }

        [HttpGet]

        public async Task<ActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }




    }
}
