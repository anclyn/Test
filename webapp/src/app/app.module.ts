import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import  { FormsModule} from "@angular/forms";
import {HttpClientModule} from "@angular/common/http";
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';

import { AppComponent } from './app.component';
import { SchedulingDetailsComponent } from './scheduling-details/scheduling-details.component';
import { SchedulingDetailsFormComponent } from './scheduling-details/scheduling-details-form/scheduling-details-form.component';

@NgModule({
  declarations: [
    AppComponent,
    SchedulingDetailsComponent,
    SchedulingDetailsFormComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
