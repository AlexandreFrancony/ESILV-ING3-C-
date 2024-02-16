using System;
using System.Collections.Generic;

abstract class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
}

class Employee : Person
{
    public int EmployeeId { get; set; }
    public decimal Salary { get; set; }
}

class Provider : Person
{
    public string CompanyName { get; set; }
    public string ExpertiseDomain { get; set; }
}

class Enterprise
{
    public string Name { get; set; }
    public string Headquarters { get; set; }
    public List<Employee> Employees { get; set; }
    public List<Provider> Providers { get; set; }

    public Enterprise()
    {
        Employees = new List<Employee>();
        Providers = new List<Provider>();
    }

    public void HireEmployee(Employee employee)
    {
        Console.WriteLine("Enter the following details:");
        Console.Write("Last Name: ");
        string lastName = Console.ReadLine();
        Console.Write("First Name: ");
        string firstName = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.Write("Address: ");
        string address = Console.ReadLine();
        Console.Write("Employee ID: ");
        int employeeId = int.Parse(Console.ReadLine());
        Console.Write("Salary: ");
        decimal salary = decimal.Parse(Console.ReadLine());

        string line = $"{lastName};{firstName};{email};{address};{employeeId};{salary}";
        System.IO.File.AppendAllText("data/Salarie.csv", line);
    }

    public void FireEmployee(Employee employee)
    {
        string[] lines = System.IO.File.ReadAllLines("data/Salarie.csv");
        List<string> updatedLines = new List<string>();

        foreach (string line in lines)
        {
            string[] employeeData = line.Split(';');
            int employeeId = int.Parse(employeeData[4]);

            if (employeeId != employee.EmployeeId)
            {
                updatedLines.Add(line);
            }
        }

        System.IO.File.WriteAllLines("data/Salarie.csv", updatedLines);
    }

    public void ModifyEmployeeEmail(Employee employee, string newEmail)
    {
        string[] lines = System.IO.File.ReadAllLines("data/Salarie.csv");
        List<string> updatedLines = new List<string>();

        foreach (string line in lines)
        {
            string[] employeeData = line.Split(';');
            int employeeId = int.Parse(employeeData[4]);

            if (employeeId == employee.EmployeeId)
            {
                employeeData[2] = newEmail;
                line = string.Join(";", employeeData);
            }

            updatedLines.Add(line);
        }

        System.IO.File.WriteAllLines("data/Salarie.csv", updatedLines);
        
    }

    public void ModifyEmployeeSalary(Employee employee, decimal newSalary)
    {
        string[] lines = System.IO.File.ReadAllLines("data/Salarie.csv");
        List<string> updatedLines = new List<string>();

        foreach (string line in lines)
        {
            string[] employeeData = line.Split(';');
            int employeeId = int.Parse(employeeData[4]);

            if (employeeId == employee.EmployeeId)
            {
                employeeData[5] = newSalary.ToString();
                line = string.Join(";", employeeData);
            }

            updatedLines.Add(line);
        }

        System.IO.File.WriteAllLines("data/Salarie.csv", updatedLines);
    }

    public void AdmitProvider(Provider provider)
    {
        Console.WriteLine("Enter the following details:");
        Console.Write("Last Name: ");
        string lastName = Console.ReadLine();
        Console.Write("First Name: ");
        string firstName = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.Write("Address: ");
        string address = Console.ReadLine();
        Console.Write("Company Name: ");
        string companyName = Console.ReadLine();
        Console.Write("Expertise Domain: ");
        string expertiseDomain = Console.ReadLine();

        string line = $"{lastName};{firstName};{email};{address};{companyName};{expertiseDomain}";
        System.IO.File.AppendAllText("data/Fournisseur.csv", line);
    }

    public void ModifyProviderEmail(Provider provider, string newEmail)
    {
        string[] lines = System.IO.File.ReadAllLines("data/Fournisseur.csv");
        List<string> updatedLines = new List<string>();

        foreach (string line in lines)
        {
            string[] providerData = line.Split(';');
            string companyName = providerData[4];

            if (companyName == provider.CompanyName)
            {
                providerData[2] = newEmail;
                line = string.Join(";", providerData);
            }

            updatedLines.Add(line);
        }

        System.IO.File.WriteAllLines("data/Fournisseur.csv", updatedLines);
    }

    public void ModifyProviderAddress(Provider provider, string newAddress)
    {
        string[] lines = System.IO.File.ReadAllLines("data/Fournisseur.csv");
        List<string> updatedLines = new List<string>();

        foreach (string line in lines)
        {
            string[] providerData = line.Split(';');
            string companyName = providerData[4];

            if (companyName == provider.CompanyName)
            {
                providerData[3] = newAddress;
                line = string.Join(";", providerData);
            }

            updatedLines.Add(line);
        }

        System.IO.File.WriteAllLines("data/Fournisseur.csv", updatedLines);
    }

    public void RemoveProvider(Provider provider)
    {
        string[] lines = System.IO.File.ReadAllLines("data/Fournisseur.csv");
        List<string> updatedLines = new List<string>();

        foreach (string line in lines)
        {
            string[] providerData = line.Split(';');
            string companyName = providerData[4];

            if (companyName != provider.CompanyName)
            {
                updatedLines.Add(line);
            }
        }

        System.IO.File.WriteAllLines("data/Fournisseur.csv", updatedLines);
    }
}
