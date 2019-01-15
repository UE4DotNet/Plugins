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
    ///<summary>Lightmapped Surface Collection</summary>
    public unsafe partial class LightmappedSurfaceCollection : UObject  {
        ///<summary>The UModel these surfaces come from.</summary>
        public unsafe Model SourceModel {
            get {return LightmappedSurfaceCollection_ptr->SourceModel;}
            set {LightmappedSurfaceCollection_ptr->SourceModel = value;}
        }
         //TODO: array not UObject TArray Surfaces
        static LightmappedSurfaceCollection() {
            StaticClass = Main.GetClass("LightmappedSurfaceCollection");
        }
        internal unsafe LightmappedSurfaceCollection_fields* LightmappedSurfaceCollection_ptr => (LightmappedSurfaceCollection_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LightmappedSurfaceCollection(IntPtr p) => UObject.Make<LightmappedSurfaceCollection>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LightmappedSurfaceCollection DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LightmappedSurfaceCollection New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
