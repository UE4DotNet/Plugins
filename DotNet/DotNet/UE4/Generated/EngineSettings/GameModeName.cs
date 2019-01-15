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


namespace UE4.EngineSettings{
        ///<summary>Helper structure, used to associate GameModes with shortcut names.</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct GameModeName {
            [FieldOffset(0)] byte Name; //TODO: string FString Name

            ///<summary>GameMode class to load</summary>
            [FieldOffset(16)] SoftClassPath GameMode;

        }
}
