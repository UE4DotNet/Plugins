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
        ///This is used for redirecting old name to new name
        ///We use manually parsing array, but that makes harder to modify from property setting
        ///</summary>
        ///<remarks>So adding this USTRUCT to support it properly</remarks>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct Redirector {
            [FieldOffset(0)] public Name OldName;

            [FieldOffset(12)] public Name NewName;

        }
}
