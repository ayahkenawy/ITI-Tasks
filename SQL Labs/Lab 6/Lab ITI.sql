use iti


--1.	 Create a scalar function that takes date and returns Month name of that date.

create function getmonth(@date date)
returns nvarchar(10)
     begin
	 declare @month nvarchar(20)
	    set @month =format(@date,'MM')
		 return @month
	 end
select dbo.getmonth('04-04-1990')

--2.	 Create a multi-statements table-valued function that takes 2 integers and returns the values between them.

create function getvalues(@fvalue int , @svalue int)
returns @t table 
(
	betweenvalue int
)
		as
		begin
			while @fvalue+1<@svalue
			begin
			set @fvalue+=1
			insert into @t
			select @fvalue
			end
			return
		end
		    
select * from  dbo.getvalues(10,20)

--3.	 Create inline function that takes Student No and returns Department Name with Student full name.

create function getdeptname(@st_no int)
returns table 
		as return(
			 select Dept_Name 
			 from Student inner join Department
			 on Student.Dept_Id=Department.Dept_Id and Student.St_Id =@st_no	
		)
select * from  dbo.getdeptname(1)

--4.	Create a scalar function that takes Student ID and returns a message to user 
--a.	If first name and Last name are null then display 'First name & last name are null'
--b.	If First name is null then display 'first name is null'
--c.	If Last name is null then display 'last name is null'
--d.	Else display 'First name & last name are not null'

create function getmsg(@st_id int)
returns nvarchar(50)  
     begin
	 declare @msg nvarchar(50)
	 declare @fname nvarchar(20)
	 declare @lname nvarchar(20)
	 select @fname=st_fname , @lname=St_Lname from student where St_Id = @st_id
	 if @fname is null and @lname is null
	 set @msg ='First name & last name are null'
	 else if @fname is null and @lname is not null
	 set @msg ='first name is null'
	 else if @fname is not null and @lname is null
	 set @msg ='last name is null'
	 else 
	 set @msg ='First name & last name are not null'
		 return @msg 
	 end
select dbo.getmsg(14) as msg
select dbo.getmsg(13)  as msg

--5.	Create inline function that takes integer which represents manager ID and displays department name, Manager Name and hiring date 

alter function getdetails(@mgr_id int)
returns table 
		as return(
			 select Dept_Name , Ins_Name , Manager_hiredate
			 from Department inner join Instructor
			 on Instructor.Ins_Id=Department.Dept_Manager and Department.Dept_Manager=@mgr_id
		)
select * from  dbo.getdetails(1)

--6.	Create multi-statements table-valued function that takes a string
--If string='first name' returns student first name
--If string='last name' returns student last name 
--If string='full name' returns Full Name from student table 
--Note: Use “ISNULL” function

create function getstname(@string nvarchar(50))
returns @t table 
(
	studentName nvarchar(50)
)
		as
		begin
	 if @string ='first name'
				 insert into @t
	 			 select isnull(St_Fname,'Fname') from Student
	 else if @string ='last name'
				 insert into @t
	 			 select isnull(St_Lname,'Lname') from Student
	 else if @string ='full name'
				 insert into @t
	 			 select isnull(St_Fname+' '+St_Lname,'Fullname')  from Student
			return
		end
		    
select * from  dbo.getstname('first name')
select * from  dbo.getstname('last name')
select * from  dbo.getstname('full name')

--7.	Write a query that returns the Student No and Student first name without the last char

select St_Id 'Student No', substring(St_Fname,0,len(St_Fname)) 'Student first name' from student 

--8.	Wirte query to delete all grades for the students Located in SD Department

delete Stud_Course from Stud_Course	 
		inner join student on 	 Stud_Course.St_Id = Student.St_Id 
		inner join Department on Department.Dept_Id = Student.Dept_Id
	where Dept_Name='SD'

--9.	Using Merge statement between the following two tables [User ID, Transaction Amount]

merge into 	 'last transactions'   as l
		using 'daily transactions'  as d
			ON l.userid = d.userid
		when matched then
			update set l.amount = d.amount
		When not matched by target Then 
			insert(userid,amount)
			values(d.userid,d.amount)
		When not matched by Source
			Then delete;
--10.	Try to Create Login Named(ITIStud) who can access Only student and Course tablesfrom ITI DB 
--then allow him to select and insert data into tables and deny Delete and update



--Bonus:
--Give one Example about Hierarchyid datatype

