import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {HttpHeaders} from "@angular/common/http";
import { AddScheduleStaffWebRequest } from './add-schedule-staff-web-request.model';
import { GetScheduleStaffWebResponse } from './get-schedule-staff-web-response.model';

@Injectable({
  providedIn: 'root'
})
export class StaffScheduleServiceService {

  constructor(private http : HttpClient) { }

  private readonly baseURL = 'https://localhost:44373/StaffSchedule/';

  addStaffSchedule : AddScheduleStaffWebRequest = new AddScheduleStaffWebRequest();
  list : GetScheduleStaffWebResponse;
  postScheduleStaff(){
    let httpHeaders = new HttpHeaders({
     'Content-Type' : 'application/json',
     'Cache-Control': 'no-cache'
    });
    let options = {
	      headers: httpHeaders
     };  

    return this.http.post(this.baseURL + 'AddStaffOrder',this.addStaffSchedule,options);
  }

  refreshList(){
    this.http.get(this.baseURL)
              .toPromise()
              .then(res => {
                console.log(JSON.stringify(res));
                this.list = res as GetScheduleStaffWebResponse
              })
  }

  deleteScheduledStaff(id: number)
  {
    return this.http.delete(`${this.baseURL}DeleteSchedule/${id}`);
  }
}
