//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages;
//using halloween.Model;
//using System.Net.Http;
//using Newtonsoft.Json;

//namespace halloween.Pages
//{

//    public class UpdateModel : PageModel
//    {
//        // DEFAULT MODE
//        public void OnGet()
//        {
//            isPreviewPage = false;
//        }

//        // PREVIEW MODE (AFTER SUBMITTING)
//        public async Task<IActionResult> OnPost()
//        {


//            if (await isValid())
//            {
//                if (ModelState.IsValid)
//                {


//                    try
//                    {
//                        //ADD NEW RECORD TO THE DATABASE
//                        _theDB.Greetings.Add(bridgeGreetings);
//                        _theDB.SaveChanges();

//                        //SEND USER TO THE PREVIEW PAGE SHOWING THE NEW RECORD
//                        return RedirectToPage("Preview", new { id = bridgeGreetings.ID });
//                    }
//                    catch { message = "Oppsie"}
//                }
//            }
//            else
//            {
//                ModelState.AddModelError("bridgeGreetings.Recaptcha", "Oppsie");
//            }

//            return Page();
//        }


//        // BRIDGE TO GREETINGS MODEL
//        [BindProperty]
//        public Greetings bridgeGreetings { get; set; }

//        //CONNECT DATABSE TO MODEL
//        private bridgeDBContext _theDB;
//        public IndexModel(bridgeDBContext theDB)
//        {
//            _theDB = theDB;
//        }

//        // TEST IF USER IS LOOKING AT PREVIEW OR FORM
//        public bool isPreviewPage { get; set; }





//    }
//}

