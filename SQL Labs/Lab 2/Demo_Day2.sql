use Company_SD

use ITI

--Create Table emp

/*
xxxxxx
xxx
*/


--DDL
--create table

create table emp
(
Eid int primary key,
Ename varchar(5),
salary int
)

create table emp
(
Eid int primary key identity,
Ename varchar(5),
salary int not null ,
addres varchar(50) default 'cairo'
)


alter table emp
add did int


create table dept
(
did int primary key,
deptname varchar(50)
)

drop table emp

--DML
--insert
--simple insert
insert into student(st_id,st_fname)
values(400,'khalid')


insert into student(st_id,st_fname,st_lname,st_age,st_super,dept_id)
values(400,'khalid')


insert into student
values(400,'khalid','ali','cairo',22,10,1)


--row constructor
insert into student
values(402,'khalid1','ali','cairo',22,10,1),
	  (403,'khalid3','ali','cairo',22,10,1),
	  (404,'khalid5','ali','cairo',22,10,1)


--update
update student
set st_age=25

update student
set st_age=25
where st_id=3

update student
set st_age=25
where st_age=24

update student
set st_age=25,st_address='alex'
where st_id=5 


delete from student
where st_id=400


truncate table student

--DQL
--select 
select *
from student

select st_id,st_fname
from student

select st_fname + ' '+ ST_LNAME as [full name]
from student


SELECT *
from student
where st_age>25


SELECT *
from student
where st_age>25 and st_age <30




SELECT *
from student
where st_age between 26 and 29



select * from student
where st_address ='alex'

select * from student
where st_address ='alex' or st_address='cairo'

select * from student
where st_address in('cairo','alex','mansoura')


select * from student
where st_address not in('cairo','alex','mansoura')

-- _ one char, % set of char
select *
from student
where st_fname like 'a%'

select *
from student
where st_fname like '%a'


select *
from student
where st_fname like '%a%'


select *
from student
where st_fname like 'a__'


select *
from student
where st_fname like '[_]%'

select *
from student
where st_fname like '[_]__'


select st_fname
from student

select distinct(st_fname)
from student


select *
from student
where st_fname is not null


select *
from student
where st_fname is  null



select *
from student
order by st_fname,st_lname



select *
from student
order by 1






