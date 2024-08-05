--Clustered ----- PK
create clustered index myindex
on student(st_fname)

create nonclustered index myindex
on student(st_fname)

create nonclustered index myindex2
on student(st_Lname)

Primary key   --> Constraint --> Clustered Index
Unique        --> Constraint --> nonclutered index

create unique index i3
on student(st_age) 

create table test
(
X int Primary key,
Y int Unique,
Z int unique,
M varchar(20)
)

select * from Student where st_age=20

Declare C1 Cursor
for select st_id,st_fname
	from Student
	where st_address='cairo'
for read only     --update
declare @id int,@n varchar(20)
open C1
Fetch C1 into @id,@n
while @@FETCH_STATUS=0
	begin
		select @id,@n
		Fetch C1 into @id,@n
	end
close C1
Deallocate C1

--One Cell  [ahmed,ali,amr,fady......................]
declare c1 cursor
for select distinct St_Fname
	from Student
	where st_fname is not null
for read only

declare @name varchar(20),@all_names varchar(300)=''
open c1
fetch c1 into @name
while @@FETCH_STATUS=0
	begin
		set @all_names=concat(@all_names,',',@name)
		fetch c1 into @name   --Next Row 
	end
select @all_names
close c1
deallocate C1


declare c1 Cursor
for select salary
	from Instructor
for update
declare @sal int
open c1
fetch c1 into @sal
while @@fetch_status=0
	begin
		if @sal>=3000
			update instructor
				set salary=@sal*1.20
			where current of c1
		else
			update Instructor
				set Salary=@sal*1.10
			where current of c1
		fetch c1 into @sal
	end
close c1
deallocate c1


Declare C1 Cursor
for select st_fname
	from Student
for read only
declare @name varchar(20),@counter int=0 
open C1
Fetch C1 into @name
while @@FETCH_STATUS=0
	begin
		,,,,,,,,,,,,
		,,,,,,,,,,,,
	end
select @counter
close C1
Deallocate C1
------------------------------

create view Vstud
as
	select *
	from student

select * from Vstud

alter View Vcairo
as
	select st_id,st_fname,st_address
	from Student
	where St_Address='cairo'

select * from Vcairo

alter View Valex(Sid,Sname,Sadd)
as
	select st_id,st_fname,st_address
	from Student
	where St_Address='alex'

Select * from Valex

Select sname from Valex

alter schema HR transfer Valex

Select * from HR.Valex


create view VCairo_Alex
as
select * from Vcairo
union all
select * from HR.Valex


sp_helptext 'Vcairo'


create view Vjoin(Sid,Sname,Did,Dname)
as
select st_id,st_fname,D.dept_id,dept_name
from Student S inner join Department D
	on S.dept_id= d.dept_id


select sname,dname from Vjoin

create view Vgrades
as
select sname,dname,grade
from Vjoin V inner join Stud_Course SC
	on V.sid=SC.st_id

select * from Vgrades

--DML + view
-----------View One Table
alter View Vcairo
as
	select st_id,st_fname,st_address
	from Student
	where St_Address='cairo'

	insert into Vcairo
	values(77,'ahmed','cairo')

-----------View Multi Tables
create view Vjoin(Sid,Sname,Did,Dname)
as
select st_id,st_fname,D.dept_id,dept_name
from Student S inner join Department D
	on S.dept_id= d.dept_id

--XXXXXXXXXXXX Delete
--insert   Update
insert into Vjoin
values(1111,'ali',90,'HR')

insert into Vjoin(sid,sname)
values(1111,'ali')

-----------------------------
alter View Vcairo
as
	select st_id,st_fname,st_address
	from Student
	where St_Address='cairo'
	with check option


insert into Vcairo
values(9988,'ali','cairo')

insert into Vcairo
values(9989,'ali','mansoura')


create view Vsal
as
	select *
	from Instructor
	where salary>1000
	with check option
	
--Index
--Cursor
--View
--Pivot and Grouping
--ROLLUP   cUBE   GROUPING SET      PIVOT   UNPIVOT

--rollup and cube

use test

create table sales
(
ProductID int,
SalesmanName varchar(10),
Quantity int
)
truncate table sales

insert into sales
values  (1,'ahmed',10),
		(1,'khalid',20),
		(1,'ali',45),
		(2,'ahmed',15),
		(2,'khalid',30),
		(2,'ali',20),
		(3,'ahmed',30),
		(4,'ali',80),
		(1,'ahmed',25),
		(1,'khalid',10),
		(1,'ali',100),
		(2,'ahmed',55),
		(2,'khalid',40),
		(2,'ali',70),
		(3,'ahmed',30),
		(4,'ali',90),
		(3,'khalid',30),
		(4,'khalid',90)
		
select ProductID,SalesmanName,quantity
from sales

select ProductID as X,sum(quantity) as "Quantities"
	from sales
	group by ProductID


select ProductID as X,sum(quantity) as "Quantities"
	from sales
	group by rollup(ProductID)

select SalesmanName as Name,sum(quantity) as Qty
	from sales
	group by rollup(SalesmanName)
		
--order by ProductID,SalesmanName
select SalesmanName,sum(quantity) as "Quantities"
from sales
group by rollup(SalesmanName)


select ProductID,SalesmanName,sum(quantity) as "Quantities"
from sales
group by ProductID,SalesmanName

select ProductID,SalesmanName,sum(quantity) as "Quantities"
from sales
group by rollup(ProductID,SalesmanName)

select ProductID,SalesmanName,sum(quantity) as "Quantities"
from sales
group by rollup(SalesmanName,ProductID)


select ProductID,SalesmanName,sum(quantity) as "Quantities"
from sales
group by Cube(SalesmanName,ProductID)


select isnull(Name,'my total'),qty
from (
	select SalesmanName as Name,sum(quantity) as Qty
	from sales
	group by rollup(SalesmanName)
	) as newta
	ble

select isnull(x,0),Quantities
from (
	select ProductID as X,sum(quantity) as "Quantities"
	from sales
	group by rollup(ProductID)
	) as newtable


select SalesmanName,ProductID,sum(quantity) as "Quantities"
from sales
group by rollup(SalesmanName,ProductID)

select ProductID,SalesmanName,sum(quantity) as "Quantities"
from sales
group by cube(ProductID,SalesmanName)

--order by ProductID,SalesmanName


select ProductID,SalesmanName,sum(quantity) as "Quantities"
from sales
group by cube(ProductID,SalesmanName)
--order by ProductID,SalesmanName

--grouping sets
select ProductID,SalesmanName,sum(quantity) as "Quantities"
from sales
group by grouping sets(ProductID,SalesmanName)
order by SalesmanName

----Pivot and Unpivot OLAP
--if u have the result of the previouse query
select ProductID,SalesmanName,sum(quantity) as "Quantities"
from sales
group by SalesmanName,ProductID

SELECT * 
FROM sales 
PIVOT (SUM(Quantity) FOR SalesmanName IN ([Ahmed],[Khalid],[ali])) as Newtable


select * from newtable


--how to get the table
SELECT * FROM newtable 
UNPIVOT (qty FOR salesname IN ([Ahmed],[Khalid],[Ali])) UNPVT



execute('SELECT * FROM sales 
PIVOT(SUM(Quantity) FOR SalesmanName IN (p1))')
	 