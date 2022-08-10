use iti 


--1.	Retrieve number of students who have a value in their age. 

select count(St_Id) as StudentCount from Student where st_age is not null

--2.	Get all instructors Names without repetition

select distinct Ins_Name from Instructor

--3.	Display student with the following Format (use isNull function)
--Student ID	Student Full Name	Department name
		
select St_Id as 'Student ID', isnull(St_Fname+' '+St_Lname,'Student Full Name') as 'Student Full Name' ,Dept_Name as 'Department Name' from Student
inner join Department on Student.Dept_Id = Department.Dept_Id

--4.	Display instructor Name and Department Name 
--Note: display all the instructors if they are attached to a department or not

select Ins_Name as InstuctorName , Dept_Name as DepartmentName from Instructor left join Department on Instructor.Dept_Id = Department.Dept_Id

--5.	Display student full name and the name of the course he is taking
--For only courses which have a grade  

select St_Fname+' '+St_Lname as 'Student Full Name' , Crs_Name as 'Course Name' 
from Student inner join Stud_Course 
	on Student.St_Id =Stud_Course.St_Id
inner join Course
	on Course.Crs_Id=Stud_Course.Crs_Id and Grade is not null

--6.	Display number of courses for each topic name

select count(Crs_Id) ,Top_Name  from Course inner join Topic on Course.Top_Id = Topic.Top_Id group by Top_Name

--7.	Display max and min salary for instructors

select min(salary) as 'Min Salary',max(salary) as 'Max Salary'	from Instructor

--8.	Display instructors who have salaries less than the average salary of all instructors.

select *  from Instructor where Salary < (select avg(Salary) from Instructor)

--9.	Display the Department name that contains the instructor who receives the minimum salary.

select Dept_Name as'Department name' from Department inner join Instructor 
on Department.Dept_Id = Instructor.Dept_Id and Salary =(select min(Salary) from Instructor)

--10.	 Select max two salaries in instructor table. 

select top(2) salary from Instructor order by Salary desc

--11.	 Select instructor name and his salary but if there is no salary display instructor bonus keyword. “use coalesce Function”

select Ins_Name as InstuctorName, coalesce(convert(nvarchar(20),salary),'instructor bonus') as Salary from Instructor 

--12.	Select Average Salary for instructors 

select avg(salary) as AvgSalary from Instructor

--13.	Select Student first name and the data of his supervisor 

select s.St_Fname as StudentFirstName , super.*  from student as s inner join student super
on s.St_super = super.St_Id

--14.	Write a query to select the highest two salaries in Each Department for instructors who have salaries. “using one of Ranking Functions”

select * from (select salary,Dept_Id, ROW_NUMBER() over (partition by Dept_Id order by salary) as rk from instructor where salary is not null)
as newtable where rk <=2

--15.	 Write a query to select a random  student from each department.  “using one of Ranking Functions”

select * from (select *, rank() over (partition by Dept_Id order by newid()) as rk from Student)
as newtable where rk <2