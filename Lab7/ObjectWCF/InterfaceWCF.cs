using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Proiect1Net.Data;
using Proiect1Net;
namespace ObjectWCF
{
    [ServiceContract]
    interface InterfaceMedia
    {
        [OperationContract]
        List<Medias> GetAllMedia();
        [OperationContract]
        List<Medias> GetAllPhotos();
        [OperationContract]
        List<Medias> GetAllVideos();
        

        [OperationContract]
        bool AddMedia(string path, DateTime creationDate, Event ev = null, bool isVideo = false,
            string note = null, int rating = 0, List<Person> people = null, Scenary scenary = null);
        [OperationContract]
        List<Medias> FilterMedia(DateTime creationDateStart, DateTime creationDateEnd, string eventName, string eventLocation, int isVideo, Person person, string scenary, string season);
      
        [OperationContract]
        Medias GetMediaById(int id);

        [OperationContract]
        bool DeleteMedia(int id);

    }
    [ServiceContract]
    interface InterfacePerson
    {
        [OperationContract]
        bool AddPerson(string firstName, string lastName);
        [OperationContract]
        List<Person> GetAllPeople();
        [OperationContract]
        Person GetPerson(string firstName, string lastName);
        [OperationContract]
        Person GetOrCreatePerson(string firstName, string lastName);
        [OperationContract]
        List<string> GetAllPeopleNames();
        [OperationContract]
        Person GetPersonById(int id);
        [OperationContract]
        bool DeletePerson(int id);
    }
    [ServiceContract]
    interface InterfaceEvent
    {
        [OperationContract]
        bool AddEvent(string name, string location);
        [OperationContract]
        List<Event> GetAllEvents();
        [OperationContract]
        Event GetEvent(string location, string name);
        [OperationContract]
        Event GetOrCreateEvent(string location, string name);
        [OperationContract]
        List<string> GetEventNames();
        [OperationContract]
        List<string> GetEventLocation();
        [OperationContract]
        Event GetEventById(int id);
        [OperationContract]
        bool DeleteEvent(int id);
        
    }
    [ServiceContract]
    interface InterfaceScenary
    {
        [OperationContract]
        bool AddScenary(string season, string type);
        [OperationContract]
        Scenary GetScenary(string season, string type);
        [OperationContract]
        Scenary GetOrCreateScenary(string season, string type);
        [OperationContract]
        List<Scenary> GetAllScenaries();
        [OperationContract]
        List<string> GetAllScenaryTypes();
        [OperationContract]
        Scenary GetScenaryById(int id);
        [OperationContract]
        bool DeleteScenary(int id);
  
    }
    [ServiceContract]
    interface IPostMedia : InterfaceMedia, InterfacePerson, InterfaceEvent, InterfaceScenary
    {
    }
}
