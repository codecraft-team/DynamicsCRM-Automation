using System;
using System.Collections.Generic;
using System.Linq;

namespace PowerShellLibrary.Crm.CmdletProviders.Extensions {
  public static class EnumerableExtensions {
    public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action) {
      enumerable?.ToList().ForEach(action);
    }

    public static TSource FirstRandom<TSource>(this IEnumerable<TSource> source) {
      Random random = new Random(DateTime.Now.Millisecond);

      IEnumerable<TSource> enumeratedSource = source as IList<TSource> ?? source.ToList();
      int randomIndex = random.Next(0, enumeratedSource.Count());

      return enumeratedSource.ElementAt(randomIndex);
    }
  }
}