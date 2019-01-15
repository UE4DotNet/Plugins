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
    ///<summary>Actor used to control temporary matinees for camera anims that only exist in the editor</summary>
    public unsafe partial class MatineeActorCameraAnim : MatineeActor  {
        ///<summary>The camera anim we are editing</summary>
        public unsafe CameraAnim CameraAnim {
            get {return MatineeActorCameraAnim_ptr->CameraAnim;}
            set {MatineeActorCameraAnim_ptr->CameraAnim = value;}
        }
        static MatineeActorCameraAnim() {
            StaticClass = Main.GetClass("MatineeActorCameraAnim");
        }
        internal unsafe MatineeActorCameraAnim_fields* MatineeActorCameraAnim_ptr => (MatineeActorCameraAnim_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MatineeActorCameraAnim(IntPtr p) => UObject.Make<MatineeActorCameraAnim>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MatineeActorCameraAnim DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MatineeActorCameraAnim New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
