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
using UE4.AIModule.Native;
using UE4.Engine;

namespace UE4.AIModule {
    ///<summary>this class is abstract even though it's perfectly functional on its own.</summary>
    ///<remarks>
    ///The reason is to stop it from showing as valid player pawn type when configuring
    ///   project's game mode.
    ///</remarks>
    public unsafe partial class EQSTestingPawn : Character  {
        ///<summary>Query Template</summary>
        public unsafe EnvQuery QueryTemplate {
            get {return EQSTestingPawn_ptr->QueryTemplate;}
            set {EQSTestingPawn_ptr->QueryTemplate = value;}
        }
         //TODO: array not UObject TArray QueryParams
         //TODO: array not UObject TArray QueryConfig
        ///<summary>Time Limit Per Step</summary>
        public unsafe float TimeLimitPerStep {
            get {return EQSTestingPawn_ptr->TimeLimitPerStep;}
            set {EQSTestingPawn_ptr->TimeLimitPerStep = value;}
        }
        ///<summary>Step to Debug Draw</summary>
        public unsafe int StepToDebugDraw {
            get {return EQSTestingPawn_ptr->StepToDebugDraw;}
            set {EQSTestingPawn_ptr->StepToDebugDraw = value;}
        }
         //TODO: enum EEnvQueryHightlightMode HighlightMode
        public bool bDrawLabels {
            get {return Main.GetGetBoolPropertyByName(this, "bDrawLabels"); }
            set {Main.SetGetBoolPropertyByName(this, "bDrawLabels", value); }
        }
        public bool bDrawFailedItems {
            get {return Main.GetGetBoolPropertyByName(this, "bDrawFailedItems"); }
            set {Main.SetGetBoolPropertyByName(this, "bDrawFailedItems", value); }
        }
        public bool bReRunQueryOnlyOnFinishedMove {
            get {return Main.GetGetBoolPropertyByName(this, "bReRunQueryOnlyOnFinishedMove"); }
            set {Main.SetGetBoolPropertyByName(this, "bReRunQueryOnlyOnFinishedMove", value); }
        }
        public bool bShouldBeVisibleInGame {
            get {return Main.GetGetBoolPropertyByName(this, "bShouldBeVisibleInGame"); }
            set {Main.SetGetBoolPropertyByName(this, "bShouldBeVisibleInGame", value); }
        }
        public bool bTickDuringGame {
            get {return Main.GetGetBoolPropertyByName(this, "bTickDuringGame"); }
            set {Main.SetGetBoolPropertyByName(this, "bTickDuringGame", value); }
        }
        ///<summary>Querying Mode</summary>
        public unsafe byte QueryingMode {
            get {return EQSTestingPawn_ptr->QueryingMode;}
            set {EQSTestingPawn_ptr->QueryingMode = value;}
        }
        ///<summary>Nav Agent Properties</summary>
        public unsafe NavAgentProperties NavAgentProperties {
            get {return EQSTestingPawn_ptr->NavAgentProperties;}
            set {EQSTestingPawn_ptr->NavAgentProperties = value;}
        }
        ///<summary>Editor Preview</summary>
        public unsafe EQSRenderingComponent EdRenderComp {
            get {return EQSTestingPawn_ptr->EdRenderComp;}
            set {EQSTestingPawn_ptr->EdRenderComp = value;}
        }
        static EQSTestingPawn() {
            StaticClass = Main.GetClass("EQSTestingPawn");
        }
        internal unsafe EQSTestingPawn_fields* EQSTestingPawn_ptr => (EQSTestingPawn_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EQSTestingPawn(IntPtr p) => UObject.Make<EQSTestingPawn>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EQSTestingPawn DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EQSTestingPawn New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
