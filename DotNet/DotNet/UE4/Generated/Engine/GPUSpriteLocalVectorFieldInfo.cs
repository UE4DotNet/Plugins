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
        ///<summary>Data needed for local vector fields.</summary>
        [StructLayout( LayoutKind.Explicit, Size=112 )]
        public unsafe struct GPUSpriteLocalVectorFieldInfo {
            [FieldOffset(0)] 
            private IntPtr  Field_field;
            ///<summary>Local vector field to apply to this emitter.</summary>
            public VectorField Field {
                get {return Field_field;}
                set {Field_field = value;}
            }

            ///<summary>Local vector field transform.</summary>
            [FieldOffset(16)] Transform Transform;

            ///<summary>Minimum initial rotation.</summary>
            [FieldOffset(64)] Rotator MinInitialRotation;

            ///<summary>Maximum initial rotation.</summary>
            [FieldOffset(76)] Rotator MaxInitialRotation;

            ///<summary>Local vector field rotation rate.</summary>
            [FieldOffset(88)] Rotator RotationRate;

            [FieldOffset(100)] public float Intensity;

            [FieldOffset(104)] public float Tightness;

            [FieldOffset(108)] public bool bIgnoreComponentTransform;

            [FieldOffset(108)] public bool bTileX;

            [FieldOffset(108)] public bool bTileY;

            [FieldOffset(108)] public bool bTileZ;

            [FieldOffset(108)] public bool bUseFixDT;

        }
}
