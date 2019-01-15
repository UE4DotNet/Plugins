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
        ///<summary>Stat Color Mapping</summary>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct StatColorMapping {
            [FieldOffset(0)] byte StatName; //TODO: string FString StatName

            [FieldOffset(16)] byte ColorMap; //TODO: array TArray ColorMap

            [FieldOffset(32)] public bool DisableBlend;

        }
}
