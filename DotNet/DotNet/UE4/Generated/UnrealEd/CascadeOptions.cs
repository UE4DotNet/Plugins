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
    ///<summary>Cascade Options</summary>
    public unsafe partial class CascadeOptions : UObject  {
        public bool bShowModuleDump {
            get {return Main.GetGetBoolPropertyByName(this, "bShowModuleDump"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowModuleDump", value); }
        }
        ///<summary>Background Color</summary>
        public unsafe Color BackgroundColor {
            get {return CascadeOptions_ptr->BackgroundColor;}
            set {CascadeOptions_ptr->BackgroundColor = value;}
        }
        public bool bUseSubMenus {
            get {return Main.GetGetBoolPropertyByName(this, "bUseSubMenus"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseSubMenus", value); }
        }
        public bool bUseSpaceBarReset {
            get {return Main.GetGetBoolPropertyByName(this, "bUseSpaceBarReset"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseSpaceBarReset", value); }
        }
        public bool bUseSpaceBarResetInLevel {
            get {return Main.GetGetBoolPropertyByName(this, "bUseSpaceBarResetInLevel"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseSpaceBarResetInLevel", value); }
        }
        ///<summary>Empty Background</summary>
        public unsafe Color Empty_Background {
            get {return CascadeOptions_ptr->Empty_Background;}
            set {CascadeOptions_ptr->Empty_Background = value;}
        }
        ///<summary>Emitter Background</summary>
        public unsafe Color Emitter_Background {
            get {return CascadeOptions_ptr->Emitter_Background;}
            set {CascadeOptions_ptr->Emitter_Background = value;}
        }
        ///<summary>Emitter Unselected</summary>
        public unsafe Color Emitter_Unselected {
            get {return CascadeOptions_ptr->Emitter_Unselected;}
            set {CascadeOptions_ptr->Emitter_Unselected = value;}
        }
        ///<summary>Emitter Selected</summary>
        public unsafe Color Emitter_Selected {
            get {return CascadeOptions_ptr->Emitter_Selected;}
            set {CascadeOptions_ptr->Emitter_Selected = value;}
        }
        ///<summary>Module Color General Unselected</summary>
        public unsafe Color ModuleColor_General_Unselected {
            get {return CascadeOptions_ptr->ModuleColor_General_Unselected;}
            set {CascadeOptions_ptr->ModuleColor_General_Unselected = value;}
        }
        ///<summary>Module Color General Selected</summary>
        public unsafe Color ModuleColor_General_Selected {
            get {return CascadeOptions_ptr->ModuleColor_General_Selected;}
            set {CascadeOptions_ptr->ModuleColor_General_Selected = value;}
        }
        ///<summary>Module Color Type Data Unselected</summary>
        public unsafe Color ModuleColor_TypeData_Unselected {
            get {return CascadeOptions_ptr->ModuleColor_TypeData_Unselected;}
            set {CascadeOptions_ptr->ModuleColor_TypeData_Unselected = value;}
        }
        ///<summary>Module Color Type Data Selected</summary>
        public unsafe Color ModuleColor_TypeData_Selected {
            get {return CascadeOptions_ptr->ModuleColor_TypeData_Selected;}
            set {CascadeOptions_ptr->ModuleColor_TypeData_Selected = value;}
        }
        ///<summary>Module Color Beam Unselected</summary>
        public unsafe Color ModuleColor_Beam_Unselected {
            get {return CascadeOptions_ptr->ModuleColor_Beam_Unselected;}
            set {CascadeOptions_ptr->ModuleColor_Beam_Unselected = value;}
        }
        ///<summary>Module Color Beam Selected</summary>
        public unsafe Color ModuleColor_Beam_Selected {
            get {return CascadeOptions_ptr->ModuleColor_Beam_Selected;}
            set {CascadeOptions_ptr->ModuleColor_Beam_Selected = value;}
        }
        ///<summary>Module Color Trail Unselected</summary>
        public unsafe Color ModuleColor_Trail_Unselected {
            get {return CascadeOptions_ptr->ModuleColor_Trail_Unselected;}
            set {CascadeOptions_ptr->ModuleColor_Trail_Unselected = value;}
        }
        ///<summary>Module Color Trail Selected</summary>
        public unsafe Color ModuleColor_Trail_Selected {
            get {return CascadeOptions_ptr->ModuleColor_Trail_Selected;}
            set {CascadeOptions_ptr->ModuleColor_Trail_Selected = value;}
        }
        ///<summary>Module Color Spawn Unselected</summary>
        public unsafe Color ModuleColor_Spawn_Unselected {
            get {return CascadeOptions_ptr->ModuleColor_Spawn_Unselected;}
            set {CascadeOptions_ptr->ModuleColor_Spawn_Unselected = value;}
        }
        ///<summary>Module Color Spawn Selected</summary>
        public unsafe Color ModuleColor_Spawn_Selected {
            get {return CascadeOptions_ptr->ModuleColor_Spawn_Selected;}
            set {CascadeOptions_ptr->ModuleColor_Spawn_Selected = value;}
        }
        ///<summary>Module Color Light Unselected</summary>
        public unsafe Color ModuleColor_Light_Unselected {
            get {return CascadeOptions_ptr->ModuleColor_Light_Unselected;}
            set {CascadeOptions_ptr->ModuleColor_Light_Unselected = value;}
        }
        ///<summary>Module Color Light Selected</summary>
        public unsafe Color ModuleColor_Light_Selected {
            get {return CascadeOptions_ptr->ModuleColor_Light_Selected;}
            set {CascadeOptions_ptr->ModuleColor_Light_Selected = value;}
        }
        ///<summary>Module Color Sub UV Unselected</summary>
        public unsafe Color ModuleColor_SubUV_Unselected {
            get {return CascadeOptions_ptr->ModuleColor_SubUV_Unselected;}
            set {CascadeOptions_ptr->ModuleColor_SubUV_Unselected = value;}
        }
        ///<summary>Module Color Sub UV Selected</summary>
        public unsafe Color ModuleColor_SubUV_Selected {
            get {return CascadeOptions_ptr->ModuleColor_SubUV_Selected;}
            set {CascadeOptions_ptr->ModuleColor_SubUV_Selected = value;}
        }
        ///<summary>Module Color Required Unselected</summary>
        public unsafe Color ModuleColor_Required_Unselected {
            get {return CascadeOptions_ptr->ModuleColor_Required_Unselected;}
            set {CascadeOptions_ptr->ModuleColor_Required_Unselected = value;}
        }
        ///<summary>Module Color Required Selected</summary>
        public unsafe Color ModuleColor_Required_Selected {
            get {return CascadeOptions_ptr->ModuleColor_Required_Selected;}
            set {CascadeOptions_ptr->ModuleColor_Required_Selected = value;}
        }
        ///<summary>Module Color Event Unselected</summary>
        public unsafe Color ModuleColor_Event_Unselected {
            get {return CascadeOptions_ptr->ModuleColor_Event_Unselected;}
            set {CascadeOptions_ptr->ModuleColor_Event_Unselected = value;}
        }
        ///<summary>Module Color Event Selected</summary>
        public unsafe Color ModuleColor_Event_Selected {
            get {return CascadeOptions_ptr->ModuleColor_Event_Selected;}
            set {CascadeOptions_ptr->ModuleColor_Event_Selected = value;}
        }
        public bool bShowGrid {
            get {return Main.GetGetBoolPropertyByName(this, "bShowGrid"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowGrid", value); }
        }
        ///<summary>Grid Color Hi</summary>
        public unsafe Color GridColor_Hi {
            get {return CascadeOptions_ptr->GridColor_Hi;}
            set {CascadeOptions_ptr->GridColor_Hi = value;}
        }
        ///<summary>Grid Color Low</summary>
        public unsafe Color GridColor_Low {
            get {return CascadeOptions_ptr->GridColor_Low;}
            set {CascadeOptions_ptr->GridColor_Low = value;}
        }
        ///<summary>Grid Perspective Size</summary>
        public unsafe float GridPerspectiveSize {
            get {return CascadeOptions_ptr->GridPerspectiveSize;}
            set {CascadeOptions_ptr->GridPerspectiveSize = value;}
        }
        public bool bShowParticleCounts {
            get {return Main.GetGetBoolPropertyByName(this, "bShowParticleCounts"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowParticleCounts", value); }
        }
        public bool bShowParticleEvents {
            get {return Main.GetGetBoolPropertyByName(this, "bShowParticleEvents"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowParticleEvents", value); }
        }
        public bool bShowParticleTimes {
            get {return Main.GetGetBoolPropertyByName(this, "bShowParticleTimes"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowParticleTimes", value); }
        }
        public bool bShowParticleDistance {
            get {return Main.GetGetBoolPropertyByName(this, "bShowParticleDistance"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowParticleDistance", value); }
        }
        public bool bShowParticleMemory {
            get {return Main.GetGetBoolPropertyByName(this, "bShowParticleMemory"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowParticleMemory", value); }
        }
        ///<summary>Particle Memory Update Time</summary>
        public unsafe float ParticleMemoryUpdateTime {
            get {return CascadeOptions_ptr->ParticleMemoryUpdateTime;}
            set {CascadeOptions_ptr->ParticleMemoryUpdateTime = value;}
        }
        public bool bShowFloor {
            get {return Main.GetGetBoolPropertyByName(this, "bShowFloor"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowFloor", value); }
        }
         //TODO: string FString FloorMesh
        ///<summary>Floor Position</summary>
        public unsafe Vector FloorPosition {
            get {return CascadeOptions_ptr->FloorPosition;}
            set {CascadeOptions_ptr->FloorPosition = value;}
        }
        ///<summary>Floor Rotation</summary>
        public unsafe Rotator FloorRotation {
            get {return CascadeOptions_ptr->FloorRotation;}
            set {CascadeOptions_ptr->FloorRotation = value;}
        }
        ///<summary>Floor Scale</summary>
        public unsafe float FloorScale {
            get {return CascadeOptions_ptr->FloorScale;}
            set {CascadeOptions_ptr->FloorScale = value;}
        }
        ///<summary>Floor Scale 3D</summary>
        public unsafe Vector FloorScale3D {
            get {return CascadeOptions_ptr->FloorScale3D;}
            set {CascadeOptions_ptr->FloorScale3D = value;}
        }
        ///<summary>Show PPFlags</summary>
        public unsafe int ShowPPFlags {
            get {return CascadeOptions_ptr->ShowPPFlags;}
            set {CascadeOptions_ptr->ShowPPFlags = value;}
        }
        public bool bUseSlimCascadeDraw {
            get {return Main.GetGetBoolPropertyByName(this, "bUseSlimCascadeDraw"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseSlimCascadeDraw", value); }
        }
        ///<summary>The height to use for the 'slimline' module drawing method in cascade.</summary>
        public unsafe int SlimCascadeDrawHeight {
            get {return CascadeOptions_ptr->SlimCascadeDrawHeight;}
            set {CascadeOptions_ptr->SlimCascadeDrawHeight = value;}
        }
        public bool bCenterCascadeModuleText {
            get {return Main.GetGetBoolPropertyByName(this, "bCenterCascadeModuleText"); }
            set {Main.SetGetBoolPropertyByName(this, "bCenterCascadeModuleText", value); }
        }
        ///<summary>The number of units the mouse must move before considering the module as dragged.</summary>
        public unsafe int Cascade_MouseMoveThreshold {
            get {return CascadeOptions_ptr->Cascade_MouseMoveThreshold;}
            set {CascadeOptions_ptr->Cascade_MouseMoveThreshold = value;}
        }
        ///<summary>The radius of the motion mode</summary>
        public unsafe float MotionModeRadius {
            get {return CascadeOptions_ptr->MotionModeRadius;}
            set {CascadeOptions_ptr->MotionModeRadius = value;}
        }
        static CascadeOptions() {
            StaticClass = Main.GetClass("CascadeOptions");
        }
        internal unsafe CascadeOptions_fields* CascadeOptions_ptr => (CascadeOptions_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CascadeOptions(IntPtr p) => UObject.Make<CascadeOptions>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CascadeOptions DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CascadeOptions New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
