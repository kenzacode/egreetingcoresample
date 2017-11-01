using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using halloween.Model;

namespace halloween.Pages
{
    public class PreviewModel : PageModel
    {
        // BRIDGE TO GREETINGS MODEL
        [BindProperty]
        public Greetings bridgeGreetings { get; set; }

        //CONNECT DATABSE TO MODEL
        private bridgeDBContext _theDB;
        public PreviewModel(bridgeDBContext theDB)
        {
            _theDB = theDB;
        }
        public void OnGet(int ID = 0)
        {
            if (ID > 0)
            {
                bridgeGreetings = _theDB.Greetings.Find(ID);
            }
        }


    }
}