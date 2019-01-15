using System;
using System.Collections.Generic;
using UE4.Core;

namespace UE4.Native {
    public static class Interfaces {
        private static Dictionary<Name,IntPtr> NameToInterface = new Dictionary<Name, IntPtr>();

        internal static void Add( Name name, IntPtr interf ) =>
            NameToInterface.Add( name, interf );

        public static IntPtr Get( Name name ) =>
            NameToInterface[name];

    }
}
