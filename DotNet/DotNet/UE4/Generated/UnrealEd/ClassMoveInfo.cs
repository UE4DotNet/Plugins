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
        ///<summary>Used during asset renaming/duplication to specify class-specific package/group targets.</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct ClassMoveInfo {
            [FieldOffset(0)] byte ClassName; //TODO: string FString ClassName

            [FieldOffset(16)] byte PackageName; //TODO: string FString PackageName

            [FieldOffset(32)] byte GroupName; //TODO: string FString GroupName

            [FieldOffset(48)] public bool bActive;

        }
}
