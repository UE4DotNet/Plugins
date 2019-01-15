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
        ///<summary>Struct used for a particular named instance parameter for this ParticleSystemComponent.</summary>
        [StructLayout( LayoutKind.Explicit, Size=144 )]
        public unsafe struct ParticleSysParam {
            [FieldOffset(0)] public Name Name;

            [FieldOffset(12)] public byte ParamType;

            [FieldOffset(16)] public float Scalar;

            [FieldOffset(20)] public float Scalar_Low;

            ///<summary>Vector</summary>
            [FieldOffset(24)] Vector Vector;

            ///<summary>Vector Low</summary>
            [FieldOffset(36)] Vector Vector_Low;

            ///<summary>Color</summary>
            [FieldOffset(48)] Color Color;

            [FieldOffset(56)] 
            private IntPtr  Actor_field;
            ///<summary>Actor</summary>
            public Actor Actor {
                get {return Actor_field;}
                set {Actor_field = value;}
            }

            [FieldOffset(64)] 
            private IntPtr  Material_field;
            ///<summary>Material</summary>
            public MaterialInterface Material {
                get {return Material_field;}
                set {Material_field = value;}
            }

        }
}
