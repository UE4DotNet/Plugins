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
using UE4.AIModule.Native;

namespace UE4.AIModule {
    ///<summary>Visual Logger Extension</summary>
    public unsafe partial class VisualLoggerExtension : UObject  {
        static VisualLoggerExtension() {
            StaticClass = Main.GetClass("VisualLoggerExtension");
        }
        internal unsafe VisualLoggerExtension_fields* VisualLoggerExtension_ptr => (VisualLoggerExtension_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator VisualLoggerExtension(IntPtr p) => UObject.Make<VisualLoggerExtension>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static VisualLoggerExtension DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static VisualLoggerExtension New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
