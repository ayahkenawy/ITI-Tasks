use Center
create table Instructor(
instuctorID int identity primary key ,
hiredate date default getdate(),
address nvarchar(100),
salary decimal (18,2) default 3000,
overtime decimal (18,2) unique,
bdate date ,
lname nvarchar(20),
fname nvarchar(20),
age as (year(getdate())-year(bdate)),
netsalary as(isnull(salary,0)+isnull(overtime,0)) persisted,
constraint addressCheck check(address in('alex','cairo')),
constraint salaryCheck check(salary between 1000 and 5000),
)

create table Course(
courseID int identity primary key ,
name nvarchar(50),
duration int unique
)

create table Lab (
labID int identity ,
location nvarchar(100),
capacity int ,
courseID int  ,
constraint capacityCheck check(capacity > 20),
constraint primarykeys primary key(labID,courseID),
constraint fk_courseLab foreign key (courseID) references Course(courseID) 
on delete  cascade on update cascade
)
create table Teach (
instuctorID int ,
courseID int,
constraint fk_instuctorTeach foreign key (instuctorID) references Instructor(instuctorID) 
on delete  cascade on update cascade,
constraint fk_courseTeach foreign key (courseID) references Course(courseID) 
on delete  cascade on update cascade,
constraint primarykeysTeach primary key(instuctorID,courseID),
)
