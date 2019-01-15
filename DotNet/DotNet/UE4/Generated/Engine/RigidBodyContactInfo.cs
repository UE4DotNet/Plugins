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
        ///<summary>Information about one contact between a pair of rigid bodies.</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct RigidBodyContactInfo {
            ///<summary>Contact Position</summary>
            [FieldOffset(0)] Vector ContactPosition;

            ///<summary>Contact Normal</summary>
            [FieldOffset(12)] Vector ContactNormal;

            [FieldOffset(24)] public float ContactPenetration;

            [FieldOffset(32)] 
            private IntPtr  PhysMaterial_field;
            ///<summary>Phys Material</summary>
            public PhysicalMaterial PhysMaterial {
                get {return PhysMaterial_field;}
                set {PhysMaterial_field = value;}
            }

        }
}
