using System;
using System.Collections.Generic;
using System.Text;

namespace _6.DERS_Ödev.Interface
{
    interface ICampagainService
    {
        void Add(Campagain campagain);
        void Update(Campagain campagain);
        void Delete(Campagain campagain);
    }
}
