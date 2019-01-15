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
        ///<summary>Information about net startup actors that need to be rolled back by being destroyed and re-created</summary>
        [StructLayout( LayoutKind.Explicit, Size=168 )]
        public unsafe struct RollbackNetStartupActorInfo {
            [FieldOffset(16)] 
            private IntPtr  Archetype_field;
            ///<summary>Archetype</summary>
            public UObject Archetype {
                get {return Archetype_field;}
                set {Archetype_field = value;}
            }

            [FieldOffset(48)] 
            private IntPtr  Level_field;
            ///<summary>Level</summary>
            public Level Level {
                get {return Level_field;}
                set {Level_field = value;}
            }

            [FieldOffset(152)] byte ObjReferences; //TODO: array TArray ObjReferences

        }
}
