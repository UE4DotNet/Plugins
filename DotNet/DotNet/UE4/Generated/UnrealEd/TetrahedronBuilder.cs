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
    ///<summary>Tetrahedron Builder</summary>
    public unsafe partial class TetrahedronBuilder : EditorBrushBuilder  {
        ///<summary>The radius of this sphere</summary>
        public unsafe float Radius {
            get {return TetrahedronBuilder_ptr->Radius;}
            set {TetrahedronBuilder_ptr->Radius = value;}
        }
        ///<summary>How many iterations this sphere uses to tessellate its geometry</summary>
        public unsafe int SphereExtrapolation {
            get {return TetrahedronBuilder_ptr->SphereExtrapolation;}
            set {TetrahedronBuilder_ptr->SphereExtrapolation = value;}
        }
        ///<summary>Group Name</summary>
        public unsafe Name GroupName {
            get {return TetrahedronBuilder_ptr->GroupName;}
            set {TetrahedronBuilder_ptr->GroupName = value;}
        }
        static TetrahedronBuilder() {
            StaticClass = Main.GetClass("TetrahedronBuilder");
        }
        internal unsafe TetrahedronBuilder_fields* TetrahedronBuilder_ptr => (TetrahedronBuilder_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TetrahedronBuilder(IntPtr p) => UObject.Make<TetrahedronBuilder>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TetrahedronBuilder DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TetrahedronBuilder New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
