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
using UE4.MovieSceneTools.Native;
using UE4.MovieScene;

namespace UE4.MovieSceneTools {
    ///<summary>Float Channel Key Proxy</summary>
    public unsafe partial class FloatChannelKeyProxy : UObject  {
        ///<summary>User-facing time of the key, applied to the actual key on PostEditChange, and updated every tick</summary>
        public unsafe FrameNumber Time {
            get {return FloatChannelKeyProxy_ptr->Time;}
            set {FloatChannelKeyProxy_ptr->Time = value;}
        }
        ///<summary>User-facing value of the key, applied to the actual key on PostEditChange, and updated every tick</summary>
        public unsafe MovieSceneFloatValue Value {
            get {return FloatChannelKeyProxy_ptr->Value;}
            set {FloatChannelKeyProxy_ptr->Value = value;}
        }
        static FloatChannelKeyProxy() {
            StaticClass = Main.GetClass("FloatChannelKeyProxy");
        }
        internal unsafe FloatChannelKeyProxy_fields* FloatChannelKeyProxy_ptr => (FloatChannelKeyProxy_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator FloatChannelKeyProxy(IntPtr p) => UObject.Make<FloatChannelKeyProxy>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static FloatChannelKeyProxy DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static FloatChannelKeyProxy New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
