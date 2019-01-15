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
    ///<summary>Skeletal Mesh Socket</summary>
    public unsafe partial class SkeletalMeshSocket : UObject  {

        ///<summary>Get Socket Location</summary>
        public Vector GetSocketLocation(SkeletalMeshComponent SkelComp)  => 
            SkeletalMeshSocket_methods.GetSocketLocation_method.Invoke(ObjPointer, SkelComp);

        ///<summary>Sets BoneName, RelativeLocation and RelativeRotation based on closest bone to WorldLocation and WorldNormal</summary>
        public void InitializeSocketFromLocation(SkeletalMeshComponent SkelComp, Vector WorldLocation, Vector WorldNormal)  => 
            SkeletalMeshSocket_methods.InitializeSocketFromLocation_method.Invoke(ObjPointer, SkelComp, WorldLocation, WorldNormal);
        ///<summary>Defines a named attachment location on the USkeletalMesh.</summary>
        ///<remarks>
        ///These are set up in editor and used as a shortcut instead of specifying
        ///everything explicitly to AttachComponent in the SkeletalMeshComponent.
        ///The Outer of a SkeletalMeshSocket should always be the USkeletalMesh.
        ///</remarks>
        public unsafe Name SocketName {
            get {return SkeletalMeshSocket_ptr->SocketName;}
        }
        ///<summary>Bone Name</summary>
        public unsafe Name BoneName {
            get {return SkeletalMeshSocket_ptr->BoneName;}
        }
        ///<summary>Relative Location</summary>
        public unsafe Vector RelativeLocation {
            get {return SkeletalMeshSocket_ptr->RelativeLocation;}
        }
        ///<summary>Relative Rotation</summary>
        public unsafe Rotator RelativeRotation {
            get {return SkeletalMeshSocket_ptr->RelativeRotation;}
        }
        ///<summary>Relative Scale</summary>
        public unsafe Vector RelativeScale {
            get {return SkeletalMeshSocket_ptr->RelativeScale;}
        }
        public bool bForceAlwaysAnimated {
            get {return Main.GetGetBoolPropertyByName(this, "bForceAlwaysAnimated"); }
        }
        static SkeletalMeshSocket() {
            StaticClass = Main.GetClass("SkeletalMeshSocket");
        }
        internal unsafe SkeletalMeshSocket_fields* SkeletalMeshSocket_ptr => (SkeletalMeshSocket_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SkeletalMeshSocket(IntPtr p) => UObject.Make<SkeletalMeshSocket>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SkeletalMeshSocket DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SkeletalMeshSocket New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
