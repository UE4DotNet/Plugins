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


namespace UE4.AnimationCore{
        ///<summary>Constraint data container.</summary>
        ///<remarks>
        ///It contains union of Constraints and node will contain array of these.
        ///
        ///These are the one contained in NodeData, and it will be iterated via evaluate process
        ///The goal is to have contiguous memory location where they can iterate through linearly
        ///</remarks>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct ConstraintDescriptor {
            [FieldOffset(0)] byte Type; //TODO: enum EConstraintType Type

        }
}
