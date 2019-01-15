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
    ///<summary>Renderer Override Settings</summary>
    public unsafe partial class RendererOverrideSettings : DeveloperSettings  {
        public bool bSupportAllShaderPermutations {
            get {return Main.GetGetBoolPropertyByName(this, "bSupportAllShaderPermutations"); }
            set {Main.SetGetBoolPropertyByName(this, "bSupportAllShaderPermutations", value); }
        }
        public bool bForceRecomputeTangents {
            get {return Main.GetGetBoolPropertyByName(this, "bForceRecomputeTangents"); }
            set {Main.SetGetBoolPropertyByName(this, "bForceRecomputeTangents", value); }
        }
        static RendererOverrideSettings() {
            StaticClass = Main.GetClass("RendererOverrideSettings");
        }
        internal unsafe RendererOverrideSettings_fields* RendererOverrideSettings_ptr => (RendererOverrideSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator RendererOverrideSettings(IntPtr p) => UObject.Make<RendererOverrideSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static RendererOverrideSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static RendererOverrideSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
