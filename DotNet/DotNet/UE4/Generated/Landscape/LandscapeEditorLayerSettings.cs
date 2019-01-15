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
        ///<summary>Landscape Editor Layer Settings</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct LandscapeEditorLayerSettings {
            [FieldOffset(0)] 
            private IntPtr  LayerInfoObj_field;
            ///<summary>Layer Info Obj</summary>
            public LandscapeLayerInfoObject LayerInfoObj {
                get {return LayerInfoObj_field;}
                set {LayerInfoObj_field = value;}
            }

            [FieldOffset(8)] byte ReimportLayerFilePath; //TODO: string FString ReimportLayerFilePath

        }
}
