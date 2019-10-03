using AutoMapper;
using WellnessRoomTracker.Controllers.Resources;
using WellnessRoomTracker.Domain;

namespace WellnessRoomTracker.Controllers.Mapping
{
    public class MappingProfile:Profile
    {
      public MappingProfile()
      {
        //domain class to API resource
          CreateMap<WellnessRoomStatus,WellnessroomStatusResource>()
          .ForMember(r => r.ChangedById, op => op.MapFrom( s => s.ChangedBy.Id))
          .ForMember(r => r.ChangedByName, op => op.MapFrom( s => s.ChangedBy.Name));
          CreateMap<Person, IdNameResource>();
          CreateMap<Schedule,ScheduleReadResource>() ;

          //API resource to domain class
          CreateMap<WellnessroomStatusResource,WellnessRoomStatus>()
          .ForMember(s => s.PersonId, op => op.MapFrom( vr => vr.ChangedById));
          //.ForMember(s => s.ChangedBy, op => op.MapFrom(op => new Person(){Id= op.ChangedById })) ;
          CreateMap<IdNameResource,Person>(); 
          CreateMap<ScheduleWriteResource,Schedule>() ;
      }  
    }
}