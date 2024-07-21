using Microsoft.AspNetCore.Mvc;
using registrationrepo.Abstract;
using registrationrepo.Model;
using registrationrepo.Repository;

namespace course_assignment.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly IAdd _userRepository;

        public RegistrationController(regRepo userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegistrationModel user)
        {
            if (ModelState.IsValid)
            {
                user.password = GenerateRandomPassword();
                _userRepository.Add(user);
                return View("RegistrationSuccess");
            }

            return View(user);
        }

        private int GenerateRandomPassword()
        {
            return new Random().Next(10000, 100000);
        }
    }
    
}

