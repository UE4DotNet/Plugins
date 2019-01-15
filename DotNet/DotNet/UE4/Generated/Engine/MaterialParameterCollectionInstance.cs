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
    ///<summary>Class that stores per-world instance parameter data for a given UMaterialParameterCollection resource.</summary>
    ///<remarks>Instances of this class are always transient.</remarks>
    public unsafe partial class MaterialParameterCollectionInstance : UObject  {
        ///<summary>Collection resource this instance is based off of.</summary>
        public unsafe MaterialParameterCollection Collection {
            get {return MaterialParameterCollectionInstance_ptr->Collection;}
            set {MaterialParameterCollectionInstance_ptr->Collection = value;}
        }
        ///<summary>World that owns this instance.</summary>
        public unsafe World World {
            get {return MaterialParameterCollectionInstance_ptr->World;}
            set {MaterialParameterCollectionInstance_ptr->World = value;}
        }
        static MaterialParameterCollectionInstance() {
            StaticClass = Main.GetClass("MaterialParameterCollectionInstance");
        }
        internal unsafe MaterialParameterCollectionInstance_fields* MaterialParameterCollectionInstance_ptr => (MaterialParameterCollectionInstance_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialParameterCollectionInstance(IntPtr p) => UObject.Make<MaterialParameterCollectionInstance>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialParameterCollectionInstance DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialParameterCollectionInstance New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
