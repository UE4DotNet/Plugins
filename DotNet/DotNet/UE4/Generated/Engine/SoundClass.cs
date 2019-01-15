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
    ///<summary>Sound Class</summary>
    public unsafe partial class SoundClass : UObject  {
        ///<summary>Configurable properties like volume and priority.</summary>
        public unsafe SoundClassProperties Properties {
            get {return SoundClass_ptr->Properties;}
        }
        ///<summary>Child Classes</summary>
        public ObjectArrayField<SoundClass> ChildClasses{ get {
            if(ChildClasses_store == null) ChildClasses_store = new ObjectArrayField<SoundClass> (&SoundClass_ptr->ChildClasses);
            return ChildClasses_store;
        } }
        private ObjectArrayField<SoundClass> ChildClasses_store;

         //TODO: array not UObject TArray PassiveSoundMixModifiers
        ///<summary>Parent Class</summary>
        public unsafe SoundClass ParentClass {
            get {return SoundClass_ptr->ParentClass;}
            set {SoundClass_ptr->ParentClass = value;}
        }
        static SoundClass() {
            StaticClass = Main.GetClass("SoundClass");
        }
        internal unsafe SoundClass_fields* SoundClass_ptr => (SoundClass_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SoundClass(IntPtr p) => UObject.Make<SoundClass>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SoundClass DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SoundClass New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
