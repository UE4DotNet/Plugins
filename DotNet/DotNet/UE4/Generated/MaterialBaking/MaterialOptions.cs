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
using UE4.MaterialBaking.Native;

namespace UE4.MaterialBaking {
    ///<summary>Options object to define what and how a material should be baked out</summary>
    public unsafe partial class MaterialOptions : UObject  {
         //TODO: array not UObject TArray Properties
        ///<summary>Size of the final texture(s) containing the baked out property data</summary>
        public unsafe IntPoint TextureSize {
            get {return MaterialOptions_ptr->TextureSize;}
            set {MaterialOptions_ptr->TextureSize = value;}
        }
         //TODO: array not UObject TArray LODIndices
        public bool bUseMeshData {
            get {return Main.GetGetBoolPropertyByName(this, "bUseMeshData"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseMeshData", value); }
        }
        public bool bUseSpecificUVIndex {
            get {return Main.GetGetBoolPropertyByName(this, "bUseSpecificUVIndex"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseSpecificUVIndex", value); }
        }
        ///<summary>Specific texture coordinate which should be used to while baking out material properties as the positions stream</summary>
        public unsafe int TextureCoordinateIndex {
            get {return MaterialOptions_ptr->TextureCoordinateIndex;}
            set {MaterialOptions_ptr->TextureCoordinateIndex = value;}
        }
        static MaterialOptions() {
            StaticClass = Main.GetClass("MaterialOptions");
        }
        internal unsafe MaterialOptions_fields* MaterialOptions_ptr => (MaterialOptions_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialOptions(IntPtr p) => UObject.Make<MaterialOptions>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialOptions DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialOptions New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
