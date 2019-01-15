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


namespace UE4.UnrealEd{
        ///<summary>Editor Parameter Group</summary>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct EditorParameterGroup {
            [FieldOffset(0)] public Name GroupName;

            [FieldOffset(12)] public byte GroupAssociation;

            [FieldOffset(16)] byte Parameters; //TODO: array TArray Parameters

            [FieldOffset(32)] public int GroupSortPriority;

        }
}
