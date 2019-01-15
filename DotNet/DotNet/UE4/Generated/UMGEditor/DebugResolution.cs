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


namespace UE4.UMGEditor{
        ///<summary>Debug Resolution</summary>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct DebugResolution {
            [FieldOffset(0)] public int Width;

            [FieldOffset(4)] public int Height;

            [FieldOffset(8)] byte Description; //TODO: string FString Description

            ///<summary>Color</summary>
            [FieldOffset(24)] LinearColor Color;

        }
}
