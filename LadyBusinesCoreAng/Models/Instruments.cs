using System;
using System.Collections.Generic;

namespace LadyBusinesCoreAng
{
    public partial class Instruments
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
