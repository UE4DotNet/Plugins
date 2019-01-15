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
    ///<summary>Anim Notify State Trail</summary>
    public unsafe partial class AnimNotifyState_Trail : AnimNotifyState  {

        ///<summary>Override PSTemplate</summary>
        public event OverridePSTemplate_delegate OverridePSTemplate;
        public delegate ParticleSystem OverridePSTemplate_delegate(SkeletalMeshComponent MeshComp, AnimSequenceBase Animation, ParticleSystem ReturnValue);
        internal ParticleSystem on_OverridePSTemplate(SkeletalMeshComponent MeshComp, AnimSequenceBase Animation, ParticleSystem ReturnValue) =>
            OverridePSTemplate != null ? OverridePSTemplate(MeshComp, Animation, ReturnValue) : ReturnValue;

        ///<summary>The particle system to use for this trail.</summary>
        public unsafe ParticleSystem PSTemplate {
            get {return AnimNotifyState_Trail_ptr->PSTemplate;}
        }
        ///<summary>Name of the first socket defining this trail.</summary>
        public unsafe Name FirstSocketName {
            get {return AnimNotifyState_Trail_ptr->FirstSocketName;}
        }
        ///<summary>Name of the second socket defining this trail.</summary>
        public unsafe Name SecondSocketName {
            get {return AnimNotifyState_Trail_ptr->SecondSocketName;}
        }
        ///<summary>Controls the way width scale is applied.</summary>
        ///<remarks>
        ///In each method a width scale of 1.0 will mean the width is unchanged from the position of the sockets. A width scale of 0.0 will cause a trail of zero width.
        ///From Centre = Trail width is scaled outwards from the centre point between the two sockets.
        ///From First = Trail width is scaled outwards from the position of the first socket.
        ///From Second = Trail width is scaled outwards from the position of the Second socket.
        ///</remarks>
        public unsafe byte WidthScaleMode {
            get {return AnimNotifyState_Trail_ptr->WidthScaleMode;}
        }
        ///<summary>Name of the curve to drive the width scale.</summary>
        public unsafe Name WidthScaleCurve {
            get {return AnimNotifyState_Trail_ptr->WidthScaleCurve;}
        }
        public bool bRecycleSpawnedSystems {
            get {return Main.GetGetBoolPropertyByName(this, "bRecycleSpawnedSystems"); }
        }
        public bool bRenderGeometry {
            get {return Main.GetGetBoolPropertyByName(this, "bRenderGeometry"); }
        }
        public bool bRenderSpawnPoints {
            get {return Main.GetGetBoolPropertyByName(this, "bRenderSpawnPoints"); }
        }
        public bool bRenderTangents {
            get {return Main.GetGetBoolPropertyByName(this, "bRenderTangents"); }
        }
        public bool bRenderTessellation {
            get {return Main.GetGetBoolPropertyByName(this, "bRenderTessellation"); }
        }
        static AnimNotifyState_Trail() {
            StaticClass = Main.GetClass("AnimNotifyState_Trail");
            AnimNotifyState_Trail_events.OverridePSTemplate_event.Setup();
        }
        internal unsafe AnimNotifyState_Trail_fields* AnimNotifyState_Trail_ptr => (AnimNotifyState_Trail_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimNotifyState_Trail(IntPtr p) => UObject.Make<AnimNotifyState_Trail>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimNotifyState_Trail DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimNotifyState_Trail New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
