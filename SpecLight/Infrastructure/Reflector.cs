using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace SpecLight.Infrastructure
{
    internal static class Reflector
    {
        public static readonly List<string> PendingExceptionNames = new List<string>("System.NotImplementedException,NUnit.Framework.InconclusiveException".Split(','));//todo: any more?

        public static readonly ConcurrentDictionary<MethodInfo, bool> MethodIsEmptyCache = new ConcurrentDictionary<MethodInfo, bool>();

        public static bool MethodIsEmpty(MethodInfo methodInfo)
        {
#if NETCOREAPP1_1
            return false;
#else
            return MethodIsEmptyCache.GetOrAdd(methodInfo, info =>
            {
                var il = info.GetMethodBody().GetILAsByteArray();

                //it's probably just [Nop, Ret]
                return il.Length < 10 && il.All(x => x == OpCodes.Nop.Value || x == OpCodes.Ret.Value);
            });
#endif
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static MethodBase FindCallingMethod()
        {
#if NETCOREAPP1_1
            return null;
#else
            var st = new StackTrace(2, false);
            var v = from f in st.GetFrames()
                select f.GetMethod()
                into m
                let t = m.DeclaringType
                where !NameIsCompilerGenerated(t.Name)
                where !(t.Namespace ?? "System.Runtime.CompilerServices").StartsWith("System.Runtime.CompilerServices")
                select m;

            return v.First();
#endif

        }

        public static bool NameIsCompilerGenerated(string s)
        {
            return s.Contains("<");
        }

    }
}
