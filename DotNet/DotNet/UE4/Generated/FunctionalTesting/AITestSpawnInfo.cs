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
using UE4.AIModule;

namespace UE4.FunctionalTesting{
        ///<summary>AITest Spawn Info</summary>
        [StructLayout( LayoutKind.Explicit, Size=64 )]
        public unsafe struct AITestSpawnInfo {
            ///<summary>Determines AI to be spawned</summary>
            public SubclassOf<Pawn> PawnClass {
                get {return PawnClass_class; }
                set {PawnClass_class = value; }
            }
            [FieldOffset(0)] private IntPtr PawnClass_class;

            ///<summary>class to override default pawn's controller class. If None the default will be used</summary>
            public SubclassOf<AIController> ControllerClass {
                get {return ControllerClass_class; }
                set {ControllerClass_class = value; }
            }
            [FieldOffset(8)] private IntPtr ControllerClass_class;

            ///<summary>Team ID</summary>
            [FieldOffset(16)] GenericTeamId TeamID;

            [FieldOffset(24)] 
            private IntPtr  BehaviorTree_field;
            ///<summary>if set will be applied to spawned AI</summary>
            public BehaviorTree BehaviorTree {
                get {return BehaviorTree_field;}
                set {BehaviorTree_field = value;}
            }

            [FieldOffset(32)] 
            private IntPtr  SpawnLocation_field;
            ///<summary>Where should AI be spawned</summary>
            public Actor SpawnLocation {
                get {return SpawnLocation_field;}
                set {SpawnLocation_field = value;}
            }

            [FieldOffset(40)] public int NumberToSpawn;

            [FieldOffset(44)] public float SpawnDelay;

            [FieldOffset(48)] public float PreSpawnDelay;

        }
}
