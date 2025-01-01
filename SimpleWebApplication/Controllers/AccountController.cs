using Microsoft.AspNetCore.Mvc;
using SimpleWebApplication.Data;
using SimpleWebApplication.Models;

namespace SimpleWebApplication.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;

        public AccountController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login() => View();

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            var account = _context.Accounts.FirstOrDefault(a => a.Username == model.Username && a.Password == model.Password);
            if (account == null) return View();

            HttpContext.Session.SetString("LoggedUser", account.AccountNumber);
            return RedirectToAction("Status");
        }

        [HttpGet]
        public IActionResult Register() => View();

        [HttpPost]
        public IActionResult Register(Account account)
        {
            account.AccountNumber = $"ACC-{Guid.NewGuid().ToString().Substring(0, 8).ToUpper()}";
            account.DynamicsCredits = 0;

            _context.Accounts.Add(account);
            _context.SaveChanges();
            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult Status()
        {
            var accountNumber = HttpContext.Session.GetString("LoggedUser");
            if (string.IsNullOrEmpty(accountNumber)) return RedirectToAction("Login");

            var account = _context.Accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
            return View(account);
        }

        [HttpPost]
        public IActionResult AddCredit()
        {
            var accountNumber = HttpContext.Session.GetString("LoggedUser");
            var account = _context.Accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);

            account.DynamicsCredits += 1;
            _context.SaveChanges();

            return RedirectToAction("Status");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
