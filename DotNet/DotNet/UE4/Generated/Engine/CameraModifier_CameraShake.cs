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
    ///<summary>
    ///A UCameraModifier_CameraShake is a camera modifier that can apply a UCameraShake to
    ///the owning camera.
    ///</summary>
    public unsafe partial class CameraModifier_CameraShake : CameraModifier  {
        ///<summary>List of active CameraShake instances</summary>
        public ObjectArrayField<CameraShake> ActiveShakes{ get {
            if(ActiveShakes_store == null) ActiveShakes_store = new ObjectArrayField<CameraShake> (&CameraModifier_CameraShake_ptr->ActiveShakes);
            return ActiveShakes_store;
        } }
        private ObjectArrayField<CameraShake> ActiveShakes_store;

        ///<summary>Scaling factor applied to all camera shakes in when in splitscreen mode. Normally used to reduce shaking, since shakes feel more intense in a smaller viewport.</summary>
        public unsafe float SplitScreenShakeScale {
            get {return CameraModifier_CameraShake_ptr->SplitScreenShakeScale;}
            set {CameraModifier_CameraShake_ptr->SplitScreenShakeScale = value;}
        }
        static CameraModifier_CameraShake() {
            StaticClass = Main.GetClass("CameraModifier_CameraShake");
        }
        internal unsafe CameraModifier_CameraShake_fields* CameraModifier_CameraShake_ptr => (CameraModifier_CameraShake_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CameraModifier_CameraShake(IntPtr p) => UObject.Make<CameraModifier_CameraShake>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CameraModifier_CameraShake DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CameraModifier_CameraShake New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
