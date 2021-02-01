
using _6.DERS_Ödev.Managers;
using System;

namespace _6.DERS_Ödev
{
    class Program
    {

        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1, 
                BirtYear = 2001,
                FirstName = "ŞÜKRAN",
                LastName = "KARAKAYA", 
                IdentityNumber = 12345 
            });
            

            CampagainManager campagain1 = new CampagainManager();
            campagain1.Add(new Campagain
            {
                Id = 111,
                Name = " Şubat İndirimi",
                Rate = 5
            });
            CampagainManager campagain2 = new CampagainManager();
            campagain2.Update(new Campagain
            {
                Id = 222,
                Name = " Yeni Yıl İndirimi",
                Rate = 10
            });
            CampagainManager campagain3 = new CampagainManager();
            campagain3.Delete(new Campagain
            {
                Id = 111,
                Name = " Ocak İndirimi",
                Rate = 5
            });
            









        }
    }
}
