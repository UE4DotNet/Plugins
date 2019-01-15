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
        ///<summary>FLandscapeEditToolRenderData</summary>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct LandscapeEditToolRenderData {
            [FieldOffset(0)] 
            private IntPtr  ToolMaterial_field;
            ///<summary>Material used to render the tool.</summary>
            public MaterialInterface ToolMaterial {
                get {return ToolMaterial_field;}
                set {ToolMaterial_field = value;}
            }

            [FieldOffset(8)] 
            private IntPtr  GizmoMaterial_field;
            ///<summary>Material used to render the gizmo selection region...</summary>
            public MaterialInterface GizmoMaterial {
                get {return GizmoMaterial_field;}
                set {GizmoMaterial_field = value;}
            }

            [FieldOffset(16)] public int SelectedType;

            [FieldOffset(20)] public int DebugChannelR;

            [FieldOffset(24)] public int DebugChannelG;

            [FieldOffset(28)] public int DebugChannelB;

            [FieldOffset(32)] 
            private IntPtr  DataTexture_field;
            ///<summary>Data Texture</summary>
            public Texture2D DataTexture {
                get {return DataTexture_field;}
                set {DataTexture_field = value;}
            }

        }
}
