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


namespace UE4.UnrealEd{
        ///<summary>Scalar Parameter Atlas Data</summary>
        [StructLayout( LayoutKind.Explicit, Size=104 )]
        public unsafe struct ScalarParameterAtlasData {
            [FieldOffset(0)] public bool bIsUsedAsAtlasPosition;

            [FieldOffset(8)] byte Curve; //TODO: soft object TSoftObjectPtr<UCurveLinearColor> Curve

            [FieldOffset(56)] byte Atlas; //TODO: soft object TSoftObjectPtr<UCurveLinearColorAtlas> Atlas

        }
}
