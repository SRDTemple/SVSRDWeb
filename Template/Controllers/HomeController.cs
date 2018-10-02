using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Template.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/Registration
        public ActionResult Registration()
        {
            return View();
        }

        // GET: Home/Contact
        public ActionResult Contact()
        {
            return View();
        }



        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        [HttpPost]
        public ActionResult Contact(string name, string email, string phone, string subject, string message)
        {
            try
            {
                MailMessage mail = new MailMessage();
                string frommail = "svtemplesrd@gmail.com"; // ConfigurationManager.AppSettings["FromMailAddress"];
                string password = "Perumal7"; // ConfigurationManager.AppSettings["password"];
                mail.To.Add("svtemplesrd@gmail.com"); // ConfigurationManager.AppSettings["ToMailAddress"];
                mail.From = new MailAddress(frommail);
                mail.Subject = subject;
                StringBuilder sb = new StringBuilder();
                sb.Append("<br/>Name: " + name);
                sb.Append("<br/>Email Id: " + email);
                sb.Append("<br/>Phone No: " + phone);
                sb.Append("<br/>Message: " + message);

                string Body = "Hi, <br/><br/> A new enquiry by user. Detail is as follows:<br/><br/> " + sb.ToString() + "<br/><br/>Thanks";
                mail.Body = Body;
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                //SMTP Server Address of gmail
                smtp.EnableSsl = true;
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential(frommail, password);
                // Smtp Email ID and Password For authentication

                smtp.Send(mail);
                return new JsonResult() { Data = new { Result = "Thank you for contacting us." } };
                //return Json(new { view = Index() });
            }
            catch (Exception ex)
            {
                return new JsonResult() { Data = new { Result = "Error ....." + ex.Message.ToString() } };
                //return Json(new { view = Index() });
            }
           
            
        }
        [HttpPost]
        public JsonResult Registration(string fullname, string email, string phone)
        {
            try
            {
                MailMessage mail = new MailMessage();
                string frommail = "svtemplesrd@gmail.com"; // ConfigurationManager.AppSettings["FromMailAddress"];
                string password = "Perumal7"; // ConfigurationManager.AppSettings["password"];
                mail.To.Add("svtemplesrd@gmail.com"); // ConfigurationManager.AppSettings["ToMailAddress"];
                mail.From = new MailAddress(frommail);
                mail.Subject = "New user registration";
                StringBuilder sb = new StringBuilder();
                sb.Append("<br/>Name: " + fullname);
                sb.Append("<br/>Email Id: " + email);
                sb.Append("<br/>Phone No: " + phone);
                string Body = "Hi, <br/><br/> A new enquiry by user. Detail is as follows:<br/><br/> " + sb.ToString() + "<br/><br/>Thanks";
                mail.Body = Body;
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                //SMTP Server Address of gmail
                smtp.EnableSsl = true;
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;

                // Smtp Email ID and Password For authentication
                smtp.Credentials = new System.Net.NetworkCredential(frommail, password);


                smtp.Send(mail);
                return new JsonResult() { Data = new { Result = "Thank you for register." } };
            }
            catch (Exception ex)
            {
                return new JsonResult() { Data = new { Result = "Error .." + ex.Message.ToString() } };
            }
            
        }
    }
}
