--DB Schema
--Object    [SchemaName].ObjectName
select * from Student

Create schema HR

Create Schema Sales

alter schema HR transfer Student

alter schema HR Transfer Instructor

alter schema sales transfer Department

select * from student

select * from HR.student

create table student
(
 id int,
 name varchar(20)
)

select * from Student

create table sales.student
(
 sid int,
 sname varchar(20),
 sage int
)

--Security -------------
Authentication [UserName+Pass]
-----Windows Authentication
-------windows admin =====> SQL Admin
-----SQL Server Authentication
---------Create Remote Login

Authorization [Permisssions]


--User -->tables[student instructor] -->Grant Select insert
									--	Deny Delete Update

update hr.student
	set st_age+=1

--Object [ServerName].[DBName].[SchemaName].[ObjectName]

select *
from course

select *
from [DESKTOP-VF50P25].iti.dbo.course

select *
from Company_SD.dbo.project

select dname
from [IPServer1].Company_SD.dbo.Departments
union all
select dept_name
from [IPServer2].[iti].sales.Department

--DDL
Select * into t2
from course


Select * into t2
from course

Select * into sales.t2
from course


Select * into company_sd.dbo.course
from course

select st_id,st_fname into t3
from hr.student
where st_address='alex'

select * into t4
from hr.student
where 1=2

--insert based on select
insert into t3
values(7,'ali')

insert into t3
select st_id,st_fname from hr.student
where st_address='mansoura'

--------------------------------------
alter schema dbo transfer HR.student

select top(3)* 
from student

select top(5) st_fname 
from student

select top(3) *
from student
where st_address='alex'

select max(salary)
from instructor

select top(2) salary
from instructor
order by salary desc

select top(5) with ties *
from student
order by st_age desc

select newid()   --GUID

select top(3)*
from student
order by newid() 

select convert(varchar(20),getdate())

select cast(getdate() as varchar(20))

select convert(varchar(20),getdate(),101)
select convert(varchar(20),getdate(),103)
select convert(varchar(20),getdate(),111)
select convert(varchar(20),getdate(),110)
select convert(varchar(20),getdate(),107)

select format(getdate(),'dd-MM-yyyy')
select format(getdate(),'dddd MMMM yyyy')
select format(getdate(),'ddd MMM yy')
select format(getdate(),'dddd')
select format(getdate(),'MMMM')
select format(getdate(),'hh:mm:ss')
select format(getdate(),'hh tt')
select format(getdate(),'HH')
select format(getdate(),'dd-MM-yyyy hh:mm:ss')
select format(getdate(),'dd-MM-yyyy hh:mm:ss tt')

select format(getdate(),'dd')
select day(getdate())

select eomonth(getdate())

select format(eomonth(getdate()),'dd')

select format(eomonth(getdate()),'dddd')

select upper(st_fname),lower(st_lname)
from student

select len(st_fname),st_fname
from student

select substring(st_fname,1,3)
from student

select db_name()

select suser_name()

sin cos tan log

select power(salary,2)
from instructor

--select max(len(st_fname))
--from student

select top(1)st_fname
from student
order by len(St_fname) desc

Select *
From (select *,Row_number() over(order by st_age desc) as RN
	  from student) as Newtable
where RN=1

Select *
From (select *,Dense_Rank() over(order by st_age desc) as DR
	  from student) as NewTable
where DR=1



Select *
From (select *,Row_number() over(partition by dept_id order by st_age desc) as RN
	  from student) as Newtable
where RN=1

Select *
From (select *,Dense_Rank() over(partition by dept_id order by st_age desc) as DR
	  from student) as NewTable
where DR=1


create table LastT
(
 id int,
 name varchar(20),
 MyValue int
)

create table DailyT
(
 did int,
 dname varchar(20),
 Val int
)

Merge into LastT as T
using DailyT as S
on T.id=S.did
when matched then
	update 
		Set T.MyValue=S.Val
when not matched then
	insert 
	values(S.did,S.dname,S.Val);

--Security & Schema    --Authentication
--Select into      --Top   
--Builtin Functions
--Ranking
--Merge
