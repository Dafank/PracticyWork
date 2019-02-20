using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseLibrary;

namespace ControllsLibrary
{
    
    public class LoginController
    {
        DataBaseModel model;

        public LoginController()
        {
            model = new DataBaseModel();
        }
        public bool TryAutorize(string email, string password)
        {
            model.Books.Add()
            return true;
        }
    }
}
