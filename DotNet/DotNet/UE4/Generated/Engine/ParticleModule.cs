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
    ///<summary>Particle Module</summary>
    public unsafe partial class ParticleModule : UObject  {
        public bool bSpawnModule {
            get {return Main.GetGetBoolPropertyByName(this, "bSpawnModule"); }
            set {Main.SetGetBoolPropertyByName(this, "bSpawnModule", value); }
        }
        public bool bUpdateModule {
            get {return Main.GetGetBoolPropertyByName(this, "bUpdateModule"); }
            set {Main.SetGetBoolPropertyByName(this, "bUpdateModule", value); }
        }
        public bool bFinalUpdateModule {
            get {return Main.GetGetBoolPropertyByName(this, "bFinalUpdateModule"); }
            set {Main.SetGetBoolPropertyByName(this, "bFinalUpdateModule", value); }
        }
        public bool bUpdateForGPUEmitter {
            get {return Main.GetGetBoolPropertyByName(this, "bUpdateForGPUEmitter"); }
            set {Main.SetGetBoolPropertyByName(this, "bUpdateForGPUEmitter", value); }
        }
        public bool bCurvesAsColor {
            get {return Main.GetGetBoolPropertyByName(this, "bCurvesAsColor"); }
            set {Main.SetGetBoolPropertyByName(this, "bCurvesAsColor", value); }
        }
        public bool b3DDrawMode {
            get {return Main.GetGetBoolPropertyByName(this, "b3DDrawMode"); }
            set {Main.SetGetBoolPropertyByName(this, "b3DDrawMode", value); }
        }
        public bool bSupported3DDrawMode {
            get {return Main.GetGetBoolPropertyByName(this, "bSupported3DDrawMode"); }
            set {Main.SetGetBoolPropertyByName(this, "bSupported3DDrawMode", value); }
        }
        public bool bEnabled {
            get {return Main.GetGetBoolPropertyByName(this, "bEnabled"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnabled", value); }
        }
        public bool bEditable {
            get {return Main.GetGetBoolPropertyByName(this, "bEditable"); }
            set {Main.SetGetBoolPropertyByName(this, "bEditable", value); }
        }
        public bool LODDuplicate {
            get {return Main.GetGetBoolPropertyByName(this, "LODDuplicate"); }
            set {Main.SetGetBoolPropertyByName(this, "LODDuplicate", value); }
        }
        public bool bSupportsRandomSeed {
            get {return Main.GetGetBoolPropertyByName(this, "bSupportsRandomSeed"); }
            set {Main.SetGetBoolPropertyByName(this, "bSupportsRandomSeed", value); }
        }
        public bool bRequiresLoopingNotification {
            get {return Main.GetGetBoolPropertyByName(this, "bRequiresLoopingNotification"); }
            set {Main.SetGetBoolPropertyByName(this, "bRequiresLoopingNotification", value); }
        }
        ///<summary>The LOD levels this module is present in.</summary>
        ///<remarks>
        ///Bit-flags are used to indicate validity for a given LOD level.
        ///For example, if
        ///        ((1 << Level) & LODValidity) != 0
        ///then the module is used in that LOD.
        ///</remarks>
        public unsafe byte LODValidity {
            get {return ParticleModule_ptr->LODValidity;}
            set {ParticleModule_ptr->LODValidity = value;}
        }
        ///<summary>The color to draw the modules curves in the curve editor.</summary>
        ///<remarks>If bCurvesAsColor is true, it overrides this value.</remarks>
        public unsafe Color ModuleEditorColor {
            get {return ParticleModule_ptr->ModuleEditorColor;}
            set {ParticleModule_ptr->ModuleEditorColor = value;}
        }
        static ParticleModule() {
            StaticClass = Main.GetClass("ParticleModule");
        }
        internal unsafe ParticleModule_fields* ParticleModule_ptr => (ParticleModule_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModule(IntPtr p) => UObject.Make<ParticleModule>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModule DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModule New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
