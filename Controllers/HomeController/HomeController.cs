using Microsoft.AspNetCore.Mvc;
namespace helloWorld
{
    public class HomeController : Controller 
    {
        //Requests
        //localhost:5000/
             //associated route string (excluding the leading /)
        [HttpGet("")]       //this is the type of request
        public ViewResult Index()
        {
            return View();
        }

        //localhost:5000/hello
        [Route("hello")]
        [HttpGet]
        public string Hello()
        {
            return "Once Again, Hello!!!!";
        }


    }
}