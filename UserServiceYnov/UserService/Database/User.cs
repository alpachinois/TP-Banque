using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserServiceYnov.UserService.Database
{
    public enum SituationMaritale
    {
        Celibataire,
        Marie,
        Veuf,
        Pacse,
        Divorce,
        Concubinage
    }
    public enum Fonction
    {
        ChargeClientele,
        Client
    }
    public enum Sexe
    {
        Homme,
        Femme
    }
    public class User
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public SituationMaritale SituationMaritale { get; set; }
        public string Email { get; set; }
        public Fonction Fonction { get; set; }
        public string Adresse { get; set; }
        public string TelNumber { get; set; }
    }
}
