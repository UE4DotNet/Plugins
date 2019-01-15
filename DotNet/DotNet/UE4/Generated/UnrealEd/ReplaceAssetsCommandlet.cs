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
    ///<summary>Commandlet for replacing assets with those from another location (intended use is replacing with cooked assets)</summary>
    public unsafe partial class ReplaceAssetsCommandlet : Commandlet  {
        static ReplaceAssetsCommandlet() {
            StaticClass = Main.GetClass("ReplaceAssetsCommandlet");
        }
        internal unsafe ReplaceAssetsCommandlet_fields* ReplaceAssetsCommandlet_ptr => (ReplaceAssetsCommandlet_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ReplaceAssetsCommandlet(IntPtr p) => UObject.Make<ReplaceAssetsCommandlet>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ReplaceAssetsCommandlet DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ReplaceAssetsCommandlet New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
