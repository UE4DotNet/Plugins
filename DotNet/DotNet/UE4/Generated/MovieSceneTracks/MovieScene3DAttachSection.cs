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
using UE4.MovieSceneTracks.Native;

namespace UE4.MovieSceneTracks {
    ///<summary>A 3D Attach section</summary>
    public unsafe partial class MovieScene3DAttachSection : MovieScene3DConstraintSection  {
        ///<summary>Attach Socket Name</summary>
        public unsafe Name AttachSocketName {
            get {return MovieScene3DAttachSection_ptr->AttachSocketName;}
            set {MovieScene3DAttachSection_ptr->AttachSocketName = value;}
        }
        ///<summary>Attach Component Name</summary>
        public unsafe Name AttachComponentName {
            get {return MovieScene3DAttachSection_ptr->AttachComponentName;}
            set {MovieScene3DAttachSection_ptr->AttachComponentName = value;}
        }
         //TODO: enum EAttachmentRule AttachmentLocationRule
         //TODO: enum EAttachmentRule AttachmentRotationRule
         //TODO: enum EAttachmentRule AttachmentScaleRule
         //TODO: enum EDetachmentRule DetachmentLocationRule
         //TODO: enum EDetachmentRule DetachmentRotationRule
         //TODO: enum EDetachmentRule DetachmentScaleRule
        static MovieScene3DAttachSection() {
            StaticClass = Main.GetClass("MovieScene3DAttachSection");
        }
        internal unsafe MovieScene3DAttachSection_fields* MovieScene3DAttachSection_ptr => (MovieScene3DAttachSection_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieScene3DAttachSection(IntPtr p) => UObject.Make<MovieScene3DAttachSection>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieScene3DAttachSection DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieScene3DAttachSection New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
