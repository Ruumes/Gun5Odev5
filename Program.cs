using System;

namespace Gun5Odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, FirstName = "Engin", LastName = "Demiroğ",
                BirthYear = 1985, IdentityNumber = 12345 });           
        }
    }
 
}
