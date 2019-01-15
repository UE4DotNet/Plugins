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
    ///<summary>A volume that can be added a level in order to remove triangles from source meshes before generating HLOD or merged meshes</summary>
    public unsafe partial class MeshMergeCullingVolume : Volume  {
        static MeshMergeCullingVolume() {
            StaticClass = Main.GetClass("MeshMergeCullingVolume");
        }
        internal unsafe MeshMergeCullingVolume_fields* MeshMergeCullingVolume_ptr => (MeshMergeCullingVolume_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MeshMergeCullingVolume(IntPtr p) => UObject.Make<MeshMergeCullingVolume>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MeshMergeCullingVolume DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MeshMergeCullingVolume New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
