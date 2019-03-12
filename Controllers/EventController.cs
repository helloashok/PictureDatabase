using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PictureDatabase.Models;
using PictureDatabase.Repository;
using System.Web;
using PictureDatabase.ViewModels;


namespace PictureDatabase.Controllers
{

    public class EventController : Controller
    {
    
        private IRepository<Events> _eventRepository;


        public EventController()
        {
            this._eventRepository = new AllRepository<Events>();
        }
  
        public ActionResult Index()
        {
            return View();
        }

        // GET: Event/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Event/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Event/Create
        [HttpPost]
 
  public ActionResult Create(InsertEvent eventview)
        {

            var identity = User.Identity.IsAuthenticated;
            var Username = User.Identity.Name;
            IRepository<Users> _userrepository;
            _userrepository = new AllRepository<Users>();
            var UserData = _userrepository.FindByCondition(x => x.UserName == Username).FirstOrDefault();
            var OrganizationId = UserData.OrganizationId;
           
            
            var  base64 = eventview.EventPhoto.Split(",")[1];
            String temp = eventview.EventPhoto;
            int Pos1 = temp.IndexOf('/') + 1;
            int Pos2 = temp.IndexOf(';');
            String ImageExtension = temp.Substring(Pos1, Pos2 - Pos1);
            
            byte[] imageBytes = Convert.FromBase64String(base64);

            System.IO.Directory.CreateDirectory(@"C:\\Users\\User\\source\\repos\\PictureDatabase\\PictureDatabase\\EventsPhoto\\" + Username);
            var filepath = @"C:\\Users\\User\\source\\repos\\PictureDatabase\\PictureDatabase\\EventsPhoto\\" + Username;
            var OriginalfilePath = Path.Combine(filepath, Guid.NewGuid() + "." + ImageExtension);
            System.IO.File.WriteAllBytes(OriginalfilePath, imageBytes);
            Events newEvent = new Events();
            newEvent.EventName = eventview.EventName;
            newEvent.StartDate = eventview.EventStartDate;
            newEvent.EndDate = eventview.EventEndDate;
            newEvent.OrganizationId = (Guid)OrganizationId;
            newEvent.EventPhoto = OriginalfilePath;
            _eventRepository.Create(newEvent);



            

            return null;
        }

        // GET: Event/Edit/5
        public ActionResult Edit(int id)
        {


            return View();
        }

        // POST: Event/Edit/5
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

        // GET: Event/Delete/5
       
        public ActionResult Delete()
        {
        //   _eventRepository.Delete()
            return View();
        }

        // POST: Event/Delete/5
        [HttpPost]
       
        public ActionResult Delete(dynamic something)
        {

            var abc = Request.Form["someevent"];
            Guid gu = Guid.Parse(abc);
         var Eventone=   _eventRepository.FindByCondition(x => x.EventId == gu).FirstOrDefault();

            _eventRepository.Delete(Eventone);

            return null;
        }


        public ActionResult InsertEvent()
        {
            return View();
        }

       [HttpGet]
        public ActionResult GetAllEvents()
        {
            var list = _eventRepository.FindAll();
            // var eventdata=   JsonConvert.SerializeObject(list);
           var  result = Path.GetFileName("");
            foreach (var value in list)
            {
                value.EventPhoto = Path.GetFileName(value.EventPhoto);
                
            }




            return Json(list);
        }

        public ActionResult ShowAllEvents()
        {

            return View();
        }
        [HttpPost]
        public ActionResult GetBase64(dynamic id)
        {
              var abc = Request.Form["event"];
            Guid gu = Guid.Parse(abc);

            var Eventdata = _eventRepository.FindByCondition(x => x.EventId == gu).FirstOrDefault();
            var rawdata = Eventdata.EventPhoto;
            byte[] imageArray = System.IO.File.ReadAllBytes(@rawdata);
            string base64ImageRepresentation = Convert.ToBase64String(imageArray);


              return Content(base64ImageRepresentation);
            


        }
        [HttpGet]
        public ActionResult Check()
        {
            var filepath = @"C:\\Users\\User\\source\\repos\\PictureDatabase\\PictureDatabase\\wwwroot\\assets\\img\\blue.jpg";
            byte[] imgdata = System.IO.File.ReadAllBytes(filepath);
            return null;
        }
        
     
       
    

    }

}
