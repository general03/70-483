using System;
using System.Collections.Generic;

namespace ConstraintsOnTypeParameters
{
    public static class ClassTypeParameter
    {
        public static void Main()
        {
            Company<Employee> myList = new Company<Employee>();
            
            Employee employee1 = new Employee("David", 29);
            myList.AddEmployee(employee1);

            Employee employee2 = new Employee("John", 23);
            myList.AddEmployee(employee2);

            Employee employee3 = new Employee("Saul", 36);
            myList.AddEmployee(employee3);
            
            myList.getAllEmployees();

            Console.ReadKey();
        }
    }

    public class Employee
    {
        private string name;
        private int age;

        public Employee(string s, int a)
        {
            name = s;
            age = a;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }

    public class Company<T> where T : Employee
    {
        private List<Employee> allEmployees = new List<Employee>();

        public Company() 
        {
            Console.WriteLine("Constructor Company");
        }

        public void getAllEmployees()
        {
            foreach(Employee anEmployee in allEmployees)
            {
                Console.WriteLine(String.Concat(anEmployee.Name, " => ", anEmployee.Age));
            }
        }

        public void AddEmployee(T t)
        {
            allEmployees.Add(t);
        }
    }
}
