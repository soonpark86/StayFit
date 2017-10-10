using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StayFit.Models
{
    public enum WorkOutType
    {
        Cardio=1,WeightTraning=2
    }
    public enum WorkOut
    {
        Chest = 1, Back = 2, Leg = 3
    }

    public class Excercise
    {
        public int Id { get; set; }
        public WorkOutType WorkOutType { get; set; }
        public WorkOut WorkOut { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}