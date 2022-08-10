using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryAll
{
    struct HireDate
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
    }

    struct Employee
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
    }
}
