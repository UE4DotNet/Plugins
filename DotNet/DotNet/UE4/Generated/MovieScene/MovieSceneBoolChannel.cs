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


namespace UE4.MovieScene{
        ///<summary>Movie Scene Bool Channel</summary>
        [StructLayout( LayoutKind.Explicit, Size=144 )]
        public unsafe struct MovieSceneBoolChannel {
            [FieldOffset(8)] byte Times; //TODO: array TArray Times

            [FieldOffset(24)] public bool DefaultValue;

            [FieldOffset(25)] public bool bHasDefaultValue;

            [FieldOffset(32)] byte Values; //TODO: array TArray Values

        }
}
