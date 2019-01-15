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
using UE4.CustomMeshComponent.Native;
using UE4.Engine;

namespace UE4.CustomMeshComponent {
    ///<summary>Component that allows you to specify custom triangle mesh geometry</summary>
    public unsafe partial class CustomMeshComponent : MeshComponent  {

        ///<summary>Add to the geometry to use on this triangle mesh.  This may cause an allocation.  Use SetCustomMeshTriangles() instead when possible to reduce allocations.</summary>
        public void AddCustomMeshTriangles(byte Triangles /*TODO: array TArray */)  => 
            CustomMeshComponent_methods.AddCustomMeshTriangles_method.Invoke(ObjPointer, Triangles);

        ///<summary>Removes all geometry from this triangle mesh.  Does not deallocate memory, allowing new geometry to reuse the existing allocation.</summary>
        public void ClearCustomMeshTriangles()  => 
            CustomMeshComponent_methods.ClearCustomMeshTriangles_method.Invoke(ObjPointer);

        ///<summary>Set the geometry to use on this triangle mesh</summary>
        public bool SetCustomMeshTriangles(byte Triangles /*TODO: array TArray */)  => 
            CustomMeshComponent_methods.SetCustomMeshTriangles_method.Invoke(ObjPointer, Triangles);
        static CustomMeshComponent() {
            StaticClass = Main.GetClass("CustomMeshComponent");
        }
        internal unsafe CustomMeshComponent_fields* CustomMeshComponent_ptr => (CustomMeshComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CustomMeshComponent(IntPtr p) => UObject.Make<CustomMeshComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CustomMeshComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CustomMeshComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
