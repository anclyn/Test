import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { StaffScheduleServiceService } from '../shared/staff-schedule-service.service';

@Component({
  selector: 'app-scheduling-details',
  templateUrl: './scheduling-details.component.html',
  styles: [
  ]
})
export class SchedulingDetailsComponent implements OnInit {

  constructor(public service : StaffScheduleServiceService, private toastr : ToastrService) { }

  ngOnInit(): void {
    this.service.refreshList();
  }

  OnDelete(id:number)
  {
    if(confirm("Are you sure to delete this record?"))
    {
    this.service.deleteScheduledStaff(id)
    .subscribe(
      res => {
        this.service.refreshList();
        this.toastr.error("Deleted successfully.","Scheduling Staff");
      },
      err => {
        console.log(err);
      }
    )
  }
  }

}
