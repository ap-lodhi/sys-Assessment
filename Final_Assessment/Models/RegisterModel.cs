using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Assessment.Models
{
    public class RegisterModel
    {

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string phone { get; set; }
        public string encryptedPassword { get; set; }
        public string decryptedPassword { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
