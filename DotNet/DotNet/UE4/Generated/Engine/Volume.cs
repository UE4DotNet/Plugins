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
    ///<summary>An editable 3D volume placed in a level.</summary>
    ///<remarks>
    ///Different types of volumes perform different functions
    ///@see https://docs.unrealengine.com/latest/INT/Engine/Actors/Volumes
    ///</remarks>
    public unsafe partial class Volume : Brush  {
        static Volume() {
            StaticClass = Main.GetClass("Volume");
        }
        internal unsafe Volume_fields* Volume_ptr => (Volume_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator Volume(IntPtr p) => UObject.Make<Volume>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static Volume DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static Volume New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
