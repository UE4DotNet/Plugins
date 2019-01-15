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
        ///<summary>Landscape Spline Mesh Entry</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct LandscapeSplineMeshEntry {
            [FieldOffset(0)] 
            private IntPtr  Mesh_field;
            ///<summary>Mesh to use on the spline</summary>
            public StaticMesh Mesh {
                get {return Mesh_field;}
                set {Mesh_field = value;}
            }

            [FieldOffset(8)] byte MaterialOverrides; //TODO: array TArray MaterialOverrides

            [FieldOffset(24)] public bool bCenterH;

            ///<summary>Tweak to center the mesh correctly on the spline</summary>
            [FieldOffset(28)] Vector2D CenterAdjust;

            [FieldOffset(36)] public bool bScaleToWidth;

            ///<summary>Scale of the spline mesh, (Z=Forwards)</summary>
            [FieldOffset(40)] Vector Scale;

            [FieldOffset(53)] public byte ForwardAxis;

            [FieldOffset(54)] public byte UpAxis;

        }
}
