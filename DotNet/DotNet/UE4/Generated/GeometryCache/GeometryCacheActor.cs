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
using UE4.GeometryCache.Native;
using UE4.Engine;

namespace UE4.GeometryCache {
    ///<summary>GeometryCache actor, serves as a place-able actor for GeometryCache objects</summary>
    public unsafe partial class GeometryCacheActor : Actor  {

        ///<summary>Returns GeometryCacheComponent subobject *</summary>
        public GeometryCacheComponent GetGeometryCacheComponent()  => 
            GeometryCacheActor_methods.GetGeometryCacheComponent_method.Invoke(ObjPointer);
        ///<summary>Geometry Cache Component</summary>
        public unsafe GeometryCacheComponent GeometryCacheComponent {
            get {return GeometryCacheActor_ptr->GeometryCacheComponent;}
        }
        static GeometryCacheActor() {
            StaticClass = Main.GetClass("GeometryCacheActor");
        }
        internal unsafe GeometryCacheActor_fields* GeometryCacheActor_ptr => (GeometryCacheActor_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GeometryCacheActor(IntPtr p) => UObject.Make<GeometryCacheActor>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GeometryCacheActor DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GeometryCacheActor New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
