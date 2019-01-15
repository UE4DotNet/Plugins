// Copyright 2018 by JCoder58.  See License.txt for license
// Auto-generated --- Do not modify.
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UE4.Core;
using UE4.CoreUObject;
using UE4.CoreUObject.Native;
using UE4.InputCore;
using UE4.Native;


namespace UE4.Engine{
        ///<summary>Active and named net drivers instantiated from an FNetDriverDefinition</summary>
        ///<remarks>The net driver will remain instantiated on this struct until it is destroyed</remarks>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct NamedNetDriver {
            [FieldOffset(0)] 
            private IntPtr  NetDriver_field;
            ///<summary>Instantiation of named net driver</summary>
            public NetDriver NetDriver {
                get {return NetDriver_field;}
                set {NetDriver_field = value;}
            }

        }
}
