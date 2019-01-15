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
    ///<summary>This class is a base class for any function libraries exposed to blueprints.</summary>
    ///<remarks>Methods in subclasses are expected to be static, and no methods should be added to this base class.</remarks>
    public unsafe partial class BlueprintFunctionLibrary : UObject  {
        static BlueprintFunctionLibrary() {
            StaticClass = Main.GetClass("BlueprintFunctionLibrary");
        }
        internal unsafe BlueprintFunctionLibrary_fields* BlueprintFunctionLibrary_ptr => (BlueprintFunctionLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BlueprintFunctionLibrary(IntPtr p) => UObject.Make<BlueprintFunctionLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BlueprintFunctionLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BlueprintFunctionLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
