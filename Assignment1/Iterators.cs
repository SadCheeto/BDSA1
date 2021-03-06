using System;
using System.Collections.Generic;

namespace Assignment1
{
    public static class Iterators
    {
    
        
        public static IEnumerable<T> Flatten<T>(IEnumerable<IEnumerable<T>> items)
        {
            foreach (var item in items)
            {
                foreach (var t in item)
                {
                    yield return t;
                }
            }
        }
        //isadfjpsiafj

        public static IEnumerable<T> Filter<T>(IEnumerable<T> items, Predicate<T> predicate)
        {
            foreach (var t in items)
            {
                if (predicate(t))
                {
                    yield return t;
                }
            }
        }
    }
}
