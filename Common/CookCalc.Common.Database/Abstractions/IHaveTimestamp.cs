namespace CookCalc.Common.Database.Abstractions;

public interface IHaveTimestamp
{
    DateTime CreatedAt { get; }
    DateTime UpdatedAt { get; }
}
