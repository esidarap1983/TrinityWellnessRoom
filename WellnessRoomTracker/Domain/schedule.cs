
using System;

namespace WellnessRoomTracker.Domain
{
    public class Schedule
    {
        public int Id{get;set;}

        public Person Person { get; set; }  

        public DateTime From { get; set; }

        public DateTime To{get;set;}

        public int PersonId{get;set;}
 
    }
}