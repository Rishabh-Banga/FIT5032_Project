using SendGrid.Helpers.Mail;
using Steercar_proj.Models;
using System;
using System.Net.Mail;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SendGrid;

namespace Steercar_proj.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Events()
        {
            ViewBag.Message = "Your events are here.";

            return View();
        }

        public ActionResult Send_Email()
        {
            return View(new EmailSenderVIewModel());
        }

        [HttpPost]
        public ActionResult Send_Email(EmailSenderVIewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    String toEmail = model.ToEmail;
                    String subject = model.Subject;
                    String contents = model.Contents;

                    EmailSender es = new EmailSender();
                    es.Send(toEmail, subject, contents);

                    ViewBag.Result = "Email has been send.";

                    ModelState.Clear();

                    return View(new EmailSenderVIewModel());
                }
                catch
                {
                    return View();
                }
            }

            return View();
        }

        private const String API_KEY = "SG.mjEGAOvGQrqA3o9NbzuQvw.6VU-i_KghF5P2YdxtU7VQSqlTiEI2NcpEqgjQ_c4XC";

        public void Send(String toEmail, String subject, String contents)
        {
            var client = new SendGridClient(API_KEY);
            var from = new EmailAddress("noreply@steercar.com", "Try our SteerCa services, we are here to help");
            var to = new EmailAddress(toEmail, "");
            var plainTextContent = contents;
            var htmlContent = "<p>" + contents + "</p>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = client.SendEmailAsync(msg);
        }

    }

}