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


namespace UE4.MagicLeapIdentity{
        ///<summary>Represents an attribute and its value of a user's profile.</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct MagicLeapIdentityAttribute {
            [FieldOffset(0)] byte Attribute; //TODO: enum EMagicLeapIdentityKey Attribute

            [FieldOffset(8)] byte Value; //TODO: string FString Value

        }
}
