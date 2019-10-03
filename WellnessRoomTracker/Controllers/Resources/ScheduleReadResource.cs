using System;

namespace WellnessRoomTracker.Controllers.Resources
{
    public class ScheduleReadResource
    {
        
        public int Id{get;set;}

        public IdNameResource Person { get; set; }  

        public DateTime From { get; set; }

        public DateTime To{get;set;}
 
  public override string  ToString(){
return $"person object id:{this.Person?.Id}, person name: {this.Person?.Name}, from: {this.From} to: {this.To}";
    }}
}