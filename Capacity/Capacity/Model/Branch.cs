using System;
using System.Collections.Generic;
using System.Text;

namespace Capacity.Model
{
    public class Branch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int MaxCapacity { get; set; }
        public int LegalCertificate { get; set; }
        public int Id_Location { get; set; }
        public int Id_Company { get; set; }


    }
}
