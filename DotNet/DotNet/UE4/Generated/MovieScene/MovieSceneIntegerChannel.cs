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
        ///<summary>Movie Scene Integer Channel</summary>
        [StructLayout( LayoutKind.Explicit, Size=144 )]
        public unsafe struct MovieSceneIntegerChannel {
            [FieldOffset(8)] byte Times; //TODO: array TArray Times

            [FieldOffset(24)] public int DefaultValue;

            [FieldOffset(28)] public bool bHasDefaultValue;

            [FieldOffset(32)] byte Values; //TODO: array TArray Values

        }
}
