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


namespace UE4.LevelSequence{
        ///<summary>Structure for animated Actor objects.</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct LevelSequenceObject {
            [FieldOffset(0)] byte ObjectOrOwner; //TODO: lazy_object TLazyObjectPtr<UObject> ObjectOrOwner

            [FieldOffset(32)] byte ComponentName; //TODO: string FString ComponentName

            [FieldOffset(48)] byte CachedComponent; //TODO: weak object TWeakObjectPtr<UObject> CachedComponent

        }
}
