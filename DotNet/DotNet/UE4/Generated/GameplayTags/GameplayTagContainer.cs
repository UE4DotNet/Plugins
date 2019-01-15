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
        ///<summary>A Tag Container holds a collection of FGameplayTags, tags are included explicitly by adding them, and implicitly from adding child tags</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct GameplayTagContainer {
            [FieldOffset(0)] byte GameplayTags; //TODO: array TArray GameplayTags

            [FieldOffset(16)] byte ParentTags; //TODO: array TArray ParentTags

        }
}
