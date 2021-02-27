using System;
using System.Collections.Generic;
using System.Text;

namespace Gun5Odev5
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear==1985 && gamer.FirstName=="Engin" && gamer.LastName=="Demiroğ"
                    && gamer.IdentityNumber==12345 )
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
