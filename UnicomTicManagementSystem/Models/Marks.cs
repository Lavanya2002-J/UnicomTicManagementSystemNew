using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTicManagementSystem.Models
{
    public class Marks
    {
        public int MarkId { get; set; } 
        public int StudentId { get; set; }
        public int ExamId { get;  set; }
        public int Score { get; set; }
        public string SubjectName { get; set; } 
    }
}
