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
using UE4.DatasmithContent.Native;
using UE4.Engine;

namespace UE4.DatasmithContent {
    ///<summary>Datasmith Scene Component Template</summary>
    public unsafe partial class DatasmithSceneComponentTemplate : DatasmithObjectTemplate  {
        ///<summary>Relative Transform</summary>
        public unsafe Transform RelativeTransform {
            get {return DatasmithSceneComponentTemplate_ptr->RelativeTransform;}
            set {DatasmithSceneComponentTemplate_ptr->RelativeTransform = value;}
        }
        ///<summary>Mobility</summary>
        public unsafe byte Mobility {
            get {return DatasmithSceneComponentTemplate_ptr->Mobility;}
            set {DatasmithSceneComponentTemplate_ptr->Mobility = value;}
        }
        ///<summary>Attach Parent</summary>
        public unsafe SceneComponent AttachParent {
            get {return DatasmithSceneComponentTemplate_ptr->AttachParent;}
            set {DatasmithSceneComponentTemplate_ptr->AttachParent = value;}
        }
        static DatasmithSceneComponentTemplate() {
            StaticClass = Main.GetClass("DatasmithSceneComponentTemplate");
        }
        internal unsafe DatasmithSceneComponentTemplate_fields* DatasmithSceneComponentTemplate_ptr => (DatasmithSceneComponentTemplate_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DatasmithSceneComponentTemplate(IntPtr p) => UObject.Make<DatasmithSceneComponentTemplate>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DatasmithSceneComponentTemplate DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DatasmithSceneComponentTemplate New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
