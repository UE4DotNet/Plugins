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
        ///<summary>Material Sprite Element</summary>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct MaterialSpriteElement {
            [FieldOffset(0)] 
            private IntPtr  Material_field;
            ///<summary>The material that the sprite is rendered with.</summary>
            public MaterialInterface Material {
                get {return Material_field;}
                set {Material_field = value;}
            }

            [FieldOffset(8)] 
            private IntPtr  DistanceToOpacityCurve_field;
            ///<summary>A curve that maps distance on the X axis to the sprite opacity on the Y axis.</summary>
            public CurveFloat DistanceToOpacityCurve {
                get {return DistanceToOpacityCurve_field;}
                set {DistanceToOpacityCurve_field = value;}
            }

            [FieldOffset(16)] public bool bSizeIsInScreenSpace;

            [FieldOffset(20)] public float BaseSizeX;

            [FieldOffset(24)] public float BaseSizeY;

            [FieldOffset(32)] 
            private IntPtr  DistanceToSizeCurve_field;
            ///<summary>A curve that maps distance on the X axis to the sprite size on the Y axis.</summary>
            public CurveFloat DistanceToSizeCurve {
                get {return DistanceToSizeCurve_field;}
                set {DistanceToSizeCurve_field = value;}
            }

        }
}
