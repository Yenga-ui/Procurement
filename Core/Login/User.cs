using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Login
{
    public class User
    {
        private readonly MyPayrollContext _context;

        String username;

        String password;

        public User()
        {
            MyPayrollContext context = new MyPayrollContext();
            _context = new Models.MyPayrollContext();
        }

        public bool login(String username, String password)
        {
            var userCount = 1;
            userCount = _context.CdfUsers.Where(p => p.Email == username).Count();
            return userCount >= 1;
        }
    }
}