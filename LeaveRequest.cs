using System;

namespace FinalProject
{
    public class LeaveRequest
    {
        public Guid EmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Reason { get; set; }
        public LeaveRequestStatus Status { get; set; }

        public LeaveRequest(Guid employeeId, DateTime startDate, DateTime endDate, string reason)
        {
            EmployeeId = employeeId;
            StartDate = startDate;
            EndDate = endDate;
            Reason = reason;
            Status = LeaveRequestStatus.Pending;
        }

    }

    public enum LeaveRequestStatus
    {
        Pending,
        Accepted,
        Rejected
    }
}
