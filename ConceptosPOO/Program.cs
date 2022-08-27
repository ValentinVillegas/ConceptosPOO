// See https://aka.ms/new-console-template for more information
using ConceptosPOO;

Employee employee1 = new SalaryEmployee()
{
    Id = 1010,
    FirstName = "Sandra",
    LastName = "Morales",
    BirthDay = new Date(1990, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Salary = 1815.45M,
};

//Console.WriteLine(employee1);
//Console.WriteLine("\n");

Employee employee2 = new CommissionEmployee()
{
    Id = 2020,
    FirstName = "Patricia",
    LastName = "Gutierrez",
    BirthDay = new Date(1995, 5, 23),
    HiringDate = new Date(2022, 2, 5),
    IsActive = true,
    Sales = 3200000M,
    CommissionPercentaje = 0.03F,
};

//Console.WriteLine(employee2);
//Console.WriteLine("\n");

Employee employee3 = new HourlyEmployee()
{
    Id = 3030,
    FirstName = "Gonzalo",
    LastName = "Cardona",
    BirthDay = new Date(1985, 5, 23),
    HiringDate = new Date(2022, 2, 5),
    IsActive = true,
    Hours = 18,
    HourValue = 680,

};

//Console.WriteLine(employee3);
//Console.WriteLine("\n");

Employee employee4 = new BaseCommissionEmployee()
{
    Id = 4040,
    FirstName = "Jazmin",
    LastName = "Salazar",
    BirthDay = new Date(1997, 9, 20),
    HiringDate = new Date(2022, 4, 18),
    IsActive = true,
    CommissionPercentaje = 0.015F,
    Sales = 580000,
    Base = 4500,
};

//Console.WriteLine(employee4);

ICollection<Employee> employees = new List<Employee>() {
    employee1, employee2, employee3, employee4
};

/*
employees.Add(employee1);
employees.Add(employee2);
employees.Add(employee3);
employees.Add(employee4);
*/

decimal payroll = 0;

foreach (Employee emp in employees)
{
    Console.WriteLine(emp);
    payroll += emp.GetValueToPay();
}

Console.WriteLine("==================================================");
Console.WriteLine($"TOTAL........................: {$"{payroll:C2}",18}");
Console.WriteLine("\n\n\n");

Invoice invoice1 = new Invoice()
{
    Id = 1,
    Description = "Iphone 13 Pro Max",
    Price = 18000,
    Quantity = 6
};

Invoice invoice2 = new Invoice()
{
    Id = 2,
    Description = "Arrachera wabe",
    Price = 850,
    Quantity = 17.5F
};

Console.WriteLine(invoice1);
Console.WriteLine(invoice2);