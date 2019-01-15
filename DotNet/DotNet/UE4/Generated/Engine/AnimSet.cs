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
    ///<summary>Anim Set</summary>
    public unsafe partial class AnimSet : UObject  {
        public bool bAnimRotationOnly {
            get {return Main.GetGetBoolPropertyByName(this, "bAnimRotationOnly"); }
            set {Main.SetGetBoolPropertyByName(this, "bAnimRotationOnly", value); }
        }
         //TODO: array not UObject TArray TrackBoneNames
        ///<summary>Actual animation sequence information.</summary>
        public ObjectArrayField<AnimSequence> Sequences{ get {
            if(Sequences_store == null) Sequences_store = new ObjectArrayField<AnimSequence> (&AnimSet_ptr->Sequences);
            return Sequences_store;
        } }
        private ObjectArrayField<AnimSequence> Sequences_store;

         //TODO: array not UObject TArray LinkupCache
         //TODO: array not UObject TArray BoneUseAnimTranslation
         //TODO: array not UObject TArray ForceUseMeshTranslation
         //TODO: array not UObject TArray UseTranslationBoneNames
         //TODO: array not UObject TArray ForceMeshTranslationBoneNames
        ///<summary>In the AnimSetEditor, when you switch to this AnimSet, it sees if this skeletal mesh is loaded and if so switches to it.</summary>
        public unsafe Name PreviewSkelMeshName {
            get {return AnimSet_ptr->PreviewSkelMeshName;}
            set {AnimSet_ptr->PreviewSkelMeshName = value;}
        }
        ///<summary>Holds the name of the skeletal mesh whose reference skeleton best matches the TrackBoneName array.</summary>
        public unsafe Name BestRatioSkelMeshName {
            get {return AnimSet_ptr->BestRatioSkelMeshName;}
            set {AnimSet_ptr->BestRatioSkelMeshName = value;}
        }
        static AnimSet() {
            StaticClass = Main.GetClass("AnimSet");
        }
        internal unsafe AnimSet_fields* AnimSet_ptr => (AnimSet_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimSet(IntPtr p) => UObject.Make<AnimSet>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimSet DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimSet New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
