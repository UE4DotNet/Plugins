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
        ///<summary>structs for ForeignWorldSplineDataMap</summary>
        ///<remarks>these are editor-only, but we don't have the concept of an editor-only USTRUCT</remarks>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct ForeignControlPointData {
            ///<summary>Modification Key</summary>
            [FieldOffset(0)] FGuid ModificationKey;

            [FieldOffset(16)] 
            private IntPtr  MeshComponent_field;
            ///<summary>Mesh Component</summary>
            public ControlPointMeshComponent MeshComponent {
                get {return MeshComponent_field;}
                set {MeshComponent_field = value;}
            }

            [FieldOffset(24)] byte Identifier; //TODO: lazy_object TLazyObjectPtr<ULandscapeSplineControlPoint> Identifier

        }
}
