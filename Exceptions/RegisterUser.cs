using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class RegisterUser
    {
        public string? _login { get; private set; }
        public string? _password { get; private set; }
        public string? _confirmPassword { get; private set; }

        public RegisterUser(string? login, string? password, string? confirmPassword)
        {
            //if(!(login?.Length > 20 && login.Contains(' ')))
            //    _login = login;
            if (login?.Length > 20 || login.Contains(' '))
            {
                
                throw new WrongLoginException("Login must not contain spaces and should be less than 20 chars.");
            }
            else
            {
                _login = login;
            }
            
            if(password?.Length > 20 || password.Contains(' ') || !password.Any(char.IsDigit))
            {
                throw new WrongPasswordException("Password must not contain any spaces," +
                    " its length should be below 20 chars and it must contain at least one digit.");
            }
            else
            {
                _password = password;
            }

            if(confirmPassword != password)
            {
                throw new WrongPasswordException("Fields \"Password\" and \"ConfirmPassword\" must be equal.");
            }
            else
            {
                _confirmPassword = confirmPassword;
            }
            
          
        }
    }
}
