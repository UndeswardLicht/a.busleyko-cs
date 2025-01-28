using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject.mytask_rest.Utils
{
    internal class TestUtils
    {
        public static bool IsListSortedAscending(List<int> list, IComparer<int>? comparer = default)
        {
            if (list.Count <= 1)
            {
                return true;
            }
            comparer ??= Comparer<int>.Default;

            for (var i = 1; i < list.Count; i++)
            {
                if (comparer.Compare(list[i - 1], list[i]) > 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
