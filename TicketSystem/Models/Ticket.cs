using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystem.Models
{
    public class Ticket
    {
        //
        public int ticketID { get; set; }
        public string category { get; set; }
        [DataType(DataType.Date)]
        public DateTime createdDate { get; set; }
        public string description { get; set; }
        public string status { get; set; }

    }
}
