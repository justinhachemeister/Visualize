﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AssemblyToProcess
{
    [Visualize.DebuggerEnumerableType]
    public class ClassWithIEnumerable : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            return Enumerable.Range(0, 10).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}