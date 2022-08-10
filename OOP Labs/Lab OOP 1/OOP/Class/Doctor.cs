using System;

namespace Class
{
    internal class Doctor
    {
        #region Set Properties

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Specification { get; set; }
        public int Grade { get; set; }
        public static int counter;
        public static int Counter
        {
            get
            {
                return counter;
            }
        }
        #endregion

        #region Constructors

        static Doctor()
        {
            counter = 0;
        }

        public Doctor(int _id,string _name ,int _age,string _spe,int _grade)
        {
            counter++;
            Name = _name;
            Age = _age;
            Specification = _spe;
            Grade = _grade;
            Id=_id;
        }
        public Doctor()
        {
            counter++;
        }

        #endregion

        #region Print
        public string print()
        {
            return $" {Id} , {Name} , {Age} , {Specification} , {Grade} ";
        }

        #endregion
    }
}
