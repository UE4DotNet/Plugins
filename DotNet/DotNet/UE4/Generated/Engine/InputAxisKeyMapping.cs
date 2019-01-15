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
        ///Defines a mapping between an axis and key
        ///@
        ///</summary>
        ///<remarks>see https://docs.unrealengine.com/latest/INT/Gameplay/Input/index.html</remarks>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct InputAxisKeyMapping {
            [FieldOffset(0)] public Name AxisName;

            [FieldOffset(12)] public float Scale;

            ///<summary>Key to bind it to.</summary>
            [FieldOffset(16)] Key Key;

        }
}
