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

namespace UE4.Landscape{
        ///<summary>Grass Input</summary>
        [StructLayout( LayoutKind.Explicit, Size=80 )]
        public unsafe struct GrassInput {
            [FieldOffset(0)] public Name Name;

            [FieldOffset(16)] 
            private IntPtr  GrassType_field;
            ///<summary>Grass Type</summary>
            public LandscapeGrassType GrassType {
                get {return GrassType_field;}
                set {GrassType_field = value;}
            }

            ///<summary>Input</summary>
            [FieldOffset(24)] ExpressionInput Input;

        }
}
