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
        ///<summary>
        ///Defines a mapping between an action and key
        ///@
        ///</summary>
        ///<remarks>see https://docs.unrealengine.com/latest/INT/Gameplay/Input/index.html</remarks>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct InputActionKeyMapping {
            [FieldOffset(0)] public Name ActionName;

            [FieldOffset(12)] public bool bShift;

            [FieldOffset(12)] public bool bCtrl;

            [FieldOffset(12)] public bool bAlt;

            [FieldOffset(12)] public bool bCmd;

            ///<summary>Key to bind it to.</summary>
            [FieldOffset(16)] Key Key;

        }
}
