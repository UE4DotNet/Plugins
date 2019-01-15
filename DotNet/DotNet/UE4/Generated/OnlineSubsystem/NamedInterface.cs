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


namespace UE4.OnlineSubsystem{
        ///<summary>Holds a named object interface for dynamically bound interfaces</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct NamedInterface {
            [FieldOffset(0)] public Name InterfaceName;

            [FieldOffset(16)] 
            private IntPtr  InterfaceObject_field;
            ///<summary>The object to store at this location</summary>
            public UObject InterfaceObject {
                get {return InterfaceObject_field;}
                set {InterfaceObject_field = value;}
            }

        }
}
