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
    ///<summary>Anim State Transition Node</summary>
    public unsafe partial class AnimStateTransitionNode : AnimStateNodeBase  {
        ///<summary>The transition logic graph for this transition (returning a boolean)</summary>
        public unsafe EdGraph BoundGraph {
            get {return AnimStateTransitionNode_ptr->BoundGraph;}
            set {AnimStateTransitionNode_ptr->BoundGraph = value;}
        }
        ///<summary>The animation graph for this transition if it uses custom blending (returning a pose)</summary>
        public unsafe EdGraph CustomTransitionGraph {
            get {return AnimStateTransitionNode_ptr->CustomTransitionGraph;}
            set {AnimStateTransitionNode_ptr->CustomTransitionGraph = value;}
        }
        ///<summary>The priority order of this transition.</summary>
        ///<remarks>
        ///If multiple transitions out of a state go
        ///true at the same time, the one with the smallest priority order will take precedent
        ///</remarks>
        public unsafe int PriorityOrder {
            get {return AnimStateTransitionNode_ptr->PriorityOrder;}
            set {AnimStateTransitionNode_ptr->PriorityOrder = value;}
        }
        ///<summary>The duration to cross-fade for</summary>
        public unsafe float CrossfadeDuration {
            get {return AnimStateTransitionNode_ptr->CrossfadeDuration;}
            set {AnimStateTransitionNode_ptr->CrossfadeDuration = value;}
        }
         //TODO: enum EAlphaBlendOption BlendMode
        ///<summary>Custom Blend Curve</summary>
        public unsafe CurveFloat CustomBlendCurve {
            get {return AnimStateTransitionNode_ptr->CustomBlendCurve;}
            set {AnimStateTransitionNode_ptr->CustomBlendCurve = value;}
        }
        ///<summary>The blend profile to use to evaluate this transition per-bone</summary>
        public unsafe BlendProfile BlendProfile {
            get {return AnimStateTransitionNode_ptr->BlendProfile;}
            set {AnimStateTransitionNode_ptr->BlendProfile = value;}
        }
        public bool bAutomaticRuleBasedOnSequencePlayerInState {
            get {return Main.GetGetBoolPropertyByName(this, "bAutomaticRuleBasedOnSequencePlayerInState"); }
            set {Main.SetGetBoolPropertyByName(this, "bAutomaticRuleBasedOnSequencePlayerInState", value); }
        }
        ///<summary>What transition logic to use</summary>
        public unsafe byte LogicType {
            get {return AnimStateTransitionNode_ptr->LogicType;}
            set {AnimStateTransitionNode_ptr->LogicType = value;}
        }
        ///<summary>Transition Start</summary>
        public unsafe AnimNotifyEvent TransitionStart {
            get {return AnimStateTransitionNode_ptr->TransitionStart;}
            set {AnimStateTransitionNode_ptr->TransitionStart = value;}
        }
        ///<summary>Transition End</summary>
        public unsafe AnimNotifyEvent TransitionEnd {
            get {return AnimStateTransitionNode_ptr->TransitionEnd;}
            set {AnimStateTransitionNode_ptr->TransitionEnd = value;}
        }
        ///<summary>Transition Interrupt</summary>
        public unsafe AnimNotifyEvent TransitionInterrupt {
            get {return AnimStateTransitionNode_ptr->TransitionInterrupt;}
            set {AnimStateTransitionNode_ptr->TransitionInterrupt = value;}
        }
        public bool Bidirectional {
            get {return Main.GetGetBoolPropertyByName(this, "Bidirectional"); }
            set {Main.SetGetBoolPropertyByName(this, "Bidirectional", value); }
        }
        public bool bSharedRules {
            get {return Main.GetGetBoolPropertyByName(this, "bSharedRules"); }
            set {Main.SetGetBoolPropertyByName(this, "bSharedRules", value); }
        }
        public bool bSharedCrossfade {
            get {return Main.GetGetBoolPropertyByName(this, "bSharedCrossfade"); }
            set {Main.SetGetBoolPropertyByName(this, "bSharedCrossfade", value); }
        }
         //TODO: string FString SharedRulesName
        ///<summary>Shared rules guid useful when copying between different state machines</summary>
        public unsafe FGuid SharedRulesGuid {
            get {return AnimStateTransitionNode_ptr->SharedRulesGuid;}
            set {AnimStateTransitionNode_ptr->SharedRulesGuid = value;}
        }
        ///<summary>Color we draw in the editor as if we are shared</summary>
        public unsafe LinearColor SharedColor {
            get {return AnimStateTransitionNode_ptr->SharedColor;}
            set {AnimStateTransitionNode_ptr->SharedColor = value;}
        }
         //TODO: string FString SharedCrossfadeName
        ///<summary>Shared Crossfade Guid</summary>
        public unsafe FGuid SharedCrossfadeGuid {
            get {return AnimStateTransitionNode_ptr->SharedCrossfadeGuid;}
            set {AnimStateTransitionNode_ptr->SharedCrossfadeGuid = value;}
        }
        ///<summary>Shared Crossfade Idx</summary>
        public unsafe int SharedCrossfadeIdx {
            get {return AnimStateTransitionNode_ptr->SharedCrossfadeIdx;}
            set {AnimStateTransitionNode_ptr->SharedCrossfadeIdx = value;}
        }
        static AnimStateTransitionNode() {
            StaticClass = Main.GetClass("AnimStateTransitionNode");
        }
        internal unsafe AnimStateTransitionNode_fields* AnimStateTransitionNode_ptr => (AnimStateTransitionNode_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimStateTransitionNode(IntPtr p) => UObject.Make<AnimStateTransitionNode>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimStateTransitionNode DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimStateTransitionNode New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
