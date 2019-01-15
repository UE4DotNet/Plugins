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
        ///<summary>Dialogue Context</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct DialogueContext {
            [FieldOffset(0)] 
            private IntPtr  Speaker_field;
            ///<summary>The person speaking the dialogue.</summary>
            public DialogueVoice Speaker {
                get {return Speaker_field;}
                set {Speaker_field = value;}
            }

            [FieldOffset(8)] byte Targets; //TODO: array TArray Targets

        }
}
