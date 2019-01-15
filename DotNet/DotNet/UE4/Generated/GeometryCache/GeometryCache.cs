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
    ///<summary>A Geometry Cache is a piece/set of geometry that consists of individual Mesh/Transformation samples.</summary>
    ///<remarks>In contrast with Static Meshes they can have their vertices animated in certain ways. *</remarks>
    public unsafe partial class GeometryCache : UObject  {
        ///<summary>Importing data and options used for this Geometry cache object</summary>
        public unsafe AssetImportData AssetImportData {
            get {return GeometryCache_ptr->AssetImportData;}
            set {GeometryCache_ptr->AssetImportData = value;}
        }
        ///<summary>Information for thumbnail rendering</summary>
        public unsafe ThumbnailInfo ThumbnailInfo {
            get {return GeometryCache_ptr->ThumbnailInfo;}
            set {GeometryCache_ptr->ThumbnailInfo = value;}
        }
        ///<summary>Materials</summary>
        public ObjectArrayField<MaterialInterface> Materials{ get {
            if(Materials_store == null) Materials_store = new ObjectArrayField<MaterialInterface> (&GeometryCache_ptr->Materials);
            return Materials_store;
        } }
        private ObjectArrayField<MaterialInterface> Materials_store;

        ///<summary>GeometryCache track defining the samples/geometry data for this GeomCache instance</summary>
        public ObjectArrayField<GeometryCacheTrack> Tracks{ get {
            if(Tracks_store == null) Tracks_store = new ObjectArrayField<GeometryCacheTrack> (&GeometryCache_ptr->Tracks);
            return Tracks_store;
        } }
        private ObjectArrayField<GeometryCacheTrack> Tracks_store;

        ///<summary>Start Frame</summary>
        public unsafe int StartFrame {
            get {return GeometryCache_ptr->StartFrame;}
        }
        ///<summary>End Frame</summary>
        public unsafe int EndFrame {
            get {return GeometryCache_ptr->EndFrame;}
        }
        static GeometryCache() {
            StaticClass = Main.GetClass("GeometryCache");
        }
        internal unsafe GeometryCache_fields* GeometryCache_ptr => (GeometryCache_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GeometryCache(IntPtr p) => UObject.Make<GeometryCache>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GeometryCache DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GeometryCache New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
