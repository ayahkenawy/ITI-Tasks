use Company_SD
--1.	Display the Department id, name and id and the name of its manager.
select Dnum , Dname , SSN , Fname +' '+Lname as name from Departments inner join Employee on Employee.SSN = Departments.MGRSSN
--2.	Display the name of the departments and the name of the projects under its control.
select Pname, Dname from Project inner join Departments on Departments.Dnum = Project.Dnum
--3.	Display the full data about all the dependence associated with the name of the employee they depend on him/her.
select Dependent.*, Fname +' '+Lname as name from Dependent left outer join Employee on Employee.SSN = Dependent.ESSN
--4.	Display the Id, name and location of the projects in Cairo or Alex city.
select Pnumber , Pname , Plocation from Project where city in ('Cairo','Alex')
--5.	Display the Projects full data of the projects with a name starts with "a" letter.
select * from Project where Pname like 'a%'
--6.	display all the employees in department 30 whose salary from 1000 to 2000 LE monthly
select * from Employee where Dno=30 and Salary between 1000 and 2000
--7.	Retrieve the names of all employees in department 10 who works more than or equal10 hours per week on "AL Rabwah" project.
select Fname +' '+Lname as name from Employee inner join Works_for on Employee.SSN = Works_for.ESSn and Hours >=10 inner join Project on
Project.Pnumber = Works_for.Pno and Project.Pname ='AL Rabwah'
--8.	Find the names of the employees who directly supervised with Kamel Mohamed.
SELECT a.Fname +' '+a.Lname as name FROM Employee a , Employee b
where a.Superssn = b.SSN
AND b.Fname +' '+b.Lname ='Kamel Mohamed'
--9.	Retrieve the names of all employees and the names of the projects they are working on, sorted by the project name.
select Fname +' '+Lname as name , Pname from Employee inner join Works_for on Employee.SSN = Works_for.ESSn inner join Project on
Project.Pnumber = Works_for.Pno order by Pname
--10.	For each project located in Cairo City , find the project number, the controlling department name ,the department manager last name ,address and birthdate.
select Pnumber, Dname , Lname, Address,Bdate from Project inner join Departments on Project.Dnum = Departments.Dnum and city = 'Cairo' 
inner join Employee on Employee.SSN = Departments.MGRSSN
--11.	Display All Data of the managers
SELECT distinct a.* FROM Employee a , Departments b
where a.SSN = b.MGRSSN
--Supervisor
--SELECT distinct b.* FROM Employee a , Employee b
--where a.Superssn = b.SSN
--12.	Display All Employees data and the data of their dependents even if they have no dependents
select Employee.* ,Dependent.* from Dependent right outer join Employee on Employee.SSN = Dependent.ESSN
--13.	Insert your personal data to the employee table as a new employee in department number 30, SSN = 102672, Superssn = 112233, salary=3000.
insert into Employee  
([Fname],[Lname],[SSN],[Bdate],[Address],[Sex],[Salary],[Superssn],[Dno])
VALUES('Aya','Kenawy',102672,'04-04-1990','PTS','F',3000,112233,30)
--14.	Insert another employee with personal data your friend as new employee in department number 30, SSN = 102660, 
--but don’t enter any value for salary or supervisor number to him.
insert into Employee  
([Fname],[Lname],[SSN],[Bdate],[Address],[Sex],[Dno])
VALUES('Omnya','Ahmed',102660,'03-05-1992','PTS','F',30)
--15.Upgrade your salary by 20 % of its last value.
update Employee
set salary += Salary*.2
where SSN =102672

