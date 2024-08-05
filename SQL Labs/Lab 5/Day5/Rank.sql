
--6)ranking functions
--used with order by
select st_fname,st_age,ROW_NUMBER() over(order by st_age) as "order by age"
from student

select st_fname,st_age,rank() over(order by st_age) as "rank"
from student

select st_fname,ST_AGE
	   ,ROW_NUMBER() over(order by st_age) as "order by age"
	   ,rank() over(order by st_age) as "rank"  	
       ,DENSE_RANK() over(order by st_age) as "exact ranking"  
															--   ,NTILE(3) over(order by st_age) as group3          --divided into 3 groups
    from student

select st_fname,st_address,ST_AGE
	   ,ROW_NUMBER() over(ORDER BY st_age DESC) as "order by age"
FROM Student

select st_fname,st_address,ST_AGE
	   ,ROW_NUMBER() over(ORDER BY st_address,st_age DESC) as "order by age"
FROM Student

select st_fname,st_address,ST_AGE
	   ,ROW_NUMBER() over(PARTITION BY st_address ORDER BY st_age DESC) as "order by age"
FROM Student

 SELECT *, ROW_NUMBER() OVER(PARTITION BY dept_id ORDER BY st_age DESC) AS rk
      FROM student
      where st_age is not null
--Top N with group
--Top 2 ages by city (no ties)
--select one course for each instructor

select Ins_Id,Ins_Name,Crs_Id

from (
select i.Ins_Id,i.Ins_Name,Crs_Id,ROW_NUMBER() OVER(PARTITION BY i.Ins_Id ORDER BY Crs_ID DESC) AS rk

from dbo.Instructor i,dbo.Ins_Course ic

where i.Ins_Id=ic.Ins_Id

)as newtable

where rk=1


SELECT *
FROM (
	  SELECT *, ROW_NUMBER() OVER(PARTITION BY dept_id ORDER BY st_age desc) AS rk
      FROM student
      where  dept_id is not null 
      ) 
      AS L
WHERE rk<=2;


SELECT *
FROM (
	  SELECT *, NTILE(3)  OVER(ORDER BY st_age DESC) AS gr
      FROM student
      ) 
      AS L
WHERE gr = 1;
