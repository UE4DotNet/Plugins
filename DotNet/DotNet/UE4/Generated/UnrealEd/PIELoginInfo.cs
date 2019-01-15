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
        ///<summary>Data structure for storing PIE login credentials</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct PIELoginInfo {
            [FieldOffset(0)] byte Type; //TODO: string FString Type

            [FieldOffset(16)] byte Id; //TODO: string FString Id

            [FieldOffset(32)] byte Token; //TODO: string FString Token

        }
}
