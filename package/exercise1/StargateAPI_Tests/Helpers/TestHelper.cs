using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using StargateAPI.Business.Data;

namespace StargateAPI_Tests.Helper;

[ExcludeFromCodeCoverage]
public class TestHelper
{
    public static StargateContext CreateInMemoryDbContext()
    {
        var options = new DbContextOptionsBuilder<StargateContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()) // Unique name for each test
            .Options;
        var context = new StargateContext(options);
        return context;
    }

    public static bool AddPersonRecords(StargateContext ctx)
    {
        bool hasCompleted = false;
        try
        {
            List<Person> people = new()
            {
                new() { Id = 1, Name = "Test Person01" },
                new() { Id = 2, Name = "Test Person02" },
                new() { Id = 3, Name = "Test Person03" }
            };

            ctx.People.AddRange(people);
            ctx.SaveChanges();

            hasCompleted = true;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Oops, problem with people: {ex.Message}");
        }
        return hasCompleted;
    }

    public static bool AddAstronautDutyRecords(StargateContext ctx)
    {
        bool hasCompleted = false;

        try
        {
            var hasPeople = TestHelper.AddPersonRecords(ctx);
            if (hasPeople)
            {
                List<AstronautDuty> duties = new()
                {
                    new() {
                        Id = 1,
                        PersonId = 1,
                        Person = ctx.People.Find(1) ?? new() { Name = "01" },
                        Rank = "Astronaut",
                        DutyTitle = "Commander",
                        DutyStartDate = DateTime.Now.AddMonths(-10),
                        DutyEndDate = null
                    },
                    new() {
                        Id = 2,
                        PersonId = 2,
                        Person = ctx.People.Find(2) ?? new() { Name = "02" },
                        Rank = "Astronaut",
                        DutyTitle = "Pilot",
                        DutyStartDate = DateTime.Now.AddMonths(-10),
                        DutyEndDate = null
                    },
                    new() {
                        Id = 3,
                        PersonId = 3,
                        Person = ctx.People.Find(3) ?? new() { Name = "03" },
                        Rank = "Astronaut Candidate",
                        DutyTitle = "Intern",
                        DutyStartDate = DateTime.Now.AddMonths(-6),
                        DutyEndDate = DateTime.Now.AddMonths(-3)
                    },
                    new() {
                        Id = 4,
                        PersonId = 3,
                        Person = ctx.People.Find(3) ?? new() { Name = "03" },
                        Rank = "Astronaut Candidate",
                        DutyTitle = "Crew Member",
                        DutyStartDate = DateTime.Now.AddMonths(-3),
                        DutyEndDate = null
                    }
                };

                ctx.AstronautDuties.AddRange(duties);
                ctx.SaveChanges();

                hasCompleted = true;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Oops, problem with duties: {ex.Message}");
        }

        return hasCompleted;
    }

    public static bool AddAstronautDetailRecords(StargateContext ctx, bool allData = true)
    {
        bool hasCompleted = false;

        try
        {
            if (allData)
            {
                bool hasDuties = TestHelper.AddAstronautDutyRecords(ctx);
            }
            else
            {
                bool hasPeople = TestHelper.AddPersonRecords(ctx);
            }

            List<AstronautDetail> details = new()
            {
                new() {
                    Id = 1,
                    PersonId = 1,
                    Person = ctx.People.Find(1) ?? new() { Name = "01" },
                    CurrentRank = "Astronaut",
                    CurrentDutyTitle = "Commander",
                    CareerStartDate = DateTime.Now.AddMonths(-24),
                    CareerEndDate = null
                },
                new() {
                    Id = 2,
                    PersonId = 2,
                    Person = ctx.People.Find(2) ?? new() { Name = "02" },
                    CurrentRank = "Astronaut",
                    CurrentDutyTitle = "Pilot",
                    CareerStartDate = DateTime.Now.AddMonths(-20),
                    CareerEndDate = null
                },
                new() {
                    Id = 3,
                    PersonId = 3,
                    Person = ctx.People.Find(3) ?? new() { Name = "03" },
                    CurrentRank = "Astronaut Candidate",
                    CurrentDutyTitle = "Crew Member",
                    CareerStartDate = DateTime.Now.AddMonths(-6),
                    CareerEndDate = null
                },
            };

            ctx.AstronautDetails.AddRange(details);
            ctx.SaveChanges();

            hasCompleted = true;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Oops, problem with details: {ex.Message}");
        }

        return hasCompleted;
    }
}
