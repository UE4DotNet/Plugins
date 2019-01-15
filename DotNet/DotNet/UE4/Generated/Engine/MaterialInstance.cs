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
    ///<summary>Material Instance</summary>
    public unsafe partial class MaterialInstance : MaterialInterface  {
        ///<summary>Physical material to use for this graphics material. Used for sounds, effects etc.</summary>
        public unsafe PhysicalMaterial PhysMaterial {
            get {return MaterialInstance_ptr->PhysMaterial;}
            set {MaterialInstance_ptr->PhysMaterial = value;}
        }
        ///<summary>Parent material.</summary>
        public unsafe MaterialInterface Parent {
            get {return MaterialInstance_ptr->Parent;}
        }
        public bool bHasStaticPermutationResource {
            get {return Main.GetGetBoolPropertyByName(this, "bHasStaticPermutationResource"); }
            set {Main.SetGetBoolPropertyByName(this, "bHasStaticPermutationResource", value); }
        }
        public bool bOverrideSubsurfaceProfile {
            get {return Main.GetGetBoolPropertyByName(this, "bOverrideSubsurfaceProfile"); }
        }
         //TODO: array not UObject TArray ScalarParameterValues
         //TODO: array not UObject TArray VectorParameterValues
         //TODO: array not UObject TArray TextureParameterValues
         //TODO: array not UObject TArray FontParameterValues
        ///<summary>Base Property Overrides</summary>
        public unsafe MaterialInstanceBasePropertyOverrides BasePropertyOverrides {
            get {return MaterialInstance_ptr->BasePropertyOverrides;}
            set {MaterialInstance_ptr->BasePropertyOverrides = value;}
        }
        ///<summary>Cached texture references from all expressions in the material (including nested functions).</summary>
        ///<remarks>This is used to link uniform texture expressions which were stored in the DDC with the UTextures that they reference.</remarks>
        public ObjectArrayField<Texture> PermutationTextureReferences{ get {
            if(PermutationTextureReferences_store == null) PermutationTextureReferences_store = new ObjectArrayField<Texture> (&MaterialInstance_ptr->PermutationTextureReferences);
            return PermutationTextureReferences_store;
        } }
        private ObjectArrayField<Texture> PermutationTextureReferences_store;

         //TODO: array not UObject TArray ReferencedTextureGuids
        ///<summary>Static parameter values that are overridden in this instance.</summary>
        public unsafe StaticParameterSet StaticParameters {
            get {return MaterialInstance_ptr->StaticParameters;}
            set {MaterialInstance_ptr->StaticParameters = value;}
        }
        static MaterialInstance() {
            StaticClass = Main.GetClass("MaterialInstance");
        }
        internal unsafe MaterialInstance_fields* MaterialInstance_ptr => (MaterialInstance_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialInstance(IntPtr p) => UObject.Make<MaterialInstance>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialInstance DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialInstance New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
