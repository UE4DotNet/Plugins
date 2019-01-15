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
    ///<summary>Helper / intermediate for asset player graphical nodes</summary>
    public unsafe partial class AnimGraphNode_AssetPlayerBase : AnimGraphNode_Base  {
        ///<summary>Sync group settings for this player.  Sync groups keep related animations with different lengths synchronized.</summary>
        public unsafe AnimationGroupReference SyncGroup {
            get {return AnimGraphNode_AssetPlayerBase_ptr->SyncGroup;}
            set {AnimGraphNode_AssetPlayerBase_ptr->SyncGroup = value;}
        }
        static AnimGraphNode_AssetPlayerBase() {
            StaticClass = Main.GetClass("AnimGraphNode_AssetPlayerBase");
        }
        internal unsafe AnimGraphNode_AssetPlayerBase_fields* AnimGraphNode_AssetPlayerBase_ptr => (AnimGraphNode_AssetPlayerBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimGraphNode_AssetPlayerBase(IntPtr p) => UObject.Make<AnimGraphNode_AssetPlayerBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimGraphNode_AssetPlayerBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimGraphNode_AssetPlayerBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
