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
    ///<summary>Anim Compress Remove Every Second Key</summary>
    public unsafe partial class AnimCompress_RemoveEverySecondKey : AnimCompress  {
        ///<summary>Animations with fewer than MinKeys will not lose any keys.</summary>
        public unsafe int MinKeys {
            get {return AnimCompress_RemoveEverySecondKey_ptr->MinKeys;}
            set {AnimCompress_RemoveEverySecondKey_ptr->MinKeys = value;}
        }
        public bool bStartAtSecondKey {
            get {return Main.GetGetBoolPropertyByName(this, "bStartAtSecondKey"); }
            set {Main.SetGetBoolPropertyByName(this, "bStartAtSecondKey", value); }
        }
        static AnimCompress_RemoveEverySecondKey() {
            StaticClass = Main.GetClass("AnimCompress_RemoveEverySecondKey");
        }
        internal unsafe AnimCompress_RemoveEverySecondKey_fields* AnimCompress_RemoveEverySecondKey_ptr => (AnimCompress_RemoveEverySecondKey_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimCompress_RemoveEverySecondKey(IntPtr p) => UObject.Make<AnimCompress_RemoveEverySecondKey>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimCompress_RemoveEverySecondKey DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimCompress_RemoveEverySecondKey New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
