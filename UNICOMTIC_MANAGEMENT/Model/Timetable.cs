using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNICOMTIC_MANAGEMENT.Model
{
    internal class Timetable
    {
       
        public int TimeTableID { get; set; }
       
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
       
        public string TimeSlot { get; set; }
        public int RoomID { get; internal set; }
        public string RoomName { get; set; }
        public string RoomType { get; set; }

    }
}
