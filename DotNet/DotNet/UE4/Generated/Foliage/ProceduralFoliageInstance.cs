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


namespace UE4.Foliage{
        ///<summary>Procedural Foliage Instance</summary>
        [StructLayout( LayoutKind.Explicit, Size=96 )]
        public unsafe struct ProceduralFoliageInstance {
            ///<summary>Location</summary>
            [FieldOffset(0)] Vector Location;

            ///<summary>Rotation</summary>
            [FieldOffset(16)] Quat Rotation;

            ///<summary>Normal</summary>
            [FieldOffset(32)] Vector Normal;

            [FieldOffset(44)] public float Age;

            [FieldOffset(48)] public float Scale;

            [FieldOffset(56)] 
            private IntPtr  Type_field;
            ///<summary>Type</summary>
            public FoliageType_InstancedStaticMesh Type {
                get {return Type_field;}
                set {Type_field = value;}
            }

        }
}
