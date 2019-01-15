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
        ///<summary>Represents the current selection state of a level (its selected actors and components) from a given point in a time, in a way that can be safely restored later even if the level is reloaded</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct SelectionStateOfLevel {
            [FieldOffset(0)] byte SelectedActors; //TODO: array TArray SelectedActors

            [FieldOffset(16)] byte SelectedComponents; //TODO: array TArray SelectedComponents

        }
}
