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
using UE4.ViewportInteraction.Native;
using UE4.Engine;

namespace UE4.ViewportInteraction {
    ///<summary>Base class for transform gizmo</summary>
    public unsafe partial class BaseTransformGizmo : Actor  {
        ///<summary>Scene component root of this actor</summary>
        public unsafe SceneComponent SceneComponent {
            get {return BaseTransformGizmo_ptr->SceneComponent;}
            set {BaseTransformGizmo_ptr->SceneComponent = value;}
        }
        ///<summary>All gizmo components</summary>
        public ObjectArrayField<GizmoHandleGroup> AllHandleGroups{ get {
            if(AllHandleGroups_store == null) AllHandleGroups_store = new ObjectArrayField<GizmoHandleGroup> (&BaseTransformGizmo_ptr->AllHandleGroups);
            return AllHandleGroups_store;
        } }
        private ObjectArrayField<GizmoHandleGroup> AllHandleGroups_store;

        ///<summary>Owning object</summary>
        public unsafe ViewportWorldInteraction WorldInteraction {
            get {return BaseTransformGizmo_ptr->WorldInteraction;}
            set {BaseTransformGizmo_ptr->WorldInteraction = value;}
        }
        static BaseTransformGizmo() {
            StaticClass = Main.GetClass("BaseTransformGizmo");
        }
        internal unsafe BaseTransformGizmo_fields* BaseTransformGizmo_ptr => (BaseTransformGizmo_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BaseTransformGizmo(IntPtr p) => UObject.Make<BaseTransformGizmo>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BaseTransformGizmo DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BaseTransformGizmo New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
