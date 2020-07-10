using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace Threading.Core
{
    public static class ThreadingSafeCollections<T>
    {
        public static readonly BlockingCollection<T> _blockingBag = new BlockingCollection<T>(new ConcurrentBag<T>());

        public static readonly BlockingCollection<T> _blockingQueue = new BlockingCollection<T>(new ConcurrentQueue<T>());

        public static readonly BlockingCollection<T> _blockingStack = new BlockingCollection<T>(new ConcurrentStack<T>());


    }
}
