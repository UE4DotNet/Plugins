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
using UE4.MeshPaint.Native;

namespace UE4.MeshPaint {
    ///<summary>Vertex Color Import Options</summary>
    public unsafe partial class VertexColorImportOptions : UObject  {
        ///<summary>Texture Coordinate Channel to use for Sampling the Texture</summary>
        public unsafe int UVIndex {
            get {return VertexColorImportOptions_ptr->UVIndex;}
            set {VertexColorImportOptions_ptr->UVIndex = value;}
        }
        ///<summary>LOD Index to import the Vertex Colors to</summary>
        public unsafe int LODIndex {
            get {return VertexColorImportOptions_ptr->LODIndex;}
            set {VertexColorImportOptions_ptr->LODIndex = value;}
        }
        public bool bRed {
            get {return Main.GetGetBoolPropertyByName(this, "bRed"); }
            set {Main.SetGetBoolPropertyByName(this, "bRed", value); }
        }
        public bool bBlue {
            get {return Main.GetGetBoolPropertyByName(this, "bBlue"); }
            set {Main.SetGetBoolPropertyByName(this, "bBlue", value); }
        }
        public bool bGreen {
            get {return Main.GetGetBoolPropertyByName(this, "bGreen"); }
            set {Main.SetGetBoolPropertyByName(this, "bGreen", value); }
        }
        public bool bAlpha {
            get {return Main.GetGetBoolPropertyByName(this, "bAlpha"); }
            set {Main.SetGetBoolPropertyByName(this, "bAlpha", value); }
        }
        public bool bImportToInstance {
            get {return Main.GetGetBoolPropertyByName(this, "bImportToInstance"); }
            set {Main.SetGetBoolPropertyByName(this, "bImportToInstance", value); }
        }
        public bool bCanImportToInstance {
            get {return Main.GetGetBoolPropertyByName(this, "bCanImportToInstance"); }
            set {Main.SetGetBoolPropertyByName(this, "bCanImportToInstance", value); }
        }
        static VertexColorImportOptions() {
            StaticClass = Main.GetClass("VertexColorImportOptions");
        }
        internal unsafe VertexColorImportOptions_fields* VertexColorImportOptions_ptr => (VertexColorImportOptions_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator VertexColorImportOptions(IntPtr p) => UObject.Make<VertexColorImportOptions>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static VertexColorImportOptions DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static VertexColorImportOptions New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
