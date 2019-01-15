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
        ///<summary>Implements a key -> value pair for the per-instance view port settings</summary>
        [StructLayout( LayoutKind.Explicit, Size=112 )]
        public unsafe struct LevelEditorViewportInstanceSettingsKeyValuePair {
            [FieldOffset(0)] byte ConfigName; //TODO: string FString ConfigName

            ///<summary>Settings for this config.</summary>
            [FieldOffset(16)] LevelEditorViewportInstanceSettings ConfigSettings;

        }
}
