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

namespace UE4.GameplayDebugger{
        ///<summary>Gameplay Debugger Player Data</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct GameplayDebuggerPlayerData {
            [FieldOffset(0)] 
            private IntPtr  Controller_field;
            ///<summary>Controller</summary>
            public GameplayDebuggerLocalController Controller {
                get {return Controller_field;}
                set {Controller_field = value;}
            }

            [FieldOffset(8)] 
            private IntPtr  InputComponent_field;
            ///<summary>Input Component</summary>
            public InputComponent InputComponent {
                get {return InputComponent_field;}
                set {InputComponent_field = value;}
            }

            [FieldOffset(16)] 
            private IntPtr  Replicator_field;
            ///<summary>Replicator</summary>
            public GameplayDebuggerCategoryReplicator Replicator {
                get {return Replicator_field;}
                set {Replicator_field = value;}
            }

        }
}
