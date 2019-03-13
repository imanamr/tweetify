using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TweetifyB.DAL;
using TweetifyB.Models;

namespace TweetifyB.Controllers
{
    public class AuthController : Controller
    {

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(User u)
        {
            using (var context = new TweetifyContext())
            {
                User temp = context.Users.FirstOrDefault(x => x.Username == u.Username);

                if (temp != null)
                {
                    throw new Exception("User existe déja");
                }
                else
                {
                    u.Username = u.Username.ToLower();
                    context.Users.Add(u);
                    await context.SaveChangesAsync();
                    return RedirectToAction("Login");
                }
            }
        }

        public IActionResult Login()
        {
            // Récupérer un user à partir du username (en minuscules)
            // SI User => Verifier Mdp 
            if u.username = u.username
            // // Si User.MDP == MDP 
            // //    Je créée la variable de session
            // // SINON
            // //   STFU
            // SINON 
            //   STFU 

            return View();
        }
        public IActionResult Logout()
        {
            // VARIABLE DE SESSION ? 
            return View();
        }
    }
}