using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEvents
{
    public class Event
    {
        int eventId;
        public int EventId
        {
            get { return eventId; }
        }

        string eventNaam;
        public string EventNaam
        {
            get { return eventNaam; }
        }

        string beschrijving;
        public string Beschrijving
        {
            get { return beschrijving; }
        }

        DateTime start;
        public DateTime Start
        {
            get { return start; }
        }

        DateTime eind;
        public DateTime Eind
        {
            get { return eind; }
        }

        int maxInschrijvingen;
        public int MaxInschrijvingen
        {
            get { return maxInschrijvingen; }
        }


        int aantalInschrijvingen;
        public int AantalInschrijvingen
        {
            get { return aantalInschrijvingen; }
            set { 
                    if(value <= MaxInschrijvingen)
                        aantalInschrijvingen = value;
                }
        }

        public Event(int id, string n, string beschr, DateTime st, DateTime ei, int maxinsch)
        {
            eventId = id;
            eventNaam = n;
            beschrijving = beschr;
            start = st;
            eind = ei;
            maxInschrijvingen = maxinsch;
        }

        public Event(int id, string n, string beschr, int maxinsch)
        {
            eventId = id;
            eventNaam = n;
            beschrijving = beschr;
            start = DateTime.Now;
            eind = DateTime.Now;
            maxInschrijvingen = maxinsch;
        }

        public override string ToString()
        {
            return string.Format("{0:d3}\t{1} BEGIN: {2} END: {3} MAX: {4}", EventId, EventNaam, Start, Eind, MaxInschrijvingen);
        }
    }
}
