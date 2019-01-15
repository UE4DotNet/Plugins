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


namespace UE4.Engine{
        ///<summary>Cached Anim Transition Data</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct CachedAnimTransitionData {
            [FieldOffset(0)] public Name StateMachineName;

            [FieldOffset(12)] public Name FromStateName;

            [FieldOffset(24)] public Name ToStateName;

        }
}
