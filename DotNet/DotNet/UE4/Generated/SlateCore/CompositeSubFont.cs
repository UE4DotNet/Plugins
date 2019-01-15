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


namespace UE4.SlateCore{
        ///<summary>Composite Sub Font</summary>
        [StructLayout( LayoutKind.Explicit, Size=72 )]
        public unsafe struct CompositeSubFont {
            [FieldOffset(24)] byte CharacterRanges; //TODO: array TArray CharacterRanges

            [FieldOffset(40)] byte Cultures; //TODO: string FString Cultures

            [FieldOffset(56)] public Name EditorName;

        }
}
