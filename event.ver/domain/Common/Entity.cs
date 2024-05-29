using OneOf;

namespace Domain.Common;

public record Entity<T>(T Id, SeqNum SequenceNumber);

public static class EntityExtensions
{
   public static OneOf<Entity<T>, Error> ApplyValidEvent<T>(
      this Event<T> @event,
      Entity<T> entity)
      where T : IEquatable<T>
   {
      if (!@event.EntityId.Equals(entity.Id)
         || @event.SequenceNumber != entity.SequenceNumber.Inc())
         return new InvalidArgument<Event<T>, Entity<T>>("Cannot apply {Event} on {Entity}", @event, entity);

      return entity;
   }
}
