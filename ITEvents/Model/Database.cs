using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ITEvents.Model;
using ITEvents.Model.CSGroep14DataSetTableAdapters;

namespace ITEvents
{
    class Database
    {
        static Database databaseInstance = new Database();
        CSGroep14DataSet dataset;
        gebruikereventTableAdapter geAdapter;
        gebruikerTableAdapter gAdapter;
        eventTableAdapter eAdapter;

        public static Database getInstance
        {
            get
            {
                return databaseInstance;
            }
        }
        private Database()
        {
            dataset = new CSGroep14DataSet();
            geAdapter = new gebruikereventTableAdapter();
            gAdapter = new gebruikerTableAdapter();
            eAdapter = new eventTableAdapter();
        }

        public List<Gebruiker> LeesGebruikers() 
        {
            gAdapter.Fill(dataset.gebruiker);

            List<Gebruiker> gebruikerLijst = new List<Gebruiker>();
            for (int i = 0; i < dataset.gebruiker.Rows.Count; i++) 
            {
                Gebruiker gebruiker = new Gebruiker(dataset.gebruiker[i].user_id,
                    dataset.gebruiker[i].naam,
                    dataset.gebruiker[i].paswoord);
                gebruikerLijst.Add(gebruiker);
            }
            return gebruikerLijst;
        }

        public List<Event> LeesEvents() 
        {
            eAdapter.Fill(dataset._event);

            return VulEventLijst(dataset);
        }

        public List<Event> LeesVerledenEvents()
        {
            eAdapter.GetEventsInVerleden(dataset._event);

            return VulEventLijst(dataset);
        }


        public Gebruiker LeesGebruikerMetEvents()
        {
            if (dataset.gebruiker.Rows.Count != 0) 
            {
                eAdapter.Fill(dataset._event);

                List<Event> eventLijst = VulEventLijst(dataset);

                Gebruiker gebruiker = new Gebruiker(dataset.gebruiker[0].user_id,
                        dataset.gebruiker[0].naam,
                        dataset.gebruiker[0].paswoord);
                return gebruiker;
            }
            else
            {
                throw new Exception("UserID is fout");
            }
        }

        public void VerwijderGebruikerMetEvents() 
        {
            gAdapter.Fill(dataset.gebruiker);

            if (dataset.gebruiker.Rows.Count != 0) 
            {
                dataset.gebruiker[0].Delete();

                gAdapter.Update(dataset.gebruiker);
            }
            else
            {
                throw new Exception("User ID is fout");
            }
        }

        public void WijzigGebruikerMetEvent(Gebruiker gebruiker) 
        {
            gAdapter.Fill(dataset.gebruiker);

            if (dataset.gebruiker.Rows.Count != 0)
            {
                CSGroep14DataSet.gebruikerRow gebruikerRij = dataset.gebruiker[0];
                VulGebruikerRij(gebruikerRij, gebruiker);

                gAdapter.Update(dataset.gebruiker);
                geAdapter.Fill(dataset.gebruikerevent);

                for (int i = 0; i < dataset.gebruikerevent.Rows.Count; i++) 
                {
                    dataset.gebruikerevent[i].Delete();
                }

                MaakGebruikerEventRijen(dataset.gebruikerevent, gebruiker);

                geAdapter.Update(dataset.gebruikerevent);
            }
        }

        public void MaakGebruikerEventRijen(CSGroep14DataSet.gebruikereventDataTable gebruikereventDataTable, Gebruiker gebruiker)
        {
            for (int i = 0; i < gebruiker.Evenementen.Count(); i++)
            {
                CSGroep14DataSet.gebruikereventRow rij = gebruikereventDataTable.NewgebruikereventRow();
                rij.user_id = gebruiker.UserId;
                rij.event_id = gebruiker.Evenementen[i].EventId;
            }
        }

        private void VulGebruikerRij(CSGroep14DataSet.gebruikerRow gebruikerRij, Gebruiker gebruiker)
        {
            gebruikerRij.user_id = gebruiker.UserId;
            gebruikerRij.paswoord = gebruiker.Paswoord;
            gebruikerRij.naam = gebruiker.GebruikerNaam;
        }

