////Try All What we discuss
////1- model Creation EF Convension,Data annotation ,fluent API [onmodelcreating]
////2- 1->m relationship
////3- 1->1 relationship   optional FK put in Mandatory entity
////4- m->m Relationship   2 Ways
////5- Composite PK   => OnModelCreating
//6- DB creation Strategies  EnsureCreated,EnsureDeleted,Migration
//7- local storage
//8- find(PK)
//9- Sql Statement

using EntityFWorkD3.Context;
using EntityFWorkD3.Models;

ITIContext Db = new ITIContext();
Db.Database.EnsureDeleted();
Db.Database.EnsureCreated();
Department d1 = new Department() { DeptName = "FullStack" };
Db.Add(d1);
Student st = new Student()
{
    Name = "aya",
    Age = 30,
    Address = "PTS",
    DOB = DateTime.Now,
    Email = "aya",
    Price = 123,
    DeptId = 1
};
Db.Add(st);
Instuctor ins = new Instuctor()
{
    Name = "Ahmed"
    ,
    Age = 35,
    DeptId = 1
    ,
    Email = "Ahmed",
    Salary = 1234
};
Db.Add(ins);
Db.SaveChanges();