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
        ///<summary>Preview items that are attached to the skeleton *</summary>
        [StructLayout( LayoutKind.Explicit, Size=72 )]
        public unsafe struct PreviewAttachedObjectPair {
            [FieldOffset(0)] byte AttachedObject; //TODO: soft object TSoftObjectPtr<UObject> AttachedObject

            [FieldOffset(56)] public Name AttachedTo;

        }
}
