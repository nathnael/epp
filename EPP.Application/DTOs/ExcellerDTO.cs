using System;
using System.Collections.Generic;
using System.Text;

namespace EPP.Application.DTOs
{
    public class ExcellerDto
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string FatherName { get; set; }
        public string GrandFatherName { get; set; }
        public int YearsOfExperience { get; set; }
        public DateTime ContractSigningDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
