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
        ///<summary>MovieSceneSpawnable describes an object that can be spawned for this MovieScene</summary>
        [StructLayout( LayoutKind.Explicit, Size=160 )]
        public unsafe struct MovieSceneSpawnable {
            ///<summary>Optional spawn transform</summary>
            [FieldOffset(0)] Transform SpawnTransform;

            [FieldOffset(48)] byte Tags; //TODO: array TArray Tags

            ///<summary>Unique identifier of the spawnable object.</summary>
            ///<remarks>
            ///// @todo sequencer: Guids need to be handled carefully when the asset is duplicated (or loaded after being copied on disk).
            /////                                     Sometimes we'll need to generate fresh Guids.
            ///</remarks>
            [FieldOffset(64)] FGuid FGuid;

            [FieldOffset(80)] byte Name; //TODO: string FString Name

            [FieldOffset(96)] 
            private IntPtr  ObjectTemplate_field;
            ///<summary>Object Template</summary>
            public UObject ObjectTemplate {
                get {return ObjectTemplate_field;}
                set {ObjectTemplate_field = value;}
            }

            [FieldOffset(104)] byte ChildPossessables; //TODO: array TArray ChildPossessables

            [FieldOffset(120)] byte Ownership; //TODO: enum ESpawnOwnership Ownership

            [FieldOffset(136)] public Name LevelName;

        }
}
