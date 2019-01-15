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
        ///<summary>Movie Scene Property Section Data</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct MovieScenePropertySectionData {
            [FieldOffset(0)] public Name PropertyName;

            [FieldOffset(16)] byte PropertyPath; //TODO: string FString PropertyPath

            [FieldOffset(32)] public Name FunctionName;

            [FieldOffset(44)] public Name NotifyFunctionName;

        }
}