        public void NieuweGebruikerMetEvent(Gebruiker gebruiker) 
        {
            dataset.gebruiker.Clear();
            CSGroep14DataSet.gebruikerRow rij = dataset.gebruiker.NewgebruikerRow();
            VulGebruikerRij(rij, gebruiker);

            gAdapter.Update(dataset.gebruiker);

            gebruiker = new Gebruiker(rij.user_id, rij.paswoord, rij.naam);

            MaakGebruikerEventRijen(dataset.gebruikerevent, gebruiker);

            geAdapter.Update(dataset.gebruikerevent);
        }

        public void MaakEvent(Event _event)
        {
            dataset._event.Clear();
            CSGroep14DataSet.eventRow rij = dataset._event.NeweventRow();

            VulEventRij(rij, _event);
            dataset._event.Rows.Add(rij);
            eAdapter.Update(dataset._event);
        }

        private void MaakEventRijen(CSGroep14DataSet.eventDataTable eventDataTable, Event _event)
        {
                CSGroep14DataSet.eventRow rij = eventDataTable.NeweventRow();
                
                rij.event_id = _event.EventId;
                rij.naam = _event.EventNaam;
                rij.beschrijving = _event.Beschrijving;
                rij.start = _event.Start;
                rij.eind = _event.Eind;
                rij.max_inschrijvingen = _event.MaxInschrijvingen;

                eventDataTable.Rows.Add(rij);
        }

        private void VulEventRij(CSGroep14DataSet.eventRow eventRij, Event _event)
        {
            eventRij.event_id =_event.EventId;
            eventRij.naam = _event.EventNaam;
            eventRij.beschrijving = _event.Beschrijving;
            eventRij.start = _event.Start;
            eventRij.eind = _event.Eind;
            eventRij.max_inschrijvingen = _event.MaxInschrijvingen;
        }


        public Gebruiker LeesGebruikersRij(string userName)
        {   
            gAdapter.GetInloggerGegevens(dataset.gebruiker, userName);
            if (dataset.gebruiker.Rows.Count != 0)
            {
                Gebruiker gebruiker = new Gebruiker(dataset.gebruiker[0].user_id, userName, dataset.gebruiker[0].paswoord);
                return gebruiker;
            }

            return null;
        }

        public List<Event> LeesVolleEvents()
        {
            eAdapter.FillByEventsInToekomstVol(dataset._event);
            return VulEventLijst(dataset);
        }

        public List<Event> LeesNietVolleEvents()
        {
            eAdapter.FillByEventsInToekomstNietVol(dataset._event);
            
            return VulEventLijst(dataset);
        }

        public int LeesAantalInschrijvingen(int eventID)
        {
            return Convert.ToInt32(geAdapter.GetAantalInschrijvingenByEventId(eventID));
            
        }

        public List<Event> LeesInschrijvingenVanGebruiker(string gebruikersnaam)
        {
            eAdapter.FillByUserName(dataset._event, gebruikersnaam);
            return VulEventLijst(dataset);
        }

        public List<Event> LeesNietInschrijvingenVanGebruiker(string gebruikersnaam)
        {
            eAdapter.FillByNietIngeschrevenUsername(dataset._event, gebruikersnaam);
            
            return VulEventLijst(dataset);
        }


        public List<Event> VulEventLijst(CSGroep14DataSet dataset)
        {
            List<Event> eventLijst = new List<Event>();
            for (int i = 0; i < dataset._event.Count; i++)
            {
                Event _event = new Event(dataset._event[i].event_id,
                    dataset._event[i].naam,
                    dataset._event[i].beschrijving,
                    dataset._event[i].start,
                    dataset._event[i].eind,
                    dataset._event[i].max_inschrijvingen);
                eventLijst.Add(_event);
            }

            return eventLijst;
        }

        public void SchrijfGebruikerIn(int eventID, int userId)
        {
            geAdapter.schrijfGebruikerIn(eventID, userId);
            geAdapter.Update(dataset.gebruikerevent);

        }

        public void SchrijfGebruikerUit(int eventID, int userId)
        {
            geAdapter.schrijfGebruikerUit(eventID, userId);
            geAdapter.Update(dataset.gebruikerevent);
        }
    }
}
