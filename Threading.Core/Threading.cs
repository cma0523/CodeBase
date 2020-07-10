using System;
using System.Threading;

namespace Threading.Core
{
    public class MyClass
    {
        private readonly ManualResetEventSlim _initialized = new ManualResetEventSlim();

        private int _value;

        public int WaitForInitialization()
        {
            _initialized.Wait();
            return _value;
        }

        public void InitializeFromAnotherThread()
        {
            _value = 13;
            _initialized.Set();
        }
    }
}
