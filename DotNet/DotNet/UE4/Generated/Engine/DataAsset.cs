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
    ///<summary>Base class for a simple asset containing data. The editor will list this in the content browser if you inherit from this class</summary>
    public unsafe partial class DataAsset : UObject  {
        ///<summary>Native Class</summary>
        public unsafe SubclassOf<DataAsset> NativeClass {
            get {return DataAsset_ptr->NativeClass;}
            set {DataAsset_ptr->NativeClass = value;}
        }
        static DataAsset() {
            StaticClass = Main.GetClass("DataAsset");
        }
        internal unsafe DataAsset_fields* DataAsset_ptr => (DataAsset_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DataAsset(IntPtr p) => UObject.Make<DataAsset>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DataAsset DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DataAsset New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
