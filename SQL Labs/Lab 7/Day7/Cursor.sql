-- is a mechanism that processes the result row-by-row 

declare s_cur cursor
	for select st_id,st_fname from student
	for read only  --update


declare @id int
declare @name nvarchar(50)
open s_cur 
fetch s_cur into @id,@name
begin
	While @@fetch_status=0  --returns 0 success -- 1 failed  --2 no more rows to fetch
	begin
		select @id,@name 
		fetch s_cur into @id,@name
	end
end
close s_cur
deallocate s_cur
	
declare t_cur cursor
	for select t_id,t_name,sal from teacher
	for update

declare @id int
declare @name nvarchar(50)
declare @s int
open t_cur 
fetch t_cur into @id,@name,@s
begin
	While @@fetch_status=0
	begin
		if @s<1000
			begin
				update teacher	set sal= @s*1.10 
				where current of t_cur 
		fetch t_cur into @id,@name,@s
			end
	end
end
close t_cur
deallocate t_cur



// 	    set cursor rows 5 for biz_book 


