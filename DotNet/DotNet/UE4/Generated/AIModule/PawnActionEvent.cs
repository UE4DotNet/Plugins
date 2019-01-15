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


namespace UE4.AIModule{
        ///<summary>Pawn Action Event</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct PawnActionEvent {
            [FieldOffset(0)] 
            private IntPtr  Action_field;
            ///<summary>Action</summary>
            public PawnAction Action {
                get {return Action_field;}
                set {Action_field = value;}
            }

        }
}
