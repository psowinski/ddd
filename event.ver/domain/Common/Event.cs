namespace Domain.Common;

public record EventId(Guid Value)
{
   public static EventId NewId() => new EventId(Guid.NewGuid());
}

#pragma warning disable IDE1006, S101 // Naming Styles
public interface Event<out T>
#pragma warning restore IDE1006, S101 // Naming Styles
{
   EventId EventId { get; }
   T EntityId { get;}
   SeqNum SequenceNumber { get; }
   CorellationId CorellationId { get; }
}
