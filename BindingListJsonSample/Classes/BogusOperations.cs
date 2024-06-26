﻿using BindingListJsonSample.Models;
using Bogus;
using Bogus.DataSets;

namespace BindingListJsonSample.Classes;

/// <summary>
/// Responsible for creating a list of customers
/// </summary>
public class BogusOperations
{
    /// <summary>
    /// Create list of customers
    /// </summary>
    /// <param name="count">Count of customers to create, if not passed 10 will be generated</param>
    /// <returns>List of Customers</returns>
    public static List<Customer> CustomersList(int count = 10)
    {

        Randomizer.Seed = new Random(334);

        int identifier = 1;

        var faker = new Faker<Customer>()
                .CustomInstantiator(f => new Customer(identifier++))  
                .RuleFor(u => u.Gender, f => f.PickRandom<Gender>())
                .RuleFor(c => c.FirstName, (f, c) => f.Name.FirstName((Name.Gender?)c.Gender))
                .RuleFor(c => c.LastName, f => f.Name.LastName())
                .RuleFor(c => c.BirthDay, f => f.Date.BetweenDateOnly(new DateOnly(1950, 1, 1), new DateOnly(2010, 1, 1)))
                .RuleFor(e => e.Email, (f, e) => f.Internet.Email(e.FirstName, e.LastName));

        return faker.Generate(count);

    }
}