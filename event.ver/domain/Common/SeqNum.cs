namespace Domain.Common;

public record SeqNum(uint Value)
{
   public SeqNum Inc() => new(Value + 1);
}
