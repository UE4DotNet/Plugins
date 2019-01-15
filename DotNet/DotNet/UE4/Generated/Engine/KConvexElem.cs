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


namespace UE4.Engine{
        ///<summary>One convex hull, used for simplified collision.</summary>
        [StructLayout( LayoutKind.Explicit, Size=160 )]
        public unsafe struct KConvexElem {
            [FieldOffset(48)] byte VertexData; //TODO: array TArray VertexData

            ///<summary>Bounding box of this convex hull.</summary>
            [FieldOffset(64)] Box ElemBox;

            ///<summary>Transform of this element</summary>
            [FieldOffset(96)] Transform Transform;

        }
}
