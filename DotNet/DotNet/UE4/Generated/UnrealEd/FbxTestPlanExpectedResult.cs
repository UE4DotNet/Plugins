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
        ///<summary>Container for detailing collision automated test data.</summary>
        [StructLayout( LayoutKind.Explicit, Size=72 )]
        public unsafe struct FbxTestPlanExpectedResult {
            [FieldOffset(0)] public byte ExpectedPresetsType;

            [FieldOffset(8)] byte ExpectedPresetsDataInteger; //TODO: array TArray ExpectedPresetsDataInteger

            [FieldOffset(24)] byte ExpectedPresetsDataFloat; //TODO: array TArray ExpectedPresetsDataFloat

            [FieldOffset(40)] byte ExpectedPresetsDataDouble; //TODO: array TArray ExpectedPresetsDataDouble

            [FieldOffset(56)] byte ExpectedPresetsDataString; //TODO: array TArray ExpectedPresetsDataString

        }
}
