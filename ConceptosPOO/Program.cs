﻿// See https://aka.ms/new-console-template for more information
using ConceptosPOO;

Employee employee1 = new SalaryEmployee()
{
    Id =1010,
    FirstName = "Sandra",
    LastName = "Morales",
    BirthDay = new Date(1990,5,23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Salary = 1815.45M,
};

Console.WriteLine(employee1);