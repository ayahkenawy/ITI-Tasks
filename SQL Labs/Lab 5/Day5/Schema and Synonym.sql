create schema x


alter schema x transfer student


select * from x.student



/*
SQL Server 2005 introduces the concept of a synonym: 
a single-part name that can replace a two-, three-, or 
four-part name in many SQL statements. Using synonyms 
lets you cut down on typing 
*/
create synonym mySyn 
for HumanResources.Employee
				-----------------------
select * from mySyn
				-----------------------
use AdventureWorks
--to create an alias for the table name
create synonym p
for Production.ProductListPriceHistory
