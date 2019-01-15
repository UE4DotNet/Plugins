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
using UE4.MediaAssets.Native;

namespace UE4.MediaAssets {
    ///<summary>Base class for concrete media sources.</summary>
    public unsafe partial class BaseMediaSource : MediaSource  {
         //TODO: map TMap PlatformPlayerNames
        ///<summary>Name of the desired native media player (Empty = find one automatically).</summary>
        public unsafe Name PlayerName {
            get {return BaseMediaSource_ptr->PlayerName;}
            set {BaseMediaSource_ptr->PlayerName = value;}
        }
        static BaseMediaSource() {
            StaticClass = Main.GetClass("BaseMediaSource");
        }
        internal unsafe BaseMediaSource_fields* BaseMediaSource_ptr => (BaseMediaSource_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BaseMediaSource(IntPtr p) => UObject.Make<BaseMediaSource>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BaseMediaSource DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BaseMediaSource New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
