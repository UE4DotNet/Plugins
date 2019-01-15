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
        ///<summary>Rig Controller for bone transform *</summary>
        [StructLayout( LayoutKind.Explicit, Size=112 )]
        public unsafe struct Node {
            [FieldOffset(0)] public Name Name;

            [FieldOffset(12)] public Name ParentName;

            ///<summary>Absolute transform of the node. Hoping to use this data in the future to render</summary>
            [FieldOffset(32)] Transform Transform;

            [FieldOffset(80)] byte DisplayName; //TODO: string FString DisplayName

            [FieldOffset(96)] public bool bAdvanced;

        }
}
