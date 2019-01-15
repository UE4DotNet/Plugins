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
using UE4.UnrealEd.Native;
using UE4.Engine;

namespace UE4.UnrealEd {
    ///<summary>Material Editor Instance Constant</summary>
    public unsafe partial class MaterialEditorInstanceConstant : UObject  {
        ///<summary>Physical material to use for this graphics material. Used for sounds, effects etc.</summary>
        public unsafe PhysicalMaterial PhysMaterial {
            get {return MaterialEditorInstanceConstant_ptr->PhysMaterial;}
            set {MaterialEditorInstanceConstant_ptr->PhysMaterial = value;}
        }
        ///<summary>since the Parent may point across levels and the property editor needs to import this text, it must be marked lazy so it doesn't set itself to NULL in FindImportedObject</summary>
        public unsafe MaterialInterface Parent {
            get {return MaterialEditorInstanceConstant_ptr->Parent;}
            set {MaterialEditorInstanceConstant_ptr->Parent = value;}
        }
         //TODO: array not UObject TArray ParameterGroups
        ///<summary>This is the refraction depth bias, larger values offset distortion to prevent closer objects from rendering into the distorted surface at acute viewing angles but increases the disconnect between surface and where the refraction starts.</summary>
        public unsafe float RefractionDepthBias {
            get {return MaterialEditorInstanceConstant_ptr->RefractionDepthBias;}
            set {MaterialEditorInstanceConstant_ptr->RefractionDepthBias = value;}
        }
        ///<summary>SubsurfaceProfile, for Screen Space Subsurface Scattering</summary>
        public unsafe SubsurfaceProfile SubsurfaceProfile {
            get {return MaterialEditorInstanceConstant_ptr->SubsurfaceProfile;}
        }
        public bool bOverrideSubsurfaceProfile {
            get {return Main.GetGetBoolPropertyByName(this, "bOverrideSubsurfaceProfile"); }
            set {Main.SetGetBoolPropertyByName(this, "bOverrideSubsurfaceProfile", value); }
        }
        public bool bIsFunctionPreviewMaterial {
            get {return Main.GetGetBoolPropertyByName(this, "bIsFunctionPreviewMaterial"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsFunctionPreviewMaterial", value); }
        }
        public bool bIsFunctionInstanceDirty {
            get {return Main.GetGetBoolPropertyByName(this, "bIsFunctionInstanceDirty"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsFunctionInstanceDirty", value); }
        }
        ///<summary>Base Property Overrides</summary>
        public unsafe MaterialInstanceBasePropertyOverrides BasePropertyOverrides {
            get {return MaterialEditorInstanceConstant_ptr->BasePropertyOverrides;}
            set {MaterialEditorInstanceConstant_ptr->BasePropertyOverrides = value;}
        }
        ///<summary>Source Instance</summary>
        public unsafe MaterialInstanceConstant SourceInstance {
            get {return MaterialEditorInstanceConstant_ptr->SourceInstance;}
            set {MaterialEditorInstanceConstant_ptr->SourceInstance = value;}
        }
        ///<summary>Source Function</summary>
        public unsafe MaterialFunctionInstance SourceFunction {
            get {return MaterialEditorInstanceConstant_ptr->SourceFunction;}
            set {MaterialEditorInstanceConstant_ptr->SourceFunction = value;}
        }
         //TODO: array not UObject TArray VisibleExpressions
        ///<summary>The Lightmass override settings for this object.</summary>
        public unsafe LightmassParameterizedMaterialSettings LightmassSettings {
            get {return MaterialEditorInstanceConstant_ptr->LightmassSettings;}
            set {MaterialEditorInstanceConstant_ptr->LightmassSettings = value;}
        }
        public bool bUseOldStyleMICEditorGroups {
            get {return Main.GetGetBoolPropertyByName(this, "bUseOldStyleMICEditorGroups"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseOldStyleMICEditorGroups", value); }
        }
        ///<summary>Stored Layer Previews</summary>
        public ObjectArrayField<MaterialInstanceConstant> StoredLayerPreviews{ get {
            if(StoredLayerPreviews_store == null) StoredLayerPreviews_store = new ObjectArrayField<MaterialInstanceConstant> (&MaterialEditorInstanceConstant_ptr->StoredLayerPreviews);
            return StoredLayerPreviews_store;
        } }
        private ObjectArrayField<MaterialInstanceConstant> StoredLayerPreviews_store;

        ///<summary>Stored Blend Previews</summary>
        public ObjectArrayField<MaterialInstanceConstant> StoredBlendPreviews{ get {
            if(StoredBlendPreviews_store == null) StoredBlendPreviews_store = new ObjectArrayField<MaterialInstanceConstant> (&MaterialEditorInstanceConstant_ptr->StoredBlendPreviews);
            return StoredBlendPreviews_store;
        } }
        private ObjectArrayField<MaterialInstanceConstant> StoredBlendPreviews_store;

        static MaterialEditorInstanceConstant() {
            StaticClass = Main.GetClass("MaterialEditorInstanceConstant");
        }
        internal unsafe MaterialEditorInstanceConstant_fields* MaterialEditorInstanceConstant_ptr => (MaterialEditorInstanceConstant_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialEditorInstanceConstant(IntPtr p) => UObject.Make<MaterialEditorInstanceConstant>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialEditorInstanceConstant DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialEditorInstanceConstant New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
