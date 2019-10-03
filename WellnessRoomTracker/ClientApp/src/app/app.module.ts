import { ScheduleService } from './Services/schedule.service';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule  } from '@angular/common/http';
import { RouterModule } from '@angular/router';  
import { NoopAnimationsModule, BrowserAnimationsModule } from '@angular/platform-browser/animations'; 
import { MatFormFieldModule } from '@angular/material/form-field'; 
import {NgbModule} from '@ng-bootstrap/ng-bootstrap';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component'; 
import { HistoryComponent } from './history/history.component';
import { WellnessRoomServiceService } from './Services/wellness-room-service.service';  
import { WellnessRoomLatestComponent } from './wellness-room-latest/wellness-room-latest.component';
import { ScheduleComponent } from './schedule/schedule.component';
import { NewScheduleComponent } from './new-schedule/new-schedule.component';
import {   
  MatDatepickerModule,
  MatNativeDateModule,
  MatInputModule,
  MatSliderModule
} from '@angular/material';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HistoryComponent,
    WellnessRoomLatestComponent,
    ScheduleComponent,
    NewScheduleComponent
  ],
  imports: [
    NgbModule,
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    HttpClientModule,
    MatFormFieldModule, 
    MatNativeDateModule, 
    MatInputModule,
    MatDatepickerModule , 
    BrowserAnimationsModule,
    MatSliderModule,
    RouterModule.forRoot([
      { path: '', component: ScheduleComponent, pathMatch: 'full' },
      { path: 'newSchedule', component: NewScheduleComponent, pathMatch: 'full' },
      { path: 'Latest', component: WellnessRoomLatestComponent, pathMatch: 'full' },
      { path: 'history', component: HistoryComponent } 
    ]),
    NoopAnimationsModule
  ],
  providers: [
    WellnessRoomServiceService ,
    {provide: ScheduleService,useClass:ScheduleService} 
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
