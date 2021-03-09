using Microsoft.EntityFrameworkCore;
using Scheduling.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling.Services
{
    public class StaffScheduleService : IStaffScheduleServices
    {
        private readonly SCHEDULINGContext _context;
        private bool disposed = false;
        public StaffScheduleService(SCHEDULINGContext context)
        {
            _context = context;
        }

        public async Task<AddStaffScheduleResponse> AddStaffScheduleAsync(AddStaffScheduleRequest request)
        {
            AddStaffScheduleResponse response = null;

           
                StaffScheduleList scheduleList = new StaffScheduleList();                
                scheduleList.CreateDate = DateTime.Now;
                scheduleList.CreatedBy = request.CreatedBy;
                scheduleList.Order = request.Order;

                await _context.StaffScheduleLists.AddAsync(scheduleList);
                await _context.SaveChangesAsync();   

                response = new AddStaffScheduleResponse
                {
                    CreatedAt = scheduleList.CreateDate,
                    CreatedBy = scheduleList.CreatedBy,
                    Order = scheduleList.Order,
                    StaffId = scheduleList.StaffId
                };
                
           
            return response;
        }

        public async Task<GetStaffScheduleResponse> GetStaffScheduleAsync()
        {
            List<StaffScheduleList> scheduleLists = await _context.StaffScheduleLists.ToListAsync();

            GetStaffScheduleResponse response = new GetStaffScheduleResponse();
            response.Data = new List<Models.StaffScheduleModel>();

            if (scheduleLists != null)
            {
                foreach(StaffScheduleList scheduledList in scheduleLists)
                {
                    var staffScheduleModel = new Models.StaffScheduleModel();
                    staffScheduleModel.StaffId = scheduledList.StaffId;
                    staffScheduleModel.Order = scheduledList.Order;
                    staffScheduleModel.CreatedAt = scheduledList.CreateDate;
                    staffScheduleModel.CreatedBy = scheduledList.CreatedBy;
                    response.Data.Add(staffScheduleModel);
                }
            }
            return response;
        }

        public int GenerateId()
        {
            return (_context.StaffScheduleLists.Select(p => p.StaffId).DefaultIfEmpty().Max() + 1);            
        }

        protected virtual void Dispose(bool disposing)
        {
            if(!this.disposed)
            {
                if(disposing)
                {
                    _context.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
