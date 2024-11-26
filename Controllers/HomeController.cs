using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using TPLOCAL1.Models;

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
            var model = new FormModel();
            

            if (string.IsNullOrWhiteSpace(id))
                //return to the Index view (see routing in Program.cs)
                return View();
            else
            {
                //Call different pages, according to the id pass as parameter
                switch (id)
                {
                    case "OpinionList":
                        //TODO : code reading of the xml files provide
                        return View(id);
                    case "Form":
                        //TODO : call the Form view with data model empty
                        return View(id);
                    default:
                        //return to the Index view (see routing in Program.cs)
                        return View();
                }
            }
        }


        //method to send datas from form to validation page
        [HttpPost]
        public ActionResult ValidationFormulaire(int id, [Bind("Id,Name,Forename,Gender,Address,ZipCode")] FormModel model)
        {
            //TODO : test if model's fields are set
            //if not, display an error message and stay on the form page
            //else, call ValidationForm with the datas set by the user

                     
            if (ModelState.IsValid)
            {
                return View("ValidationFormulaire", model);                
            }
            return View("Form", model);            
        }
    }
}