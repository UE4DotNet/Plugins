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
using UE4.AnimGraph.Native;

namespace UE4.AnimGraph {
    ///<summary>This class is a base class for performing AnimBlueprint Post Compilation Validation.</summary>
    public unsafe partial class AnimBlueprintPostCompileValidation : UObject  {
        static AnimBlueprintPostCompileValidation() {
            StaticClass = Main.GetClass("AnimBlueprintPostCompileValidation");
        }
        internal unsafe AnimBlueprintPostCompileValidation_fields* AnimBlueprintPostCompileValidation_ptr => (AnimBlueprintPostCompileValidation_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimBlueprintPostCompileValidation(IntPtr p) => UObject.Make<AnimBlueprintPostCompileValidation>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimBlueprintPostCompileValidation DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimBlueprintPostCompileValidation New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
