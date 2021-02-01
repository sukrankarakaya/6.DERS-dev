using System;
using System.Collections.Generic;
using System.Text;

namespace _6.DERS_Ödev
{
    class NewEStateUserValidationManager : IUserValidationService
    {
        public bool Validation(Gamer gamer)
        {
            return true;
        }
    }
}
