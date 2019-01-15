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
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>Represents a secondary split screen connection that reroutes calls to the parent connection.</summary>
    public unsafe partial class ChildConnection : NetConnection  {
        ///<summary>Parent</summary>
        public unsafe NetConnection Parent {
            get {return ChildConnection_ptr->Parent;}
            set {ChildConnection_ptr->Parent = value;}
        }
        static ChildConnection() {
            StaticClass = Main.GetClass("ChildConnection");
        }
        internal unsafe ChildConnection_fields* ChildConnection_ptr => (ChildConnection_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ChildConnection(IntPtr p) => UObject.Make<ChildConnection>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ChildConnection DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ChildConnection New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
