using System;
namespace FirstBlazorApp.Pages.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
         public string FirstName { get; set; }
          public string LastName { get; set; }
           public string Email { get; set; }
            public DateTime DateOfBirth { get; set; }
            public Gender Gender { get; set; }
            public Department Department { get; set; }
            public String PhotoPath { get; set; }
    }
    public enum Gender {
        male, Female
    }
    }
