using CloudCustomers.API.Models;

namespace CloudCustomers.UnitTests.Fixtures;

public static class UsersFixture
{
    public static List<User> GetTestUsers() =>
        new()
        {
            new User
            {
                Name = "Test User 1",
                Email = "test.user.1@email.com",
                Address = new Address()
                {
                    Street = "123 Market st",
                    City = "Somewhere",
                    ZipCode = "12323"
                }
            },
            new User
            {
                Name = "Test User 2",
                Email = "test.user.2@email.com",
                Address = new Address()
                {
                    Street = "123 Highway st",
                    City = "Around",
                    ZipCode = "32456"
                }
            },
            new User
            {
                Name = "Test User 3",
                Email = "test.user.3@email.com",
                Address = new Address()
                {
                    Street = "123 My Place st",
                    City = "Earth",
                    ZipCode = "78903"
                }
            }
        };
}
