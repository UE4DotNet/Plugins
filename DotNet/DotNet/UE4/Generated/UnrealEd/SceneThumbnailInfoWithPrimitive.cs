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
    ///<summary>Scene Thumbnail Info with Primitive</summary>
    public unsafe partial class SceneThumbnailInfoWithPrimitive : SceneThumbnailInfo  {
        ///<summary>The type of primitive used in this thumbnail</summary>
        public unsafe byte PrimitiveType {
            get {return SceneThumbnailInfoWithPrimitive_ptr->PrimitiveType;}
            set {SceneThumbnailInfoWithPrimitive_ptr->PrimitiveType = value;}
        }
        ///<summary>The custom mesh used when the primitive type is TPT_None</summary>
        public unsafe SoftObjectPath PreviewMesh {
            get {return SceneThumbnailInfoWithPrimitive_ptr->PreviewMesh;}
            set {SceneThumbnailInfoWithPrimitive_ptr->PreviewMesh = value;}
        }
        public bool bUserModifiedShape {
            get {return Main.GetGetBoolPropertyByName(this, "bUserModifiedShape"); }
            set {Main.SetGetBoolPropertyByName(this, "bUserModifiedShape", value); }
        }
        static SceneThumbnailInfoWithPrimitive() {
            StaticClass = Main.GetClass("SceneThumbnailInfoWithPrimitive");
        }
        internal unsafe SceneThumbnailInfoWithPrimitive_fields* SceneThumbnailInfoWithPrimitive_ptr => (SceneThumbnailInfoWithPrimitive_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SceneThumbnailInfoWithPrimitive(IntPtr p) => UObject.Make<SceneThumbnailInfoWithPrimitive>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SceneThumbnailInfoWithPrimitive DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SceneThumbnailInfoWithPrimitive New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
