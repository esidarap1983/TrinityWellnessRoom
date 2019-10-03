using System;

namespace WellnessRoomTracker.Controllers.Resources
{
    public class ScheduleWriteResource
    {

        public int Id { get; set; }

        public int PersonId { get; set; }

        public DateTime From { get; set; }

        public DateTime To { get; set; }

        public override string ToString()
        {
            return $"person id: {this.PersonId} from: {this.From} to: {this.To}";
        }
    }
}