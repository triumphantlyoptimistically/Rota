using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rota
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Position { get; set; }
        public List<Availability> AvailabilitySlots { get; set; }

        public struct Availability
        {
            public DayOfWeek Day { get; }
            public TimeSpan StartTime { get; }
            public TimeSpan EndTime { get; }

            public Availability(DayOfWeek day, TimeSpan startTime, TimeSpan endTime)
            {
                Day = day;
                StartTime = startTime;
                EndTime = endTime;
            }

            public override string ToString()
            {
                return $"{Day} {StartTime} - {EndTime}";
            }
        }

        public Employee(int employeeID, string employeeName, string position, List<Availability> availabilitySlots)
        {
            EmployeeID = employeeID;
            EmployeeName = employeeName;
            Position = position;
            AvailabilitySlots = availabilitySlots;
        }

        public override string ToString()
        {
            string employeeDetails = $"Employee: {EmployeeID}, {EmployeeName}, {Position}, ";
            string availabilityString = string.Join(", ", AvailabilitySlots);
            employeeDetails += availabilityString;
            return employeeDetails;
        }
    }
}
