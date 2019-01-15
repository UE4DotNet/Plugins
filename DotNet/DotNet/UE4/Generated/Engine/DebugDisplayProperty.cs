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
        ///<summary>
        ///Debug property display functionality to interact with this, use "display", "displayall", "displayclear"
        ///@
        ///</summary>
        ///<remarks>
        ///see UGameViewportClient
        ///@see FDebugDisplayProperty
        ///@see DrawStatsHUD
        ///</remarks>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct DebugDisplayProperty {
            [FieldOffset(0)] 
            private IntPtr  Obj_field;
            ///<summary>the object whose property to display. If this is a class, all objects of that class are drawn.</summary>
            public UObject Obj {
                get {return Obj_field;}
                set {Obj_field = value;}
            }

            ///<summary>if Obj is a class and WithinClass is not nullptr, further limit the display to objects that have an Outer of WithinClass</summary>
            public SubclassOf<UObject> WithinClass {
                get {return WithinClass_class; }
                set {WithinClass_class = value; }
            }
            [FieldOffset(8)] private IntPtr WithinClass_class;

        }
}
