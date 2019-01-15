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

namespace UE4.UnrealEd {
    ///<summary>Holds a map of extension collections paired with worlds</summary>
    public unsafe partial class EditorWorldExtensionManager : UObject  {
        ///<summary>Map of all the editor world maps</summary>
        public ObjectArrayField<EditorWorldExtensionCollection> EditorWorldExtensionCollection{ get {
            if(EditorWorldExtensionCollection_store == null) EditorWorldExtensionCollection_store = new ObjectArrayField<EditorWorldExtensionCollection> (&EditorWorldExtensionManager_ptr->EditorWorldExtensionCollection);
            return EditorWorldExtensionCollection_store;
        } }
        private ObjectArrayField<EditorWorldExtensionCollection> EditorWorldExtensionCollection_store;

        static EditorWorldExtensionManager() {
            StaticClass = Main.GetClass("EditorWorldExtensionManager");
        }
        internal unsafe EditorWorldExtensionManager_fields* EditorWorldExtensionManager_ptr => (EditorWorldExtensionManager_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EditorWorldExtensionManager(IntPtr p) => UObject.Make<EditorWorldExtensionManager>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EditorWorldExtensionManager DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EditorWorldExtensionManager New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
