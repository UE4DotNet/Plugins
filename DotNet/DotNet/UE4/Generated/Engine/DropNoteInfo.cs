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
        ///<summary>Info about one note dropped in the map during PIE.</summary>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct DropNoteInfo {
            ///<summary>Location to create Note actor in edited level.</summary>
            [FieldOffset(0)] Vector Location;

            ///<summary>Rotation to create Note actor in edited level.</summary>
            [FieldOffset(12)] Rotator Rotation;

            [FieldOffset(24)] byte Comment; //TODO: string FString Comment

        }
}
