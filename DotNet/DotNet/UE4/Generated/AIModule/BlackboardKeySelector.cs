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
        ///<summary>
        ///helper struct for defining types of allowed blackboard entries
        ///(e.
        ///</summary>
        ///<remarks>g. only entries holding points and objects derived form actor class)</remarks>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct BlackboardKeySelector {
            [FieldOffset(0)] byte AllowedTypes; //TODO: array TArray AllowedTypes

            [FieldOffset(16)] public Name SelectedKeyName;

            ///<summary>class of selected key</summary>
            public SubclassOf<BlackboardKeyType> SelectedKeyType {
                get {return SelectedKeyType_class; }
                set {SelectedKeyType_class = value; }
            }
            [FieldOffset(32)] private IntPtr SelectedKeyType_class;

            [FieldOffset(40)] public byte SelectedKeyID;

            [FieldOffset(44)] public bool bNoneIsAllowedValue;

        }
}
