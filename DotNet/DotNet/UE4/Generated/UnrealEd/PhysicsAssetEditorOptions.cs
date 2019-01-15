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
    ///<summary>Physics Asset Editor Options</summary>
    public unsafe partial class PhysicsAssetEditorOptions : UObject  {
        ///<summary>Lets you manually control the physics/animation</summary>
        public unsafe float PhysicsBlend {
            get {return PhysicsAssetEditorOptions_ptr->PhysicsBlend;}
            set {PhysicsAssetEditorOptions_ptr->PhysicsBlend = value;}
        }
        public bool bUpdateJointsFromAnimation {
            get {return Main.GetGetBoolPropertyByName(this, "bUpdateJointsFromAnimation"); }
            set {Main.SetGetBoolPropertyByName(this, "bUpdateJointsFromAnimation", value); }
        }
        ///<summary>Determines whether simulation of root body updates component transform</summary>
        public unsafe byte PhysicsUpdateMode {
            get {return PhysicsAssetEditorOptions_ptr->PhysicsUpdateMode;}
            set {PhysicsAssetEditorOptions_ptr->PhysicsUpdateMode = value;}
        }
        ///<summary>Time between poking ragdoll and starting to blend back.</summary>
        public unsafe float PokePauseTime {
            get {return PhysicsAssetEditorOptions_ptr->PokePauseTime;}
            set {PhysicsAssetEditorOptions_ptr->PokePauseTime = value;}
        }
        ///<summary>Time taken to blend from physics to animation.</summary>
        public unsafe float PokeBlendTime {
            get {return PhysicsAssetEditorOptions_ptr->PokeBlendTime;}
            set {PhysicsAssetEditorOptions_ptr->PokeBlendTime = value;}
        }
        ///<summary>Scale factor for the gravity used in the simulation</summary>
        public unsafe float GravScale {
            get {return PhysicsAssetEditorOptions_ptr->GravScale;}
            set {PhysicsAssetEditorOptions_ptr->GravScale = value;}
        }
        ///<summary>Max FPS for simulation in PhysicsAssetEditor. This is helpful for targeting the same FPS as your game. -1 means disabled</summary>
        public unsafe int MaxFPS {
            get {return PhysicsAssetEditorOptions_ptr->MaxFPS;}
            set {PhysicsAssetEditorOptions_ptr->MaxFPS = value;}
        }
        ///<summary>Linear damping of mouse spring forces</summary>
        public unsafe float HandleLinearDamping {
            get {return PhysicsAssetEditorOptions_ptr->HandleLinearDamping;}
            set {PhysicsAssetEditorOptions_ptr->HandleLinearDamping = value;}
        }
        ///<summary>Linear stiffness of mouse spring forces</summary>
        public unsafe float HandleLinearStiffness {
            get {return PhysicsAssetEditorOptions_ptr->HandleLinearStiffness;}
            set {PhysicsAssetEditorOptions_ptr->HandleLinearStiffness = value;}
        }
        ///<summary>Angular damping of mouse spring forces</summary>
        public unsafe float HandleAngularDamping {
            get {return PhysicsAssetEditorOptions_ptr->HandleAngularDamping;}
            set {PhysicsAssetEditorOptions_ptr->HandleAngularDamping = value;}
        }
        ///<summary>Angular stiffness of mouse spring forces</summary>
        public unsafe float HandleAngularStiffness {
            get {return PhysicsAssetEditorOptions_ptr->HandleAngularStiffness;}
            set {PhysicsAssetEditorOptions_ptr->HandleAngularStiffness = value;}
        }
        ///<summary>How quickly we interpolate the physics target transform for mouse spring forces</summary>
        public unsafe float InterpolationSpeed {
            get {return PhysicsAssetEditorOptions_ptr->InterpolationSpeed;}
            set {PhysicsAssetEditorOptions_ptr->InterpolationSpeed = value;}
        }
        ///<summary>Strength of the impulse used when poking with left mouse button</summary>
        public unsafe float PokeStrength {
            get {return PhysicsAssetEditorOptions_ptr->PokeStrength;}
            set {PhysicsAssetEditorOptions_ptr->PokeStrength = value;}
        }
        public bool bShowConstraintsAsPoints {
            get {return Main.GetGetBoolPropertyByName(this, "bShowConstraintsAsPoints"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowConstraintsAsPoints", value); }
        }
        public bool bRenderOnlySelectedConstraints {
            get {return Main.GetGetBoolPropertyByName(this, "bRenderOnlySelectedConstraints"); }
            set {Main.SetGetBoolPropertyByName(this, "bRenderOnlySelectedConstraints", value); }
        }
        ///<summary>Controls how large constraints are drawn in Physics Asset Editor</summary>
        public unsafe float ConstraintDrawSize {
            get {return PhysicsAssetEditorOptions_ptr->ConstraintDrawSize;}
            set {PhysicsAssetEditorOptions_ptr->ConstraintDrawSize = value;}
        }
         //TODO: enum EPhysicsAssetEditorRenderMode MeshViewMode
         //TODO: enum EPhysicsAssetEditorRenderMode CollisionViewMode
         //TODO: enum EPhysicsAssetEditorConstraintViewMode ConstraintViewMode
         //TODO: enum EPhysicsAssetEditorRenderMode SimulationMeshViewMode
         //TODO: enum EPhysicsAssetEditorRenderMode SimulationCollisionViewMode
         //TODO: enum EPhysicsAssetEditorConstraintViewMode SimulationConstraintViewMode
        ///<summary>Opacity of 'solid' rendering</summary>
        public unsafe float CollisionOpacity {
            get {return PhysicsAssetEditorOptions_ptr->CollisionOpacity;}
            set {PhysicsAssetEditorOptions_ptr->CollisionOpacity = value;}
        }
        public bool bSolidRenderingForSelectedOnly {
            get {return Main.GetGetBoolPropertyByName(this, "bSolidRenderingForSelectedOnly"); }
            set {Main.SetGetBoolPropertyByName(this, "bSolidRenderingForSelectedOnly", value); }
        }
        public bool bResetClothWhenSimulating {
            get {return Main.GetGetBoolPropertyByName(this, "bResetClothWhenSimulating"); }
            set {Main.SetGetBoolPropertyByName(this, "bResetClothWhenSimulating", value); }
        }
        static PhysicsAssetEditorOptions() {
            StaticClass = Main.GetClass("PhysicsAssetEditorOptions");
        }
        internal unsafe PhysicsAssetEditorOptions_fields* PhysicsAssetEditorOptions_ptr => (PhysicsAssetEditorOptions_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PhysicsAssetEditorOptions(IntPtr p) => UObject.Make<PhysicsAssetEditorOptions>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PhysicsAssetEditorOptions DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PhysicsAssetEditorOptions New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
