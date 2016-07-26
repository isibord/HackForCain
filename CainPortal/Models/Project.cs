using System;
using System.Collections.Generic;

namespace CainPortal.Models
{
    public partial class Project
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public int ProjectTypeId { get; set; }
        public int NumberOfParticipants { get; set; }
        public decimal? AmountRaised { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public string Organizer { get; set; }
        public string Comments { get; set; }

        public virtual ProjectType ProjectType { get; set; }
    }
}
