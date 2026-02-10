using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rota
{
    public class Scheduler
    {
        public List<Employee> Employees { get; }
        public List<Shift> Shifts { get; }

        public Scheduler(List<Employee> employees, List<Shift> shifts)
        {
            Employees = employees ?? new List<Employee>();
            Shifts = shifts ?? new List<Shift>();
        }
        public bool CheckAvailability(Employee employee, Shift shift)
        {
            if (employee.Position == shift.Position)
            {
                foreach (Employee.Availability availableShift in employee.AvailabilitySlots)
                {
                    if (availableShift.Day == shift.ShiftStart.DayOfWeek && availableShift.StartTime <= shift.ShiftStart.TimeOfDay && availableShift.EndTime >= shift.ShiftEnd.TimeOfDay)
                    {
                        foreach (Shift checkShiftOverlap in Shifts)
                        {
                            if (checkShiftOverlap.EmployeeOnShift == employee)
                            {
                                if (checkShiftOverlap.ShiftEnd > shift.ShiftStart && checkShiftOverlap.ShiftStart < shift.ShiftEnd)
                                {
                                    return false;
                                }
                            }
                        }
                        return true;
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        public bool AssignEmployee(Employee employee, Shift shift)
        {
            if (CheckAvailability(employee, shift) == true)
            {
                shift.EmployeeOnShift = employee;
                return true;
            }
            return false;
        }

        public List<Shift> FindUnfilledShifts()
        {
            List<Shift> unfilledShifts = new List<Shift>();
            foreach (Shift shift in Shifts)
            {
                if (shift.EmployeeOnShift == null)
                {
                    unfilledShifts.Add(shift);
                }
            }
            return unfilledShifts;
        }

        public List<Employee> FindAvailableEmployees(Shift shiftToFill)
        {
            List<Employee> availableEmployees = new List<Employee>();
            foreach (Employee employee in Employees)
            {
                if (CheckAvailability(employee, shiftToFill) == true)
                {
                    availableEmployees.Add(employee);
                }
            }
            return availableEmployees;
        }
    }
}
