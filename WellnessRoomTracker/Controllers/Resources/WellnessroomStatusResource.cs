using System;
namespace WellnessRoomTracker.Controllers.Resources
{
    public class WellnessroomStatusResource
    {
        
        public int Id{get;set;}
 
 //indicate if it's check in or check out
        public bool IsCheckin{get;set;}

        public string   ChangedByName { get; set; }
         
        public int   ChangedById { get; set; }
         
        public DateTime ChangedTime{get;set;}

        public override string  ToString(){

            return $"Id: {Id}, isCheckin: {this.IsCheckin}, changed by: {this.ChangedByName}";
        }
        
    }
}