using Microsoft.AspNetCore.Mvc;
using PersonelApp.Web.Models;
using System.Net.Mail;
using System.Threading.Tasks;

namespace PersonelApp.Web.Controllers
{
    public class IletisimController : Controller
    {
        private readonly AppDbContext _context;
        private readonly BlogRepository _blogRepository;
        private readonly YoneticiRepository _yoneticiRepository;
        private readonly DuyurularRepository _duyurularRepository;

        public IletisimController(AppDbContext context)
        {
            _blogRepository = new BlogRepository();
            _yoneticiRepository = new YoneticiRepository();
            _duyurularRepository = new DuyurularRepository();
            _context = context;
        }

        public IActionResult Index()
        {
            var bloglar = _context.Bloglar.ToList();
            var yonetici = _context.Yonetici.ToList();
            var duyurular = _context.Duyurular.ToList();
            ViewBag.Duyurular = duyurular;
            ViewBag.Yonetici = yonetici;
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
                        From = new MailAddress("_@gmail.com"), // Gönderici e-posta adresi
                        Subject = model.Title,
                        Body = $"Name: {model.Name}\nSurname: {model.Surname}\nEmail: {model.Mail}\nPhone: {model.Tel}\n\nMessage:\n{model.Content}",
                        IsBodyHtml = false
                    };
                    mailMessage.To.Add("bedirhan.koksoy@rumeli.edu.tr"); // Hedef e-posta adresi

                    using (var smtpClient = new SmtpClient("smtp.gmail.com"))
                    {
                        smtpClient.Credentials = new System.Net.NetworkCredential("_@gmail.com", "_"); // Parola yerine Gmail uygulama şifresi kullanın
                        smtpClient.Port = 587;
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
