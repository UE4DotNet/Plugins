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
using UE4.UMG.Native;

namespace UE4.UMG {
    ///<summary>Property Binding</summary>
    public unsafe partial class PropertyBinding : UObject  {
         //TODO: weak object TWeakObjectPtr<UObject> SourceObject
        ///<summary>The property path to trace to resolve this binding on the Source Object</summary>
        public unsafe DynamicPropertyPath SourcePath {
            get {return PropertyBinding_ptr->SourcePath;}
            set {PropertyBinding_ptr->SourcePath = value;}
        }
        ///<summary>Used to determine if a binding already exists on the object and if this binding can be safely removed.</summary>
        public unsafe Name DestinationProperty {
            get {return PropertyBinding_ptr->DestinationProperty;}
            set {PropertyBinding_ptr->DestinationProperty = value;}
        }
        static PropertyBinding() {
            StaticClass = Main.GetClass("PropertyBinding");
        }
        internal unsafe PropertyBinding_fields* PropertyBinding_ptr => (PropertyBinding_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PropertyBinding(IntPtr p) => UObject.Make<PropertyBinding>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PropertyBinding DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PropertyBinding New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
