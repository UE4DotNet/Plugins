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
    ///<summary>Cull Distance Volume</summary>
    public unsafe partial class CullDistanceVolume : Volume  {
         //TODO: array not UObject TArray CullDistances
        public bool bEnabled {
            get {return Main.GetGetBoolPropertyByName(this, "bEnabled"); }
        }
        static CullDistanceVolume() {
            StaticClass = Main.GetClass("CullDistanceVolume");
        }
        internal unsafe CullDistanceVolume_fields* CullDistanceVolume_ptr => (CullDistanceVolume_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CullDistanceVolume(IntPtr p) => UObject.Make<CullDistanceVolume>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CullDistanceVolume DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CullDistanceVolume New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
