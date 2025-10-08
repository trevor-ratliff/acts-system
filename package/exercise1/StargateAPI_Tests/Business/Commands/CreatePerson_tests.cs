using MediatR;
using StargateAPI.Business.Commands;
using Moq;
using StargateAPI.Business.Data;
using Microsoft.EntityFrameworkCore;
using StargateAPI_Tests.Helper;
using System.Diagnostics.CodeAnalysis;

namespace StargateAPI_Tests.Business.Commands;

[ExcludeFromCodeCoverage]
public class CreatePerson_tests
{
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
    public async Task CreatePersonHandler_OnHandle_AddsPerson()
    {
        // Given
        CreatePerson request = new() { Name = "Bob N. Ferrapples" };
        var ctx = TestHelper.CreateInMemoryDbContext();
        CreatePersonHandler handler = new(ctx);

        // When
        var result = await handler.Handle(request, new CancellationToken());
        Person? added = ctx.People.Find(result.Id);

        // Then
        Assert.NotNull(result);
        Assert.Equal(1, result.Id);
        Assert.Equal(1, ctx.People.Count());
        Assert.NotNull(added);
        Assert.Equal(request.Name, added.Name);
    }

}
