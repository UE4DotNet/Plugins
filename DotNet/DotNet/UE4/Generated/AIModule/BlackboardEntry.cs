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
        ///<summary>blackboard entry definition</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct BlackboardEntry {
            [FieldOffset(0)] public Name EntryName;

            [FieldOffset(16)] byte EntryDescription; //TODO: string FString EntryDescription

            [FieldOffset(32)] 
            private IntPtr  KeyType_field;
            ///<summary>key type and additional properties</summary>
            public BlackboardKeyType KeyType {
                get {return KeyType_field;}
                set {KeyType_field = value;}
            }

            [FieldOffset(40)] public bool bInstanceSynced;

        }
}
