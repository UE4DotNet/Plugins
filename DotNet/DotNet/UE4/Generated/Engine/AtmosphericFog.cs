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
    ///<summary>
    ///A placeable fog actor that simulates atmospheric light scattering
    ///@
    ///</summary>
    ///<remarks>see https://docs.unrealengine.com/latest/INT/Engine/Actors/FogEffects/AtmosphericFog/index.html</remarks>
    public unsafe partial class AtmosphericFog : Info  {
        ///<summary>Main fog component</summary>
        public unsafe AtmosphericFogComponent AtmosphericFogComponent {
            get {return AtmosphericFog_ptr->AtmosphericFogComponent;}
        }
        ///<summary>Arrow component to indicate default sun rotation</summary>
        public unsafe ArrowComponent ArrowComponent {
            get {return AtmosphericFog_ptr->ArrowComponent;}
            set {AtmosphericFog_ptr->ArrowComponent = value;}
        }
        static AtmosphericFog() {
            StaticClass = Main.GetClass("AtmosphericFog");
        }
        internal unsafe AtmosphericFog_fields* AtmosphericFog_ptr => (AtmosphericFog_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AtmosphericFog(IntPtr p) => UObject.Make<AtmosphericFog>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AtmosphericFog DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AtmosphericFog New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
