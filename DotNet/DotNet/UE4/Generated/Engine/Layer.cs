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
    ///<summary>Layer</summary>
    public unsafe partial class Layer : UObject  {
        ///<summary>The display name of the layer</summary>
        public unsafe Name LayerName {
            get {return Layer_ptr->LayerName;}
            set {Layer_ptr->LayerName = value;}
        }
        public bool bIsVisible {
            get {return Main.GetGetBoolPropertyByName(this, "bIsVisible"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsVisible", value); }
        }
         //TODO: array not UObject TArray ActorStats
        static Layer() {
            StaticClass = Main.GetClass("Layer");
        }
        internal unsafe Layer_fields* Layer_ptr => (Layer_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator Layer(IntPtr p) => UObject.Make<Layer>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static Layer DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static Layer New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
