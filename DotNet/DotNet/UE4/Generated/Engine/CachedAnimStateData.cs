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
        ///<summary>
        ///This file contains a number of helper structures that can be used to process state-machine-
        ///related data in C++.
        ///</summary>
        ///<remarks>This includes relevancy, state weights, animation time etc.</remarks>
        [StructLayout( LayoutKind.Explicit, Size=36 )]
        public unsafe struct CachedAnimStateData {
            [FieldOffset(0)] public Name StateMachineName;

            [FieldOffset(12)] public Name StateName;

        }
}
