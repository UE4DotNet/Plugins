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
        ///<summary>Component Key</summary>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct ComponentKey {
            ///<summary>Owner Class</summary>
            public SubclassOf<UObject> OwnerClass {
                get {return OwnerClass_class; }
                set {OwnerClass_class = value; }
            }
            [FieldOffset(0)] private IntPtr OwnerClass_class;

            [FieldOffset(8)] public Name SCSVariableName;

            ///<summary>Associated Guid</summary>
            [FieldOffset(20)] FGuid AssociatedGuid;

        }
}
