using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ITEvents.Model;


//singleton
//the controller is called on by the view. 
//It checks whether the user is authorized to do the action.

namespace ITEvents
{
    public class Controller
    {
        Database db;
        public Controller()
        {
            db = Database.getInstance;
        }

        public List<Gebruiker> LeesLeden()
        {
            return db.LeesGebruikers();
        }

        public List<Event> LeesEvents()
        {
            return db.LeesEvents();
        }

        public List<Event> LeesVerledenEvents()
        {
            List<Event> le = db.LeesVerledenEvents();

            return fillListWithAantalInschrijvingen(le);
        }

        public Gebruiker LeesGebruikerMetEvents()
        { 
            return db.LeesGebruikerMetEvents();
        }

        public void MaakEvent(Event _event) 
        {
            db.MaakEvent(_event);
        }

        public bool LogIn(string userName, string password)
        {
            Gebruiker gebruiker = db.LeesGebruikersRij(userName);
            if (gebruiker == null)
                return false;
            if (password == gebruiker.Paswoord)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Event> LeesVolleEvents()
        {
            List<Event> le = db.LeesVolleEvents();
            

            return fillListWithAantalInschrijvingen(le);
        }

        public List<Event> LeesNietVolleEvents()
        {
            List<Event> le =  db.LeesNietVolleEvents();

            return fillListWithAantalInschrijvingen(le);
        }

        private List<Event> fillListWithAantalInschrijvingen(List<Event> le)
        {
            for (int i = 0; i < le.Count; ++i)
            {
                le[i].AantalInschrijvingen = db.LeesAantalInschrijvingen(le[i].EventId);
            }

            return le;
        }


        public List<Event> LeesInschrijvingenVanGebruiker(string gebruikersnaam)
        {
            List<Event> le = db.LeesInschrijvingenVanGebruiker(gebruikersnaam);

            return fillListWithAantalInschrijvingen(le);
        }

        public List<Event> LeesNietInschrijvingenVanGebruiker(string gebruikersnaam)
        {
            List<Event> le = db.LeesNietInschrijvingenVanGebruiker(gebruikersnaam);

            return fillListWithAantalInschrijvingen(le);
        }

        public void SchrijfGebruikerIn(int eventID, string gebruikersnaam)
        {
            db.SchrijfGebruikerIn(eventID, db.LeesGebruikersRij(gebruikersnaam).UserId);
        }

        public void SchrijfGebruikerUit(int eventID, string gebruikersnaam)
        {
            db.SchrijfGebruikerUit(eventID, db.LeesGebruikersRij(gebruikersnaam).UserId);
        }
    }
}
