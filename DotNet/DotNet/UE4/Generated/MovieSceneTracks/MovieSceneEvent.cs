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


namespace UE4.MovieSceneTracks{
        ///<summary>Struct type that is bound to a blueprint function entry node, and resolved to a cached UFunction when the blueprint/track is recompiled.</summary>
        ///<remarks>
        ///Events can be bound to either of the following function signatures:
        ///
        ///  1. A function with no parameters (and no return value).
        ///    - Compatible with master tracks or object bindings
        ///    - No context passed through to event
        ///
        ///  2. A function with a single object or interface parameter (and no return value).
        ///    - Compatible with master tracks or object bindings
        ///    - Will be triggered with objects in the following order:
        ///        - Objects bound to the track's object binding, or:
        ///        - Objects specified on the track's event receivers array, or:
        ///        - Objects provided by the playback context.
        ///    - Will only trigger if the specified object is of the same type as the parameter (or interface)
        ///</remarks>
        [StructLayout( LayoutKind.Explicit, Size=20 )]
        public unsafe struct MovieSceneEvent {
            [FieldOffset(0)] public Name FunctionName;

            [FieldOffset(12)] byte FunctionEntry; //TODO: weak object TWeakObjectPtr<UObject> FunctionEntry

        }
}
