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
        ///<summary>Landscape Proxy Material Override</summary>
        [StructLayout( LayoutKind.Explicit, Size=96 )]
        public unsafe struct LandscapeProxyMaterialOverride {
            ///<summary>LODIndex</summary>
            [FieldOffset(0)] PerPlatformInt LODIndex;

            [FieldOffset(88)] 
            private IntPtr  Material_field;
            ///<summary>Material</summary>
            public MaterialInterface Material {
                get {return Material_field;}
                set {Material_field = value;}
            }

        }
}
