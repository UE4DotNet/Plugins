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
        ///<summary>Named Emitter Material</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct NamedEmitterMaterial {
            [FieldOffset(0)] public Name Name;

            [FieldOffset(16)] 
            private IntPtr  Material_field;
            ///<summary>Material</summary>
            public MaterialInterface Material {
                get {return Material_field;}
                set {Material_field = value;}
            }

        }
}
