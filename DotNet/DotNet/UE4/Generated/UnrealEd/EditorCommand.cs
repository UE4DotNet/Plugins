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
        ///<summary>A parameterless exec command that can be bound to hotkeys and menu items in the editor.</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct EditorCommand {
            [FieldOffset(0)] public Name Parent;

            [FieldOffset(12)] public Name CommandName;

            [FieldOffset(24)] byte ExecCommand; //TODO: string FString ExecCommand

            [FieldOffset(40)] byte Description; //TODO: string FString Description

        }
}
