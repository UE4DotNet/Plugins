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
    ///<summary>Anim Single Node Instance</summary>
    public unsafe partial class AnimSingleNodeInstance : AnimInstance  {

        ///<summary>Get the currently used asset</summary>
        public AnimationAsset GetAnimationAsset()  => 
            AnimSingleNodeInstance_methods.GetAnimationAsset_method.Invoke(ObjPointer);

        ///<summary>Get Length</summary>
        public float GetLength()  => 
            AnimSingleNodeInstance_methods.GetLength_method.Invoke(ObjPointer);

        ///<summary>For AnimSequence specific *</summary>
        public void PlayAnim(bool bIsLooping, float InPlayRate, float InStartPosition)  => 
            AnimSingleNodeInstance_methods.PlayAnim_method.Invoke(ObjPointer, bIsLooping, InPlayRate, InStartPosition);

        ///<summary>Set New Asset - calls InitializeAnimation, for now we need MeshComponent *</summary>
        public void SetAnimationAsset(AnimationAsset NewAsset, bool bIsLooping, float InPlayRate)  => 
            AnimSingleNodeInstance_methods.SetAnimationAsset_method.Invoke(ObjPointer, NewAsset, bIsLooping, InPlayRate);

        ///<summary>Set Blend Space Input</summary>
        public void SetBlendSpaceInput(Vector InBlendInput)  => 
            AnimSingleNodeInstance_methods.SetBlendSpaceInput_method.Invoke(ObjPointer, InBlendInput);

        ///<summary>Set Looping</summary>
        public void SetLooping(bool bIsLooping)  => 
            AnimSingleNodeInstance_methods.SetLooping_method.Invoke(ObjPointer, bIsLooping);

        ///<summary>Set Playing</summary>
        public void SetPlaying(bool bIsPlaying)  => 
            AnimSingleNodeInstance_methods.SetPlaying_method.Invoke(ObjPointer, bIsPlaying);

        ///<summary>Set Play Rate</summary>
        public void SetPlayRate(float InPlayRate)  => 
            AnimSingleNodeInstance_methods.SetPlayRate_method.Invoke(ObjPointer, InPlayRate);

        ///<summary>Set Position</summary>
        public void SetPosition(float InPosition, bool bFireNotifies)  => 
            AnimSingleNodeInstance_methods.SetPosition_method.Invoke(ObjPointer, InPosition, bFireNotifies);

        ///<summary>Set Position with Previous Time</summary>
        public void SetPositionWithPreviousTime(float InPosition, float InPreviousTime, bool bFireNotifies)  => 
            AnimSingleNodeInstance_methods.SetPositionWithPreviousTime_method.Invoke(ObjPointer, InPosition, InPreviousTime, bFireNotifies);

        ///<summary>Set pose value</summary>
        public void SetPreviewCurveOverride(Name PoseName, float Value, bool bRemoveIfZero)  => 
            AnimSingleNodeInstance_methods.SetPreviewCurveOverride_method.Invoke(ObjPointer, PoseName, Value, bRemoveIfZero);

        ///<summary>Set Reverse</summary>
        public void SetReverse(bool bInReverse)  => 
            AnimSingleNodeInstance_methods.SetReverse_method.Invoke(ObjPointer, bInReverse);

        ///<summary>Stop Anim</summary>
        public void StopAnim()  => 
            AnimSingleNodeInstance_methods.StopAnim_method.Invoke(ObjPointer);
        ///<summary>Current Asset being played *</summary>
        public unsafe AnimationAsset CurrentAsset {
            get {return AnimSingleNodeInstance_ptr->CurrentAsset;}
            set {AnimSingleNodeInstance_ptr->CurrentAsset = value;}
        }
         //TODO: delegate FPostEvaluateAnimEvent PostEvaluateAnimEvent
        static AnimSingleNodeInstance() {
            StaticClass = Main.GetClass("AnimSingleNodeInstance");
        }
        internal unsafe AnimSingleNodeInstance_fields* AnimSingleNodeInstance_ptr => (AnimSingleNodeInstance_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimSingleNodeInstance(IntPtr p) => UObject.Make<AnimSingleNodeInstance>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimSingleNodeInstance DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimSingleNodeInstance New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
