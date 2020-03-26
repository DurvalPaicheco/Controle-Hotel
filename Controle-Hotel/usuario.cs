using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Controle_Hotel
{
    class Usuario 
    {
        private String password { get; set; }
        private String user { get; set; } 

     public  Usuario(String User, String Pass)
        {
            password = Pass;
            user = User;
        }

        public int Login()
        {

            return 1;
        }

    }
}
