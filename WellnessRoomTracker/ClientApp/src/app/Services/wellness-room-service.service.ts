import { HttpClient } from '@angular/common/http';  
import { Injectable } from '@angular/core'; 

@Injectable({
  providedIn: 'root'
})
export class WellnessRoomServiceService {

  constructor(private http: HttpClient) { }

  getLatestStatus() {
    return this.http.get('/api/latestStatus');
  }

  getHistory(){
    return this.http.get('/api/history');
  }

  getPeople() {
    return this.http.get('/api/people');

  }

  newStatus(status) {
    delete status.changedByName;
    console.log("service log", status);

    return this.http.post('/api/checkin', status);
  }

}
