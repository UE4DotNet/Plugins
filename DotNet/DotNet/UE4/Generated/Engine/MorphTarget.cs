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
    ///<summary>Morph Target</summary>
    public unsafe partial class MorphTarget : UObject  {
        ///<summary>USkeletalMesh that this vertex animation works on.</summary>
        public unsafe SkeletalMesh BaseSkelMesh {
            get {return MorphTarget_ptr->BaseSkelMesh;}
            set {MorphTarget_ptr->BaseSkelMesh = value;}
        }
        static MorphTarget() {
            StaticClass = Main.GetClass("MorphTarget");
        }
        internal unsafe MorphTarget_fields* MorphTarget_ptr => (MorphTarget_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MorphTarget(IntPtr p) => UObject.Make<MorphTarget>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MorphTarget DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MorphTarget New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
