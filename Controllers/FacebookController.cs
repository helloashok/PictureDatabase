using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using System.IO;

using System.Net;
using System.Net.Http;
using Microsoft.AspNetCore.Authentication.Facebook;

using System.Web.Http;

using System.Configuration;
using Newtonsoft.Json.Linq;

using System.Data.SqlClient;

using System.Web;

namespace PictureDatabase.Controllers
{
    public class FacebookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public  async Task<HttpResponseMessage> GetAccessCode()
        {
            try
            {
                var fb = new FacebookClient();
                var loginUrl = fb.GetLoginUrl(new
                {
                    client_id = "415547075642876",
                    client_secret = "ab7b6d89df67c7ee5b5df7de14b0f241",
                    //redirect_uri = RedirectUri.AbsoluteUri,
                    redirect_uri = "http://localhost:50186/api/Image/GetToken",
                    // RedirectUri.AbsoluteUri,       
                    response_type = "code",
                    scope = "email,manage_pages,publish_pages" // Add other permissions as needed
                });

            }
            catch (Exception ex)
            {
                var a = ex;
            }


            return null;


        }
        public IHttpActionResult GetToken(String token)
        {

            var client = new FacebookClient(token);

            dynamic pagetoken = client.Get("336107027195328?fields=access_token");
            var pageaccesstoken = pagetoken;
            string jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(pageaccesstoken);


            var abc = JObject.Parse(jsonString)["access_token"];
            String patoken = abc.ToString();

            var clientpost = new FacebookClient(patoken);

            byte[] imageArray = System.IO.File.ReadAllBytes(@"C:\Users\rajan\source\repos\WebApplication9\WebApplication9\App_Data\image\00f3a6c4-c5e4-4918-b32b-39f06779e875.jpg");

            dynamic parameters = new System.Dynamic.ExpandoObject();
            parameters.source = new FacebookMediaObject
            {
                ContentType = "image",
                FileName = "abc"
            }.SetValue(imageArray);

            dynamic poosting = clientpost.Post("/336107027195328/photos", parameters);

            return null;

        }


    }
}