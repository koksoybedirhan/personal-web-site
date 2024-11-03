using Microsoft.AspNetCore.Mvc;
using PersonelApp.Web.Models;
using System.Net.Mail;

namespace PersonelApp.Web.Controllers
{
    public class IletisimController : Controller
    {
        private AppDbContext _context;
        private readonly BlogRepository _blogRepository;

        public IletisimController(AppDbContext context)
        {
            _blogRepository = new BlogRepository();
            _context = context;
        }

        public IActionResult Index()
        {
            var bloglar = _context.Bloglar.ToList();
            ViewBag.Bloglar = bloglar;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(IletisimModel model)
        {
            if (ModelState.IsValid)
            {
                // Veritabanına kaydet
                _context.Iletisim.Add(model);
                await _context.SaveChangesAsync();

                // E-posta gönderme işlemi
                try
                {
                    var mailMessage = new MailMessage
                    {
                        From = new MailAddress("your_email@example.com"),
                        Subject = model.Title,
                        Body = $"Name: {model.Name}\nSurname: {model.Surname}\nEmail: {model.Mail}\nPhone: {model.Tel}\n\nMessage:\n{model.Content}",
                        IsBodyHtml = false
                    };
                    mailMessage.To.Add("your_email@example.com");

                    using (var smtpClient = new SmtpClient("smtp.your-email-provider.com"))
                    {
                        smtpClient.Credentials = new System.Net.NetworkCredential("your_email@example.com", "your_password");
                        smtpClient.Port = 587; // veya sağlayıcınız için doğru port
                        smtpClient.EnableSsl = true;
                        await smtpClient.SendMailAsync(mailMessage);
                    }
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, "E-posta gönderiminde bir hata oluştu: " + ex.Message);
                }

                return RedirectToAction("Index", "Home"); // Başarılı bir şekilde kaydedildikten sonra yönlendirme
            }
            return View(model); // Hata varsa formu tekrar göster
        }
    }
}
