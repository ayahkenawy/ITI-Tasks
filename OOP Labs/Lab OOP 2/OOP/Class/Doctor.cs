namespace Class
{
    internal class Doctor
    {
        #region Create class Person 
        private int id;
        private string name;
        private int age;
        private string Specification;
        private int grade;
        #endregion

        #region Setter & Getter

        public void setId(int _id)
        {
            id = _id;
        }

        public int getId()
        {
            return id;
        }
        public void setName(string _name)
        {
            name = _name;
        }

        public string getName()
        {
            return name;
        }
        public void setAge(int _age)
        {
            age = _age;
        }

        public int getAge()
        {
            return age;
        }
        public void setSpecification(string _Specification)
        {
            Specification = _Specification;
        }

        public string getSpecification()
        {
            return Specification;
        }
        public void setgrade(int _grade)
        {
            grade = _grade;
        }

        public int getgrade()
        {
            return grade;
        }
        #endregion

        #region Print

        public string print()
        {
            return $" {id} , {name} , {age} , {Specification} , {grade} ";
        }

        #endregion
    }
}
