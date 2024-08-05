--rollup , cube  , grouping sets,  pivot,  unpivot

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

select SalesmanName as Name,sum(quantity) as Qty
from sales
group by SalesmanName
union
select 'Total Values',sum(quantity)
from sales





Select isnull(Name,'Total'),Qty
from ( 
select SalesmanName as Name,sum(quantity) as Qty
from sales
group by rollup(SalesmanName)
) as t




select SalesmanName as Name,sum(quantity) as Qty
from sales
group by rollup(SalesmanName)
		

select SalesmanName as Name,Count(quantity) as Qty
from sales
group by rollup(SalesmanName)
		

--order by ProductID,SalesmanName
select ProductID,sum(quantity) as "Quantities"
from sales
group by rollup(ProductID)




select ProductID,SalesmanName,sum(quantity) as "Quantities"
from sales
group by ProductID,SalesmanName



select ProductID,SalesmanName,sum(quantity) as "Quantities"
from sales
group by rollup(ProductID,SalesmanName)



select ProductID,SalesmanName,sum(quantity) as "Quantities"
from sales
group by ProductID,SalesmanName
union 
select sum(quantity),productid
from sales
group by productid
union 
select sum(quantity) from sales



select SalesmanName,ProductID,sum(quantity) as "Quantities"
from sales
group by rollup(SalesmanName,ProductID)



select ProductID,SalesmanName,sum(quantity) as "Quantities"
from sales
group by Cube(ProductID,SalesmanName)

select ProductID,SalesmanName,sum(quantity) as "Quantities"
from sales
group by Cube(ProductID,SalesmanName,branschid)


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


----Pivot and Unpivot OLAP
--if u have the result of the previouse query
select ProductID,SalesmanName,sum(quantity) as "Quantities"
from sales
group by SalesmanName,ProductID


SELECT * 
FROM sales 
PIVOT (SUM(Quantity) FOR SalesmanName IN ([Ahmed],[Khalid],[ali])) as PVT


select * from newtable


SELECT *
FROM sales 
PIVOT (SUM(Quantity) FOR SalesmanName IN ([Ahmed],[Khalid])) as PVT

SELECT *
FROM sales 
PIVOT (SUM(Quantity) FOR productid IN ([1],[2],[3],[4])) as PVT

Select * from newpivot


select * from newtable


--how to get the table
SELECT * FROM newtable 
UNPIVOT (qty FOR salesname IN ([Ahmed],[Khalid],[Ali])) UNPVT



execute('SELECT * FROM sales 
PIVOT(SUM(Quantity) FOR SalesmanName IN (p1))')

PVT


alter proc p1
as
select distinct(salesmanname)
from sales

p1

