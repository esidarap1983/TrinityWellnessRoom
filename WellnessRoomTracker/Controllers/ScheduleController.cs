using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WellnessRoomTracker.Domain;
using WellnessRoomTracker.Persistence;
using WellnessRoomTracker.Controllers.Resources;

namespace WellnessRoomTracker.Controllers
{
    public class ScheduleController : Controller
    {

        private readonly WellnessRoomDbContext _context;
        private readonly IMapper _mapper;

        public ScheduleController(WellnessRoomDbContext context, IMapper mapper)
        {
            _context = context;
            this._mapper = mapper;
        }

[HttpGet("api/schedule")]
        public async Task<IEnumerable<ScheduleReadResource>> GetTodaySchedule()
        {
            DateTime todayStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            DateTime todayEnd = todayStart.AddDays(1);
            var schedules= await _context.Schedules
            .Where(x => x.From >= todayStart  )
            .Include(x=>x.Person).ToListAsync();
            return _mapper.Map<List< Schedule>,List< ScheduleReadResource>>(schedules);
        } 
[HttpPost("api/schedule/add")]
        public ActionResult AddSchedule([FromBody]ScheduleWriteResource scheduleResource)
        {
            Console.WriteLine("schedule resource",scheduleResource);
            var schedule = _mapper.Map<ScheduleWriteResource, Schedule>(scheduleResource);
            Console.WriteLine("schedule:" ,schedule);
            _context.Schedules.Add(schedule);
            _context.SaveChanges();
            return Ok(schedule);
        }
    }
}