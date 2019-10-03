import { ScheduleService } from './../Services/schedule.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-schedule',
  templateUrl: './schedule.component.html',
  styleUrls: ['./schedule.component.css']
})
export class ScheduleComponent implements OnInit {
 
  constructor(private service: ScheduleService) { }
  schedules;
  ngOnInit() {
    this.service.getSchedules().subscribe(s => {
      console.log("s" + JSON.stringify(s));
      this.schedules = s;
      this.schedules.forEach(s => {
        s.from = new Date(s.from).toLocaleString();
        s.to = new Date(s.to).toLocaleString();
      });
      console.log(this.schedules);
    });
  } 
}
