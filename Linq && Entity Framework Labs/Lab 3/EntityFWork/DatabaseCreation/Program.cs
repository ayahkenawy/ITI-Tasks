using DatabaseCreation.Context;
using DatabaseCreation.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

CompanyContext Db=new CompanyContext();
//Db.Database.EnsureDeleted();
//Db.Database.EnsureCreated();
//Database Creation Strategy
//migration
//Db.Add(new Department(){Name = "FullStack"}); 
//Db.SaveChanges();

#region Local Storage

//Console.WriteLine(Db.Employees.Local.Count);
//Console.WriteLine(Db.Employees.Count());
//Console.WriteLine(Db.Employees.Local.Count);
//var Q1 = Db.Employees.Where(ww => ww.DepartmentId == 1).ToList();
//Console.WriteLine(Db.Employees.Local.Count);

//foreach (var item in Q1)
//{
//    Console.WriteLine(item);
//}

//var Q2 = Db.Employees.Where(ww => ww.DepartmentId == 3).ToList();
//Console.WriteLine(Db.Employees.Local.Count);
////var Q3 = Db.Employees.Where(ww => ww.DepartmentId == 1&&ww.Name.ToLower().Contains("k")).ToList(); //bad 
//var Q4 = Db.Employees.Local.Where(ww => ww.DepartmentId == 1 && ww.Name.ToLower().Contains("k")).ToList();
//foreach (var item in Q4)
//{
//    Console.WriteLine(item);
//}

#endregion

#region Lazy Loading & Eager Loading $ Explicit Loading

//var Q1=Db.Employees.FirstOrDefault(ww => ww.DepartmentId == 1);
//Console.WriteLine(Q1);
//var Q2 = Db.Employees.Include(ww=>ww.Department).FirstOrDefault(ww => ww.DepartmentId == 1);
//Console.WriteLine(Q2);
//Db.Employees.Load(); // to Local Storage //Bad Practice

#endregion

#region Find

//By Primary Key
////var Q1 = Db.Employees.Find(1);
////Console.WriteLine(Q1);

#endregion

#region SQL Statment
//Error Without List Connection not Closed
var Q1 = Db.Employees.FromSqlRaw("select * from Employees")
    .OrderBy(ww => ww.Id).ToList();
foreach (var item in Q1)
{
    Console.WriteLine(item);
}
var Q4 = Db.Employees.FromSqlInterpolated($"select * from Employees where DepartmentId ={1} ")
    .OrderBy(ww => ww.Id).ToList();
foreach (var item in Q1)
{
    Console.WriteLine(item);
}
//Execute Stored 
var Q3 = Db.Employees.FromSqlRaw("select * from Employees where DepartmentId =@id", new SqlParameter("@id",1))
    .OrderBy(ww => ww.Id).ToList();
foreach (var item in Q3)
{
    Console.WriteLine(item);
}

//DML
//var Q4 = Db.Database.ExecuteSqlRaw()
#endregion