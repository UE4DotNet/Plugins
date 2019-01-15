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
        ///<summary>Simple struct for a table row in the gameplay tag table and element in the ini list</summary>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct GameplayTagTableRow {
            [FieldOffset(8)] public Name Tag;

            [FieldOffset(24)] byte DevComment; //TODO: string FString DevComment

        }
}
