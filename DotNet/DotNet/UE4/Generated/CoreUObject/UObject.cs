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
using UE4.CoreUObject.Native;

namespace UE4.CoreUObject {
    ///<summary>Object</summary>
    public unsafe partial class UObject {

        ///<summary>Executes some portion of the ubergraph.</summary>
        ///<remarks>
        ///@param       EntryPoint      The entry point to start code execution at.
        ///</remarks>
        public event ExecuteUbergraph_delegate ExecuteUbergraph;
        public delegate void ExecuteUbergraph_delegate(int EntryPoint);
        internal void on_ExecuteUbergraph(int EntryPoint) =>
            ExecuteUbergraph?.Invoke(EntryPoint);

        static UObject() {
            StaticClass = Main.GetClass("Object");
            UObject_events.ExecuteUbergraph_event.Setup();
        }
        internal unsafe UObject_fields* UObject_ptr => (UObject_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator UObject(IntPtr p) => UObject.Make<UObject>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static UObject DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static UObject New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
