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

using UE4.InputCore;

namespace UE4.UnrealEd{
        ///<summary>An editor hotkey binding to a parameterless exec.</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct EditorKeyBinding {
            [FieldOffset(0)] public bool bCtrlDown;

            [FieldOffset(0)] public bool bAltDown;

            [FieldOffset(0)] public bool bShiftDown;

            ///<summary>Key</summary>
            [FieldOffset(8)] Key Key;

            [FieldOffset(40)] public Name CommandName;

        }
}
