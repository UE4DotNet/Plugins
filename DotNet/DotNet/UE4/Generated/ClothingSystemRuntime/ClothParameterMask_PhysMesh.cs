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


namespace UE4.ClothingSystemRuntime{
        ///<summary>A mask is simply some storage for a physical mesh parameter painted onto clothing.</summary>
        ///<remarks>
        ///Used in the editor for users to paint onto and then target to a parameter, which
        ///is then later applied to a phys mesh
        ///</remarks>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct ClothParameterMask_PhysMesh {
            [FieldOffset(0)] public Name MaskName;

            [FieldOffset(12)] byte CurrentTarget; //TODO: enum MaskTarget_PhysMesh CurrentTarget

            [FieldOffset(16)] public float MaxValue;

            [FieldOffset(20)] public float MinValue;

            [FieldOffset(24)] byte Values; //TODO: array TArray Values

            [FieldOffset(40)] public bool bEnabled;

        }
}
