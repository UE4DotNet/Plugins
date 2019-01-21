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
using UE4.ActorLayerUtilities.Native;
using UE4.Engine;

namespace UE4.ActorLayerUtilities {
    ///<summary>Function library containing methods for interacting with editor layers</summary>
    public unsafe partial class LayersBlueprintLibrary : BlueprintFunctionLibrary  {

        ///<summary>Get all the actors in this layer</summary>
        public static IReadOnlyCollection<Actor> GetActors(UObject WorldContextObject, ActorLayer ActorLayer)  => 
            LayersBlueprintLibrary_methods.GetActors_method.Invoke(WorldContextObject, ActorLayer);
        static LayersBlueprintLibrary() {
            StaticClass = Main.GetClass("LayersBlueprintLibrary");
        }
        internal unsafe LayersBlueprintLibrary_fields* LayersBlueprintLibrary_ptr => (LayersBlueprintLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LayersBlueprintLibrary(IntPtr p) => UObject.Make<LayersBlueprintLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LayersBlueprintLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LayersBlueprintLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
