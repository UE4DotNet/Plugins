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
        ///<summary>Env Query Result</summary>
        [StructLayout( LayoutKind.Explicit, Size=64 )]
        public unsafe struct EnvQueryResult {
            ///<summary>type of generated items</summary>
            public SubclassOf<EnvQueryItemType> ItemType {
                get {return ItemType_class; }
            }
            [FieldOffset(16)] private IntPtr ItemType_class;

            [FieldOffset(44)] public int OptionIndex;

            [FieldOffset(48)] public int QueryID;

        }
}
