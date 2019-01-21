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
using UE4.MagicLeapHandTracking.Native;
using UE4.LiveLinkInterface;

namespace UE4.MagicLeapHandTracking {
    ///<summary>Live Link Magic Leap Hand Tracking Source Factory</summary>
    public unsafe partial class LiveLinkMagicLeapHandTrackingSourceFactory : LiveLinkSourceFactory  {
        static LiveLinkMagicLeapHandTrackingSourceFactory() {
            StaticClass = Main.GetClass("LiveLinkMagicLeapHandTrackingSourceFactory");
        }
        internal unsafe LiveLinkMagicLeapHandTrackingSourceFactory_fields* LiveLinkMagicLeapHandTrackingSourceFactory_ptr => (LiveLinkMagicLeapHandTrackingSourceFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LiveLinkMagicLeapHandTrackingSourceFactory(IntPtr p) => UObject.Make<LiveLinkMagicLeapHandTrackingSourceFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LiveLinkMagicLeapHandTrackingSourceFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LiveLinkMagicLeapHandTrackingSourceFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
