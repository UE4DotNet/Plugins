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


namespace UE4.GameplayTags{
        ///<summary>A single redirect from a deleted tag to the new tag that should replace it</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct GameplayTagRedirect {
            [FieldOffset(0)] public Name OldTagName;

            [FieldOffset(12)] public Name NewTagName;

        }
}
