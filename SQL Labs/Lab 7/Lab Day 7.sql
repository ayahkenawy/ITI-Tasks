Use ITI

--1.	 Create a view that displays student full name, course name if the student has a grade more than 50. 

Create view Student_Details	
as
select concat(s.St_Fname,' ',s.St_Lname) as FullName ,c.Crs_Name As CourseName , Grade from Student as S 
		inner join Stud_Course as SC on s.St_Id=sc.St_Id and Grade > 50
		inner join Course as C on c.Crs_Id=sc.Crs_Id

select * from Student_Details

--2.	 Create an Encrypted view that displays manager names and the topics they teach. 

alter view View_MangerDetails
with encryption
as
select Ins.Ins_Name as ManagerName , Top_Name as Topic from Department as Dept 
		inner join  Instructor as Ins on Dept.Dept_Manager = ins.Ins_Id 
		inner join Ins_Course on ins.Ins_Id=Ins_Course.Ins_Id
		inner join Course on Ins_Course.Crs_Id = Course.Crs_Id
		inner join Topic on Topic.Top_Id = Course.Top_Id
WITH CHECK OPTION;

select * from View_MangerDetails

--3.	Create a view that will display Instructor Name, Department Name for the ‘SD’ or ‘Java’ Department 

Create view View_InsDeptDetails
as
select Ins_Name as InstuctorName , Dept_Name as DepartmentName from Instructor 
		inner join Department on Department.Dept_Id=Instructor.Dept_Id and Dept_Name in ('SD','Java')

select * from View_InsDeptDetails

--4.	 Create a view “V1” that displays student data for student who lives in Alex or Cairo. 
--Note: Prevent the users to run the following query 
--Update V1 set st_address=’tanta’
--Where st_address=’alex’;
alter view V1 
as
select * from Student 
where St_Address in ('Alex','Cairo')
With  check	option;

update V1
set st_address='tanta'
Where st_address='alex';

select * from V1

--5.	Create a view that will display the project name and the number of employees work on it. “Use Company DB”

Use Company_SD

Create View View_ProjectDetails
as
select Pname as ProjectName , count(ESSn) as NumOFEmps from Project 
		inner join Works_for on Project.Pnumber = Works_for.Pno 
		inner join Employee on Employee.SSN = Works_for.ESSn
			group by Pname 

select * from View_ProjectDetails

--6.	Create the following schema and transfer the following tables to it 
--a.	Company Schema 
--i.	Department table (Programmatically)
--ii.	Project table (by wizard)
--b.	Human Resource Schema
--i.	  Employee table (Programmatically)

Create schema Company
Alter schema Company transfer Departments

Create schema [Human Resource]
Alter schema [Human Resource] transfer Employee

--7.	Create index on column (manager_Hiredate) that allow u to cluster the data in table Department. What will happen?

Use ITI

-- can't use clustered cause the table have primary key and already one clustered index
Create nonclustered index  manager_Hiredate on Department(Manager_hiredate)

--8.	Create index that allow u to enter unique ages in student table. What will happen?

-- there are duplicated value in age
Create unique index Unique_Age on Student(st_age) 

--9.	Create a cursor for Employee table that increases Employee salary by 10% if Salary <3000 
--and increases it by 20% if Salary >=3000. Use company DB

declare EditSalary Cursor
for select salary from Instructor
for update 
declare @salary  money
open EditSalary
fetch EditSalary into @salary
while @@fetch_status=0
	begin
		if @salary < 3000
			update instructor
				set salary += @salary*.1
			where current of EditSalary
		else if @salary >= 3000
			update Instructor
			set Salary += @salary*.2 
			where current of EditSalary
		fetch EditSalary into @salary
	end
close EditSalary
deallocate EditSalary

--10.	Display Department name with its manager name using cursor.

declare DeptDetails Cursor
for select Dept_Name , Ins_Name  from Department inner join Instructor on Department.Dept_Manager = Instructor.Ins_Id
for read only 
declare @deptName nvarchar(20) , @mangName nvarchar(20)
open  DeptDetails
fetch DeptDetails into @deptName, @mangName
while @@fetch_status=0
	begin
		select @deptName, @mangName
		fetch DeptDetails into @deptName, @mangName
	end
close DeptDetails
deallocate DeptDetails

--11.	Try to display all instructor names in one cell separated by comma. Using Cursor

declare instNames cursor
for select distinct Ins_Name
from Instructor where Ins_Name is not null
for read only
declare @name varchar(20),@all_names varchar(300)=''
open instNames
fetch instNames into @name
while @@FETCH_STATUS=0
	begin
		set @all_names=concat(@all_names,' , ',@name)
		fetch instNames into @name 
	end
select @all_names
close instNames
deallocate instNames

--12.	Try to generate script from DB ITI that describes all tables and views in this DB

-- Error because of encryption of views

-- Lecture 

Declare C1 Cursor
for select st_fname	,lead(St_Fname) over (order by st_id)
	from Student
for read only
declare @fname varchar(20),@nextName varchar(20),@counter int=0 
open C1
Fetch C1 into @fname ,@nextName
while @@FETCH_STATUS=0
	begin
		 if (lower(@fname) ='ahmed' and lower(@nextName)='amr')
					   set @counter +=1 
		 Fetch C1 into @fname ,@nextName
	end
select @counter
close C1
Deallocate C1