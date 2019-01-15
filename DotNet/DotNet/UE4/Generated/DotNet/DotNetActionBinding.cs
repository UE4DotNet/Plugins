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
using UE4.DotNet.Native;
using UE4.Engine;

namespace UE4.DotNet {
    ///<summary>Dot Net Action Binding</summary>
    public unsafe partial class DotNetActionBinding : UObject  {
        ///<summary>Action Name</summary>
        public unsafe Name ActionName {
            get {return DotNetActionBinding_ptr->ActionName;}
        }
        ///<summary>Input</summary>
        public unsafe InputComponent Input {
            get {return DotNetActionBinding_ptr->Input;}
        }
        ///<summary>Input Event</summary>
        public unsafe byte InputEvent {
            get {return DotNetActionBinding_ptr->InputEvent;}
        }
        static DotNetActionBinding() {
            StaticClass = Main.GetClass("DotNetActionBinding");
        }
        internal unsafe DotNetActionBinding_fields* DotNetActionBinding_ptr => (DotNetActionBinding_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DotNetActionBinding(IntPtr p) => UObject.Make<DotNetActionBinding>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DotNetActionBinding DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DotNetActionBinding New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
