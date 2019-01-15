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


namespace UE4.LevelSequence{
        ///<summary>Structure that stores a one to many mapping from object binding ID, to object references that pertain to that ID.</summary>
        [StructLayout( LayoutKind.Explicit, Size=160 )]
        public unsafe struct LevelSequenceBindingReferences {
            [FieldOffset(0)] byte BindingIdToReferences; //TODO: map TMap BindingIdToReferences

            [FieldOffset(80)] byte AnimSequenceInstances; //TODO: set TSet AnimSequenceInstances

        }
}
