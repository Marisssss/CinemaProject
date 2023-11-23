using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.Infrastructure.ViewModel
{
    public class CinemaViewModel
    {
        public long IdCinema { get; set; }
        public string Address { get; set; }
        public string NameCinema { get; set; }

        public long IdClient { get; set; }
        public string LastNameClient { get; set; }
        public string NameClient { get; set; }
        public string MiddleNameClient { get; set; }
        public string SessionName { get; set; }

        public long IdEmployee { get; set; }
        public string LastNameEmployee { get; set; }
        public string NameEmployee { get; set; }
        public string MiddleNameEmployee { get; set; }
        public string DateOfBirth { get; set; }
        public string Floor { get; set; }
        public long IdPost { get; set; }
        public string PostName { get; set; }

        public long IdHall { get; set; }
        public long NumberOfSeats { get; set; }

        public long IdMovie { get; set; }
        public string NameMovie { get; set; }
        public decimal Rating { get; set; }

        public string NamePost { get; set; }
        public string EmployeeName { get; set; }

        public long IdSession { get; set; }
        public long Cost { get; set; }
        public long NumberOfClient { get; set; }
        public string SessionStartTime { get; set; }
        public decimal SessionEndTime { get; set; }
        public long HallName { get; set; }
        public long MovieName { get; set; }
        public long ClientName { get; set; }

    }
}
