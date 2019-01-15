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
        ///<summary>Foreign Spline Segment Data</summary>
        [StructLayout( LayoutKind.Explicit, Size=64 )]
        public unsafe struct ForeignSplineSegmentData {
            ///<summary>Modification Key</summary>
            [FieldOffset(0)] FGuid ModificationKey;

            [FieldOffset(16)] byte MeshComponents; //TODO: array TArray MeshComponents

            [FieldOffset(32)] byte Identifier; //TODO: lazy_object TLazyObjectPtr<ULandscapeSplineSegment> Identifier

        }
}
