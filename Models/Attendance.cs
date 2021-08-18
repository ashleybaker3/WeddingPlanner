using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Models
{
    public class Attendance
    {
        public int AttendanceID { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        
        public int UserID { get; set; }
        public User User { get; set; }
        public int WeddingID { get; set; }
        public Wedding Wedding { get; set; }
    }
}