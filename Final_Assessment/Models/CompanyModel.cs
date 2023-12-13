using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Assessment.Models
{
    public class CompanyModel
    {

 
        public int Company_Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyURL { get; set; }
        public string Remark { get; set; }
        public string CompanyLocation { get; set; }
        public int UserId { get; set; }
        public string Phone_Number { get; set; }
        public int Number_of_Employe { get; set; }
        public string Timezone { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public DateTime CreatedAt { get; set; }
    }

}

