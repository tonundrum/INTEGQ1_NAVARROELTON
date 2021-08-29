using System;

namespace SVRMSBusinessLayer
{
    
    static public class User
    {
        static private string _email;
        static public string Email
        {
            get { return _email; }
            set { _email = value;
        
            }
        }
        static private string _password;
        static public string Password
        {
            get { return _password; }
            set { _password = value;
             
            }
        }
        
       

    }
}
