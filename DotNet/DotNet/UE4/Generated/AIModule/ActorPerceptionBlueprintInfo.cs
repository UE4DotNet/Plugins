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

namespace UE4.AIModule{
        ///<summary>Actor Perception Blueprint Info</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct ActorPerceptionBlueprintInfo {
            [FieldOffset(0)] 
            private IntPtr  Target_field;
            ///<summary>Target</summary>
            public Actor Target {
                get {return Target_field;}
                set {Target_field = value;}
            }

            [FieldOffset(8)] byte LastSensedStimuli; //TODO: array TArray LastSensedStimuli

            [FieldOffset(24)] public bool bIsHostile;

        }
}
