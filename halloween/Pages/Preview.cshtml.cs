using halloween.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Net.Mail;

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

        //SEND RELATED FOR CATCH 
        public string Message { get; set; }

        public IActionResult OnPost(int id = 0)
        {
            if (id > 0)
            {
                bridgeGreetings = _theDB.Greetings.Find(id);

                try
                {
                    //SEND AN EMAIL
                    MailMessage Mailer = new MailMessage();

 
                    Mailer.To.Add(new MailAddress(bridgeGreetings.toEmail, bridgeGreetings.toName));
                    Mailer.Subject = bridgeGreetings.subject;
                    Mailer.Body = bridgeGreetings.mesg;
                    Mailer.From = new MailAddress(bridgeGreetings.fromEmail,bridgeGreetings.fromName);

                    Mailer.IsBodyHtml = true;

                    using (SmtpClient smtpServer = new SmtpClient()){
                        smtpServer.EnableSsl = true;
                        smtpServer.Host = "smtp.wowoco.org" ; //CHANGE
                        smtpServer.Port = 25; //CHANGE
                        smtpServer.UseDefaultCredentials = false;
                        smtpServer.Send(Mailer);
                    }

                    // ADD TO DATABASE
                    bridgeGreetings.sendDate = DateTime.Now.ToString();
                    bridgeGreetings.sendIP = this.HttpContext.Connection.RemoteIpAddress.ToString();

                    //UPDATE NEW RECORD TO THE DATABASE
                    _theDB.Greetings.Update(bridgeGreetings);
                    _theDB.SaveChanges();
                    
                    return RedirectToPage("Complete");

                }
                catch
                {
                    Message = "Sorry, it didn't work! Try again!";
                }
            }

            return Page();
        }

    }
}