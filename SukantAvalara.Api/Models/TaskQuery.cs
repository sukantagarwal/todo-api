using SukantAvalara.Api.Domain;

namespace SukantAvalara.Api.Models
{
    public class TaskQuery
    {
        public int Id {get;set;}
        public string ListId {get;set;}
        public string Description {get;set;}
        public string Subject {get;set;}
        public TaskStatus? Status {get;set;}
    }
}