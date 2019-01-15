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
using UE4.ConfigEditor.Native;

namespace UE4.ConfigEditor {
    ///<summary>Config Hierarchy Property View</summary>
    public unsafe partial class ConfigHierarchyPropertyView : UObject  {
         //TODO: weak object TWeakObjectPtr<UProperty> EditProperty
        ///<summary>Config File Property Objects</summary>
        public ObjectArrayField<PropertyConfigFileDisplayRow> ConfigFilePropertyObjects{ get {
            if(ConfigFilePropertyObjects_store == null) ConfigFilePropertyObjects_store = new ObjectArrayField<PropertyConfigFileDisplayRow> (&ConfigHierarchyPropertyView_ptr->ConfigFilePropertyObjects);
            return ConfigFilePropertyObjects_store;
        } }
        private ObjectArrayField<PropertyConfigFileDisplayRow> ConfigFilePropertyObjects_store;

        static ConfigHierarchyPropertyView() {
            StaticClass = Main.GetClass("ConfigHierarchyPropertyView");
        }
        internal unsafe ConfigHierarchyPropertyView_fields* ConfigHierarchyPropertyView_ptr => (ConfigHierarchyPropertyView_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ConfigHierarchyPropertyView(IntPtr p) => UObject.Make<ConfigHierarchyPropertyView>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ConfigHierarchyPropertyView DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ConfigHierarchyPropertyView New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
