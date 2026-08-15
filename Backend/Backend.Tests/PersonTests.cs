using Backend.Models;
using Xunit;

namespace Backend.Tests;

public class PersonTests
{
    [Fact]
    public void NewPerson_DefaultValues_AreEmptyStrings()
    {
        var person = new Person();

        Assert.Equal(string.Empty, person.FirstName);
        Assert.Equal(string.Empty, person.LastName);
    }

    [Fact]
    public void Person_SetFirstAndLastName_ValuesAreStored()
    {
        var person = new Person
        {
            FirstName = "Arsh",
            LastName = "Sheelam"
        };

        Assert.Equal("Arsh", person.FirstName);
        Assert.Equal("Sheelam", person.LastName);
    }
}
