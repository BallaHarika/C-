using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApis;

namespace MyAPIs.Controllers
{
    [Route("api/[controller]")] //pattern of uri
    [ApiController]
    public class SecondController : ControllerBase
    {
        [HttpGet]       //api/Second/tryroute
        [Route("tryroute")]   //Additional pattern  //https://localhost:44345/api/tryroute
        public string[] Get()
        {
            return new string[] { "eena", "meena", "deeka", "cheeka" };
        }
        [HttpGet("covidregions")] //localhost:<port>/api/Second/covidregions //https://localhost:44345/api/Second/covidregions
        public List<string> GetPlaces()
        {
            return new List<string>() { "pune", "mumbai", "delhi", "Bangalore" };
        }

        
       [HttpGet("/getplace/{place?}")] //https://.../api/Second/getplace/pune //https://localhost:44345/api/Second/getplace/pune
       [Route("post/{place}")]
        public string GetSinglePlace(string place)
        {
            return $"The selected place is:{place}";
        }

        [HttpGet("{s1}")]  //https://..../api/Second/pune  //https://localhost:44345/api/Second/pune
        public string getAnotherPlace(string s1)
        {
            return $"The other place you choose:{s1}";

        }
        [HttpGet("getsingle /{placeId}/details")]  //=>Routeparam api/Second/getsingle/pune/details?speciality=vadapav     //https://localhost:44345/api/Second/getsingle/pune/details?speciality=vadapav
        public string GetSinglePlace([FromRoute] string placeId, [FromQuery] string speciality)
        {
            return $"{placeId} is known for {speciality}";
        }



     /*    public static List<Post> _posts = new List<Post>();
        [HttpPost("{msg}")] //210 created

        public IActionResult Post([FromBody] Post newPost, [FromRoute] string msg)
        {
            _posts.Add(newPost);

            //https                   :// localhost:<port>               +/api/Second/valueformsg
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/", newPost);
        }

       public static List<Post> _post = new List<Post>();*/

        [HttpGet("/getallposts")]     //https://localhost:5001/getallposts
        public List<Post> GetAllPosts()
        {
            return _posts;
        }


        public static List<Post> _posts = new List<Post>();  

        [HttpPost("newpost/{msgs}")] //210 created           //https://localhost:5001/api/second/newpost/hello

        public IActionResult Post([FromForm] Post newPost, [FromRoute] string msgs)
        {
            if(ModelState.IsValid)
            {

                _posts.Add(newPost);

                                    //https                   :// localhost:<port>               +/api/Second/valueformsg
                return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/", newPost);

            } 
            else
            {
               return BadRequest(ModelState.ErrorCount);   //status code:400  //client side input error
               
            }


        }


        [HttpPut("/update/{id}")]  //https://localhost:5001/update/1

        public IActionResult Update([FromRoute]  int id,[FromForm] Post tobeupdated)
        {
            Post foundPost = _posts.Find((p) => p.id == id);   //for more conditions use &&
            //make the updates
            foundPost.title = tobeupdated.title;
            foundPost.body = tobeupdated.body;
            foundPost.userid = tobeupdated.userid;

            return Ok(foundPost);
        }

        [HttpDelete("/delete/{id}")]    //https://localhost:5001/delete/1

        public IActionResult DeletePost(int id)
        {
            Post deletePosts = _posts.Find((p) => p.id == id);   //for more conditions use &&
            
            _posts.Remove(deletePosts);
         
         

            return Ok("delete successfully");
        }



    }

}

