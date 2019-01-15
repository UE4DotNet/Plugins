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
        ///<summary>Handles the many pieces of data passed into Client Receive</summary>
        [StructLayout( LayoutKind.Explicit, Size=64 )]
        public unsafe struct ClientReceiveData {
            [FieldOffset(0)] 
            private IntPtr  LocalPC_field;
            ///<summary>Local PC</summary>
            public PlayerController LocalPC {
                get {return LocalPC_field;}
                set {LocalPC_field = value;}
            }

            [FieldOffset(8)] public Name MessageType;

            [FieldOffset(20)] public int MessageIndex;

            [FieldOffset(24)] byte MessageString; //TODO: string FString MessageString

            [FieldOffset(40)] 
            private IntPtr  RelatedPlayerState_1_field;
            ///<summary>Related Player State 1</summary>
            public PlayerState RelatedPlayerState_1 {
                get {return RelatedPlayerState_1_field;}
                set {RelatedPlayerState_1_field = value;}
            }

            [FieldOffset(48)] 
            private IntPtr  RelatedPlayerState_2_field;
            ///<summary>Related Player State 2</summary>
            public PlayerState RelatedPlayerState_2 {
                get {return RelatedPlayerState_2_field;}
                set {RelatedPlayerState_2_field = value;}
            }

            [FieldOffset(56)] 
            private IntPtr  OptionalObject_field;
            ///<summary>Optional Object</summary>
            public UObject OptionalObject {
                get {return OptionalObject_field;}
                set {OptionalObject_field = value;}
            }

        }
}
