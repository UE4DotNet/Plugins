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


namespace UE4.AnimGraphRuntime{
        ///<summary>Blend List by Enum, it changes based on enum input that enters</summary>
        [StructLayout( LayoutKind.Explicit, Size=232 )]
        public unsafe struct AnimNode_BlendListByEnum {
            [FieldOffset(208)] byte EnumToPoseIndex; //TODO: array TArray EnumToPoseIndex

            [FieldOffset(224)] public byte ActiveEnumValue;

        }
}
