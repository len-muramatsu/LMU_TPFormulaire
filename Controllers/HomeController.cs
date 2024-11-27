using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using TPLOCAL1.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

//Subject is find at the root of the project and the logo in the wwwroot/ressources folders of the solution
//--------------------------------------------------------------------------------------
//Careful, the MVC model is a so-called convention model instead of configuration,
//The controller must imperatively be name with "Controller" at the end !!!
namespace TPLOCAL1.Controllers
{
    public class HomeController : Controller
    {
        //methode "naturally" call by router
        public ActionResult Index(string id)
        {
            
            if (string.IsNullOrWhiteSpace(id))
                //return to the Index view (see routing in Program.cs)
                return View();
            else
            {
                //Call different pages, according to the id pass as parameter
                switch (id)
                {
                    case "OpinionList":
                        var opinionList = new OpinionList();
                        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\XlmFile/DataAvis.xml");
                        var opinions = opinionList.GetAvis(filePath); 
                        ViewBag.Opinions = opinions;
                        return View(id);
                    case "Form":
                        var formModel = new FormModel(); 
                        ViewBag.FormModel = formModel;
                        return View(id);
                    default:
                        //return to the Index view (see routing in Program.cs)
                        return View();
                }
            }
        }


        //method to send datas from form to validation page
        [HttpPost]
        public ActionResult ValidationFormulaire([Bind("Id,Name,Forename,Gender,Address,ZipCode,Town,EmailAdress,DateDebutFormation,FormationSuivie")] FormModel model)
        {
            //TODO : test if model's fields are set
            //if not, display an error message and stay on the form page
            //else, call ValidationForm with the datas set by the user
            DateTime referenceDate = new DateTime(2021, 1, 1);
            if (model.DateDebutFormation == DateTime.MinValue || model.DateDebutFormation > referenceDate)
            {
                ModelState.AddModelError("", "La date de début de formation doit être antérieure au 01/01/2021.");
            }

            if (ModelState.IsValid)
            {
                return View("ValidationFormulaire", model);                
            }
            return View("Form", model);            
        }
    }
}