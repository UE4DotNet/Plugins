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
        ///<summary>Structure for collision response templates.</summary>
        [StructLayout( LayoutKind.Explicit, Size=104 )]
        public unsafe struct CollisionResponseTemplate {
            [FieldOffset(0)] public Name Name;

            [FieldOffset(12)] public byte CollisionEnabled;

            [FieldOffset(16)] public Name ObjectTypeName;

            [FieldOffset(32)] byte CustomResponses; //TODO: array TArray CustomResponses

            [FieldOffset(48)] byte HelpMessage; //TODO: string FString HelpMessage

            [FieldOffset(64)] public bool bCanModify;

        }
}
