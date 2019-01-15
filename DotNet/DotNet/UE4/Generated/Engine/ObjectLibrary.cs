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
    ///<summary>Class that holds a library of Objects</summary>
    public unsafe partial class ObjectLibrary : UObject  {
        ///<summary>Class that Objects must be of. If ContainsBlueprints is true, this is the native class that the blueprints are instances of and not UClass</summary>
        public unsafe SubclassOf<UObject> ObjectBaseClass {
            get {return ObjectLibrary_ptr->ObjectBaseClass;}
            set {ObjectLibrary_ptr->ObjectBaseClass = value;}
        }
        public bool bHasBlueprintClasses {
            get {return Main.GetGetBoolPropertyByName(this, "bHasBlueprintClasses"); }
            set {Main.SetGetBoolPropertyByName(this, "bHasBlueprintClasses", value); }
        }
        ///<summary>List of Objects in library</summary>
        public ObjectArrayField<UObject> Objects{ get {
            if(Objects_store == null) Objects_store = new ObjectArrayField<UObject> (&ObjectLibrary_ptr->Objects);
            return Objects_store;
        } }
        private ObjectArrayField<UObject> Objects_store;

         //TODO: array not UObject TArray WeakObjects
        public bool bUseWeakReferences {
            get {return Main.GetGetBoolPropertyByName(this, "bUseWeakReferences"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseWeakReferences", value); }
        }
        public bool bIsFullyLoaded {
            get {return Main.GetGetBoolPropertyByName(this, "bIsFullyLoaded"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsFullyLoaded", value); }
        }
        static ObjectLibrary() {
            StaticClass = Main.GetClass("ObjectLibrary");
        }
        internal unsafe ObjectLibrary_fields* ObjectLibrary_ptr => (ObjectLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ObjectLibrary(IntPtr p) => UObject.Make<ObjectLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ObjectLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ObjectLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
