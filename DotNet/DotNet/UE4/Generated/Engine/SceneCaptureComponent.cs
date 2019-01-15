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
    ///<summary>-> will be exported to EngineDecalClasses.h</summary>
    public unsafe partial class SceneCaptureComponent : SceneComponent  {

        ///<summary>Clears the hidden list.</summary>
        public void ClearHiddenComponents()  => 
            SceneCaptureComponent_methods.ClearHiddenComponents_method.Invoke(ObjPointer);

        ///<summary>Clears the Show Only list.</summary>
        public void ClearShowOnlyComponents(PrimitiveComponent InComponent)  => 
            SceneCaptureComponent_methods.ClearShowOnlyComponents_method.Invoke(ObjPointer, InComponent);

        ///<summary>Adds all primitive components in the actor to our list of hidden components.</summary>
        public void HideActorComponents(Actor InActor)  => 
            SceneCaptureComponent_methods.HideActorComponents_method.Invoke(ObjPointer, InActor);

        ///<summary>Adds the component to our list of hidden components.</summary>
        public void HideComponent(PrimitiveComponent InComponent)  => 
            SceneCaptureComponent_methods.HideComponent_method.Invoke(ObjPointer, InComponent);

        ///<summary>Removes a actor's components from the Show Only list.</summary>
        public void RemoveShowOnlyActorComponents(Actor InActor)  => 
            SceneCaptureComponent_methods.RemoveShowOnlyActorComponents_method.Invoke(ObjPointer, InActor);

        ///<summary>Removes a component from the Show Only list.</summary>
        public void RemoveShowOnlyComponent(PrimitiveComponent InComponent)  => 
            SceneCaptureComponent_methods.RemoveShowOnlyComponent_method.Invoke(ObjPointer, InComponent);

        ///<summary>Changes the value of TranslucentSortPriority.</summary>
        public void SetCaptureSortPriority(int NewCaptureSortPriority)  => 
            SceneCaptureComponent_methods.SetCaptureSortPriority_method.Invoke(ObjPointer, NewCaptureSortPriority);

        ///<summary>Adds all primitive components in the actor to our list of show-only components.</summary>
        public void ShowOnlyActorComponents(Actor InActor)  => 
            SceneCaptureComponent_methods.ShowOnlyActorComponents_method.Invoke(ObjPointer, InActor);

        ///<summary>Adds the component to our list of show-only components.</summary>
        public void ShowOnlyComponent(PrimitiveComponent InComponent)  => 
            SceneCaptureComponent_methods.ShowOnlyComponent_method.Invoke(ObjPointer, InComponent);
         //TODO: enum ESceneCapturePrimitiveRenderMode PrimitiveRenderMode
         //TODO: array not UObject TArray HiddenComponents
        ///<summary>The actors to hide in the scene capture.</summary>
        public ObjectArrayField<Actor> HiddenActors{ get {
            if(HiddenActors_store == null) HiddenActors_store = new ObjectArrayField<Actor> (&SceneCaptureComponent_ptr->HiddenActors);
            return HiddenActors_store;
        } }
        private ObjectArrayField<Actor> HiddenActors_store;

         //TODO: array not UObject TArray ShowOnlyComponents
        ///<summary>The only actors to be rendered by this scene capture, if PrimitiveRenderMode is set to UseShowOnlyList.</summary>
        public ObjectArrayField<Actor> ShowOnlyActors{ get {
            if(ShowOnlyActors_store == null) ShowOnlyActors_store = new ObjectArrayField<Actor> (&SceneCaptureComponent_ptr->ShowOnlyActors);
            return ShowOnlyActors_store;
        } }
        private ObjectArrayField<Actor> ShowOnlyActors_store;

        public bool bCaptureEveryFrame {
            get {return Main.GetGetBoolPropertyByName(this, "bCaptureEveryFrame"); }
            set {Main.SetGetBoolPropertyByName(this, "bCaptureEveryFrame", value); }
        }
        public bool bCaptureOnMovement {
            get {return Main.GetGetBoolPropertyByName(this, "bCaptureOnMovement"); }
            set {Main.SetGetBoolPropertyByName(this, "bCaptureOnMovement", value); }
        }
        public bool bAlwaysPersistRenderingState {
            get {return Main.GetGetBoolPropertyByName(this, "bAlwaysPersistRenderingState"); }
            set {Main.SetGetBoolPropertyByName(this, "bAlwaysPersistRenderingState", value); }
        }
        ///<summary>Scales the distance used by LOD. Set to values greater than 1 to cause the scene capture to use lower LODs than the main view to speed up the scene capture pass.</summary>
        public unsafe float LODDistanceFactor {
            get {return SceneCaptureComponent_ptr->LODDistanceFactor;}
            set {SceneCaptureComponent_ptr->LODDistanceFactor = value;}
        }
        ///<summary>if > 0, sets a maximum render distance override.  Can be used to cull distant objects from a reflection if the reflecting plane is in an enclosed area like a hallway or room</summary>
        public unsafe float MaxViewDistanceOverride {
            get {return SceneCaptureComponent_ptr->MaxViewDistanceOverride;}
            set {SceneCaptureComponent_ptr->MaxViewDistanceOverride = value;}
        }
        ///<summary>Capture priority within the frame to sort scene capture on GPU to resolve interdependencies between multiple capture components. Highest come first.</summary>
        public unsafe int CaptureSortPriority {
            get {return SceneCaptureComponent_ptr->CaptureSortPriority;}
        }
         //TODO: array not UObject TArray ShowFlagSettings
         //TODO: string FString ProfilingEventName
        static SceneCaptureComponent() {
            StaticClass = Main.GetClass("SceneCaptureComponent");
        }
        internal unsafe SceneCaptureComponent_fields* SceneCaptureComponent_ptr => (SceneCaptureComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SceneCaptureComponent(IntPtr p) => UObject.Make<SceneCaptureComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SceneCaptureComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SceneCaptureComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
