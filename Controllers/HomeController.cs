using System.Net;
using System.Net.Mail;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SendEmail(string name, string email, string phone, string message)
        {
            var client = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("address", "password")
            };
            client.Send(new MailMessage(
                email,
                "kformeck@gmail.com",
                string.Concat("New Message from ", name, " via Portfolio Site"),
                string.Concat(message, "\n\nPhone: ", phone)));
            return View();
        }
    }
}