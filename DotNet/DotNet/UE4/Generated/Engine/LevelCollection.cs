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
        ///<summary>
        ///Contains a group of levels of a particular ELevelCollectionType within a UWorld
        ///and the context required to properly tick/update those levels.
        ///</summary>
        ///<remarks>This object is move-only.</remarks>
        [StructLayout( LayoutKind.Explicit, Size=128 )]
        public unsafe struct LevelCollection {
            [FieldOffset(8)] 
            private IntPtr  GameState_field;
            ///<summary>The GameState associated with this collection.</summary>
            ///<remarks>
            ///This may be different than the UWorld's GameState
            ///since the source collection and the duplicated collection will have their own instances.
            ///</remarks>
            public GameStateBase GameState {
                get {return GameState_field;}
                set {GameState_field = value;}
            }

            [FieldOffset(16)] 
            private IntPtr  NetDriver_field;
            ///<summary>The network driver associated with this collection.</summary>
            ///<remarks>The source collection and the duplicated collection will have their own instances.</remarks>
            public NetDriver NetDriver {
                get {return NetDriver_field;}
                set {NetDriver_field = value;}
            }

            [FieldOffset(24)] 
            private IntPtr  DemoNetDriver_field;
            ///<summary>The demo network driver associated with this collection.</summary>
            ///<remarks>The source collection and the duplicated collection will have their own instances.</remarks>
            public DemoNetDriver DemoNetDriver {
                get {return DemoNetDriver_field;}
                set {DemoNetDriver_field = value;}
            }

            [FieldOffset(32)] 
            private IntPtr  PersistentLevel_field;
            ///<summary>The persistent level associated with this collection.</summary>
            ///<remarks>The source collection and the duplicated collection will have their own instances.</remarks>
            public Level PersistentLevel {
                get {return PersistentLevel_field;}
                set {PersistentLevel_field = value;}
            }

            [FieldOffset(40)] byte Levels; //TODO: set TSet Levels

        }
}
