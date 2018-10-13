﻿using System;
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
           // var User = _context.Customerses.Include(x => x.DepencyCollectionRoomDescriptionModels);
           // var cos = _context.UserModels; //.Include(x => x.CustomersID)
           //     .Include(x => x.Name);

          //  var posts = _context.RoomRent.Include(x => x.Customers).ToList();


          //  var User2 = _context.Customerses.Include(x => x.EmailOfCustomer); 

            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Login,
                    model.Password, model.RememberMe, false);

                //var cos = _context.UserModels;
                //var Name = cos.ToArray();
                ////var cos2 = cos[0].Name;
                //var ttata = Name[0].CustomersID;

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
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
                if (addCustomers.Id != default(int))
                {
                    addCustomers.Id = default(int);
                    _context.SaveChanges();
                }
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

            var posts = _context.Users
                .Include(x => x.UserName);

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            // var result = 0;
            return RedirectToAction("Index", "Account");
        }
    }
}