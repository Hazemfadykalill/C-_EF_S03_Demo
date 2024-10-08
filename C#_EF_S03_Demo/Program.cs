﻿using C__EF_S03_Demo.Contexts;
using C__EF_S03_Demo.Entities;
using Castle.Components.DictionaryAdapter.Xml;
using Microsoft.EntityFrameworkCore;

namespace C__EF_S03_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using AppDbContext Context=new AppDbContext();

            #region General
            //var Result=Context.Employees.FirstOrDefault(E=>E.Id==1);
            //Console.WriteLine(Result?.Id??0);                 // 1   
            //Console.WriteLine(Result?.Name??"Na");            // Ahmed Ali
            //Console.WriteLine(Result?.Salary??0);             // 12000
            //Console.WriteLine(Result?.Department?.Name??"Na");// Na


            //var Result=Context.Departments.FirstOrDefault(D=>D.Id==13);

            //Console.WriteLine(Result?.Id ?? 0);                 // 13   
            //Console.WriteLine(Result?.Name ?? "Na");            // HR

            //foreach (var item in Result.Employees)
            //{
            //    Console.WriteLine(item.Name??"Na"); //Error Because EF core Not Loading Navigation Property
            //} 
            #endregion

            //To Load Navigational Property

            #region Navigation Property
            //To Load Navigation Property Are Using Three Ways
            #region 1 . Explicit Loading 
            //This Way Implement By Two Step
            //in this way by using two method
            // 1 . Reference
            //var Result = Context.Employees.FirstOrDefault(E => E.Id == 1); // first step
            ////Context.Entry(Result).Reference(E=>E.Department).Load();     // second step
            ////Or
            //Context.Entry(Result).Reference("Department").Load();

            //Console.WriteLine(Result?.Id ?? 0);                 // 1   
            //Console.WriteLine(Result?.Name ?? "Na");            // Ahmed Ali
            //Console.WriteLine(Result?.Salary ?? 0);             // 12000
            //Console.WriteLine(Result?.Department?.Name ?? "Na");// HR


            // 2 . Collection


            //var Result = Context.Departments.FirstOrDefault(D => D.Id == 13);
            //Context.Entry(Result).Collection(D=>D.Employees).Load();
            //Or
            //Context.Entry(Result).Collection("Employees").Load();


            //Console.WriteLine(Result?.Id ?? 0);                 // 13   
            //Console.WriteLine(Result?.Name ?? "Na");            // HR

            //foreach (var item in Result.Employees)
            //{
            //    Console.WriteLine(item.Name ?? "Na"); //Ahmed Ali
            //}


            #endregion

            #region 2 . Eager Loading 

            //This Way Implement By One Step
            //in this way by using One method
            // 1 . Include()


            //var Result = Context.Employees.Include(E=>E.Department).FirstOrDefault(E => E.Id == 1); // first step
            //Or
            //var Result = Context.Employees.Include("Department").FirstOrDefault(E => E.Id == 1); // first step




            //Console.WriteLine(Result?.Id ?? 0);                 // 1   
            //Console.WriteLine(Result?.Name ?? "Na");            // Ahmed Ali
            //Console.WriteLine(Result?.Salary ?? 0);             // 12000
            //Console.WriteLine(Result?.Department?.Name ?? "Na");// HR

            //====================================================================================


            //var Result = Context.Departments.Include(D=>D.Employees).FirstOrDefault(D => D.Id == 13);

            //Or
            //var Result = Context.Departments.Include("Employees").FirstOrDefault(D => D.Id == 13);



            //Console.WriteLine(Result?.Id ?? 0);                 // 13   
            //Console.WriteLine(Result?.Name ?? "Na");            // HR

            //foreach (var item in Result.Employees)
            //{
            //    Console.WriteLine(item.Name ?? "Na"); //Ahmed Ali
            //}

            #endregion

            #region 3 . Lazy Loading 
            // Steps To Achieve This Way
            // 1 . Install Package ==> Microsoft.EntityFrameworkCore.Proxies
            // 2 . Inside Method OnConfiguring use ==> optionsBuilder.UseLazyLoadingProxies();
            // 3 . Must All Classes Is Public
            // 4 . Make All Navigational Property Is Virtual


            //var Result = Context.Employees.FirstOrDefault(E => E.Id == 1);
            //Console.WriteLine(Result?.Id ?? 0);                 // 1
            //Console.WriteLine(Result?.Name ?? "Na");            // Ahmed Ali
            //Console.WriteLine(Result?.Salary ?? 0);             // 12000
            //Console.WriteLine(Result?.Department?.Name ?? "Na");// HR


            //var Result = Context.Departments.FirstOrDefault(D => D.Id == 13);

            //Console.WriteLine(Result?.Id ?? 0);                 // 13   
            //Console.WriteLine(Result?.Name ?? "Na");            // HR

            //foreach (var item in Result.Employees)
            //{
            //    Console.WriteLine(item.Name ?? "Na"); //Ahmed Ali
            //}


            #endregion

            #region Join Operator
            #region Fluent Syntax &Query Synatax
            //var Result = Context.Employees.Join(Context.Departments,E=>E.Dept_Id,D=>D.Id,(E,D)=>new
            //{
            //    EmpId = E.Id,
            //    EmpName = E.Name,
            //    DeptId = D.Id,
            //    DeptName = D.Name,
            //});
            //// Query Syntax
            //Result = from E in Context.Employees
            //         join D in Context.Departments
            //         on E.Dept_Id equals D.Id

            //         select new
            //         {
            //             EmpId = E.Id,
            //             EmpName = E.Name,
            //             DeptId = D.Id,
            //             DeptName = D.Name,
            //         };

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //    // { EmpId = 1, EmpName = Ahmed Ali, DeptId = 13, DeptName = HR }
            //    // { EmpId = 4, EmpName = Mohamed Ali, DeptId = 10, DeptName = CSS }
            //    // { EmpId = 7, EmpName = Yassin, DeptId = 7, DeptName = IT }
            //    // { EmpId = 10, EmpName = Fady Ali, DeptId = 4, DeptName = HTML }
            //    // { EmpId = 13, EmpName = Monaa, DeptId = 1, DeptName = DS }
            //} 
            #endregion
            #endregion




            #endregion




        }
    }
}
