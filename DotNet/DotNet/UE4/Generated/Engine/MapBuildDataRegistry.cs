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
    ///<summary>Map Build Data Registry</summary>
    public unsafe partial class MapBuildDataRegistry : UObject  {
        ///<summary>The lighting quality the level was last built with</summary>
        public unsafe byte LevelLightingQuality {
            get {return MapBuildDataRegistry_ptr->LevelLightingQuality;}
            set {MapBuildDataRegistry_ptr->LevelLightingQuality = value;}
        }
        static MapBuildDataRegistry() {
            StaticClass = Main.GetClass("MapBuildDataRegistry");
        }
        internal unsafe MapBuildDataRegistry_fields* MapBuildDataRegistry_ptr => (MapBuildDataRegistry_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MapBuildDataRegistry(IntPtr p) => UObject.Make<MapBuildDataRegistry>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MapBuildDataRegistry DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MapBuildDataRegistry New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
