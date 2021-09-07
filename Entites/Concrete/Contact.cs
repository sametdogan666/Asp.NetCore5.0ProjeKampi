using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Concrete
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string ContactUserName { get; set; }
        public string ContactMail { get; set; }
        public string ContactSubject { get; set; }
        public string ContactMessage { get; set; }
        public DateTime ContactCreateDate { get; set; }
        public bool ContactStatus { get; set; }
        
    }
}
