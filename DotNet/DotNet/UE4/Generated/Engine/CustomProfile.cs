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
        ///<summary>Structure for custom profiles.</summary>
        ///<remarks>
        ///if you'd like to just add custom channels, not changing anything else engine defined
        ///if you'd like to override all about profile, please use
        ///+Profiles=(Name=NameOfProfileYouLikeToOverwrite,....)
        ///</remarks>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct CustomProfile {
            [FieldOffset(0)] public Name Name;

            [FieldOffset(16)] byte CustomResponses; //TODO: array TArray CustomResponses

        }
}
