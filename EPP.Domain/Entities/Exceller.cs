using System;
using System.Collections.Generic;
using System.Text;

namespace EPP.Domain.Entities
{
    public class Exceller
    {
        public string FirstName { get; set; }
        public string FatherName { get; set; }
        public string GrandFatherName { get; set; }
        public int YearsOfExperience { get; set; }
        public DateTime ContractrSigningDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }

    }
}
