using System;
using System.Collections.Generic;

namespace LadyBusinesCoreAng
{
    public partial class Songs
    {
        public long Id { get; set; }
        public string SongTitle { get; set; }
        public string FileName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
