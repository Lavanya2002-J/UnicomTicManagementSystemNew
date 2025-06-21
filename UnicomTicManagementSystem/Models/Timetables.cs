using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTicManagementSystem.Models
{
    public class Timetables
    {
        public int TimetableId { get; set; }
        public int SubjectId { get; set; }
        public string TimeSlot { get; set; }
        public int RoomId { get; set; }

        public string Date { get; set; }
    }
}
