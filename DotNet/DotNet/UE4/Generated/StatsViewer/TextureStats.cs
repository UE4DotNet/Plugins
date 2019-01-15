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
using UE4.StatsViewer.Native;

namespace UE4.StatsViewer {
    ///<summary>Statistics page for textures.</summary>
    public unsafe partial class TextureStats : UObject  {
         //TODO: weak object TWeakObjectPtr<UTexture> Texture
         //TODO: array not UObject TArray Actors
         //TODO: string FString Type
        ///<summary>Max Dimension e.g. 256x256, not including the format</summary>
        public unsafe Vector2D MaxDim {
            get {return TextureStats_ptr->MaxDim;}
            set {TextureStats_ptr->MaxDim = value;}
        }
        ///<summary>Current Dimension e.g 256x256</summary>
        public unsafe Vector2D CurrentDim {
            get {return TextureStats_ptr->CurrentDim;}
            set {TextureStats_ptr->CurrentDim = value;}
        }
        ///<summary>The texture format, e.g. PF_DXT1</summary>
        public unsafe byte Format {
            get {return TextureStats_ptr->Format;}
            set {TextureStats_ptr->Format = value;}
        }
        ///<summary>The texture group, TEXTUREGROUP_MAX is not used, e.g. TEXTUREGROUP_World</summary>
        public unsafe byte Group {
            get {return TextureStats_ptr->Group;}
            set {TextureStats_ptr->Group = value;}
        }
        ///<summary>LOD Bias for this texture. (Texture LODBias + Texture group)</summary>
        public unsafe int LODBias {
            get {return TextureStats_ptr->LODBias;}
            set {TextureStats_ptr->LODBias = value;}
        }
        ///<summary>The memory used currently in KB</summary>
        public unsafe float CurrentKB {
            get {return TextureStats_ptr->CurrentKB;}
            set {TextureStats_ptr->CurrentKB = value;}
        }
        ///<summary>The memory used when the texture is fully loaded in KB</summary>
        public unsafe float FullyLoadedKB {
            get {return TextureStats_ptr->FullyLoadedKB;}
            set {TextureStats_ptr->FullyLoadedKB = value;}
        }
        ///<summary>The number of times the texture is used</summary>
        public unsafe int NumUses {
            get {return TextureStats_ptr->NumUses;}
            set {TextureStats_ptr->NumUses = value;}
        }
        ///<summary>Relative time it was used for rendering the last time</summary>
        public unsafe float LastTimeRendered {
            get {return TextureStats_ptr->LastTimeRendered;}
            set {TextureStats_ptr->LastTimeRendered = value;}
        }
         //TODO: string FString Path
        static TextureStats() {
            StaticClass = Main.GetClass("TextureStats");
        }
        internal unsafe TextureStats_fields* TextureStats_ptr => (TextureStats_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TextureStats(IntPtr p) => UObject.Make<TextureStats>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TextureStats DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TextureStats New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
