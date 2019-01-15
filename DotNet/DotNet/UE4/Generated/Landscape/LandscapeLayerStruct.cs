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
        ///<summary>Landscape Layer Struct</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct LandscapeLayerStruct {
            [FieldOffset(0)] 
            private IntPtr  LayerInfoObj_field;
            ///<summary>Layer Info Obj</summary>
            public LandscapeLayerInfoObject LayerInfoObj {
                get {return LayerInfoObj_field;}
                set {LayerInfoObj_field = value;}
            }

            [FieldOffset(8)] 
            private IntPtr  ThumbnailMIC_field;
            ///<summary>Thumbnail MIC</summary>
            public LandscapeMaterialInstanceConstant ThumbnailMIC {
                get {return ThumbnailMIC_field;}
                set {ThumbnailMIC_field = value;}
            }

            [FieldOffset(16)] 
            private IntPtr  Owner_field;
            ///<summary>Owner</summary>
            public LandscapeProxy Owner {
                get {return Owner_field;}
                set {Owner_field = value;}
            }

            [FieldOffset(24)] public int DebugColorChannel;

            [FieldOffset(28)] public bool bSelected;

            [FieldOffset(32)] byte SourceFilePath; //TODO: string FString SourceFilePath

        }
}
