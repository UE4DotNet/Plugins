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
    ///<summary>Texture 2D</summary>
    public unsafe partial class Texture2D : Texture  {

        ///<summary>Gets the X size of the texture, in pixels</summary>
        public int Blueprint_GetSizeX()  => 
            Texture2D_methods.Blueprint_GetSizeX_method.Invoke(ObjPointer);

        ///<summary>Gets the Y size of the texture, in pixels</summary>
        public int Blueprint_GetSizeY()  => 
            Texture2D_methods.Blueprint_GetSizeY_method.Invoke(ObjPointer);
        ///<summary>FStreamingTexture index used by the texture streaming system.</summary>
        public unsafe int StreamingIndex {
            get {return Texture2D_ptr->StreamingIndex;}
            set {Texture2D_ptr->StreamingIndex = value;}
        }
        ///<summary>* Level scope index of this texture.</summary>
        ///<remarks>
        ///It is used to reduce the amount of lookup to map a texture to its level index.
        ///* Useful when building texture streaming data, as well as when filling the texture streamer with precomputed data.
        ///* It relates to FStreamingTextureBuildInfo::TextureLevelIndex and also the index in ULevel::StreamingTextureGuids.
        ///* Default value of -1, indicates that the texture has an unknown index (not yet processed). At level load time,
        ///* -2 is also used to indicate that the texture has been processed but no entry were found in the level table.
        ///* After any of these processes, the LevelIndex is reset to INDEX_NONE. Making it ready for the next level task.
        ///</remarks>
        public unsafe int LevelIndex {
            get {return Texture2D_ptr->LevelIndex;}
            set {Texture2D_ptr->LevelIndex = value;}
        }
        ///<summary>keep track of first mip level used for ResourceMem creation</summary>
        public unsafe int FirstResourceMemMip {
            get {return Texture2D_ptr->FirstResourceMemMip;}
            set {Texture2D_ptr->FirstResourceMemMip = value;}
        }
        public bool bTemporarilyDisableStreaming {
            get {return Main.GetGetBoolPropertyByName(this, "bTemporarilyDisableStreaming"); }
            set {Main.SetGetBoolPropertyByName(this, "bTemporarilyDisableStreaming", value); }
        }
        public bool bIsStreamable {
            get {return Main.GetGetBoolPropertyByName(this, "bIsStreamable"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsStreamable", value); }
        }
        public bool bHasStreamingUpdatePending {
            get {return Main.GetGetBoolPropertyByName(this, "bHasStreamingUpdatePending"); }
            set {Main.SetGetBoolPropertyByName(this, "bHasStreamingUpdatePending", value); }
        }
        public bool bForceMiplevelsToBeResident {
            get {return Main.GetGetBoolPropertyByName(this, "bForceMiplevelsToBeResident"); }
            set {Main.SetGetBoolPropertyByName(this, "bForceMiplevelsToBeResident", value); }
        }
        public bool bIgnoreStreamingMipBias {
            get {return Main.GetGetBoolPropertyByName(this, "bIgnoreStreamingMipBias"); }
            set {Main.SetGetBoolPropertyByName(this, "bIgnoreStreamingMipBias", value); }
        }
        public bool bGlobalForceMipLevelsToBeResident {
            get {return Main.GetGetBoolPropertyByName(this, "bGlobalForceMipLevelsToBeResident"); }
        }
        public bool bHasBeenPaintedInEditor {
            get {return Main.GetGetBoolPropertyByName(this, "bHasBeenPaintedInEditor"); }
            set {Main.SetGetBoolPropertyByName(this, "bHasBeenPaintedInEditor", value); }
        }
        ///<summary>The addressing mode to use for the X axis.</summary>
        public unsafe byte AddressX {
            get {return Texture2D_ptr->AddressX;}
            set {Texture2D_ptr->AddressX = value;}
        }
        ///<summary>The addressing mode to use for the Y axis.</summary>
        public unsafe byte AddressY {
            get {return Texture2D_ptr->AddressY;}
            set {Texture2D_ptr->AddressY = value;}
        }
        ///<summary>The imported size of the texture.</summary>
        ///<remarks>
        ///Only valid on cooked builds when texture source is not
        ///available. Access ONLY via the GetImportedSize() accessor!
        ///</remarks>
        public unsafe IntPoint ImportedSize {
            get {return Texture2D_ptr->ImportedSize;}
            set {Texture2D_ptr->ImportedSize = value;}
        }
        ///<summary>WorldSettings timestamp that tells the streamer to force all miplevels to be resident up until that time.</summary>
        public unsafe double ForceMipLevelsToBeResidentTimestamp {
            get {return Texture2D_ptr->ForceMipLevelsToBeResidentTimestamp;}
            set {Texture2D_ptr->ForceMipLevelsToBeResidentTimestamp = value;}
        }
        static Texture2D() {
            StaticClass = Main.GetClass("Texture2D");
        }
        internal unsafe Texture2D_fields* Texture2D_ptr => (Texture2D_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator Texture2D(IntPtr p) => UObject.Make<Texture2D>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static Texture2D DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static Texture2D New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
