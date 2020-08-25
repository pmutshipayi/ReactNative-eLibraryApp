using System.Collections.Generic;
using System.Linq;

namespace ILabrary.Core
{
    public static class Utility
    {
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> enumerable) => 
            enumerable == null || !enumerable.Any();
    }
}
