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


namespace UE4.BlueprintGraph{
        ///<summary>Action to add a node to the graph</summary>
        [StructLayout( LayoutKind.Explicit, Size=264 )]
        public unsafe struct EdGraphSchemaAction_EventFromFunction {
            [FieldOffset(256)] 
            private IntPtr  SignatureFunction_field;
            ///<summary>Signature Function</summary>
            public Function SignatureFunction {
                get {return SignatureFunction_field;}
                set {SignatureFunction_field = value;}
            }

        }
}
