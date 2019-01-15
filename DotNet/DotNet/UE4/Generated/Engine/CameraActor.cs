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
    ///<summary>A CameraActor is a camera viewpoint that can be placed in a level.</summary>
    public unsafe partial class CameraActor : Actor  {

        ///<summary>Returns index of the player for whom we auto-activate, or INDEX_NONE (-1) if disabled.</summary>
        public int GetAutoActivatePlayerIndex()  => 
            CameraActor_methods.GetAutoActivatePlayerIndex_method.Invoke(ObjPointer);
        ///<summary>Specifies which player controller, if any, should automatically use this Camera when the controller is active.</summary>
        public unsafe byte AutoActivateForPlayer {
            get {return CameraActor_ptr->AutoActivateForPlayer;}
            set {CameraActor_ptr->AutoActivateForPlayer = value;}
        }
        ///<summary>The camera component for this camera</summary>
        public unsafe CameraComponent CameraComponent {
            get {return CameraActor_ptr->CameraComponent;}
        }
        ///<summary>Scene Component</summary>
        public unsafe SceneComponent SceneComponent {
            get {return CameraActor_ptr->SceneComponent;}
        }
        static CameraActor() {
            StaticClass = Main.GetClass("CameraActor");
        }
        internal unsafe CameraActor_fields* CameraActor_ptr => (CameraActor_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CameraActor(IntPtr p) => UObject.Make<CameraActor>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CameraActor DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CameraActor New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
