using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PictureDatabase.Models;
using PictureDatabase.Repository;
using PictureDatabase.ViewModels;


namespace PictureDatabase.Controllers
{
    /*
    public class EventController : Controller
    {

        private IRepository<Events> _eventRepository;


        public EventController()
        {
            this._eventRepository = new AllRepository<Events>();
        }
        // GET: Event
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
      //  [ValidateAntiForgeryToken]
        public ActionResult Create(Events events)
        {
            try
            {
                //this is for the foreign key in events 
                IRepository<Organizations> _organizationrepository;
                String organization_name = "Government_agency";
               _organizationrepository = new AllRepository<Organizations>();
               var  organization     = _organizationrepository.FindByCondition(x => x.OrganizationName == organization_name).FirstOrDefault();
                //here ends the event for organizatio id 

                events.OrganizationId = organization.OrganizationId;

                _eventRepository.Create(events);

                return RedirectToAction(nameof(Index));
            }
            catch(Exception e )
            {
                var a = e;
                return View();
            }
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
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Event/Delete/5
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


        public ActionResult InsertEvent()
        {
            return View();
        }




    

    }
    */
}
