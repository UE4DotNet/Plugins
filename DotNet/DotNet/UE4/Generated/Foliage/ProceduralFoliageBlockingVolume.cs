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
using UE4.Foliage.Native;
using UE4.Engine;

namespace UE4.Foliage {
    ///<summary>An invisible volume used to block ProceduralFoliage instances from being spawned.</summary>
    public unsafe partial class ProceduralFoliageBlockingVolume : Volume  {
        ///<summary>Procedural Foliage Volume</summary>
        public unsafe ProceduralFoliageVolume ProceduralFoliageVolume {
            get {return ProceduralFoliageBlockingVolume_ptr->ProceduralFoliageVolume;}
            set {ProceduralFoliageBlockingVolume_ptr->ProceduralFoliageVolume = value;}
        }
        static ProceduralFoliageBlockingVolume() {
            StaticClass = Main.GetClass("ProceduralFoliageBlockingVolume");
        }
        internal unsafe ProceduralFoliageBlockingVolume_fields* ProceduralFoliageBlockingVolume_ptr => (ProceduralFoliageBlockingVolume_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ProceduralFoliageBlockingVolume(IntPtr p) => UObject.Make<ProceduralFoliageBlockingVolume>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ProceduralFoliageBlockingVolume DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ProceduralFoliageBlockingVolume New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
