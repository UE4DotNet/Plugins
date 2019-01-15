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

namespace UE4.Engine{
        ///<summary>Struct containing mappings for legacy method of binding keys to exec commands.</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct KeyBind {
            ///<summary>The key to be bound to the command</summary>
            [FieldOffset(0)] Key Key;

            [FieldOffset(32)] byte Command; //TODO: string FString Command

            [FieldOffset(48)] public bool Control;

            [FieldOffset(48)] public bool Shift;

            [FieldOffset(48)] public bool Alt;

            [FieldOffset(48)] public bool Cmd;

            [FieldOffset(48)] public bool bIgnoreCtrl;

            [FieldOffset(48)] public bool bIgnoreShift;

            [FieldOffset(48)] public bool bIgnoreAlt;

            [FieldOffset(48)] public bool bIgnoreCmd;

            [FieldOffset(49)] public bool bDisabled;

        }
}
