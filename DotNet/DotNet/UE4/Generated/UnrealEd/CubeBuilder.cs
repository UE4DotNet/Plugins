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
    ///<summary>Cube Builder</summary>
    public unsafe partial class CubeBuilder : EditorBrushBuilder  {
        ///<summary>The size of the cube in the X dimension</summary>
        public unsafe float X {
            get {return CubeBuilder_ptr->X;}
            set {CubeBuilder_ptr->X = value;}
        }
        ///<summary>The size of the cube in the Y dimension</summary>
        public unsafe float Y {
            get {return CubeBuilder_ptr->Y;}
            set {CubeBuilder_ptr->Y = value;}
        }
        ///<summary>The size of the cube in the Z dimension</summary>
        public unsafe float Z {
            get {return CubeBuilder_ptr->Z;}
            set {CubeBuilder_ptr->Z = value;}
        }
        ///<summary>The thickness of the cube wall when hollow</summary>
        public unsafe float WallThickness {
            get {return CubeBuilder_ptr->WallThickness;}
            set {CubeBuilder_ptr->WallThickness = value;}
        }
        ///<summary>Group Name</summary>
        public unsafe Name GroupName {
            get {return CubeBuilder_ptr->GroupName;}
            set {CubeBuilder_ptr->GroupName = value;}
        }
        public bool Hollow {
            get {return Main.GetGetBoolPropertyByName(this, "Hollow"); }
            set {Main.SetGetBoolPropertyByName(this, "Hollow", value); }
        }
        public bool Tessellated {
            get {return Main.GetGetBoolPropertyByName(this, "Tessellated"); }
            set {Main.SetGetBoolPropertyByName(this, "Tessellated", value); }
        }
        static CubeBuilder() {
            StaticClass = Main.GetClass("CubeBuilder");
        }
        internal unsafe CubeBuilder_fields* CubeBuilder_ptr => (CubeBuilder_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CubeBuilder(IntPtr p) => UObject.Make<CubeBuilder>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CubeBuilder DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CubeBuilder New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
