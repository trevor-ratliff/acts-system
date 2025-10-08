using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Query;
using Moq;
using StargateAPI.Business.Commands;
using StargateAPI.Business.Data;
using StargateAPI_Tests.Helper;
using Xunit.Sdk;

namespace StargateAPI_Tests.Business.Commands;

[ExcludeFromCodeCoverage]
public class UpdatePerson_tests
{
    [Fact]
    public void UpdatePerson_OnCreate_CanSetValues()
    {
        // Given
        string name = "Test Person01";
        string newName = "Test Person10";
        UpdatePerson empty = new() { Name = string.Empty, NewName = string.Empty };
        UpdatePerson request = new() { Name = name, NewName = newName };

        // Then
        Assert.NotEqual(empty, request);
        Assert.Equal(name, request.Name);
        Assert.Equal(newName, request.NewName);
    }

    [Theory]
    [InlineData("", "", "The [Name] field cannot be empty")]
    [InlineData("Bob N. Ferrapples", "", "The [NewName] field cannot be empty")]
    [InlineData("Bob N. Ferrapples", "Test Person99", "Could not find a record for [Bob N. Ferrapples] to update")]
    [InlineData("Test Person01", "Test Person02", "A record for [Test Person02] already exists")]
    public async Task UpdatePersonPreProcessor_RejectsBadData(string name, string newName, string expectedMessage)
    {
        // Given
        var ctx = TestHelper.CreateInMemoryDbContext();
        bool hasPeople = TestHelper.AddPersonRecords(ctx);

        UpdatePerson request = new() { Name = name, NewName = newName };
        CancellationToken cancelToken = new();

        UpdatePersonPreProcessor preproc = new(ctx);

        // When
        // var exception = Record.Exception(() => callYourMethod());
        var errors = await Record.ExceptionAsync(() => preproc.Process(request, cancelToken));
        // var errors = await Assert.ThrowsAnyAsync<Exception>(() => preproc.Process(request, cancelToken));

        // Then
        Assert.NotNull(errors);
        Assert.Equal(expectedMessage, errors.Message);
    }

    [Fact]
    public async Task UpdatePerson_OnHandle_ReturnsSuccess()
    {
        // Given
        StargateContext ctx = TestHelper.CreateInMemoryDbContext();
        bool hasData = TestHelper.AddPersonRecords(ctx);
        Assert.True(hasData);

        UpdatePerson request = new() { Name = "Test Person01", NewName = "Test Person10" };

        UpdatePersonHandler handler = new(ctx);

        // When
        var result = await handler.Handle(
            request,
            new());

        // Then
        Assert.True(result.Success);
        Assert.Equal(200, result.ResponseCode);
        Assert.Equal("Successful", result.Message);
        Assert.Equal(1, result.Id);
    }

    [Fact]
    public async Task UpdatePerson_OnHandle_UpdatesRecord()
    {
        // Given
        var ctx = TestHelper.CreateInMemoryDbContext();
        bool hasRecords = TestHelper.AddPersonRecords(ctx);

        string name = "Test Person01";
        string newName = "Bob N. Ferrapples";
        UpdatePerson request = new() { Name = name, NewName = newName };

        UpdatePersonHandler handler = new(ctx);

        // When
        var result = await handler.Handle(request, new());
        var tester = ctx.People.Find(result.Id);

        // Then
        Assert.NotNull(result);
        Assert.True(result.Success);
        Assert.NotEqual(name, tester?.Name);
        Assert.Equal(newName, tester?.Name);
    }

    [Fact]
    public async Task UpdatePerson_OnHandleBadData_ThrowsError()
    {
        // Given
        StargateContext ctx = TestHelper.CreateInMemoryDbContext();
        bool hasPeople = TestHelper.AddPersonRecords(ctx);
        UpdatePerson request = new() { Name = "Test Person01", NewName = "Test Person02" };
        UpdatePersonHandler handler = new(ctx);

        // When
        var errors = await Record.ExceptionAsync(() => handler.Handle(request, new()));

        // Then
        Assert.NotNull(errors);
        Assert.Equal("BadHttpRequestException", errors.GetType().Name);
    }
}
