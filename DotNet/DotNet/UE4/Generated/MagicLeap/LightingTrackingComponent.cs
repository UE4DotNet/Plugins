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
using UE4.MagicLeap.Native;
using UE4.Engine;

namespace UE4.MagicLeap {
    ///<summary>The LightingTrackingComponent wraps the Magic Leap lighting tracking API.</summary>
    ///<remarks>
    ///This api provides lumosity data from the camera that can be used to shade objects in a more realistic
    ///manner (via the post processor).
    ///</remarks>
    public unsafe partial class LightingTrackingComponent : ActorComponent  {
        public bool UseGlobalAmbience {
            get {return Main.GetGetBoolPropertyByName(this, "UseGlobalAmbience"); }
            set {Main.SetGetBoolPropertyByName(this, "UseGlobalAmbience", value); }
        }
        public bool UseColorTemp {
            get {return Main.GetGetBoolPropertyByName(this, "UseColorTemp"); }
            set {Main.SetGetBoolPropertyByName(this, "UseColorTemp", value); }
        }
        static LightingTrackingComponent() {
            StaticClass = Main.GetClass("LightingTrackingComponent");
        }
        internal unsafe LightingTrackingComponent_fields* LightingTrackingComponent_ptr => (LightingTrackingComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LightingTrackingComponent(IntPtr p) => UObject.Make<LightingTrackingComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LightingTrackingComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LightingTrackingComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
