using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WellnessRoomTracker.Domain
{
    [Table("RoomHistries")]
    public class WellnessRoomStatus
    {
        public int Id{get;set;}
 
 //indicate if it's check in or check out
        public bool IsCheckin{get;set;}

        public Person ChangedBy { get; set; }

        public DateTime ChangedTime{get;set;}
        
        public int PersonId{get;set;}
        
        public override string  ToString(){

            return $"Id: {Id}, isCheckin: {this.IsCheckin}, changed by: {this.ChangedBy?.Id}, personId:{this.PersonId}";
        }
        
    }
}