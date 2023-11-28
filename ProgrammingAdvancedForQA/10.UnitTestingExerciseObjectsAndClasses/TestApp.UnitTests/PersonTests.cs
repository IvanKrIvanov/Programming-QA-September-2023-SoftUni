using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PersonTests
{
    private Person _person;

    [SetUp]
    public void SetUp()
    {
        this._person = new Person();
    }

    [Test]
    public void Test_AddPeople_ReturnsListWithUniquePeople()
    {
        // Arrange
        string[] peopleData = { "Alice A001 25", "Bob B002 30", "Alice A001 35" };
        List<Person> expectedPeopleList = new()
        {
            new Person
            {
                Name = "Alice",
                Id = "A001",
                Age = 35,
            },
            new Person
            {
                Name = "Bob",
                Id = "B002",
                Age = 30,
            }
        };

        // Act
        List<Person> resultPeopleList = this._person.AddPeople(peopleData);

        // Assert
        Assert.That(resultPeopleList, Has.Count.EqualTo(2));
        for (int i = 0; i < resultPeopleList.Count; i++)
        {
            Assert.That(resultPeopleList[i].Name, Is.EqualTo(expectedPeopleList[i].Name));
            Assert.That(resultPeopleList[i].Id, Is.EqualTo(expectedPeopleList[i].Id));
            Assert.That(resultPeopleList[i].Age, Is.EqualTo(expectedPeopleList[i].Age));
        }
    }


    [Test]
    public void Test_AddPeople_ReturnsEmptyList_WhenNoDataGiven()
    {
        // Arrange
        string[] peopleData = { };

        // Act
        List<Person> result = this._person.AddPeople(peopleData);

        // Assert
        Assert.That(result, Has.Count.EqualTo(0));
    }

    [Test]
    public void Test_GetByAgeAscending_SortsPeopleByAge()
    {
        // Arrange
        List<Person> peopleData = new()
    {
        new Person
        {
            Name = "John",
            Id = "1",
            Age = 30,
        },
        new Person
        {
            Name = "Marry",
            Id = "2",
            Age = 25,
        },
        new Person
        {
            Name = "Ivan",
            Id = "3",
            Age = 50,
        }
    };

        // Act
        string actual = this._person.GetByAgeAscending(peopleData);

        // Assert
        Assert.IsTrue(actual.Contains("Marry with ID: 2 is 25 years old."));
        Assert.IsTrue(actual.Contains("John with ID: 1 is 30 years old."));
        Assert.IsTrue(actual.Contains("Ivan with ID: 3 is 50 years old."));
    }


    [Test]
    public void Test_GetByAgeAscending_ReturnEmptyString_WhenGivenNoData()
    {
        // Arrange
        List<Person> peopleData = new List<Person>();

        // Act
        string actual = this._person.GetByAgeAscending(peopleData);

        // Assert
        Assert.AreEqual(string.Empty, actual);
    }
}
