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


namespace UE4.Landscape{
        ///<summary>Stores information about which weightmap texture and channel each layer is stored</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct WeightmapLayerAllocationInfo {
            [FieldOffset(0)] 
            private IntPtr  LayerInfo_field;
            ///<summary>Layer Info</summary>
            public LandscapeLayerInfoObject LayerInfo {
                get {return LayerInfo_field;}
                set {LayerInfo_field = value;}
            }

            [FieldOffset(8)] public byte WeightmapTextureIndex;

            [FieldOffset(9)] public byte WeightmapTextureChannel;

        }
}
