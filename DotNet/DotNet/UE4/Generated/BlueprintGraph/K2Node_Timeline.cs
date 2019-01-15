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
using UE4.BlueprintGraph.Native;

namespace UE4.BlueprintGraph {
    ///<summary>K2Node Timeline</summary>
    public unsafe partial class K2Node_Timeline : K2Node  {
        ///<summary>The name of the timeline. Used to name ONLY the member variable (Component). To obtain the name of timeline template use UTimelineTemplate::TimelineVariableNameToTemplateName</summary>
        public unsafe Name TimelineName {
            get {return K2Node_Timeline_ptr->TimelineName;}
            set {K2Node_Timeline_ptr->TimelineName = value;}
        }
        public bool bAutoPlay {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoPlay"); }
            set {Main.SetGetBoolPropertyByName(this, "bAutoPlay", value); }
        }
        ///<summary>Unique ID for the template we use, required to indentify the timeline after a paste</summary>
        public unsafe FGuid TimelineGuid {
            get {return K2Node_Timeline_ptr->TimelineGuid;}
            set {K2Node_Timeline_ptr->TimelineGuid = value;}
        }
        public bool bLoop {
            get {return Main.GetGetBoolPropertyByName(this, "bLoop"); }
            set {Main.SetGetBoolPropertyByName(this, "bLoop", value); }
        }
        public bool bReplicated {
            get {return Main.GetGetBoolPropertyByName(this, "bReplicated"); }
            set {Main.SetGetBoolPropertyByName(this, "bReplicated", value); }
        }
        public bool bIgnoreTimeDilation {
            get {return Main.GetGetBoolPropertyByName(this, "bIgnoreTimeDilation"); }
            set {Main.SetGetBoolPropertyByName(this, "bIgnoreTimeDilation", value); }
        }
        static K2Node_Timeline() {
            StaticClass = Main.GetClass("K2Node_Timeline");
        }
        internal unsafe K2Node_Timeline_fields* K2Node_Timeline_ptr => (K2Node_Timeline_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator K2Node_Timeline(IntPtr p) => UObject.Make<K2Node_Timeline>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static K2Node_Timeline DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static K2Node_Timeline New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
