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


namespace UE4.UnrealEd{
        ///<summary>Action to add an expression node to the graph</summary>
        [StructLayout( LayoutKind.Explicit, Size=264 )]
        public unsafe struct MaterialGraphSchemaAction_NewNode {
            ///<summary>Class of expression we want to create</summary>
            public SubclassOf<UObject> MaterialExpressionClass {
                get {return MaterialExpressionClass_class; }
                set {MaterialExpressionClass_class = value; }
            }
            [FieldOffset(256)] private IntPtr MaterialExpressionClass_class;

        }
}
