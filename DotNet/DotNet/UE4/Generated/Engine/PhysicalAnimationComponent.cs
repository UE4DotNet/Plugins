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
    ///<summary>Physical Animation Component</summary>
    public unsafe partial class PhysicalAnimationComponent : ActorComponent  {

        ///<summary>Applies the physical animation profile to the body given and all bodies below.</summary>
        ///<remarks>
        ///@param  BodyName                     The body from which we'd like to start applying the physical animation profile. Finds all bodies below in the skeleton hierarchy. None implies all bodies
        ///@param  ProfileName          The physical animation profile we'd like to apply. For each body in the physics asset we search for physical animation settings with this name.
        ///@param  bIncludeSelf         Whether to include the provided body name in the list of bodies we act on (useful to ignore for cases where a root has multiple children)
        ///@param  bClearNotFound       If true, bodies without the given profile name will have any existing physical animation settings cleared. If false, bodies without the given profile name are left untouched.
        ///</remarks>
        public void ApplyPhysicalAnimationProfileBelow(Name BodyName, Name ProfileName, bool bIncludeSelf, bool bClearNotFound)  => 
            PhysicalAnimationComponent_methods.ApplyPhysicalAnimationProfileBelow_method.Invoke(ObjPointer, BodyName, ProfileName, bIncludeSelf, bClearNotFound);

        ///<summary>Applies the physical animation settings to the body given.</summary>
        public void ApplyPhysicalAnimationSettings(Name BodyName, PhysicalAnimationData PhysicalAnimationData)  => 
            PhysicalAnimationComponent_methods.ApplyPhysicalAnimationSettings_method.Invoke(ObjPointer, BodyName, PhysicalAnimationData);

        ///<summary>Applies the physical animation settings to the body given and all bodies below.</summary>
        public void ApplyPhysicalAnimationSettingsBelow(Name BodyName, PhysicalAnimationData PhysicalAnimationData, bool bIncludeSelf)  => 
            PhysicalAnimationComponent_methods.ApplyPhysicalAnimationSettingsBelow_method.Invoke(ObjPointer, BodyName, PhysicalAnimationData, bIncludeSelf);

        ///<summary>Returns the target transform for the given body. If physical animation component is not controlling this body, returns its current transform.</summary>
        public Transform GetBodyTargetTransform(Name BodyName)  => 
            PhysicalAnimationComponent_methods.GetBodyTargetTransform_method.Invoke(ObjPointer, BodyName);

        ///<summary>Sets the skeletal mesh we are driving through physical animation. Will erase any existing physical animation data.</summary>
        public void SetSkeletalMeshComponent(SkeletalMeshComponent InSkeletalMeshComponent)  => 
            PhysicalAnimationComponent_methods.SetSkeletalMeshComponent_method.Invoke(ObjPointer, InSkeletalMeshComponent);

        ///<summary>Updates strength multiplyer and any active motors</summary>
        public void SetStrengthMultiplyer(float InStrengthMultiplyer)  => 
            PhysicalAnimationComponent_methods.SetStrengthMultiplyer_method.Invoke(ObjPointer, InStrengthMultiplyer);
        ///<summary>Multiplies the strength of any active motors. (can blend from 0-1 for example)</summary>
        public unsafe float StrengthMultiplyer {
            get {return PhysicalAnimationComponent_ptr->StrengthMultiplyer;}
        }
        ///<summary>Skeletal Mesh Component</summary>
        public unsafe SkeletalMeshComponent SkeletalMeshComponent {
            get {return PhysicalAnimationComponent_ptr->SkeletalMeshComponent;}
            set {PhysicalAnimationComponent_ptr->SkeletalMeshComponent = value;}
        }
        static PhysicalAnimationComponent() {
            StaticClass = Main.GetClass("PhysicalAnimationComponent");
        }
        internal unsafe PhysicalAnimationComponent_fields* PhysicalAnimationComponent_ptr => (PhysicalAnimationComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PhysicalAnimationComponent(IntPtr p) => UObject.Make<PhysicalAnimationComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PhysicalAnimationComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PhysicalAnimationComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
