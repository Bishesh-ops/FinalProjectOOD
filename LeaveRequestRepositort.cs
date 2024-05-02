using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalProject
{
    internal class LeaveRequestRepository
    {
        private static List<LeaveRequest> leaveRequests;

        // Static constructor to initialize the static list of leave requests
        static LeaveRequestRepository()
        {
            InitializeLeaveRequests();
        }

        // Method to initialize the list of leave requests if it's empty
        private static void InitializeLeaveRequests()
        {
            if (leaveRequests == null || leaveRequests.Count == 0)
            {
                leaveRequests = new List<LeaveRequest>();

                Random rand = new Random();
                EmployeeRepository employeeRepository = new EmployeeRepository();
                List<Employee> employees = employeeRepository.GetAllEmployees();

                foreach (var employee in employees)
                {
                    int numLeaveRequests = rand.Next(1, 6);

                    for (int i = 0; i < numLeaveRequests; i++)
                    {
                        DateTime startDate = DateTime.Today.AddDays(rand.Next(1, 31));
                        DateTime endDate = startDate.AddDays(rand.Next(1, 11));

                        LeaveRequest leaveRequest = new LeaveRequest(employee.Id, startDate, endDate, "A");
                        leaveRequests.Add(leaveRequest);
                    }
                }
            }
        }

        // Constructors

        public LeaveRequestRepository()
        {
            // Ensure the static list is initialized
            InitializeLeaveRequests();
        }

        public LeaveRequestRepository(EmployeeRepository employeeRepository)
        {
            // Ensure the static list is initialized
            InitializeLeaveRequests();
        }

        // Other methods...

        public List<LeaveRequest> GetAllLeaveRequests()
        {
            return leaveRequests;
        }

        public List<LeaveRequest> GetLeaveRequestsByEmployeeId(Guid employeeId)
        {
            return leaveRequests.FindAll(lr => lr.EmployeeId == employeeId);
        }

        public void AddLeaveRequest(LeaveRequest leaveRequest)
        {
            leaveRequests.Add(leaveRequest);
        }

        public void UpdateLeaveRequestStatus(Guid leaveRequestId, LeaveRequestStatus status)
        {
            LeaveRequest leaveRequest = leaveRequests.FirstOrDefault(lr => lr.EmployeeId == leaveRequestId);
            if (leaveRequest != null)
            {
                leaveRequest.Status = status;
            }
            else
            {
                Console.WriteLine("Leave request not found!");
            }
        }

        public void RemoveLeaveRequest(Guid id)
        {
            leaveRequests.RemoveAll(lr => lr.EmployeeId == id);
        }
    }
}
