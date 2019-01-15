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
        ///<summary>Reference to a specific material in a PrimitiveComponent.</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct PrimitiveMaterialRef {
            [FieldOffset(0)] 
            private IntPtr  Primitive_field;
            ///<summary>Primitive</summary>
            public PrimitiveComponent Primitive {
                get {return Primitive_field;}
                set {Primitive_field = value;}
            }

            [FieldOffset(8)] 
            private IntPtr  Decal_field;
            ///<summary>Decal</summary>
            public DecalComponent Decal {
                get {return Decal_field;}
                set {Decal_field = value;}
            }

            [FieldOffset(16)] public int ElementIndex;

        }
}
