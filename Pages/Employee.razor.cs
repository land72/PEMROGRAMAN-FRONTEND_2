using System;
using System.Collections.Generic
using FirstBlazorApp.Models;

namespace FirstBlazorApp.Pages


{
    public partial class EmployeePage
    {
     public IEquatable<Employee> Employees { get; set; }


    protected override Task OnInitializedAsync()
    {

     LoadEmployees();
     return base.OnInitializedAsync();


    }

   private void LoadEmployees(){
       e1 = new Employee{
           EmployeeId=1,
           FirstName="Orlando",
           LastName="Sinaga",
           Email="Orlandobps27@gmail.com",
           DateOfBirth = new dateTime(2001,03,27),
           Gender = Gender.Male,
           Department = new Department{DepartmentId=1, DepartmentName="IT"},
           PhotoPath = "Image/Orlando.jpg"

       };
       Employee e2 = new Employee{
           EmployeeId=2,
           FirstName="Putri",
           LastName="Siagian",
           Email="Putri27@gmail.com",
           DateOfBirth = new dateTime(2003,02,27),
           Gender = Gender.Male,
           Department = new Department{DepartmentId=1, DepartmentName="IT"},
           PhotoPath = "Image/Putri.jpg"
    };
       Employee e3 = new Employee{
           EmployeeId=3,
           FirstName="bagas",
           LastName="Siagian",
           Email="bagas27@gmail.com",
           DateOfBirth = new dateTime(2002,02,23),
           Gender = Gender.Male,
           Department = new Department{DepartmentId=1, DepartmentName="IT"},
           PhotoPath = "Image/bagas.jpg"
};
          Employees = new List<Employee>{e1,e2,e3};
   }

    }
}