using System;
using System.Collections.Generic;
using System.Text;

namespace _6.DERS_Ödev
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validation(Gamer gamer)
        {
            if (gamer.BirtYear ==2001 && gamer.FirstName =="ŞÜKRAN"
                && gamer.LastName =="KARAKAYA" && gamer.IdentityNumber ==12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
