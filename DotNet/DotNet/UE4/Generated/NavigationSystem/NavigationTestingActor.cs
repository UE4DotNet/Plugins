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
using UE4.NavigationSystem.Native;
using UE4.Engine;

namespace UE4.NavigationSystem {
    ///<summary>Navigation Testing Actor</summary>
    public unsafe partial class NavigationTestingActor : Actor  {
        ///<summary>Capsule Component</summary>
        public unsafe CapsuleComponent CapsuleComponent {
            get {return NavigationTestingActor_ptr->CapsuleComponent;}
            set {NavigationTestingActor_ptr->CapsuleComponent = value;}
        }
        ///<summary>Editor Preview</summary>
        public unsafe NavTestRenderingComponent EdRenderComp {
            get {return NavigationTestingActor_ptr->EdRenderComp;}
            set {NavigationTestingActor_ptr->EdRenderComp = value;}
        }
        ///<summary>Invoker Component</summary>
        public unsafe NavigationInvokerComponent InvokerComponent {
            get {return NavigationTestingActor_ptr->InvokerComponent;}
            set {NavigationTestingActor_ptr->InvokerComponent = value;}
        }
        public bool bActAsNavigationInvoker {
            get {return Main.GetGetBoolPropertyByName(this, "bActAsNavigationInvoker"); }
            set {Main.SetGetBoolPropertyByName(this, "bActAsNavigationInvoker", value); }
        }
        ///<summary>@todo document</summary>
        public unsafe NavAgentProperties NavAgentProps {
            get {return NavigationTestingActor_ptr->NavAgentProps;}
            set {NavigationTestingActor_ptr->NavAgentProps = value;}
        }
        ///<summary>Querying Extent</summary>
        public unsafe Vector QueryingExtent {
            get {return NavigationTestingActor_ptr->QueryingExtent;}
            set {NavigationTestingActor_ptr->QueryingExtent = value;}
        }
        ///<summary>My Nav Data</summary>
        public unsafe NavigationData MyNavData {
            get {return NavigationTestingActor_ptr->MyNavData;}
            set {NavigationTestingActor_ptr->MyNavData = value;}
        }
        ///<summary>Projected Location</summary>
        public unsafe Vector ProjectedLocation {
            get {return NavigationTestingActor_ptr->ProjectedLocation;}
        }
        public bool bProjectedLocationValid {
            get {return Main.GetGetBoolPropertyByName(this, "bProjectedLocationValid"); }
        }
        public bool bSearchStart {
            get {return Main.GetGetBoolPropertyByName(this, "bSearchStart"); }
            set {Main.SetGetBoolPropertyByName(this, "bSearchStart", value); }
        }
        public bool bUseHierarchicalPathfinding {
            get {return Main.GetGetBoolPropertyByName(this, "bUseHierarchicalPathfinding"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseHierarchicalPathfinding", value); }
        }
        public bool bGatherDetailedInfo {
            get {return Main.GetGetBoolPropertyByName(this, "bGatherDetailedInfo"); }
            set {Main.SetGetBoolPropertyByName(this, "bGatherDetailedInfo", value); }
        }
        public bool bDrawDistanceToWall {
            get {return Main.GetGetBoolPropertyByName(this, "bDrawDistanceToWall"); }
            set {Main.SetGetBoolPropertyByName(this, "bDrawDistanceToWall", value); }
        }
        public bool bShowNodePool {
            get {return Main.GetGetBoolPropertyByName(this, "bShowNodePool"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowNodePool", value); }
        }
        public bool bShowBestPath {
            get {return Main.GetGetBoolPropertyByName(this, "bShowBestPath"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowBestPath", value); }
        }
        public bool bShowDiffWithPreviousStep {
            get {return Main.GetGetBoolPropertyByName(this, "bShowDiffWithPreviousStep"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowDiffWithPreviousStep", value); }
        }
        public bool bShouldBeVisibleInGame {
            get {return Main.GetGetBoolPropertyByName(this, "bShouldBeVisibleInGame"); }
            set {Main.SetGetBoolPropertyByName(this, "bShouldBeVisibleInGame", value); }
        }
        ///<summary>determines which cost will be shown</summary>
        public unsafe byte CostDisplayMode {
            get {return NavigationTestingActor_ptr->CostDisplayMode;}
            set {NavigationTestingActor_ptr->CostDisplayMode = value;}
        }
        ///<summary>text canvas offset to apply</summary>
        public unsafe Vector2D TextCanvasOffset {
            get {return NavigationTestingActor_ptr->TextCanvasOffset;}
            set {NavigationTestingActor_ptr->TextCanvasOffset = value;}
        }
        public bool bPathExist {
            get {return Main.GetGetBoolPropertyByName(this, "bPathExist"); }
        }
        public bool bPathIsPartial {
            get {return Main.GetGetBoolPropertyByName(this, "bPathIsPartial"); }
        }
        public bool bPathSearchOutOfNodes {
            get {return Main.GetGetBoolPropertyByName(this, "bPathSearchOutOfNodes"); }
        }
        ///<summary>Time in micro seconds</summary>
        public unsafe float PathfindingTime {
            get {return NavigationTestingActor_ptr->PathfindingTime;}
        }
        ///<summary>Path Cost</summary>
        public unsafe float PathCost {
            get {return NavigationTestingActor_ptr->PathCost;}
        }
        ///<summary>Pathfinding Steps</summary>
        public unsafe int PathfindingSteps {
            get {return NavigationTestingActor_ptr->PathfindingSteps;}
        }
        ///<summary>Other Actor</summary>
        public unsafe NavigationTestingActor OtherActor {
            get {return NavigationTestingActor_ptr->OtherActor;}
            set {NavigationTestingActor_ptr->OtherActor = value;}
        }
        ///<summary>"None" will result in default filter being used</summary>
        public unsafe SubclassOf<NavigationQueryFilter> FilterClass {
            get {return NavigationTestingActor_ptr->FilterClass;}
            set {NavigationTestingActor_ptr->FilterClass = value;}
        }
        ///<summary>Show Step Index</summary>
        public unsafe int ShowStepIndex {
            get {return NavigationTestingActor_ptr->ShowStepIndex;}
            set {NavigationTestingActor_ptr->ShowStepIndex = value;}
        }
        ///<summary>Offset from Corners Distance</summary>
        public unsafe float OffsetFromCornersDistance {
            get {return NavigationTestingActor_ptr->OffsetFromCornersDistance;}
            set {NavigationTestingActor_ptr->OffsetFromCornersDistance = value;}
        }
        static NavigationTestingActor() {
            StaticClass = Main.GetClass("NavigationTestingActor");
        }
        internal unsafe NavigationTestingActor_fields* NavigationTestingActor_ptr => (NavigationTestingActor_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator NavigationTestingActor(IntPtr p) => UObject.Make<NavigationTestingActor>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static NavigationTestingActor DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static NavigationTestingActor New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
