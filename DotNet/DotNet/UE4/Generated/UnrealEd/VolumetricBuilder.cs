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

namespace UE4.UnrealEd {
    ///<summary>Volumetric Builder</summary>
    public unsafe partial class VolumetricBuilder : EditorBrushBuilder  {
        ///<summary>Z</summary>
        public unsafe float Z {
            get {return VolumetricBuilder_ptr->Z;}
            set {VolumetricBuilder_ptr->Z = value;}
        }
        ///<summary>Radius</summary>
        public unsafe float Radius {
            get {return VolumetricBuilder_ptr->Radius;}
            set {VolumetricBuilder_ptr->Radius = value;}
        }
        ///<summary>Num Sheets</summary>
        public unsafe int NumSheets {
            get {return VolumetricBuilder_ptr->NumSheets;}
            set {VolumetricBuilder_ptr->NumSheets = value;}
        }
        ///<summary>Group Name</summary>
        public unsafe Name GroupName {
            get {return VolumetricBuilder_ptr->GroupName;}
            set {VolumetricBuilder_ptr->GroupName = value;}
        }
        static VolumetricBuilder() {
            StaticClass = Main.GetClass("VolumetricBuilder");
        }
        internal unsafe VolumetricBuilder_fields* VolumetricBuilder_ptr => (VolumetricBuilder_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator VolumetricBuilder(IntPtr p) => UObject.Make<VolumetricBuilder>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static VolumetricBuilder DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static VolumetricBuilder New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
