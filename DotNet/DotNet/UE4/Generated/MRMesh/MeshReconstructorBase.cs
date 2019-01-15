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
using UE4.MRMesh.Native;

namespace UE4.MRMesh {
    ///<summary>Mesh Reconstructor Base</summary>
    public unsafe partial class MeshReconstructorBase : UObject  {

        ///<summary>Is Reconstruction Paused</summary>
        public bool IsReconstructionPaused()  => 
            MeshReconstructorBase_methods.IsReconstructionPaused_method.Invoke(ObjPointer);

        ///<summary>Is Reconstruction Started</summary>
        public bool IsReconstructionStarted()  => 
            MeshReconstructorBase_methods.IsReconstructionStarted_method.Invoke(ObjPointer);

        ///<summary>Pause Reconstruction</summary>
        public void PauseReconstruction()  => 
            MeshReconstructorBase_methods.PauseReconstruction_method.Invoke(ObjPointer);

        ///<summary>Start Reconstruction</summary>
        public void StartReconstruction()  => 
            MeshReconstructorBase_methods.StartReconstruction_method.Invoke(ObjPointer);

        ///<summary>Stop Reconstruction</summary>
        public void StopReconstruction()  => 
            MeshReconstructorBase_methods.StopReconstruction_method.Invoke(ObjPointer);
        static MeshReconstructorBase() {
            StaticClass = Main.GetClass("MeshReconstructorBase");
        }
        internal unsafe MeshReconstructorBase_fields* MeshReconstructorBase_ptr => (MeshReconstructorBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MeshReconstructorBase(IntPtr p) => UObject.Make<MeshReconstructorBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MeshReconstructorBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MeshReconstructorBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
