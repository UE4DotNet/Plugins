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

namespace UE4.GameplayDebugger{
        ///<summary>Gameplay Debugger Input Config</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct GameplayDebuggerInputConfig {
            [FieldOffset(0)] byte ConfigName; //TODO: string FString ConfigName

            ///<summary>Key</summary>
            [FieldOffset(16)] Key Key;

            [FieldOffset(48)] public bool bModShift;

            [FieldOffset(48)] public bool bModCtrl;

            [FieldOffset(48)] public bool bModAlt;

            [FieldOffset(48)] public bool bModCmd;

        }
}
