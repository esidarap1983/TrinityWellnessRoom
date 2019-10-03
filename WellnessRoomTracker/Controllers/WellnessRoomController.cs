using System.Net;
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WellnessRoomTracker.Persistence;
using System.Collections;
using System.Collections.Generic;
using WellnessRoomTracker.Domain;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using WellnessRoomTracker.Controllers.Resources;

namespace WellnessRoomTracker.Controllers
{
    public class WellnessRoomController : Controller
    {
        private readonly WellnessRoomDbContext _context;
        private readonly IMapper _mapper;

        public WellnessRoomController(WellnessRoomDbContext context, IMapper mapper)
        {
            _context = context;
            this._mapper = mapper;
        }

        [HttpGet("/api/history")]
        public async Task<IEnumerable<WellnessroomStatusResource>> GetStatusHistory()
        {
            var histories = await _context.RoomHistries.Include(s => s.ChangedBy).ToListAsync();
            return _mapper.Map<List<WellnessRoomStatus>, List<WellnessroomStatusResource>>(histories);
        }

        [HttpGet("/api/people")]
        public async Task<IEnumerable<IdNameResource>> GetPeople()
        {
            var people = await _context.Persons.ToListAsync();
            return _mapper.Map<List<Person>, List<IdNameResource>>(people);
        }

        [HttpGet("/api/latestStatus")]
        public WellnessroomStatusResource GetLatestStatus()
        {
            var status = _context.RoomHistries.Include(s => s.ChangedBy).ToList().LastOrDefault();
            return _mapper.Map<WellnessRoomStatus, WellnessroomStatusResource>(status);

        }

        [HttpPost("/api/checkin")]
        public IActionResult Checkin([FromBody] WellnessroomStatusResource statusResource)
        {
            Console.WriteLine("status resource: " + statusResource);
            var status = _mapper.Map<WellnessroomStatusResource, WellnessRoomStatus>(statusResource  );
            Console.WriteLine("status: " + status);
            if(status != null ){
            status.ChangedTime = DateTime.Now;
            _context.RoomHistries.Add(status);
            int newId = _context.SaveChanges();}
            return Ok(status);
 
        }
    }
}