using System;
using System.Runtime.InteropServices;

namespace UE4.Native {
    internal struct DelegateHolder<TDelegate> {
        // https://github.com/dotnet/corefx/issues/14540
        public TDelegate Delegate;
        public GCHandle Handle;

        public DelegateHolder( TDelegate del ) {
            Delegate = del;
            Handle = GCHandle.Alloc( Delegate );
        }
    }
}
