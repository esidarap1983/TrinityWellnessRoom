import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ScheduleService {

  constructor(private http: HttpClient) { }

  
  getSchedules(){
    return this.http.get('/api/schedule');
  }

  addNewSchedule(newSchedule){
    console.log("newschedule json" + newSchedule);
    return this.http.post('/api/schedule/add',newSchedule);
  }
}
