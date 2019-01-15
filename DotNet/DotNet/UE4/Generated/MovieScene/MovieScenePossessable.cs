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
        ///<summary>MovieScenePossessable is a "typed slot" used to allow the MovieScene to control an already-existing object</summary>
        [StructLayout( LayoutKind.Explicit, Size=72 )]
        public unsafe struct MovieScenePossessable {
            [FieldOffset(0)] byte Tags; //TODO: array TArray Tags

            ///<summary>Unique identifier of the possessable object.</summary>
            ///<remarks>
            ///// @todo sequencer: Guids need to be handled carefully when the asset is duplicated (or loaded after being copied on disk).
            /////                                     Sometimes we'll need to generate fresh Guids.
            ///</remarks>
            [FieldOffset(16)] FGuid FGuid;

            [FieldOffset(32)] byte Name; //TODO: string FString Name

            ///<summary>Type of the object we'll be possessing // @</summary>
            ///<remarks>
            ///todo sequencer: Might be able to be editor-only.  We'll see.
            ///// @todo sequencer: This isn't used for anything yet.  We could use it to gate which types of objects can be bound to a
            ///// possessable "slot" though.  Or we could use it to generate a "preview" spawnable puppet when previewing with no
            ///// possessable object available.
            ///</remarks>
            public SubclassOf<UObject> PossessedObjectClass {
                get {return PossessedObjectClass_class; }
                set {PossessedObjectClass_class = value; }
            }
            [FieldOffset(48)] private IntPtr PossessedObjectClass_class;

            ///<summary>GUID relating to this possessable's parent, if applicable.</summary>
            [FieldOffset(56)] FGuid ParentGuid;

        }
}
