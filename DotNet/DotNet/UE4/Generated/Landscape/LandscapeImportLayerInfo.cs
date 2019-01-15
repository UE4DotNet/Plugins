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
        ///<summary>Structure storing Layer Data for import</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct LandscapeImportLayerInfo {
            [FieldOffset(0)] public Name LayerName;

            [FieldOffset(16)] 
            private IntPtr  LayerInfo_field;
            ///<summary>Layer Info</summary>
            public LandscapeLayerInfoObject LayerInfo {
                get {return LayerInfo_field;}
                set {LayerInfo_field = value;}
            }

            [FieldOffset(24)] byte SourceFilePath; //TODO: string FString SourceFilePath

        }
}
