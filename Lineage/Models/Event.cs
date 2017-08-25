using System;
using System.Collections.Generic;

namespace Lineage.Models
{
    public class Event
    {
        public Guid EventId { get; set; }
        public DateTime OccurredOn { get; set; }
        public EventType EventType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Address Place { get; set; }
        public List<Person> Participants { get; set; }
    }
}