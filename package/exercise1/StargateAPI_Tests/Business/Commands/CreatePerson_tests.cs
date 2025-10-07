using System;
using MediatR;
using StargateAPI.Business.Commands;
using Moq;
using StargateAPI.Business.Data;
using Moq.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;
using StargateAPI_Tests.Helper;

namespace StargateAPI_Tests.Business.Commands;

public class CreatePerson_tests
{
    // public StargateContext CreateInMemoryDbContext()
    // {
    //     var options = new DbContextOptionsBuilder<StargateContext>()
    //         .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()) // Unique name for each test
    //         .Options;
    //     var context = new StargateContext(options);
    //     return context;
    // }

    [Fact]
    public void CreatePerson_WhenCreate_UsesValues()
    {
        // Given
        const string testName = "Test Person01";
        CreatePerson command = new() { Name = testName };

        // When

        // Then
        Assert.IsAssignableFrom<IRequest<CreatePersonResult>>(command);
        Assert.Equal(testName, command.Name);
    }

    [Fact]
    public async Task CreatePersonHandler_Handle_AddsAPerson()
    {
        // Given
        List<Person> data = new()
        {
            new(){ Name = "Test Person01"},
            new(){ Name = "Test Person02"},
            new(){ Name = "Test Person03"}
        };
        Mock<DbSet<Person>> dbPerson = new();

        /* var ctx = new Mock<StargateContext>();
        ctx.Setup(db => db.People).ReturnsDbSet(data);
        ctx.Setup(db => db.SaveChangesAsync(It.IsAny<CancellationToken>()).Result).Returns(1);
        CreatePersonHandler handler = new(ctx.Object); */

        var ctx2 = TestHelper.CreateInMemoryDbContext();
        CreatePersonHandler handler = new(ctx2);

        // When
        var result = await handler.Handle(new CreatePerson() { Name = "bob" }, new CancellationToken());

        // Then
        //ctx2.Verify(v => v.People.AddAsync(It.IsAny<Person>(), It.IsAny<CancellationToken>()), Times.AtLeastOnce);
        Assert.NotNull(result);
        Assert.Equal(1, result.Id);
    }

}
