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
        ///<summary>Rig Configuration</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct RigConfiguration {
            [FieldOffset(0)] 
            private IntPtr  Rig_field;
            ///<summary>Rig</summary>
            public Rig Rig {
                get {return Rig_field;}
                set {Rig_field = value;}
            }

            [FieldOffset(8)] byte BoneMappingTable; //TODO: array TArray BoneMappingTable

        }
}
