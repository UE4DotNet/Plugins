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
        ///<summary>Landscape Info Layer Settings</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct LandscapeInfoLayerSettings {
            [FieldOffset(0)] 
            private IntPtr  LayerInfoObj_field;
            ///<summary>Layer Info Obj</summary>
            public LandscapeLayerInfoObject LayerInfoObj {
                get {return LayerInfoObj_field;}
                set {LayerInfoObj_field = value;}
            }

            [FieldOffset(8)] public Name LayerName;

            [FieldOffset(24)] 
            private IntPtr  ThumbnailMIC_field;
            ///<summary>Thumbnail MIC</summary>
            public MaterialInstanceConstant ThumbnailMIC {
                get {return ThumbnailMIC_field;}
                set {ThumbnailMIC_field = value;}
            }

            [FieldOffset(32)] 
            private IntPtr  Owner_field;
            ///<summary>Owner</summary>
            public LandscapeProxy Owner {
                get {return Owner_field;}
                set {Owner_field = value;}
            }

            [FieldOffset(40)] public int DebugColorChannel;

            [FieldOffset(44)] public bool bValid;

        }
}
