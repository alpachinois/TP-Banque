using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserServiceYnov.UserService.Database
{
    public class UserDatabaseExemple
    {
        public static List<User> UserDatabase = new List<User>();
        public UserDatabaseExemple()
        {
            UserDatabase.Add(new User()
            {
                Nom = "DUPOND",
                Prenom = "Martine",
                Email = "Dupond.martine@ynovcorp.com",
                Adresse = "10 rue de la Madeleine 69007 Lyon, France",
                DateNaissance = new DateTime(1956, 05, 04),
                Fonction = Fonction.ChargeClientele,
                SituationMaritale = SituationMaritale.Marie,
                TelNumber = "060404040404"

            });
            UserDatabase.Add(new User()
            {
                Nom = "KENT",
                Prenom = "Clark",
                Email = "Kent.clark@ynovcorp.com",
                Adresse = "21 Jump Street, 32009 Metropolis, USA",
                DateNaissance = new DateTime(1968, 03, 06),
                Fonction = Fonction.Client,
                SituationMaritale = SituationMaritale.Veuf,
                TelNumber = "060404040405"
            });
            UserDatabase.Add(new User()
            {
                Nom = "COOPER",
                Prenom = "Sheldon",
                Email = "Cooper.sheldon@ynovcorp.com",
                Adresse = "43 rue du Christ, 56000 Vienne, Autriche",
                DateNaissance = new DateTime(1987, 10, 09),
                Fonction = Fonction.Client,
                SituationMaritale = SituationMaritale.Celibataire,
                TelNumber = "060404040409"
            });
        }

    }
}
