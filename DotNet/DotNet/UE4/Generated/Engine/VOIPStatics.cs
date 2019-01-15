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
    ///<summary>VOIPStatics</summary>
    public unsafe partial class VOIPStatics : BlueprintFunctionLibrary  {

        ///<summary>This function sets the Mic threshold for VOIP chat.</summary>
        public static void SetMicThreshold(float InThreshold)  => 
            VOIPStatics_methods.SetMicThreshold_method.Invoke(InThreshold);
        static VOIPStatics() {
            StaticClass = Main.GetClass("VOIPStatics");
        }
        internal unsafe VOIPStatics_fields* VOIPStatics_ptr => (VOIPStatics_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator VOIPStatics(IntPtr p) => UObject.Make<VOIPStatics>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static VOIPStatics DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static VOIPStatics New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
