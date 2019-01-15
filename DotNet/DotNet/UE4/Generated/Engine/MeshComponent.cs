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
    ///<summary>MeshComponent is an abstract base for any component that is an instance of a renderable collection of triangles.</summary>
    ///<remarks>
    ///@see UStaticMeshComponent
    ///@see USkeletalMeshComponent
    ///</remarks>
    public unsafe partial class MeshComponent : PrimitiveComponent  {

        ///<summary>Get Material Index</summary>
        public int GetMaterialIndex(Name MaterialSlotName)  => 
            MeshComponent_methods.GetMaterialIndex_method.Invoke(ObjPointer, MaterialSlotName);

        ///<summary>Get Materials</summary>
        public IReadOnlyCollection<MaterialInterface> GetMaterials()  => 
            MeshComponent_methods.GetMaterials_method.Invoke(ObjPointer);

        ///<summary>Get Material Slot Names</summary>
        public IReadOnlyCollection<Name> GetMaterialSlotNames()  => 
            MeshComponent_methods.GetMaterialSlotNames_method.Invoke(ObjPointer);

        ///<summary>Is Material Slot Name Valid</summary>
        public bool IsMaterialSlotNameValid(Name MaterialSlotName)  => 
            MeshComponent_methods.IsMaterialSlotNameValid_method.Invoke(ObjPointer, MaterialSlotName);

        ///<summary>Tell the streaming system to start loading all textures with all mip-levels.</summary>
        ///<remarks>
        ///@param Seconds                                                  Number of seconds to force all mip-levels to be resident
        ///@param bPrioritizeCharacterTextures             Whether character textures should be prioritized for a while by the streaming system
        ///@param CinematicTextureGroups                   Bitfield indicating which texture groups that use extra high-resolution mips
        ///</remarks>
        public void PrestreamTextures(float Seconds, bool bPrioritizeCharacterTextures, int CinematicTextureGroups)  => 
            MeshComponent_methods.PrestreamTextures_method.Invoke(ObjPointer, Seconds, bPrioritizeCharacterTextures, CinematicTextureGroups);

        ///<summary>Set all occurrences of Scalar Material Parameters with ParameterName in the set of materials of the SkeletalMesh to ParameterValue</summary>
        public void SetScalarParameterValueOnMaterials(Name ParameterName, float ParameterValue)  => 
            MeshComponent_methods.SetScalarParameterValueOnMaterials_method.Invoke(ObjPointer, ParameterName, ParameterValue);

        ///<summary>Set all occurrences of Vector Material Parameters with ParameterName in the set of materials of the SkeletalMesh to ParameterValue</summary>
        public void SetVectorParameterValueOnMaterials(Name ParameterName, Vector ParameterValue)  => 
            MeshComponent_methods.SetVectorParameterValueOnMaterials_method.Invoke(ObjPointer, ParameterName, ParameterValue);
        ///<summary>Material overrides.</summary>
        public ObjectArrayField<MaterialInterface> OverrideMaterials{ get {
            if(OverrideMaterials_store == null) OverrideMaterials_store = new ObjectArrayField<MaterialInterface> (&MeshComponent_ptr->OverrideMaterials);
            return OverrideMaterials_store;
        } }
        private ObjectArrayField<MaterialInterface> OverrideMaterials_store;

        static MeshComponent() {
            StaticClass = Main.GetClass("MeshComponent");
        }
        internal unsafe MeshComponent_fields* MeshComponent_ptr => (MeshComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MeshComponent(IntPtr p) => UObject.Make<MeshComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MeshComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MeshComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
