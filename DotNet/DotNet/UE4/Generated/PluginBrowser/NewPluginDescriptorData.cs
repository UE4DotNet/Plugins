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
using UE4.PluginBrowser.Native;

namespace UE4.PluginBrowser {
    ///<summary>An object used internally by the New Plugin Wizard to set user-defined plugin descriptor information.</summary>
    ///<remarks>This should not be used outside of the New Plugin Wizard dialog</remarks>
    public unsafe partial class NewPluginDescriptorData : UObject  {
         //TODO: string FString CreatedBy
         //TODO: string FString CreatedByURL
         //TODO: string FString Description
        public bool bIsBetaVersion {
            get {return Main.GetGetBoolPropertyByName(this, "bIsBetaVersion"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsBetaVersion", value); }
        }
        static NewPluginDescriptorData() {
            StaticClass = Main.GetClass("NewPluginDescriptorData");
        }
        internal unsafe NewPluginDescriptorData_fields* NewPluginDescriptorData_ptr => (NewPluginDescriptorData_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator NewPluginDescriptorData(IntPtr p) => UObject.Make<NewPluginDescriptorData>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static NewPluginDescriptorData DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static NewPluginDescriptorData New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
