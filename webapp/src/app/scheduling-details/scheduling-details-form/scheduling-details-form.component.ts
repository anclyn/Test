import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { AddScheduleStaffWebRequest } from 'src/app/shared/add-schedule-staff-web-request.model';
import { StaffScheduleServiceService } from 'src/app/shared/staff-schedule-service.service';

@Component({
  selector: 'app-scheduling-details-form',
  templateUrl: './scheduling-details-form.component.html',
  styles: [
  ]
})
export class SchedulingDetailsFormComponent implements OnInit {

  constructor(public service: StaffScheduleServiceService,
              private toastr: ToastrService) { }

  ngOnInit(): void {
  }
  onSubmit(form: NgForm){
    this.service.postScheduleStaff().subscribe(
      res => {
        this.resetForm(form);
        this.toastr.success('Submitted successfully','Scheduling Staff');
      },
      err => {
        console.log(err);
      }
    );
  }
  resetForm(form: NgForm) {
      form.form.reset();
      this.service.addStaffSchedule = new AddScheduleStaffWebRequest();
      this.service.refreshList();
  }
}
