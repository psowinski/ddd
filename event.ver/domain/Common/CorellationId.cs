namespace Domain.Common;

public record CorellationId
{
   public Guid Id { get; init; }

   private CorellationId(Guid id)
   {
      Id = id;
   }
   
   public static CorellationId NewId() => new(Guid.NewGuid());
}
