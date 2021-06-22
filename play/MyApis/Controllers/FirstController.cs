using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApis;

namespace MyAPIs.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FirstController : ControllerBase
    {
        //http://..../api/First?yourname-Meena
        [HttpGet]         //https://localhost:44345/api/First/Greet
        public string Greet(String yourName)
        {
           yourName = "Meena";

           // return yourName;
           return $"Welcome to Webapis,{yourName}";
        }



        //https://....//api/First
        [HttpGet]    //https://localhost:44345/api/First/SayNamaste

        public string SayNamaste()
        {
            return "Namaste";
        }

       // https://....//api/First/FullName?fname=Meena&lname=Narayan

        [HttpGet]               //https://localhost:44345/api/First/FullName?fname=Meena&lname=Narayan

        public string FullName(string fname, string lname)
        {
            return $"your full name is : {fname} {lname}";
        }
        //https://....//api/First/GetDefaulrPost?i=1

        [HttpGet]                 //https://localhost:44345/api/First/GetDefaultPost?i=1
        public Post GetDefaultPost()
        {
            return new Post()
            {
                id = 1,
                userid = 1,
                title = "sunt aut facere repellat provident occaecati excepturi optio reprehenderit",
                body = "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto" 
            };
        }


        [HttpGet]       //https://localhost:44345/api/First/Greeting

        public int Greeting(int you)
        {
           int    y =67;
            return y;
           // return $"Welcome to Webapis,{yourName}";
        }



        
    }
}
