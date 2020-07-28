using System;
using System.Collections.Generic;

namespace LadyBusinesCoreAng
{
    public partial class Gigs
    {
        public long Id { get; set; }
        public string Location { get; set; }
        public int? HouseNumber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public DateTime? DateOfEvent { get; set; }
        public int? TimeOfEvent { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string EventName { get; set; }
        public string Url { get; set; }
        public string ImageFilename { get; set; }
        public string PhoneNum { get; set; }
        public int? EndTime { get; set; }
    }
}
