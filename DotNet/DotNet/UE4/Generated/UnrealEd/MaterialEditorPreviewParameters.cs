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
    ///<summary>Material Editor Preview Parameters</summary>
    public unsafe partial class MaterialEditorPreviewParameters : UObject  {
         //TODO: array not UObject TArray ParameterGroups
        ///<summary>Preview Material</summary>
        public unsafe Material PreviewMaterial {
            get {return MaterialEditorPreviewParameters_ptr->PreviewMaterial;}
            set {MaterialEditorPreviewParameters_ptr->PreviewMaterial = value;}
        }
        ///<summary>Original Function</summary>
        public unsafe MaterialFunction OriginalFunction {
            get {return MaterialEditorPreviewParameters_ptr->OriginalFunction;}
            set {MaterialEditorPreviewParameters_ptr->OriginalFunction = value;}
        }
        ///<summary>Original Material</summary>
        public unsafe Material OriginalMaterial {
            get {return MaterialEditorPreviewParameters_ptr->OriginalMaterial;}
            set {MaterialEditorPreviewParameters_ptr->OriginalMaterial = value;}
        }
        static MaterialEditorPreviewParameters() {
            StaticClass = Main.GetClass("MaterialEditorPreviewParameters");
        }
        internal unsafe MaterialEditorPreviewParameters_fields* MaterialEditorPreviewParameters_ptr => (MaterialEditorPreviewParameters_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialEditorPreviewParameters(IntPtr p) => UObject.Make<MaterialEditorPreviewParameters>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialEditorPreviewParameters DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialEditorPreviewParameters New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
