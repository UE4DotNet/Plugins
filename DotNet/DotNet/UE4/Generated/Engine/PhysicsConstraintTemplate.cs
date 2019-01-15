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
    ///<summary>Physics Constraint Template</summary>
    public unsafe partial class PhysicsConstraintTemplate : UObject  {
        ///<summary>Default Instance</summary>
        public unsafe ConstraintInstance DefaultInstance {
            get {return PhysicsConstraintTemplate_ptr->DefaultInstance;}
            set {PhysicsConstraintTemplate_ptr->DefaultInstance = value;}
        }
         //TODO: array not UObject TArray ProfileHandles
        ///<summary>When no profile is selected, use these settings. Only needed in editor as we serialize it into DefaultInstance on save</summary>
        public unsafe ConstraintProfileProperties DefaultProfile {
            get {return PhysicsConstraintTemplate_ptr->DefaultProfile;}
            set {PhysicsConstraintTemplate_ptr->DefaultProfile = value;}
        }
        static PhysicsConstraintTemplate() {
            StaticClass = Main.GetClass("PhysicsConstraintTemplate");
        }
        internal unsafe PhysicsConstraintTemplate_fields* PhysicsConstraintTemplate_ptr => (PhysicsConstraintTemplate_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PhysicsConstraintTemplate(IntPtr p) => UObject.Make<PhysicsConstraintTemplate>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PhysicsConstraintTemplate DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PhysicsConstraintTemplate New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
