import { WellnessRoomServiceService } from './../Services/wellness-room-service.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-wellness-room-latest',
  templateUrl: './wellness-room-latest.component.html',
  styleUrls: ['./wellness-room-latest.component.css']
})
export class WellnessRoomLatestComponent implements OnInit {

  //form data
  f;
  persons;
  //isCheckin:boolean;
  checkinStatus: string;
  submitButtonText:string; 
   currentStatus:any={
      id :{},
     changedByName: {},
     changedById: {} ,
     ischeckin:{}
   };
  constructor(private service: WellnessRoomServiceService) { }

  ngOnInit() {
      this.service.getPeople().subscribe( p =>{ 
        this.persons=p; 
      });
      this.loadLatestStatus();
  }
  clickme(){ 
    this.currentStatus.isCheckin = !this.currentStatus.isCheckin;
    console.log("clicked");  
    this.currentStatus.id = 0;
    this.currentStatus.changedById =Number(this.currentStatus.changedById)  ;
    console.log(this.currentStatus);
    this.service.newStatus(this.currentStatus).subscribe( p =>{ 
      this.loadLatestStatus();
    });;
  }
  submitData(){ 
  }  
    loadLatestStatus(){
        this.service.getLatestStatus().subscribe(
        (s:any)  =>{ 
          this.currentStatus = s; 
          let statusDate :Date;
          statusDate = new Date(s.changedTime) ;
          this.checkinStatus = (s.isCheckin? "checked in by " :
           "available. Last checked out by ") + s.changedByName  + " at "+ 
           statusDate.toLocaleString();
          //  statusDate.getFullYear() + "-" + (statusDate.getMonth() + 1) + "-" + 
          //  statusDate.getDate() + " " + statusDate.getHours() + ":" + statusDate.getMinutes() + 
          //  ":" + statusDate.getSeconds();
           this.submitButtonText = s.isCheckin? "Check out":"Check in";
        } 
      );
    } 
}
