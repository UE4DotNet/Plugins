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
        ///<summary>An external reference to an level sequence object, resolvable through an arbitrary context.</summary>
        ///<remarks>
        ///Bindings consist of an optional package name, and the path to the object within that package.
        ///Where package name is empty, the reference is a relative path from a specific outer (the context).
        ///Currently, the package name should only ever be empty for component references, which must remain relative bindings to work correctly with spawnables and reinstanced actors.
        ///</remarks>
        [StructLayout( LayoutKind.Explicit, Size=64 )]
        public unsafe struct LevelSequenceBindingReference {
            ///<summary>Path to a specific actor/component inside an external package</summary>
            [FieldOffset(16)] SoftObjectPath ExternalObjectPath;

            [FieldOffset(48)] byte ObjectPath; //TODO: string FString ObjectPath

        }
}
