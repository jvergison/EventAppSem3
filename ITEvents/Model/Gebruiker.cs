using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEvents
{
    public class Gebruiker
    {
        int userId;
        public int UserId
        {
            get { return userId; }
        }

        string gebruikerNaam;
        public string GebruikerNaam
        {
            get { return gebruikerNaam; }
        }

        string paswoord;
        public string Paswoord
        {
            get { return paswoord; }
        }

        List<Event> evenementen;
        public List<Event> Evenementen
        {
            get { return evenementen; }
        }

        public Gebruiker(int id, string n, string pasw, List<Event> ev)
        {
            userId = id;
            gebruikerNaam = n;
            paswoord = pasw;
            evenementen = ev;
        }

        public Gebruiker(int id, string n, string pasw)
        {
            userId = id;
            gebruikerNaam = n;
            paswoord = pasw;
        }

        public override string ToString()
        {
            return string.Format("{0}\t{1} {2}", UserId, GebruikerNaam, Paswoord);
        }
    }
}
