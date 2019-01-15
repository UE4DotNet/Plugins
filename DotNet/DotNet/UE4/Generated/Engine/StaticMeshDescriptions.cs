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
    ///<summary>Container UObject which holds a MeshDescription for every SourceModel LOD.</summary>
    ///<remarks>
    ///Eventually this will be outered to the static mesh's package, so the data is saved along with the static mesh, but will not be referenced by it.
    ///The static mesh can later load the mesh description container on demand.
    ///</remarks>
    public unsafe partial class StaticMeshDescriptions : UObject  {
        static StaticMeshDescriptions() {
            StaticClass = Main.GetClass("StaticMeshDescriptions");
        }
        internal unsafe StaticMeshDescriptions_fields* StaticMeshDescriptions_ptr => (StaticMeshDescriptions_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator StaticMeshDescriptions(IntPtr p) => UObject.Make<StaticMeshDescriptions>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static StaticMeshDescriptions DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static StaticMeshDescriptions New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
