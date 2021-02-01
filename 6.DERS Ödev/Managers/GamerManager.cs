using _6.DERS_Ödev.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace _6.DERS_Ödev
{
    class GamerManager : IGamerService 
    {
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validation(gamer)==true)
            {
                Console.WriteLine("Kayıt oluştu.");
            }
            else
            {
                Console.WriteLine("Doğrulama yapılamadı. Kayıt başarısız..");
            }
           
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi." + gamer.FirstName);
        }

       

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi." + gamer.FirstName);
        }
    }
}
