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
using UE4.MeshEditor.Native;

namespace UE4.MeshEditor {
    ///<summary>Mesh Editor Edit Command</summary>
    public unsafe partial class MeshEditorEditCommand : MeshEditorCommand  {
         //TODO: text FText UndoText
        public bool bNeedsDraggingInitiated {
            get {return Main.GetGetBoolPropertyByName(this, "bNeedsDraggingInitiated"); }
            set {Main.SetGetBoolPropertyByName(this, "bNeedsDraggingInitiated", value); }
        }
        public bool bNeedsHoverLocation {
            get {return Main.GetGetBoolPropertyByName(this, "bNeedsHoverLocation"); }
            set {Main.SetGetBoolPropertyByName(this, "bNeedsHoverLocation", value); }
        }
        static MeshEditorEditCommand() {
            StaticClass = Main.GetClass("MeshEditorEditCommand");
        }
        internal unsafe MeshEditorEditCommand_fields* MeshEditorEditCommand_ptr => (MeshEditorEditCommand_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MeshEditorEditCommand(IntPtr p) => UObject.Make<MeshEditorEditCommand>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MeshEditorEditCommand DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MeshEditorEditCommand New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
