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
    ///<summary>Cone Builder</summary>
    public unsafe partial class ConeBuilder : EditorBrushBuilder  {
        ///<summary>Distance from base to tip of cone</summary>
        public unsafe float Z {
            get {return ConeBuilder_ptr->Z;}
            set {ConeBuilder_ptr->Z = value;}
        }
        ///<summary>Distance from base to the tip of inner cone (when hollow)</summary>
        public unsafe float CapZ {
            get {return ConeBuilder_ptr->CapZ;}
            set {ConeBuilder_ptr->CapZ = value;}
        }
        ///<summary>Radius of cone</summary>
        public unsafe float OuterRadius {
            get {return ConeBuilder_ptr->OuterRadius;}
            set {ConeBuilder_ptr->OuterRadius = value;}
        }
        ///<summary>Radius of inner cone (when hollow)</summary>
        public unsafe float InnerRadius {
            get {return ConeBuilder_ptr->InnerRadius;}
            set {ConeBuilder_ptr->InnerRadius = value;}
        }
        ///<summary>How many sides this cone should have</summary>
        public unsafe int Sides {
            get {return ConeBuilder_ptr->Sides;}
            set {ConeBuilder_ptr->Sides = value;}
        }
        ///<summary>Group Name</summary>
        public unsafe Name GroupName {
            get {return ConeBuilder_ptr->GroupName;}
            set {ConeBuilder_ptr->GroupName = value;}
        }
        public bool AlignToSide {
            get {return Main.GetGetBoolPropertyByName(this, "AlignToSide"); }
            set {Main.SetGetBoolPropertyByName(this, "AlignToSide", value); }
        }
        public bool Hollow {
            get {return Main.GetGetBoolPropertyByName(this, "Hollow"); }
            set {Main.SetGetBoolPropertyByName(this, "Hollow", value); }
        }
        static ConeBuilder() {
            StaticClass = Main.GetClass("ConeBuilder");
        }
        internal unsafe ConeBuilder_fields* ConeBuilder_ptr => (ConeBuilder_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ConeBuilder(IntPtr p) => UObject.Make<ConeBuilder>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ConeBuilder DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ConeBuilder New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
