using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rota
{
    public class Shift
    {
        public int ShiftID { get; set; }
        public Employee EmployeeOnShift { get; set; }
        public string Position { get; set; }
        public DateTime ShiftStart { get; set; }
        public DateTime ShiftEnd { get; set; }

        public Shift(int shiftID, string position, DateTime shiftStart, DateTime shiftEnd)
        {
            ShiftID = shiftID;
            Position = position;
            ShiftStart = shiftStart;
            ShiftEnd = shiftEnd;
        }

        public Shift(int shiftID, Employee employeeOnShift, string position, DateTime shiftStart, DateTime shiftEnd)
        {
            ShiftID = shiftID;
            EmployeeOnShift = employeeOnShift;
            Position = position;
            ShiftStart = shiftStart;
            ShiftEnd = shiftEnd;
        }

        public override string ToString()
        {
            if (EmployeeOnShift != null)
            {
                return $"{EmployeeOnShift} - {Position}: {ShiftStart} - {ShiftEnd}";
            }
            else
            {
                return $"{Position}: {ShiftStart} - {ShiftEnd}";

            }
        }
    }
}
