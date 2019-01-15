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
        ///<summary>Struct that allows for different ways to reference a component.</summary>
        ///<remarks>If just an Actor is specified, will return RootComponent of that Actor.</remarks>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct ComponentReference {
            [FieldOffset(0)] 
            private IntPtr  OtherActor_field;
            ///<summary>Pointer to a different Actor that owns the Component.</summary>
            public Actor OtherActor {
                get {return OtherActor_field;}
                set {OtherActor_field = value;}
            }

            [FieldOffset(8)] public Name ComponentProperty;

        }
}
