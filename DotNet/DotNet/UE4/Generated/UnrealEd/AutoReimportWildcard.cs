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
        ///<summary>A filter used by the auto reimport manager to explicitly include/exclude files matching the specified wildcard</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct AutoReimportWildcard {
            [FieldOffset(0)] byte Wildcard; //TODO: string FString Wildcard

            [FieldOffset(16)] public bool bInclude;

        }
}
