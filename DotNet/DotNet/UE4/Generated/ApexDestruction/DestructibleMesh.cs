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
using UE4.ApexDestruction.Native;
using UE4.Engine;

namespace UE4.ApexDestruction {
    ///<summary>Holds an APEX destructible asset as well as an associated USkeletalMesh.</summary>
    public unsafe partial class DestructibleMesh : SkeletalMesh  {
        ///<summary>Parameters controlling the destruction behavior.</summary>
        public unsafe DestructibleParameters DefaultDestructibleParameters {
            get {return DestructibleMesh_ptr->DefaultDestructibleParameters;}
            set {DestructibleMesh_ptr->DefaultDestructibleParameters = value;}
        }
         //TODO: array TArray FractureEffects
        ///<summary>Information used to author an NxDestructibleAsset</summary>
        public unsafe DestructibleFractureSettings FractureSettings {
            get {return DestructibleMesh_ptr->FractureSettings;}
            set {DestructibleMesh_ptr->FractureSettings = value;}
        }
        ///<summary>Static mesh this destructible mesh is created from. Is nullptr if not created from a static mesh</summary>
        public unsafe StaticMesh SourceStaticMesh {
            get {return DestructibleMesh_ptr->SourceStaticMesh;}
            set {DestructibleMesh_ptr->SourceStaticMesh = value;}
        }
        ///<summary>Timestamp of the source static meshes last import at the time this destruction mesh has been generated.</summary>
        public unsafe FDateTime SourceSMImportTimestamp {
            get {return DestructibleMesh_ptr->SourceSMImportTimestamp;}
            set {DestructibleMesh_ptr->SourceSMImportTimestamp = value;}
        }
         //TODO: array TArray FractureChunkMeshes
        static DestructibleMesh() {
            StaticClass = Main.GetClass("DestructibleMesh");
        }
        internal unsafe DestructibleMesh_fields* DestructibleMesh_ptr => (DestructibleMesh_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DestructibleMesh(IntPtr p) => UObject.Make<DestructibleMesh>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DestructibleMesh DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DestructibleMesh New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
