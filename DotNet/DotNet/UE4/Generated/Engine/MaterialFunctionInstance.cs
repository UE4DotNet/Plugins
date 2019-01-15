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
    ///<summary>A material function instance defines parameter overrides for a parent material function.</summary>
    public unsafe partial class MaterialFunctionInstance : MaterialFunctionInterface  {
        ///<summary>Parent function.</summary>
        public unsafe MaterialFunctionInterface Parent {
            get {return MaterialFunctionInstance_ptr->Parent;}
        }
        ///<summary>Base function.</summary>
        public unsafe MaterialFunctionInterface Base {
            get {return MaterialFunctionInstance_ptr->Base;}
            set {MaterialFunctionInstance_ptr->Base = value;}
        }
         //TODO: array not UObject TArray ScalarParameterValues
         //TODO: array not UObject TArray VectorParameterValues
         //TODO: array not UObject TArray TextureParameterValues
         //TODO: array not UObject TArray FontParameterValues
         //TODO: array not UObject TArray StaticSwitchParameterValues
         //TODO: array not UObject TArray StaticComponentMaskParameterValues
        ///<summary>Preview Material</summary>
        public unsafe MaterialInstanceConstant PreviewMaterial {
            get {return MaterialFunctionInstance_ptr->PreviewMaterial;}
            set {MaterialFunctionInstance_ptr->PreviewMaterial = value;}
        }
        static MaterialFunctionInstance() {
            StaticClass = Main.GetClass("MaterialFunctionInstance");
        }
        internal unsafe MaterialFunctionInstance_fields* MaterialFunctionInstance_ptr => (MaterialFunctionInstance_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialFunctionInstance(IntPtr p) => UObject.Make<MaterialFunctionInstance>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialFunctionInstance DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialFunctionInstance New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
