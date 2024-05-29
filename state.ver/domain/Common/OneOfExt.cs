using OneOf;

namespace Domain.Common;

public static class OneOfExt
{
   public static OneOf<T, Error> AsOneOfDomain<T>(this T obj) => obj;
}
