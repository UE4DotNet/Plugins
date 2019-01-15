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
using UE4.AIModule.Native;
using UE4.Engine;

namespace UE4.AIModule {
    ///<summary>
    ///Play indicated AnimationAsset on Pawn controlled by BT
    ///Note that this node is generic and is handing multiple special cases,
    ///</summary>
    ///<remarks>If you want a more efficient solution you'll need to implement it yourself (or wait for our BTTask_PlayCharacterAnimation)</remarks>
    public unsafe partial class BTTask_PlayAnimation : BTTaskNode  {
        ///<summary>Animation asset to play. Note that it needs to match the skeleton of pawn this BT is controlling</summary>
        public unsafe AnimationAsset AnimationToPlay {
            get {return BTTask_PlayAnimation_ptr->AnimationToPlay;}
            set {BTTask_PlayAnimation_ptr->AnimationToPlay = value;}
        }
        public bool bLooping {
            get {return Main.GetGetBoolPropertyByName(this, "bLooping"); }
            set {Main.SetGetBoolPropertyByName(this, "bLooping", value); }
        }
        public bool bNonBlocking {
            get {return Main.GetGetBoolPropertyByName(this, "bNonBlocking"); }
            set {Main.SetGetBoolPropertyByName(this, "bNonBlocking", value); }
        }
        ///<summary>My Owner Comp</summary>
        public unsafe BehaviorTreeComponent MyOwnerComp {
            get {return BTTask_PlayAnimation_ptr->MyOwnerComp;}
            set {BTTask_PlayAnimation_ptr->MyOwnerComp = value;}
        }
        ///<summary>Cached Skel Mesh</summary>
        public unsafe SkeletalMeshComponent CachedSkelMesh {
            get {return BTTask_PlayAnimation_ptr->CachedSkelMesh;}
            set {BTTask_PlayAnimation_ptr->CachedSkelMesh = value;}
        }
        static BTTask_PlayAnimation() {
            StaticClass = Main.GetClass("BTTask_PlayAnimation");
        }
        internal unsafe BTTask_PlayAnimation_fields* BTTask_PlayAnimation_ptr => (BTTask_PlayAnimation_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTTask_PlayAnimation(IntPtr p) => UObject.Make<BTTask_PlayAnimation>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTTask_PlayAnimation DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTTask_PlayAnimation New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
