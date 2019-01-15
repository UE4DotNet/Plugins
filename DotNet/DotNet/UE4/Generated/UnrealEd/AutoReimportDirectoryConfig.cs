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
        ///<summary>Auto reimport settings for a specific directory</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct AutoReimportDirectoryConfig {
            [FieldOffset(0)] byte SourceDirectory; //TODO: string FString SourceDirectory

            [FieldOffset(16)] byte MountPoint; //TODO: string FString MountPoint

            [FieldOffset(32)] byte Wildcards; //TODO: array TArray Wildcards

        }
}
