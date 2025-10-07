using System;
using Moq;
using StargateAPI.Business.Commands;
using StargateAPI.Business.Data;
using StargateAPI_Tests.Helper;

namespace StargateAPI_Tests.Business.Commands;

public class UpdatePerson_tests
{
    [Fact]
    public async Task UpdatePerson_OnHandle_ReturnsSuccess()
    {
        // Given
        StargateContext ctx = TestHelper.CreateInMemoryDbContext();
        bool hasData = TestHelper.AddPersonRecords(ctx);
        Assert.True(hasData);

        UpdatePersonHandler handler = new(ctx);

        // When
        var result = await handler.Handle(
            new() { Name = "Test Person01", newName = "Test Person10" },
            new());

        // Then
        Assert.True(result.Success);
        Assert.Equal(200, result.ResponseCode);
        Assert.Equal("Successful", result.Message);
        Assert.Equal(1, result.Id);
    }

}
