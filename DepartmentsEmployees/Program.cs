using DepartmentsEmployees.Data;
using DepartmentsEmployees.Models;
using System;
using System.Collections.Generic;

namespace DepartmentsEmployees
{
    class Program
    {
        static void Main(string[] args)
        {
            //DepartmentRepository departmentRepo = new DepartmentRepository();

            //Console.WriteLine("Getting All Departments:");
            //Console.WriteLine();

            //List<Department> allDepartments = departmentRepo.GetAllDepartments();

            //foreach (Department dept in allDepartments)
            //{
            //    Console.WriteLine($"{dept.Id} {dept.DeptName}");
            //}

            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Getting Department with Id 1");

            //Department singleDepartment = departmentRepo.GetDepartmentById(1);

            //Console.WriteLine($"{singleDepartment.Id} {singleDepartment.DeptName}");

            //Department legalDept = new Department
            //{
            //    DeptName = "Legal"
            //};

            //departmentRepo.AddDepartment(legalDept);

            //departmentRepo.UpdateDepartment(1, new Department() { DeptName = "New Department" });

            //Console.WriteLine("Here's your updated department:");
            //Console.WriteLine(departmentRepo.GetDepartmentById(1).DeptName);

            //Console.WriteLine("-------------------------------");
            //Console.WriteLine("Added the new Legal Department!");

            //departmentRepo.DeleteDepartment(7);

            //Console.WriteLine("Getting All Departments:");
            //Console.WriteLine();

            //List<Department> newDeps = departmentRepo.GetAllDepartments();

            //foreach (Department dept in newDeps)
            //{
            //    Console.WriteLine($"{dept.Id} {dept.DeptName}");
            //}

            EmployeeRepository employeeRepo = new EmployeeRepository();

            //Employee Jordan = new Employee
            //{
            //    FirstName = "Jordan",
            //    LastName = "Castelloe",
            //    DepartmentId = 1
            //};

            //Employee Joe = new Employee
            //{
            //    FirstName = "Joe",
            //    LastName = "Smith",
            //    DepartmentId = 1
            //};

            //employeeRepo.AddEmployee(Jordan);
            //employeeRepo.AddEmployee(Joe);

            //employeeRepo.UpdateEmployee(4, new Employee { FirstName = "Jordan", LastName = "Castelloe", DepartmentId = 2 });

            //employeeRepo.DeleteEmployee(5);

            Console.WriteLine("Getting All Employees:");
            Console.WriteLine();

            List<Employee> allEmployees = employeeRepo.GetAllEmployees();

            foreach (Employee emp in allEmployees)
            {
                Console.WriteLine($"{emp.Id} {emp.FirstName} {emp.LastName} {emp.DepartmentId} {emp.Department}");
            }

            //Employee employee1 = employeeRepo.GetEmployeeById(1);

            //Console.WriteLine($"{employee1.Department.DeptName}");

            Console.WriteLine();
            Console.WriteLine("Getting All Employees w/ Department:");
            Console.WriteLine();

            List<Employee> allEmployeesWithDept = employeeRepo.GetAllEmployeesWithDepartment();

            foreach (Employee emp in allEmployeesWithDept)
            {
                Console.WriteLine($"{emp.Id} {emp.FirstName} {emp.LastName} {emp.Department.DeptName}");
            }


        }
    }
}
