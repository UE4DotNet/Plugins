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
        ///<summary>Category remapping. This allows base engine tag category meta data to remap to multiple project-specific categories.</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct GameplayTagCategoryRemap {
            [FieldOffset(0)] byte BaseCategory; //TODO: string FString BaseCategory

            [FieldOffset(16)] byte RemapCategories; //TODO: array TArray RemapCategories

        }
}
