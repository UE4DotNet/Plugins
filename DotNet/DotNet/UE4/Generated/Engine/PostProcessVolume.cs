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
    ///<summary>for FPostprocessSettings</summary>
    public unsafe partial class PostProcessVolume : Volume  {

        ///<summary>Adds an Blendable (implements IBlendableInterface) to the array of Blendables (if it doesn't exist) and update the weight</summary>
        public void AddOrUpdateBlendable(byte InBlendableObject /*TODO: interface TScriptInterface */, float InWeight)  => 
            PostProcessVolume_methods.AddOrUpdateBlendable_method.Invoke(ObjPointer, InBlendableObject, InWeight);
        ///<summary>Post process settings to use for this volume.</summary>
        public unsafe PostProcessSettings Settings {
            get {return PostProcessVolume_ptr->Settings;}
            set {PostProcessVolume_ptr->Settings = value;}
        }
        ///<summary>Priority of this volume.</summary>
        ///<remarks>
        ///In the case of overlapping volumes the one with the highest priority
        ///overrides the lower priority ones. The order is undefined if two or more overlapping volumes have the same priority.
        ///</remarks>
        public unsafe float Priority {
            get {return PostProcessVolume_ptr->Priority;}
            set {PostProcessVolume_ptr->Priority = value;}
        }
        ///<summary>World space radius around the volume that is used for blending (only if not unbound).</summary>
        public unsafe float BlendRadius {
            get {return PostProcessVolume_ptr->BlendRadius;}
            set {PostProcessVolume_ptr->BlendRadius = value;}
        }
        ///<summary>0:no effect, 1:full effect</summary>
        public unsafe float BlendWeight {
            get {return PostProcessVolume_ptr->BlendWeight;}
            set {PostProcessVolume_ptr->BlendWeight = value;}
        }
        public bool bEnabled {
            get {return Main.GetGetBoolPropertyByName(this, "bEnabled"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnabled", value); }
        }
        public bool bUnbound {
            get {return Main.GetGetBoolPropertyByName(this, "bUnbound"); }
            set {Main.SetGetBoolPropertyByName(this, "bUnbound", value); }
        }
        static PostProcessVolume() {
            StaticClass = Main.GetClass("PostProcessVolume");
        }
        internal unsafe PostProcessVolume_fields* PostProcessVolume_ptr => (PostProcessVolume_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PostProcessVolume(IntPtr p) => UObject.Make<PostProcessVolume>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PostProcessVolume DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PostProcessVolume New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
