using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using StargateAPI.Business.Data;
using StargateAPI_Tests.Helper;

namespace StargateAPI_Tests;

[ExcludeFromCodeCoverage]
public class Helper_tests
{
    [Fact]
    public void TestFramework_IsWorking()
    {
        Assert.True(true);
    }

    [Fact]
    public void CanCreateDbContext()
    {
        // Given
        var ctx = TestHelper.CreateInMemoryDbContext();

        // When

        // Then
        Assert.NotNull(ctx);
        Assert.IsAssignableFrom<DbContext>(ctx);
        Assert.Equal(0, ctx.People.Count());
        Assert.Equal(0, ctx.AstronautDuties.Count());
        Assert.Equal(0, ctx.AstronautDetails.Count());
    }

    [Fact]
    public void StargateContext_CanAddTestPeople()
    {
        // Given
        var ctx = TestHelper.CreateInMemoryDbContext();

        // When
        bool hasPeople = TestHelper.AddPersonRecords(ctx);
        Person? tester = ctx.People.Find(1);

        // Then
        Assert.True(hasPeople);
        Assert.Equal(3, ctx.People.Count());
        Assert.Equal("Test Person01", tester?.Name);
    }

    [Fact]
    public void StargeateContext_CanAddAstronautDuties()
    {
        // Given
        var ctx = TestHelper.CreateInMemoryDbContext();

        // When
        bool hasDuties = TestHelper.AddAstronautDutyRecords(ctx);
        AstronautDuty? tester = ctx.AstronautDuties.Find(1);

        // Then
        Assert.True(hasDuties);
        // people should have 3 records 
        Assert.Equal(3, ctx.People.Count());
        // duties should have 4 records
        Assert.Equal(4, ctx.AstronautDuties.Count());
        Assert.Equal("Commander", tester?.DutyTitle);
    }

    [Fact]
    public void StargateContext_CanAddAstronautDetails_WithPeople()
    {
        // Given
        var ctx = TestHelper.CreateInMemoryDbContext();

        // When
        bool hasDetails = TestHelper.AddAstronautDetailRecords(ctx, false);
        AstronautDetail? tester = ctx.AstronautDetails.Find(1);

        // Then
        Assert.True(hasDetails);
        // people should have 3 records 
        Assert.Equal(3, ctx.People.Count());
        // details should have 3 records
        Assert.Equal(3, ctx.AstronautDetails.Count());
        Assert.Equal("Commander", tester?.CurrentDutyTitle);
    }

    [Fact]
    public void StargateContext_CanAddAstronautDetails_WithAllRecords()
    {
        // Given
        var ctx = TestHelper.CreateInMemoryDbContext();

        // When
        bool hasDetails = TestHelper.AddAstronautDetailRecords(ctx, true);
        AstronautDetail? tester = ctx.AstronautDetails.Find(1);

        // Then
        Assert.True(hasDetails);
        // people should have 3 records 
        Assert.Equal(3, ctx.People.Count());
        // duties should have 4 records
        Assert.Equal(4, ctx.AstronautDuties.Count());
        // details should have 3 records
        Assert.Equal(3, ctx.AstronautDetails.Count());
        Assert.Equal("Commander", tester?.CurrentDutyTitle);
    }
}
