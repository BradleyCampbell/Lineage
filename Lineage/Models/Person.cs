using System;
using System.Collections.Generic;

namespace Lineage.Models
{
    public class Person
    {
        public Guid PersonId { get; set; }
        public Title Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Suffix Suffix { get; set; }
        public string MaidenName { get; set; }
        public string Nickname { get; set; }
        public Sex Gender { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime DeathDate { get; set; }
        public Dictionary<Relationship, Person> Relations { get; set; }
        public List<Event> LifeEvents { get; set; }
        public List<Address> Addresses { get; set; }
            
    }
}
