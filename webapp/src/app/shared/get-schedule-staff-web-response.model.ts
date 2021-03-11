import { StaffScheduleModel } from "./staff-schedule-model.model";

export class GetScheduleStaffWebResponse {
    data : StaffScheduleModel[]=[];
    Errors : string[]=[];
    IsSuccessful : boolean | null=false;
    Message : string | null='';
    StatusCode : number | null =0;
}
