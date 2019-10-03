import { WellnessRoomServiceService } from './../Services/wellness-room-service.service';
import { Component, OnInit } from '@angular/core';
import { RoomStatus } from '../model/roomStatus'; 

@Component({
  selector: 'app-history',
  templateUrl: './history.component.html',
  styleUrls: ['./history.component.css']
})

export class HistoryComponent implements OnInit {

  history: RoomStatus[];
  persons;
  constructor(private service: WellnessRoomServiceService) { }

  ngOnInit() {

    this.service.getPeople().subscribe(p => {
      this.persons = p;
      console.log(this.persons);
    });

    this.service.getHistory().subscribe(
      (h:any[]) => { 
        this.history = new Array(); 
        for (var i = 0; i < h.length; i++) {
          var status = new RoomStatus();
          status.changedById = h[i].changedById;
          status.id = h[i].id;
          status.changedByName = h[i].changedByName;
          status.isCheckin = h[i].isCheckin; 
          var date = new Date(h[i].changedTime); 
          status.changedTime = date.toLocaleString();
          this.history.push(status);
          //test git add
          //branch test
        } 
      }
    );
  }

}
