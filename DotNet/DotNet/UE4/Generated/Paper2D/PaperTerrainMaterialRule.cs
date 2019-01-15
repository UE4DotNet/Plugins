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


namespace UE4.Paper2D{
        ///<summary>Rule for a single section of a terrain material</summary>
        [StructLayout( LayoutKind.Explicit, Size=80 )]
        public unsafe struct PaperTerrainMaterialRule {
            [FieldOffset(0)] 
            private IntPtr  StartCap_field;
            ///<summary>The sprite to use at the 'left' (closest to spline start) edge of the terrain segment</summary>
            public PaperSprite StartCap {
                get {return StartCap_field;}
                set {StartCap_field = value;}
            }

            [FieldOffset(8)] byte Body; //TODO: array TArray Body

            [FieldOffset(24)] 
            private IntPtr  EndCap_field;
            ///<summary>The sprite to use at the 'right' (closest to spline end) edge of the terrain segment</summary>
            public PaperSprite EndCap {
                get {return EndCap_field;}
                set {EndCap_field = value;}
            }

            [FieldOffset(32)] public float MinimumAngle;

            [FieldOffset(36)] public float MaximumAngle;

            [FieldOffset(40)] public bool bEnableCollision;

            [FieldOffset(44)] public float CollisionOffset;

            [FieldOffset(48)] public int DrawOrder;

            [FieldOffset(56)] byte Description; //TODO: text FText Description

        }
}
