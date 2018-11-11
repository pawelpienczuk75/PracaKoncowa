using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using RentRoom.Context;
using RentRoom.Models;
using RentRoom.ViewModels;

namespace RentRoom.Controllers
{
    public class AccountController : Controller
    {
        private readonly IdentityContext _context;
        private readonly UserManager<UserModel> _userManager;
        private readonly SignInManager<UserModel> _signInManager;
        public AccountController(UserManager<UserModel> userManager, SignInManager<UserModel> signInManager, 
            IdentityContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LogInViewModel model)
        {
           
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Login,
                    model.Password, model.RememberMe, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Account");
                }
                else
                {
                    ModelState.AddModelError("", "Nie można się zalogować!");
                }
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            Customers addCustomers = new Customers();
            addCustomers.EmailOfCustomer = model.Email;
            addCustomers.Citi = model.Citi;
            addCustomers.NameOfComany = model.NameOfComany;
            addCustomers.NIP = model.NIP;
            addCustomers.Street = model.Street;
            addCustomers.PhoneNumber = model.PhoneNumber;
            addCustomers.NameOfCustomer = model.NameOfCustomer;
            _context.Add(addCustomers);
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException)
            {
                return Content("Brak dostepu do Bazy");
            }
            RegisterModel addNewUser = new RegisterModel();
            addNewUser.Email = model.Email;
            addNewUser.Login = model.Login;
            addNewUser.RepeatPassword = model.RepeatPassword;
            addNewUser.Password = model.Password;
            if (ModelState.IsValid)
            {
                var identity = new UserModel(addNewUser.Login);
                identity.Email = addNewUser.Email;
                identity.CustomersID = addCustomers.Id;
                var result = await _signInManager.UserManager.CreateAsync(identity, addNewUser.Password);
                if (result.Succeeded)
                {
                    await _signInManager.PasswordSignInAsync(model.Login,
                        model.Password, false, false);
                    return RedirectToAction("Index", "Account");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View();
        }
        public IActionResult CustomerDane()
        {
            CustomerEditVievModel tempCustomerEditVievModel = new CustomerEditVievModel();
            var tempUsrer = HttpContext.User.Identity.Name;
            var temp3 = _context.UserModels.Where(x => x.UserName == tempUsrer)
                .Select(i => i.CustomersID).ToArray();
            var tempCustomer = _context.Customerses.Single(x => x.Id == temp3[0]);
            tempCustomerEditVievModel.Citi = tempCustomer.Citi;
            tempCustomerEditVievModel.Email = tempCustomer.EmailOfCustomer;
            tempCustomerEditVievModel.NIP = tempCustomer.NIP;
            tempCustomerEditVievModel.NameOfComany = tempCustomer.NameOfComany;
            tempCustomerEditVievModel.NameOfCustomer = tempCustomer.NameOfCustomer;
            tempCustomerEditVievModel.PhoneNumber = tempCustomer.PhoneNumber;
            tempCustomerEditVievModel.Street = tempCustomer.PhoneNumber;
            tempCustomerEditVievModel.Id = tempCustomer.Id;
            return View(tempCustomerEditVievModel);
        }
        public IActionResult EditCustomer(int id)
        {
            CustomerEditVievModel tempCustomerEditVievModel = new CustomerEditVievModel();
            var tempCustomer = _context.Customerses.Single(x => x.Id == id);
            tempCustomerEditVievModel.Citi = tempCustomer.Citi;
            tempCustomerEditVievModel.Email = tempCustomer.EmailOfCustomer;
            tempCustomerEditVievModel.NIP = tempCustomer.NIP;
            tempCustomerEditVievModel.NameOfComany = tempCustomer.NameOfComany;
            tempCustomerEditVievModel.NameOfCustomer = tempCustomer.NameOfCustomer;
            tempCustomerEditVievModel.PhoneNumber = tempCustomer.PhoneNumber;
            tempCustomerEditVievModel.Street = tempCustomer.PhoneNumber;
            tempCustomerEditVievModel.Id = tempCustomer.Id;
            return View(tempCustomerEditVievModel);
        }
        [HttpPost]
        public IActionResult EditCustomer(CustomerEditVievModel customerEditVievModel)
        {
            Customers tempCustomers = new Customers();
            tempCustomers.Id = customerEditVievModel.Id;
            tempCustomers.Citi = customerEditVievModel.Citi;
            tempCustomers.EmailOfCustomer = customerEditVievModel.Email;
            tempCustomers.NIP = customerEditVievModel.NIP;
            tempCustomers.NameOfComany = customerEditVievModel.NameOfComany;
            tempCustomers.NameOfCustomer = customerEditVievModel.NameOfCustomer;
            tempCustomers.PhoneNumber = customerEditVievModel.PhoneNumber;
            tempCustomers.Street = customerEditVievModel.Street;
            _context.Customerses.Update(tempCustomers);
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException)
            {
                return Content("Brak dostepu do Bazy");
            }
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Account");
        }
    }
}