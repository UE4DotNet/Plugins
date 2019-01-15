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
using UE4.Engine;

namespace UE4.UnrealEd {
    ///<summary>Editor Anim Curve Bone Links</summary>
    public unsafe partial class EditorAnimCurveBoneLinks : UObject  {
        ///<summary>Curve Name</summary>
        public unsafe SmartName CurveName {
            get {return EditorAnimCurveBoneLinks_ptr->CurveName;}
            set {EditorAnimCurveBoneLinks_ptr->CurveName = value;}
        }
         //TODO: array not UObject TArray ConnectedBones
        ///<summary>Max (Lowest) LOD to evaluate to curve.</summary>
        ///<remarks>
        ///Since LOD goes from 0 to high number, we call it Max.
        ///For example, if you have 3 LODs (0, 1, 2), and if you want this to work until LOD 1, type 1.
        ///Then the curve will be evaluated until LOD1, but not for LOD 2
        ///Default value is 255
        ///</remarks>
        public unsafe byte MaxLOD {
            get {return EditorAnimCurveBoneLinks_ptr->MaxLOD;}
            set {EditorAnimCurveBoneLinks_ptr->MaxLOD = value;}
        }
        static EditorAnimCurveBoneLinks() {
            StaticClass = Main.GetClass("EditorAnimCurveBoneLinks");
        }
        internal unsafe EditorAnimCurveBoneLinks_fields* EditorAnimCurveBoneLinks_ptr => (EditorAnimCurveBoneLinks_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EditorAnimCurveBoneLinks(IntPtr p) => UObject.Make<EditorAnimCurveBoneLinks>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EditorAnimCurveBoneLinks DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EditorAnimCurveBoneLinks New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
