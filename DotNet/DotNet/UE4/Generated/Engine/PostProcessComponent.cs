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
    ///<summary>PostProcessComponent.</summary>
    ///<remarks>
    ///Enables Post process controls for blueprints.
    ///   Will use a parent UShapeComponent to provide volume data if available.
    ///</remarks>
    public unsafe partial class PostProcessComponent : SceneComponent  {

        ///<summary>Adds an Blendable (implements IBlendableInterface) to the array of Blendables (if it doesn't exist) and update the weight</summary>
        public void AddOrUpdateBlendable(byte InBlendableObject /*TODO: interface TScriptInterface */, float InWeight)  => 
            PostProcessComponent_methods.AddOrUpdateBlendable_method.Invoke(ObjPointer, InBlendableObject, InWeight);
        ///<summary>Post process settings to use for this volume.</summary>
        public unsafe PostProcessSettings Settings {
            get {return PostProcessComponent_ptr->Settings;}
            set {PostProcessComponent_ptr->Settings = value;}
        }
        ///<summary>Priority of this volume.</summary>
        ///<remarks>
        ///In the case of overlapping volumes the one with the highest priority
        ///overrides the lower priority ones. The order is undefined if two or more overlapping volumes have the same priority.
        ///</remarks>
        public unsafe float Priority {
            get {return PostProcessComponent_ptr->Priority;}
            set {PostProcessComponent_ptr->Priority = value;}
        }
        ///<summary>World space radius around the volume that is used for blending (only if not unbound).</summary>
        public unsafe float BlendRadius {
            get {return PostProcessComponent_ptr->BlendRadius;}
            set {PostProcessComponent_ptr->BlendRadius = value;}
        }
        ///<summary>0:no effect, 1:full effect</summary>
        public unsafe float BlendWeight {
            get {return PostProcessComponent_ptr->BlendWeight;}
            set {PostProcessComponent_ptr->BlendWeight = value;}
        }
        public bool bEnabled {
            get {return Main.GetGetBoolPropertyByName(this, "bEnabled"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnabled", value); }
        }
        public bool bUnbound {
            get {return Main.GetGetBoolPropertyByName(this, "bUnbound"); }
            set {Main.SetGetBoolPropertyByName(this, "bUnbound", value); }
        }
        static PostProcessComponent() {
            StaticClass = Main.GetClass("PostProcessComponent");
        }
        internal unsafe PostProcessComponent_fields* PostProcessComponent_ptr => (PostProcessComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PostProcessComponent(IntPtr p) => UObject.Make<PostProcessComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PostProcessComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PostProcessComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
