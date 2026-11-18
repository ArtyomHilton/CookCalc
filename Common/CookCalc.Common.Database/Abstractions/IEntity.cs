namespace CookCalc.Common.Database.Abstractions;

public interface IEntity
{
}

public interface IEntity<TId>
{
    TId Id { get; init; }
}
