using System;
using System.Collections.Generic;
using System.Text;

namespace Capacity.Model
{
    public class Record
    {
        public int Id { get; set; }
        public DateTime RecordDate { get; set; }
        public TimeSpan RecordHour { get; set; }
        public int Counter { get; set; }
        public int Id_Branch { get; set; }
    }
}
