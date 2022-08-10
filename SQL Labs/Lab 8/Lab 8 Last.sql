--Part1
--1.	Create a stored procedure without parameters to show the number of students per department name.[use ITI DB]

Use ITI
Create procedure Student_Numbers
	as	
		select Dept_Name DepartmentName , count(St_Id) StudentNumber from Department D inner join Student S on s.Dept_Id = d.Dept_Id 
			group by Dept_Name

Student_Numbers

--2.	Create a stored procedure that will check for the # of employees in the project p1 
--if they are more than 3 print message to the user “'The number of employees in the project p1 is 3 or more'”
--if they are less display a message to the user “'The following employees work for the project p1'” 
--in addition to the first name and last name of each one. [Company DB] 

Use Company_SD
Create procedure Emp_Numbers   @pname varchar(20),@num int=null 
	as
		select  @num = count(ESSn)  from Project 
		inner join Works_for on Project.Pnumber = Works_for.Pno  and pname =@pname
		inner join Employee on Employee.SSN = Works_for.ESSn
			if @num > 3
				select 'The number of employees in the project '+@pname+' is 3 or more'
			else  
				 select 'The following employees work for the project '+@pname
				 union all 
				 select concat(fname ,' ', lname)  from Project 
					inner join Works_for on Project.Pnumber = Works_for.Pno  and pname =@pname
					inner join Employee on Employee.SSN = Works_for.ESSn

Emp_Numbers 'Al Rowad'

--3.	Create a stored procedure that will be used in case there is an old employee has left the project 
--and a new one become instead of him. The procedure should take 3 parameters 
--(old Emp. number, new Emp. number and the project number) and it will be used to update works_on table. [Company DB]

Create procedure update_WorksFor  @old int , @new int , @pnum int
	as
	begin try
		update Works_for 
		set ESSn = @new
			where ESSn = @old and Pno = @pnum
	end try
	begin catch
		select @@error
	end catch

update_WorksFor	 102672 , 512463 ,200

--4.	add column budget in project table and insert any draft values in it then 
--then Create an Audit table with the following structure 
--ProjectNo 	UserName 	ModifiedDate 	Budget_Old 	Budget_New 
--p2 	Dbo 	2008-01-31	95000 	200000

Create Table Audit
(
	ProjectNo int not null ,
	UserName nvarchar(50) not null  ,
	ModifiedDate date  ,
	Budget_Old money not null,
	Budget_New money not null
)

--This table will be used to audit the update trials on the Budget column (Project table, Company DB)
--Example:
--If a user updated the budget column then the project number, user name that made that update, the date of the modification and the value of the old and the new budget will be inserted into the Audit table
--Note: This process will take place only if the user updated the budget column

Create Trigger Update_Audit
on Project
after update
	as 
		if update(budget)
		begin
		declare @old int,@new int , @pnum int
			select @old=budget from deleted
			select @new=budget from inserted
			select @pnum=Pnumber from inserted
		insert into Audit
			values(@pnum,suser_name(),getdate(),@old,@new)
		end

--5.	Create a trigger to prevent anyone from inserting a new record in the Department table [ITI DB]
--“Print a message for user to tell him that he can’t insert a new record in that table”

Use ITI
Create Trigger Prevent_insert
on Department
instead of insert
	as
		select 'You can’t insert a new record in that table'

--6.	 Create a trigger that prevents the insertion Process for Employee table in March [Company DB].

Use Company_SD
Create Trigger Prevent_InsertEmp
on Employee
after insert
	as
		if format(getdate(),'MM')='March'
			rollback

--7.	Create a trigger on student table after insert to add Row in Student Audit table (Server User Name , Date, Note)
--where note will be “[username] Insert New Row with Key=[Key Value] in table [table name]”
--Server User Name		Date 	Note 

Use ITI
Create Table Student_Audit
(
	UserName nvarchar(50) not null  ,
	ModifiedDate date  ,
	Note nvarchar(100) ,
)

Create Trigger Update_Audit
on Student
after insert
	as 
		insert into Student_Audit
			values(suser_name(),getdate(),suser_name()+'Insert New Row with Key = ['+convert(nvarchar(20),(select St_Id from inserted))+'] in table Student')

--8.Create a trigger on student table instead of delete to add Row in Student Audit table 
--(Server User Name, Date, Note) where note will be“ try to delete Row with Key=[Key Value]”

Create Trigger Student_Delete
on Student 
instead of Delete
	as
		insert into Student_Audit
			values(suser_name(),getdate(),suser_name()+'Try to delete Row with Key = ['+convert(nvarchar(20),(select St_Id from deleted))+'] in table Student')
		

