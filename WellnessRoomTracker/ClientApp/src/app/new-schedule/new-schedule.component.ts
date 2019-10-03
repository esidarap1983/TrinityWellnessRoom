import { ScheduleService } from './../Services/schedule.service';
import { WellnessRoomServiceService } from './../Services/wellness-room-service.service';
import { Component, OnInit } from '@angular/core';
import { NgbModal, NgbTimepicker } from '@ng-bootstrap/ng-bootstrap';
import { ModuleMapNgFactoryLoader } from '@nguniversal/module-map-ngfactory-loader';
@Component({
  selector: 'app-new-schedule',
  templateUrl: './new-schedule.component.html',
  styleUrls: ['./new-schedule.component.css']
})
export class NewScheduleComponent implements OnInit {

  constructor(private wellnessService: WellnessRoomServiceService, private scheduleService: ScheduleService) { }
  model;
  selectedUser;
  persons;
  selectedDate:Date;
  startTime;
  endTime;
  ngOnInit() {
    this.wellnessService.getPeople().subscribe(p => {
      this.persons = p;
      var currentTime = new Date();
      this.startTime = { hour: currentTime.getHours(), minute: currentTime.getMinutes() };
      currentTime = new Date(currentTime.getTime() + 30 * 60000)
      this.endTime = { hour: currentTime.getHours(), minute: currentTime.getMinutes() };
      this.selectedDate = new Date(); 
    });
  }
  saveSchedule() {
 
    let newSchedule = {
      personId: Number(this.selectedUser) ,
      from: this.formatTime(this.startTime),
      to: this.formatTime(this.endTime)
    }; 
    this.scheduleService.addNewSchedule(newSchedule).subscribe( 
      n => { 
      }
    );
  }

  formatTime(time) {
    return  this.selectedDate.getFullYear()  + "-" +
    this.formatNumber(this.selectedDate.getMonth()+1,2) + "-" + 
    this.formatNumber(this.selectedDate.getDate(),2)  + "T" +
    this.formatNumber(time.hour,2)   + ":" +
    this.formatNumber(time.minute,2) + ":00";
  }

  formatNumber(data:number ,digital:number ){
    return  data .toLocaleString('en',{minimumIntegerDigits:digital })
  }
  startChange() {
    var currentTime = new Date(this.selectedDate.getFullYear(), this.selectedDate.getMonth()+1, this.selectedDate.getDate(), this.startTime.hour, this.startTime.minute);
    currentTime = new Date(currentTime.getTime() + 30 * 60000);

    this.endTime = { hour: currentTime.getHours(), minute: currentTime.getMinutes() };

  }
}
