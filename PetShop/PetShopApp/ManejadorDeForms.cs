using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopApp
{
   public static class ManejadorDeForms
    {

        private static bool darkMode;


        static  ManejadorDeForms()
        {
            darkMode = false;
        }


        public static  bool DarkMode
        {
            get { return darkMode; }
            set { darkMode = value; }
        }


    }
}
