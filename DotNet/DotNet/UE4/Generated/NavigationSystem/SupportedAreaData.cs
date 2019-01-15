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


namespace UE4.NavigationSystem{
        ///<summary>Supported Area Data</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct SupportedAreaData {
            [FieldOffset(0)] byte AreaClassName; //TODO: string FString AreaClassName

            [FieldOffset(16)] public int AreaID;

            ///<summary>Area Class</summary>
            public SubclassOf<UObject> AreaClass {
                get {return AreaClass_class; }
                set {AreaClass_class = value; }
            }
            [FieldOffset(24)] private IntPtr AreaClass_class;

        }
}
