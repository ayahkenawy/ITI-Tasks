using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryAll
{
    struct HireDate:IComparable
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public HireDate(int _day,int _month,int _year)
        {
            Day = _day;
            Month = _month;
            Year = _year;
        }

        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }

        public int CompareTo(object obj)
        {
            HireDate hire = (HireDate)obj;
            if (Year == hire.Year)
            {
                if (Month == hire.Month)
                {
                    return Day.CompareTo(hire.Day);
                }
                else
                {
                    return Month.CompareTo(hire.Month);
                }
                
            }
            else
            {
                 return Year.CompareTo(hire.Year);
            }
           
        }
    }

    struct Employee:IComparable,ICloneable
    {
        public string Id { get; set; }
        public decimal Salary { get; set; }
        public Gender Gender { get; set; }
        public HireDate HireDate { get; set; }
        public Position Position { get; set; }

        public Employee(string _id, decimal _salary, Gender _gender, HireDate _hireDate, Position _position)
        {
            Id =_id;
            Salary = _salary;
            Gender = _gender;
            HireDate = _hireDate;
            Position = _position;
        }
        public override string ToString()
        {
            return $"Emp Id : {Id} , Emp Salary : {String.Format(new CultureInfo("en-US"), "{0:C}", Salary)} , Emp HireDate : {HireDate} , Emp Gender : {Gender} , Emp Position : {Position}";
        }

        public  string GetHash()
        {
            return   Guid.NewGuid().ToString();
        }

        public int CompareTo(object obj)
        {
           Employee emp = (Employee)obj ;
           return this.HireDate.CompareTo(emp.HireDate);
        }

        public object Clone()
        {
            return new Employee { Id = this.Id, Gender = this.Gender, Salary = this.Salary, HireDate = this.HireDate,Position = this.Position};
        }
        
    }
}
