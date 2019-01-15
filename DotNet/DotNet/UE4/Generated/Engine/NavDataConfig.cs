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
        ///<summary>Nav Data Config</summary>
        [StructLayout( LayoutKind.Explicit, Size=128 )]
        public unsafe struct NavDataConfig {
            [FieldOffset(56)] public Name Name;

            ///<summary>Color</summary>
            [FieldOffset(68)] Color Color;

            ///<summary>Default Query Extent</summary>
            [FieldOffset(72)] Vector DefaultQueryExtent;

            ///<summary>mz@todo make sure we handle NavigationDataClass and NavigationDataClassName in PostEditChange</summary>
            public SubclassOf<Actor> NavigationDataClass {
                get {return NavigationDataClass_class; }
                set {NavigationDataClass_class = value; }
            }
            [FieldOffset(88)] private IntPtr NavigationDataClass_class;

            ///<summary>Navigation Data Class Name</summary>
            [FieldOffset(96)] SoftClassPath NavigationDataClassName;

        }
}
