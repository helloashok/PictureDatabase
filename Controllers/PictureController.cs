using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PictureDatabase.Models;

using PictureDatabase.Repository;
using PictureDatabase.ViewModels;
using PictureDatabase.PasswordControl;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace PictureDatabase.Controllers
{
 
    public class PictureController : Controller, PasswordInterface
    {

        private IRepository<Organizations> _organizationRepository;


        public PictureController()
        {
            this._organizationRepository = new AllRepository<Organizations>();
        }

        // GET: Picture
        public ActionResult Index()
        {

            return View();
        }

        // GET: Picture/Details/5
        public ActionResult Details(String OrganizationName)

        {
            OrganizationName = "Organization8";
            var organization = _organizationRepository.FindByCondition(x => x.OrganizationName == OrganizationName).FirstOrDefault();
            if (organization != null)
            {
                var abc = organization.OrganizationId;
            }
            else
            {

                organization.OrganizationName = OrganizationName;
                _organizationRepository.Create(organization);
            }











            return View();

        }

        // GET: Picture/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Picture/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(OrganizationViewModels models)
        {

                var captcha = Request.Form["Captcha"];
           var checkcaptcha=     CheckCaptcha(captcha);
            if (checkcaptcha == true)
            {

                var model = new Organizations();
                model.OrganizationName = models.OrganizationName;
                model.LicensePath = models.LicensePath;

                // this is for converting into extension and base64 string 
                String temp = models.LicensePath;
                int Pos1 = temp.IndexOf('/') + 1;
                int Pos2 = temp.IndexOf(';');
                String TempLicenseExt = temp.Substring(Pos1, Pos2 - Pos1);


                // this is for base64 string   
                String TempLicense = temp.Substring(temp.LastIndexOf(',') + 1);

                byte[] imageBytes = Convert.FromBase64String(TempLicense);
                
                    System.IO.Directory.CreateDirectory(@"C:\\Users\\User\\source\\repos\\PictureDatabase\\PictureDatabase\\Organizations\\" + models.OrganizationName);
                
                var filepath = @"C:\\Users\\User\\source\\repos\\PictureDatabase\\PictureDatabase\\Organizations\\" + models.OrganizationName;
                var OriginalfilePath = Path.Combine(filepath, Guid.NewGuid() + "." + TempLicenseExt);
                System.IO.File.WriteAllBytes(OriginalfilePath, imageBytes);




                model.LicensePath = OriginalfilePath;
                model.CreatedDate = DateTime.Now;

                model.PrimaryContactEmail = models.PrimaryContactEmail;
                model.PrimaryContactName = models.PrimaryContactName;
                model.PrimaryContactPhone = models.PrimaryContactPhone;
                model.CreatedBy = models.CreatedBy;






                _organizationRepository.Create(model);
                _organizationRepository.Save();

                String OrganizationName = model.OrganizationName;


                var organization = _organizationRepository.FindByCondition(x => x.OrganizationName == OrganizationName).FirstOrDefault();




                //for UserTable 
                var UserEntry = new Users();
                IRepository<Users> _userrepository;
                _userrepository = new AllRepository<Users>();
                UserEntry.UserName = models.Username;
                UserEntry.UserEmail = models.Email;
                UserEntry.OrganizationId = organization.OrganizationId;


                //   String password = PassGenerator();
                UserEntry.Password = GenerateHash(models.Password);
                _userrepository.Create(UserEntry);

                return RedirectToAction("Users","UserLogin");
            }
            else
            {
                return View();
            }



            
          


        }



        // GET: Picture/Edit/5
        public ActionResult Edit()
        {
            return View();
        }

        // POST: Picture/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id)
        {
            try
            {
                id = new Guid("C6F71EF1-B1B8-448D-9073-E37C42C8EBDE");

                var organization = _organizationRepository.FindByCondition(x => x.OrganizationId == id).FirstOrDefault();
                if (organization != null)
                {
                    organization.OrganizationName = "OrganizationSeven";
                    _organizationRepository.Update(organization);
                    _organizationRepository.Save();

                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Picture/Delete/5
        public ActionResult Delete()
        {
            return View();
        }

        // POST: Picture/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(Organizations organization )
        //{
        //    try
        //    {
        //        organization.OrganizationId = new Guid("");
        //        organization.OrganizationName = "abc";
        //        interfaceObject.DeleteUpdate(organization);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id)
        {
            try
            {
                id = new Guid("20FED7D4-FF85-4864-B208-E5815DEF2EB6");


                var organization = _organizationRepository.FindByCondition(x => x.OrganizationId == id).FirstOrDefault();
                if (organization != null)
                {
                    _organizationRepository.Delete(organization);
                    _organizationRepository.Save();

                }

            }
            catch (Exception ex)

            {
                return View();
            }
            return View();




        }



        public ActionResult GetValue()
        {
            return null;
        }

        [HttpPost]
        public ActionResult GetValue(String name)
        {
            String something = name;
            return View();
        }



        public ActionResult Insert()
        {
            return View();
        }





        public void ForgetPassword()
        {

        }

        string PasswordInterface.GeneratePassword()
        {
            return null;
        }


        public String PassGenerator()
        {

            int length = 6;
            IEnumerable<char> characterSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
        "abcdefghijklmnopqrstuvwxyz" +
        "0123456789";

            var bytes = new byte[length * 8];
            new RNGCryptoServiceProvider().GetBytes(bytes);
            var characterArray = characterSet.Distinct().ToArray();
            var result = new char[length];
            for (int i = 0; i < length; i++)
            {
                ulong value = BitConverter.ToUInt64(bytes, i * 8);
                result[i] = characterArray[value % (uint)characterArray.Length];
            }
            var password = new string(result);

            byte[] salt = new byte[8];

            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
         password: new string(result),
         salt: salt,
         prf: KeyDerivationPrf.HMACSHA1,
         iterationCount: 10000,
         numBytesRequested: 256 / 8));
            Console.WriteLine($"Hashed: {hashed}");

            return new string(hashed);







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




    }
  
}
