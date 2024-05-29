namespace Domain.Common;


#pragma warning disable IDE1006, S101 // Naming Styles
public interface Error {};
#pragma warning restore IDE1006, S101 // Naming Styles

public abstract record ArgumentError(string? Message) : Error;

public record InvalidArgument(string? Message) : ArgumentError(Message);
public record InvalidArgument<T0>(string Message, T0 Param1) : ArgumentError(Message);
public record InvalidArgument<T0, T1>(string Message, T0 Param1, T1 Param2) : ArgumentError(Message);
