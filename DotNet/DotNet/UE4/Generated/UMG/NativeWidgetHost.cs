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

#pragma warning disable CS0108
using UE4.UMG.Native;

namespace UE4.UMG {
    ///<summary>A NativeWidgetHost is a container widget that can contain one child slate widget.</summary>
    ///<remarks>
    ///This should
    ///be used when all you need is to nest a native widget inside a UMG widget.
    ///</remarks>
    public unsafe partial class NativeWidgetHost : Widget  {
        static NativeWidgetHost() {
            StaticClass = Main.GetClass("NativeWidgetHost");
        }
        internal unsafe NativeWidgetHost_fields* NativeWidgetHost_ptr => (NativeWidgetHost_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator NativeWidgetHost(IntPtr p) => UObject.Make<NativeWidgetHost>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static NativeWidgetHost DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static NativeWidgetHost New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
