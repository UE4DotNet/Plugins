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

using UE4.Engine;

namespace UE4.PhysXVehicles{
        ///<summary>Allows overriding of friction of this tire config on a specific material</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct TireConfigMaterialFriction {
            [FieldOffset(0)] 
            private IntPtr  PhysicalMaterial_field;
            ///<summary>Physical material for friction scale</summary>
            public PhysicalMaterial PhysicalMaterial {
                get {return PhysicalMaterial_field;}
                set {PhysicalMaterial_field = value;}
            }

            [FieldOffset(8)] public float FrictionScale;

        }
}
