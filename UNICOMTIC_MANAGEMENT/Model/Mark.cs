﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNICOMTIC_MANAGEMENT.Model
{
    public class Mark
    {
        public int MarkID {  get; set; }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int ExamID { get; set; }
        public string ExamName { get; set; }
        public double Score { get; set; }
    }
}
