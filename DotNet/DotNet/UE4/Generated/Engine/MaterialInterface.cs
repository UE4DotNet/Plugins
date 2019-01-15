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
    ///<summary>Material Interface</summary>
    public unsafe partial class MaterialInterface : UObject  {

        ///<summary>Walks up parent chain and finds the base Material that this is an instance of. Just calls the virtual GetMaterial()</summary>
        public Material GetBaseMaterial()  => 
            MaterialInterface_methods.GetBaseMaterial_method.Invoke(ObjPointer);

        ///<summary>Return a pointer to the physical material used by this material instance.</summary>
        ///<remarks>
        ///@return The physical material.
        ///</remarks>
        public PhysicalMaterial GetPhysicalMaterial()  => 
            MaterialInterface_methods.GetPhysicalMaterial_method.Invoke(ObjPointer);

        ///<summary>
        ///Force the streaming system to disregard the normal logic for the specified duration and
        ///instead always load all mip-levels for all textures used by this material.
        ///</summary>
        ///<remarks>
        ///@param OverrideForceMiplevelsToBeResident    - Whether to use (true) or ignore (false) the bForceMiplevelsToBeResidentValue parameter.
        ///@param bForceMiplevelsToBeResidentValue              - true forces all mips to stream in. false lets other factors decide what to do with the mips.
        ///@param ForceDuration                                                 - Number of seconds to keep all mip-levels in memory, disregarding the normal priority logic. Negative value turns it off.
        ///@param CinematicTextureGroups                                - Bitfield indicating texture groups that should use extra high-resolution mips
        ///</remarks>
        public void SetForceMipLevelsToBeResident(bool OverrideForceMiplevelsToBeResident, bool bForceMiplevelsToBeResidentValue, float ForceDuration, int CinematicTextureGroups)  => 
            MaterialInterface_methods.SetForceMipLevelsToBeResident_method.Invoke(ObjPointer, OverrideForceMiplevelsToBeResident, bForceMiplevelsToBeResidentValue, ForceDuration, CinematicTextureGroups);
        ///<summary>SubsurfaceProfile, for Screen Space Subsurface Scattering</summary>
        public unsafe SubsurfaceProfile SubsurfaceProfile {
            get {return MaterialInterface_ptr->SubsurfaceProfile;}
        }
        ///<summary>The Lightmass settings for this object.</summary>
        public unsafe LightmassMaterialInterfaceSettings LightmassSettings {
            get {return MaterialInterface_ptr->LightmassSettings;}
            set {MaterialInterface_ptr->LightmassSettings = value;}
        }
        public bool bTextureStreamingDataSorted {
            get {return Main.GetGetBoolPropertyByName(this, "bTextureStreamingDataSorted"); }
            set {Main.SetGetBoolPropertyByName(this, "bTextureStreamingDataSorted", value); }
        }
        ///<summary>Texture Streaming Data Version</summary>
        public unsafe int TextureStreamingDataVersion {
            get {return MaterialInterface_ptr->TextureStreamingDataVersion;}
            set {MaterialInterface_ptr->TextureStreamingDataVersion = value;}
        }
         //TODO: array not UObject TArray TextureStreamingData
        ///<summary>Array of user data stored with the asset</summary>
        public ObjectArrayField<AssetUserData> AssetUserData{ get {
            if(AssetUserData_store == null) AssetUserData_store = new ObjectArrayField<AssetUserData> (&MaterialInterface_ptr->AssetUserData);
            return AssetUserData_store;
        } }
        private ObjectArrayField<AssetUserData> AssetUserData_store;

        ///<summary>The mesh used by the material editor to preview the material.</summary>
        public unsafe SoftObjectPath PreviewMesh {
            get {return MaterialInterface_ptr->PreviewMesh;}
            set {MaterialInterface_ptr->PreviewMesh = value;}
        }
        ///<summary>Information for thumbnail rendering</summary>
        public unsafe ThumbnailInfo ThumbnailInfo {
            get {return MaterialInterface_ptr->ThumbnailInfo;}
            set {MaterialInterface_ptr->ThumbnailInfo = value;}
        }
         //TODO: map TMap LayerParameterExpansion
        ///<summary>Importing data and options used for this material</summary>
        public unsafe AssetImportData AssetImportData {
            get {return MaterialInterface_ptr->AssetImportData;}
            set {MaterialInterface_ptr->AssetImportData = value;}
        }
        ///<summary>Unique ID for this material, used for caching during distributed lighting</summary>
        public unsafe FGuid LightingGuid {
            get {return MaterialInterface_ptr->LightingGuid;}
            set {MaterialInterface_ptr->LightingGuid = value;}
        }
        static MaterialInterface() {
            StaticClass = Main.GetClass("MaterialInterface");
        }
        internal unsafe MaterialInterface_fields* MaterialInterface_ptr => (MaterialInterface_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialInterface(IntPtr p) => UObject.Make<MaterialInterface>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialInterface DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialInterface New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
