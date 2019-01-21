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
    ///<summary>Ed Graph Node</summary>
    public unsafe partial class EdGraphNode : UObject  {
        ///<summary>X position of node in the editor</summary>
        public unsafe int NodePosX {
            get {return EdGraphNode_ptr->NodePosX;}
            set {EdGraphNode_ptr->NodePosX = value;}
        }
        ///<summary>Y position of node in the editor</summary>
        public unsafe int NodePosY {
            get {return EdGraphNode_ptr->NodePosY;}
            set {EdGraphNode_ptr->NodePosY = value;}
        }
        ///<summary>Width of node in the editor; only used when the node can be resized</summary>
        public unsafe int NodeWidth {
            get {return EdGraphNode_ptr->NodeWidth;}
            set {EdGraphNode_ptr->NodeWidth = value;}
        }
        ///<summary>Height of node in the editor; only used when the node can be resized</summary>
        public unsafe int NodeHeight {
            get {return EdGraphNode_ptr->NodeHeight;}
            set {EdGraphNode_ptr->NodeHeight = value;}
        }
        ///<summary>Enum to indicate if a node has advanced-display-pins, and if they are shown</summary>
        public unsafe byte AdvancedPinDisplay {
            get {return EdGraphNode_ptr->AdvancedPinDisplay;}
            set {EdGraphNode_ptr->AdvancedPinDisplay = value;}
        }
         //TODO: enum ENodeEnabledState EnabledState
        public bool bDisplayAsDisabled {
            get {return Main.GetGetBoolPropertyByName(this, "bDisplayAsDisabled"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisplayAsDisabled", value); }
        }
        public bool bUserSetEnabledState {
            get {return Main.GetGetBoolPropertyByName(this, "bUserSetEnabledState"); }
            set {Main.SetGetBoolPropertyByName(this, "bUserSetEnabledState", value); }
        }
        public bool bCanResizeNode {
            get {return Main.GetGetBoolPropertyByName(this, "bCanResizeNode"); }
            set {Main.SetGetBoolPropertyByName(this, "bCanResizeNode", value); }
        }
        public bool bHasCompilerMessage {
            get {return Main.GetGetBoolPropertyByName(this, "bHasCompilerMessage"); }
            set {Main.SetGetBoolPropertyByName(this, "bHasCompilerMessage", value); }
        }
        public bool bCommentBubblePinned {
            get {return Main.GetGetBoolPropertyByName(this, "bCommentBubblePinned"); }
            set {Main.SetGetBoolPropertyByName(this, "bCommentBubblePinned", value); }
        }
        public bool bCommentBubbleVisible {
            get {return Main.GetGetBoolPropertyByName(this, "bCommentBubbleVisible"); }
            set {Main.SetGetBoolPropertyByName(this, "bCommentBubbleVisible", value); }
        }
        public bool bCommentBubbleMakeVisible {
            get {return Main.GetGetBoolPropertyByName(this, "bCommentBubbleMakeVisible"); }
            set {Main.SetGetBoolPropertyByName(this, "bCommentBubbleMakeVisible", value); }
        }
        public bool bCanRenameNode {
            get {return Main.GetGetBoolPropertyByName(this, "bCanRenameNode"); }
            set {Main.SetGetBoolPropertyByName(this, "bCanRenameNode", value); }
        }
         //TODO: text FText NodeUpgradeMessage
         //TODO: string FString NodeComment
        ///<summary>Flag to store node specific compile error/warning</summary>
        public unsafe int ErrorType {
            get {return EdGraphNode_ptr->ErrorType;}
            set {EdGraphNode_ptr->ErrorType = value;}
        }
         //TODO: string FString ErrorMsg
        ///<summary>GUID to uniquely identify this node, to facilitate diffing versions of this graph</summary>
        public unsafe FGuid NodeGuid {
            get {return EdGraphNode_ptr->NodeGuid;}
            set {EdGraphNode_ptr->NodeGuid = value;}
        }
        static EdGraphNode() {
            StaticClass = Main.GetClass("EdGraphNode");
        }
        internal unsafe EdGraphNode_fields* EdGraphNode_ptr => (EdGraphNode_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EdGraphNode(IntPtr p) => UObject.Make<EdGraphNode>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EdGraphNode DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EdGraphNode New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
