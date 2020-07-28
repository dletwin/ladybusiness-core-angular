using System;
using System.Collections.Generic;

namespace LadyBusinesCoreAng
{
    public partial class Members
    {
        public long Id { get; set; }
        public string FName { get; set; }
        public string NickName { get; set; }
        public string Summary { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string ImageFile { get; set; }
        public bool? SpecialGuest { get; set; }
    }
}
