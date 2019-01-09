using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PictureDatabase.Models;
using System.Web;
using PictureDatabase.Repository;
using PictureDatabase.ViewModels;
using MailKit.Net.Smtp;
using MimeKit;
using reCAPTCHA;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace PictureDatabase.Controllers
{
    
    
    public class UsersController : Controller


    {
        private IRepository<Users> _userrepository;
      


        public UsersController()
        {
            this._userrepository = new AllRepository<Users>();
          
           

        }

        // GET: Users
        public ActionResult Index()
        {
            return View();
        }

        // GET: Users/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Users/Create
        public ActionResult Create()
        {
        
            var user = User.Identity.Name;
            return View();
        }

        // POST: Users/Create
        [HttpPost]
        //   [ValidateAntiForgeryToken]
        public ActionResult Create(Users user)
        {
            try
            {
                byte[] salt = new byte[8];
                string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                      password: new string(user.Password),
                      salt: salt,
                      prf: KeyDerivationPrf.HMACSHA1,
                      iterationCount: 10000,
                      numBytesRequested: 256 / 8));
                Console.WriteLine($"Hashed: {hashed}");





                var UserCount = _userrepository.FindByCondition(x => x.UserName == user.UserName && x.Password == hashed).FirstOrDefault();
                var check = UserCount;
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }


            //  return View();
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Users/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
              
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Users/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Users/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        [AllowAnonymous]
        public ActionResult UserLogin()
        {


            return View();


        }



        [HttpPost]
       
        [AllowAnonymous]
        public ActionResult UserCheck(Users user)
        {

            

      

                string password = GenerateHash(user.Password);
            // this is the starting of the code


            var UserCount = _userrepository.FindByCondition(x => x.UserName == user.UserName && x.Password == password).FirstOrDefault();
            if (UserCount != null)
            {
                var secretKey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("superSecretKey@345"));
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,user.UserName)

                };
                var abc = claims;

                var tokeOptions = new JwtSecurityToken(
                    issuer: "http://localhost:44344",
                    audience: "http://localhost:44344",

                    claims: claims,
                    expires: DateTime.Now.AddMinutes(5),
                    signingCredentials: signinCredentials
                );


                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);












            //    return Ok(new { Token = tokenString,RedirectUrl= "https://localhost:44334/Users/WelcomeScreen" });
               return Ok(new { Token = tokenString });
                //     return RedirectToAction("WelcomeScreen");
            }
            else
            {
                return Unauthorized();
            }

           
                











                // this is the ending of the code i modified
               
              
            //   return RedirectToAction(nameof(Index));
            }
            
          

       
        public ActionResult ChangePassword()
        {

            //var token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiQmlqYXkiLCJleHAiOjE1NDY3MDUyMzUsImlzcyI6Imh0dHA6Ly9sb2NhbGhvc3Q6NDQzNDQiLCJhdWQiOiJodHRwOi8vbG9jYWxob3N0OjQ0MzQ0In0.1MyiherZuLTnV";
            //var abc = new JwtSecurityTokenHandler().ReadJwtToken(token);
            //var signature= abc.SignatureAlgorithm;
            //var audience = abc.Audiences;
            //var issuer = abc.Audiences;
            //var checksignature = abc.RawSignature;
            

                
            
            //  var token = "QzpcVXNlcnNcVXNlclxzb3VyY2VccmVwb3NcUGljdHVyZURhdGFiYXNlXFBpY3R1cmVEYXRhYmFzZVxVc2Vyc1xDaGFuZ2VQYXNzd29yZA";
            //   var something = new JwtSecurityToken(token).Claims;




           
            return View();
        }

     




          [HttpPost]
          [Authorize]
        public ActionResult ChangePassword(ChangePassword user)
        {
            var identity = User.Identity.IsAuthenticated;
            var Username = User.Identity.Name;
            String password = GenerateHash(user.OldPassword);
            
            var Updateuser = _userrepository.FindByCondition(x => x.UserName == Username && x.Password == password).FirstOrDefault();
            if (Updateuser != null)
            {
                var newPassword = GenerateHash(user.NewPassword);
                Updateuser.Password = newPassword;
                _userrepository.Update(Updateuser);

            }






            return View();
        }

        public ActionResult WelcomeScreen()
        {
            return View();
        }


        // this is the view when user clicks 
        public ActionResult ForgetPassword()
        {


            return View();
        }

        // whenever user clicks the email at forget password it will call sendlink controller for sending email
        [HttpPost]
        public ActionResult SendLink(ResetPasswordViewModel email)
        {
            var emailtocheck = email.Useremail;
            var Updateuser = _userrepository.FindByCondition(x => x.UserEmail == email.Useremail).FirstOrDefault();
            if (Updateuser != null)
            {

                Updateuser.ResetTime = DateTime.Now;


                var Message = new MimeMessage();

                Message.From.Add(new MailboxAddress("Dummy", "idummy154@gmail.com"));
                Message.To.Add(new MailboxAddress(email.Useremail));

                Message.Subject = "Change Password";
                Message.Body = new TextPart("plain") { Text = "https://localhost:44334/Users/ResetPassword" };
                var client = new SmtpClient();
                client.Connect("smtp.gmail.com", 587, false);

                client.Authenticate("idummy154@gmail.com", "l@md@1234");
                client.Send(Message);
                client.Disconnect(true);
                _userrepository.Update(Updateuser);



            }

            else
            {
                return View("Please check your email");
            }











            return null;


        }



        //user gets to this view after clicking the link through mail service  
        
        public ActionResult ResetPassword()
        {


            //the useremail must be replaced with the email of the user 
            var UserEmail = "00ashokbasnet@gmail.com";
            var currenttime = DateTime.Now;
            var Updateuser = _userrepository.FindByCondition(x => x.UserEmail == UserEmail).FirstOrDefault();
            if (Updateuser != null)
            {
                DateTime DatabaseTime = (System.DateTime)Updateuser.ResetTime;
                System.TimeSpan diff = currenttime.Subtract(DatabaseTime);

                if (diff < TimeSpan.FromMinutes(2))
                {
                    return View();
                }
                else
                {
                    return View("LinkExpire");
                }


            }
            else
            {
                return null;
            }



        }










        public String GenerateHash(String ReadablePassword)
        {
            byte[] salt = new byte[8];
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                  password: new string(ReadablePassword),
                  salt: salt,
                  prf: KeyDerivationPrf.HMACSHA1,
                  iterationCount: 10000,
                  numBytesRequested: 256 / 8));
            Console.WriteLine($"Hashed: {hashed}");
            return hashed;
        }

     








        [HttpPost]
        public ActionResult CaptchaVerify(Captcha C)

        {


            var response = Request.Form["Captcha"];
       var check=     CheckCaptcha(response);

            return View();
        }


        public Boolean CheckCaptcha(String UserCaptcha)
        {
           
            var secret = "6LfgCoUUAAAAANav39QX_qRbIZHt53tuUdGvK6F3";

            HttpClient httpClient = new HttpClient();
            var res = httpClient.GetAsync($"https://www.google.com/recaptcha/api/siteverify?secret={secret}&response={UserCaptcha}").Result;


            string JSONres = res.Content.ReadAsStringAsync().Result;
            dynamic JSONdata = JObject.Parse(JSONres);
            if (JSONdata.success != "true")
            {
                return false;

            }

            else
            {
                return true;
            }





        }

     
    }

  

 
}

   





    

    

   
    
