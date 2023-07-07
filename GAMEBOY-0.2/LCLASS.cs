using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMEBOY_0._2
{
     class LCLASS 
    {
       public static List<string> LISTRPG()
        {
            List<string> Rpg = new List<string>();
            Rpg.Add("1. Final Fanstasy X");
            Rpg.Add("2. Elden ring");
            Rpg.Add("3. Dying Light 2");
            Rpg.Add("0. Back");

            return Rpg;
             
        }
        public static List<string> LISTACTION()
        {
            List<string> Action = new List<string>();
            Action.Add("1. Mortal combat X");
            Action.Add("2. Marvel Vs Capcom");
            Action.Add("3. Ghostrider V.25");
            Action.Add("0. Back");

            return Action;
        }

        public static List<string> LISTSHOOT()
        {
            List<string> Shooting = new List<string>();
            Shooting.Add("1. Red dead redemption 2");
            Shooting.Add("2. Halo");
            Shooting.Add("3. Call of duty:Warzone");
            Shooting.Add("0. Back");

            return Shooting;    
        }






    }
}
