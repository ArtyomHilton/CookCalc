namespace CookCalc.Common.Database.Entities;

using System;
using System.Collections.Generic;
using System.Text;
using CookCalc.Common.Database.Abstractions;

internal class User 
    : IEntity<Guid>, IHaveTimestamp
{
    public Guid Id { get; init; }
    public string Username { get; private set; }
    public string PasswordHash { get; private set; }
    public string? Email { get; private set; }
    public DateTime CreatedAt { get; }
    public DateTime UpdatedAt { get; }

    private User() { }

    public User(string username, string passwordHash)
    {
        Username = username;
        PasswordHash = passwordHash;
    }

    public void SetEmail(string email)
    {
        Email = email;
    }

    public static User Create(string username, string passwordHash) =>
        new User(username, passwordHash);

}
