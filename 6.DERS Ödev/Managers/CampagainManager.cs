using _6.DERS_Ödev.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace _6.DERS_Ödev.Managers
{
    class CampagainManager : ICampagainService
    {
        public void Add(Campagain campagain)
        {
            Console.WriteLine("Kampanya eklendi" + campagain.Name);
        }

        public void Delete(Campagain campagain)
        {
            Console.WriteLine("Kampanya silindi " + campagain.Name);
        }

        public void Update(Campagain campagain)
        {
            Console.WriteLine("Kampanya güncellendi" + campagain.Name);
        }
    }
}
