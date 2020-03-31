using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect1Net;
using Proiect1Net.Data;
namespace ObjectWCF
{
    public class PostMedia : IPostMedia
    {
        bool InterfaceMedia.AddMedia(string path, DateTime creationDate, Event ev, bool isVideo, string note, int rating, List<Person> people, Scenary scenary)
        {
            MediasContext medias = new MediasContext();
            return medias.Add(path, creationDate, ev, isVideo, note, rating, people, scenary);
        }

        bool InterfaceMedia.DeleteMedia(int id)
        {
            MediasContext medias = new MediasContext();
            return medias.Delete(id);
        }

        List<Medias> InterfaceMedia.FilterMedia(DateTime creationDateStart, DateTime creationDateEnd, string eventName, string eventLocation, int isVideo, Person person, string scenary, string season)
        {
            MediasContext medias = new MediasContext();
            return medias.Filter(creationDateStart, creationDateEnd, eventName, eventLocation, isVideo, person, scenary, season);
        }

    

        List<Medias> InterfaceMedia.GetAllMedia()
        {
            MediasContext medias = new MediasContext();
            return medias.GetAll();
        }

        List<Medias> InterfaceMedia.GetAllPhotos()
        {
            MediasContext medias = new MediasContext();
            return medias.GetAllPhotos();
        }

        List<Medias> InterfaceMedia.GetAllVideos()
        {
            MediasContext medias = new MediasContext();
            return medias.GetAllVideos();

        }

        Medias InterfaceMedia.GetMediaById(int id)
        {
            MediasContext medias = new MediasContext();
            return medias.GetById(id);
        }


        bool InterfacePerson.AddPerson(string firstName, string lastName)
        {
            PersonContex person = new PersonContex();
            return person.Add(firstName, lastName);
        }
       
        List<Person> InterfacePerson.GetAllPeople()
        {
            PersonContex person = new PersonContex();
            return person.GetAll();
        }
       
        Person InterfacePerson.GetPerson(string firstName, string lastName)
        {
            PersonContex person = new PersonContex();
            return person.Get(firstName, lastName);
        }
       
        Person InterfacePerson.GetOrCreatePerson(string firstName, string lastName)
        {
            PersonContex person = new PersonContex();
            return person.GetOrCreate(firstName, lastName);
        }
       
        List<string> InterfacePerson.GetAllPeopleNames()
        {
            PersonContex person = new PersonContex();
            return person.GetAllNames();
        }
        
        Person InterfacePerson.GetPersonById(int id)
        {
            PersonContex person = new PersonContex();
            return person.GetById(id);
        }
       
        bool InterfacePerson.DeletePerson(int id)
        {
            PersonContex person = new PersonContex();
            return person.Delete(id);
        }



        bool InterfaceEvent.AddEvent(string name, string location)
        {
            EventContext eventContext = new EventContext();
            return eventContext.Add(name, location);
        }

        List<Event> InterfaceEvent.GetAllEvents()
        {
            EventContext eventContext = new EventContext();
            return eventContext.GetAll();
        }
        Event InterfaceEvent.GetEvent(string location, string name)
        {
            EventContext eventContext = new EventContext();
            return eventContext.Get(location, name);
        }

        Event InterfaceEvent.GetOrCreateEvent(string location, string name)
        {
            EventContext eventContext = new EventContext();
            return eventContext.GetOrCreate(location, name);
        }

        List<string> InterfaceEvent.GetEventNames()
        {
            EventContext eventContext = new EventContext();
            return eventContext.GetEventNames();
        }

        List<string> InterfaceEvent.GetEventLocation()
        {
            EventContext eventContext = new EventContext();
            return eventContext.GetEventLocation();
        }
        Event InterfaceEvent.GetEventById(int id)
        {
            EventContext eventContext = new EventContext();
            return eventContext.GetById(id);
        }
        bool InterfaceEvent.DeleteEvent(int id)
        {
            EventContext eventContext = new EventContext();
            return eventContext.Delete(id);
        }





        bool InterfaceScenary.AddScenary(string season, string type)
        {
            ScenaryContext scenary = new ScenaryContext();
            return scenary.Add(season, type);
        }
        
        Scenary InterfaceScenary.GetScenary(string season, string type)
        {
            ScenaryContext scenary = new ScenaryContext();
            return scenary.Get(season, type);
        }

        Scenary InterfaceScenary.GetOrCreateScenary(string season, string type)
        {
            ScenaryContext scenary = new ScenaryContext();
            return scenary.GetOrCreate(season, type);
        }

        List<Scenary> InterfaceScenary.GetAllScenaries()
        {
            ScenaryContext scenary = new ScenaryContext();
            return scenary.GetAll();
        }

        List<string> InterfaceScenary.GetAllScenaryTypes()
        {
            ScenaryContext scenary = new ScenaryContext();
            return scenary.GetAllTypes();
        }

        Scenary InterfaceScenary.GetScenaryById(int id)
        {
            ScenaryContext scenary = new ScenaryContext();
            return scenary.GetById(id);
        }

        bool InterfaceScenary.DeleteScenary(int id)
        {
            ScenaryContext scenary = new ScenaryContext();
            return scenary.Delete(id);
        }
    }
}
