using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNICOMTIC_MANAGEMENT.Model
{
    public class Exam
    {
        public int ExamId { get; set; }
        public DateTime ExamDate { get; set; }
        public string ExamName {  get; set; }
        public int RoomID { get; set; }
        public string RoomName { get; set; }   
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
    }
}


