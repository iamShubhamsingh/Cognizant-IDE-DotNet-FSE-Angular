using System;
using System.Collections.Generic;

namespace GetWebApi.Models
{
    public class Client
    {
        // Implement your code here
        public int CaseId { get; set; }
        public string CaseDescription { get; set; }
        public string CaseDate { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailId { get; set; }
    }
}
