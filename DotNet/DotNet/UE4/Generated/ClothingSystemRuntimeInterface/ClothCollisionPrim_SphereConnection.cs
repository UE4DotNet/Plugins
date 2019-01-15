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


namespace UE4.ClothingSystemRuntimeInterface{
        ///<summary>Data for a single connected sphere primitive.</summary>
        ///<remarks>
        ///This should be configured after all spheres have
        ///been processed as they are really just indexing the existing spheres
        ///</remarks>
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        public unsafe struct ClothCollisionPrim_SphereConnection {
            [FieldOffset(0)] public int SphereIndices;

        }
}
