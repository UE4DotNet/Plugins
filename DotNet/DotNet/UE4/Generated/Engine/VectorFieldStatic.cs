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
    ///<summary>Vector Field Static</summary>
    public unsafe partial class VectorFieldStatic : VectorField  {
        ///<summary>Size of the vector field volume.</summary>
        public unsafe int SizeX {
            get {return VectorFieldStatic_ptr->SizeX;}
            set {VectorFieldStatic_ptr->SizeX = value;}
        }
        ///<summary>Size of the vector field volume.</summary>
        public unsafe int SizeY {
            get {return VectorFieldStatic_ptr->SizeY;}
            set {VectorFieldStatic_ptr->SizeY = value;}
        }
        ///<summary>Size of the vector field volume.</summary>
        public unsafe int SizeZ {
            get {return VectorFieldStatic_ptr->SizeZ;}
            set {VectorFieldStatic_ptr->SizeZ = value;}
        }
        ///<summary>Asset Import Data</summary>
        public unsafe AssetImportData AssetImportData {
            get {return VectorFieldStatic_ptr->AssetImportData;}
            set {VectorFieldStatic_ptr->AssetImportData = value;}
        }
        static VectorFieldStatic() {
            StaticClass = Main.GetClass("VectorFieldStatic");
        }
        internal unsafe VectorFieldStatic_fields* VectorFieldStatic_ptr => (VectorFieldStatic_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator VectorFieldStatic(IntPtr p) => UObject.Make<VectorFieldStatic>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static VectorFieldStatic DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static VectorFieldStatic New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
