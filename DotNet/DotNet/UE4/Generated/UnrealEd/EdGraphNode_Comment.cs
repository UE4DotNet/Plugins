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
using UE4.UnrealEd.Native;
using UE4.Engine;

namespace UE4.UnrealEd {
    ///<summary>Ed Graph Node Comment</summary>
    public unsafe partial class EdGraphNode_Comment : EdGraphNode  {
        ///<summary>Color to style comment with</summary>
        public unsafe LinearColor CommentColor {
            get {return EdGraphNode_Comment_ptr->CommentColor;}
            set {EdGraphNode_Comment_ptr->CommentColor = value;}
        }
        ///<summary>Size of the text in the comment box</summary>
        public unsafe int FontSize {
            get {return EdGraphNode_Comment_ptr->FontSize;}
            set {EdGraphNode_Comment_ptr->FontSize = value;}
        }
        public bool bCommentBubbleVisible_InDetailsPanel {
            get {return Main.GetGetBoolPropertyByName(this, "bCommentBubbleVisible_InDetailsPanel"); }
            set {Main.SetGetBoolPropertyByName(this, "bCommentBubbleVisible_InDetailsPanel", value); }
        }
        public bool bColorCommentBubble {
            get {return Main.GetGetBoolPropertyByName(this, "bColorCommentBubble"); }
            set {Main.SetGetBoolPropertyByName(this, "bColorCommentBubble", value); }
        }
        ///<summary>Whether the comment should move any fully enclosed nodes around when it is moved</summary>
        public unsafe byte MoveMode {
            get {return EdGraphNode_Comment_ptr->MoveMode;}
            set {EdGraphNode_Comment_ptr->MoveMode = value;}
        }
        ///<summary>comment Depth</summary>
        public unsafe int CommentDepth {
            get {return EdGraphNode_Comment_ptr->CommentDepth;}
            set {EdGraphNode_Comment_ptr->CommentDepth = value;}
        }
        static EdGraphNode_Comment() {
            StaticClass = Main.GetClass("EdGraphNode_Comment");
        }
        internal unsafe EdGraphNode_Comment_fields* EdGraphNode_Comment_ptr => (EdGraphNode_Comment_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EdGraphNode_Comment(IntPtr p) => UObject.Make<EdGraphNode_Comment>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EdGraphNode_Comment DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EdGraphNode_Comment New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
