using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionExtensions
{
    /// <summary>
    /// Extension methods for Enumerable
    /// </summary>
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Determines if a collection is empty
        /// </summary>
        public static bool IsEmpty(this IEnumerable enumerable)
        {
            Argument.CheckIfNull(enumerable, "enumerable");

            IEnumerator enumerator = enumerable.GetEnumerator();
            return !enumerator.MoveNext();
        }

        /// <summary>
        /// Simultaneiusly iterates two lists
        /// </summary>
        public static void IterateMultiple<T1, T2>(this IEnumerable<T1> first, IEnumerable<T2> second, Action<T1, T2> action)
        {
            Argument.CheckIfNull(action, "action");
            Argument.CheckIfNull(first, "first");
            Argument.CheckIfNull(second, "second");

            using (var e1 = first.GetEnumerator())
            using (var e2 = second.GetEnumerator())
            {
                while (e1.MoveNext() && e2.MoveNext())
                {
                    action(e1.Current, e2.Current);
                }
            }
        }

        /// <summary>
        /// Simultaneiusly iterates Three lists
        /// </summary>
        public static void IterateMultiple<T1, T2, T3>(this IEnumerable<T1> first, IEnumerable<T2> second, IEnumerable<T3> third, Action<T1, T2, T3> action)
        {
            Argument.CheckIfNull(action, "action");
            Argument.CheckIfNull(first, "first");
            Argument.CheckIfNull(second, "second");
            Argument.CheckIfNull(third, "third");

            using (var e1 = first.GetEnumerator())
            using (var e2 = second.GetEnumerator())
            using (var e3 = third.GetEnumerator())
            {
                while (e1.MoveNext() && e2.MoveNext() && e3.MoveNext())
                {
                    action(e1.Current, e2.Current, e3.Current);
                }
            }
        }

        /// <summary>
        /// Simultaneiusly iterates four lists
        /// </summary>
        public static void IterateMultiple<T1, T2, T3, T4>(this IEnumerable<T1> first, IEnumerable<T2> second, IEnumerable<T3> third, IEnumerable<T4> fourth, Action<T1, T2, T3, T4> action)
        {
            Argument.CheckIfNull(action, "action");
            Argument.CheckIfNull(first, "first");
            Argument.CheckIfNull(second, "second");
            Argument.CheckIfNull(third, "third");
            Argument.CheckIfNull(fourth, "fourth");

            using (var e1 = first.GetEnumerator())
            using (var e2 = second.GetEnumerator())
            using (var e3 = third.GetEnumerator())
            using (var e4 = fourth.GetEnumerator())
            {
                while (e1.MoveNext() && e2.MoveNext() && e3.MoveNext() && e4.MoveNext())
                {
                    action(e1.Current, e2.Current, e3.Current, e4.Current);
                }
            }
        }

        /// <summary>
        /// Simultaneiusly iterates five lists
        /// </summary>
        public static void IterateMultiple<T1, T2, T3, T4, T5>(this IEnumerable<T1> first, IEnumerable<T2> second, IEnumerable<T3> third, IEnumerable<T4> fourth, IEnumerable<T5> fifth, Action<T1, T2, T3, T4, T5> action)
        {
            Argument.CheckIfNull(action, "action");
            Argument.CheckIfNull(first, "first");
            Argument.CheckIfNull(second, "second");
            Argument.CheckIfNull(third, "third");
            Argument.CheckIfNull(fourth, "fourth");
            Argument.CheckIfNull(fifth, "fifth");

            using (var e1 = first.GetEnumerator())
            using (var e2 = second.GetEnumerator())
            using (var e3 = third.GetEnumerator())
            using (var e4 = fourth.GetEnumerator())
            using (var e5 = fifth.GetEnumerator())
            {
                while (e1.MoveNext() && e2.MoveNext() && e3.MoveNext() && e4.MoveNext() && e5.MoveNext())
                {
                    action(e1.Current, e2.Current, e3.Current, e4.Current, e5.Current);
                }
            }
        }

        /// <summary>
        /// Iterates two lists and performs a select from both
        /// </summary>
        public static IEnumerable<TResult> IterateMultipleAndSelect<T1, T2, TResult>(this IEnumerable<T1> first, IEnumerable<T2> second, Func<T1, T2, TResult> selector)
        {
            Argument.CheckIfNull(selector, "selector");
            Argument.CheckIfNull(first, "first");
            Argument.CheckIfNull(second, "second");

            var result = new List<TResult>();
            first.IterateMultiple(second, (arg1, arg2) => result.Add(selector(arg1, arg2)));
            return result;
        }

        /// <summary>
        /// Iterates three lists and performs a select from all three
        /// </summary>
        public static IEnumerable<TResult> IterateMultipleAndSelect<T1, T2, T3, TResult>(this IEnumerable<T1> first, IEnumerable<T2> second, IEnumerable<T3> third, Func<T1, T2, T3, TResult> selector)
        {
            Argument.CheckIfNull(selector, "selector");
            Argument.CheckIfNull(first, "first");
            Argument.CheckIfNull(second, "second");
            Argument.CheckIfNull(third, "third");

            var result = new List<TResult>();
            first.IterateMultiple(second, third, (arg1, arg2, arg3) => result.Add(selector(arg1, arg2, arg3)));
            return result;
        }

        /// <summary>
        /// Iterates four lists and performs a select from all four
        /// </summary>
        public static IEnumerable<TResult> IterateMultipleAndSelect<T1, T2, T3, T4, TResult>(this IEnumerable<T1> first, IEnumerable<T2> second, IEnumerable<T3> third, IEnumerable<T4> fourth, Func<T1, T2, T3, T4, TResult> selector)
        {
            Argument.CheckIfNull(selector, "selector");
            Argument.CheckIfNull(first, "first");
            Argument.CheckIfNull(second, "second");
            Argument.CheckIfNull(third, "third");
            Argument.CheckIfNull(fourth, "fourth");

            var result = new List<TResult>();
            first.IterateMultiple(second, third, fourth, (arg1, arg2, arg3, arg4) => result.Add(selector(arg1, arg2, arg3, arg4)));
            return result;
        }
    }
}
