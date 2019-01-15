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
        ///<summary>Latent action info</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct LatentActionInfo {
            [FieldOffset(0)] public int Linkage;

            [FieldOffset(4)] public int UUID;

            [FieldOffset(8)] public Name ExecutionFunction;

            [FieldOffset(24)] 
            private IntPtr  CallbackTarget_field;
            ///<summary>Object to execute the function on.</summary>
            public UObject CallbackTarget {
                get {return CallbackTarget_field;}
                set {CallbackTarget_field = value;}
            }

        }
}
