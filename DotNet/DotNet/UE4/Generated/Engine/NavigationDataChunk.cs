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
    ///<summary>Navigation Data Chunk</summary>
    public unsafe partial class NavigationDataChunk : UObject  {
        ///<summary>Name of NavigationData actor that owns this chunk</summary>
        public unsafe Name NavigationDataName {
            get {return NavigationDataChunk_ptr->NavigationDataName;}
            set {NavigationDataChunk_ptr->NavigationDataName = value;}
        }
        static NavigationDataChunk() {
            StaticClass = Main.GetClass("NavigationDataChunk");
        }
        internal unsafe NavigationDataChunk_fields* NavigationDataChunk_ptr => (NavigationDataChunk_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator NavigationDataChunk(IntPtr p) => UObject.Make<NavigationDataChunk>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static NavigationDataChunk DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static NavigationDataChunk New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
