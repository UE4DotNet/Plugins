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

using UE4.Engine;

namespace UE4.FunctionalTesting{
        ///<summary>AITest Spawn Set</summary>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct AITestSpawnSet {
            [FieldOffset(0)] byte SpawnInfoContainer; //TODO: array TArray SpawnInfoContainer

            [FieldOffset(16)] public Name Name;

            [FieldOffset(28)] public bool bEnabled;

            [FieldOffset(32)] 
            private IntPtr  FallbackSpawnLocation_field;
            ///<summary>location used for spawning if spawn info doesn't define one</summary>
            public Actor FallbackSpawnLocation {
                get {return FallbackSpawnLocation_field;}
                set {FallbackSpawnLocation_field = value;}
            }

        }
}
