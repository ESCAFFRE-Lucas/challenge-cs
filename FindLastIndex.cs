using System;
using System.Linq;

namespace CSharpDiscovery.Quest02
{
    public class FindLastIndex_Exercice
    {
        public static int? FindLastIndex(int[] tab, int a)
        {
            if (tab == null || a == null) return null;
            
            return Array.LastIndexOf(tab, a) == -1 ? null : Array.LastIndexOf(tab, a);
        }
    }
}