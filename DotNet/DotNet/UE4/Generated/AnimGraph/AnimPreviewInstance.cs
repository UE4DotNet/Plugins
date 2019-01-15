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
using UE4.AnimGraph.Native;
using UE4.Engine;

namespace UE4.AnimGraph {
    ///<summary>This Instance only contains one AnimationAsset, and produce poses</summary>
    ///<remarks>Used by Preview in AnimGraph, Playing single animation in Kismet2 and etc</remarks>
    public unsafe partial class AnimPreviewInstance : AnimSingleNodeInstance  {
        ///<summary>Shared parameters for previewing blendspace or animsequence *</summary>
        public unsafe byte MontagePreviewType {
            get {return AnimPreviewInstance_ptr->MontagePreviewType;}
            set {AnimPreviewInstance_ptr->MontagePreviewType = value;}
        }
        ///<summary>Montage Preview Start Section Idx</summary>
        public unsafe int MontagePreviewStartSectionIdx {
            get {return AnimPreviewInstance_ptr->MontagePreviewStartSectionIdx;}
            set {AnimPreviewInstance_ptr->MontagePreviewStartSectionIdx = value;}
        }
        static AnimPreviewInstance() {
            StaticClass = Main.GetClass("AnimPreviewInstance");
        }
        internal unsafe AnimPreviewInstance_fields* AnimPreviewInstance_ptr => (AnimPreviewInstance_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimPreviewInstance(IntPtr p) => UObject.Make<AnimPreviewInstance>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimPreviewInstance DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimPreviewInstance New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
