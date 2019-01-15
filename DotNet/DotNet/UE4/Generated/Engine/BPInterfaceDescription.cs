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
        ///<summary>Struct containing information about what interfaces are implemented in this blueprint</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct BPInterfaceDescription {
            ///<summary>Reference to the interface class we're adding to this blueprint</summary>
            public SubclassOf<Interface> Interface {
                get {return Interface_class; }
                set {Interface_class = value; }
            }
            [FieldOffset(0)] private IntPtr Interface_class;

            [FieldOffset(8)] byte Graphs; //TODO: array TArray Graphs

        }
}
