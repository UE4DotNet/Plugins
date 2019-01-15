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
        ///<summary>Physics Constraint Profile Handle</summary>
        [StructLayout( LayoutKind.Explicit, Size=272 )]
        public unsafe struct PhysicsConstraintProfileHandle {
            ///<summary>Profile Properties</summary>
            [FieldOffset(0)] ConstraintProfileProperties ProfileProperties;

            [FieldOffset(260)] public Name ProfileName;

        }
}
