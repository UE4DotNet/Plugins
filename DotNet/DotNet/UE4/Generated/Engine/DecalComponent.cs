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
    ///<summary>A material that is rendered onto the surface of a mesh.</summary>
    ///<remarks>
    ///A kind of 'bumper sticker' for a model.
    ///
    ///@see https://docs.unrealengine.com/latest/INT/Engine/Actors/DecalActor
    ///@see UDecalActor
    ///</remarks>
    public unsafe partial class DecalComponent : SceneComponent  {

        ///<summary>Utility to allocate a new Dynamic Material Instance, set its parent to the currently applied material, and assign it</summary>
        public MaterialInstanceDynamic CreateDynamicMaterialInstance()  => 
            DecalComponent_methods.CreateDynamicMaterialInstance_method.Invoke(ObjPointer);

        ///<summary>Accessor for decal material</summary>
        public MaterialInterface GetDecalMaterial()  => 
            DecalComponent_methods.GetDecalMaterial_method.Invoke(ObjPointer);

        ///<summary>Get Fade Duration</summary>
        public float GetFadeDuration()  => 
            DecalComponent_methods.GetFadeDuration_method.Invoke(ObjPointer);

        ///<summary>Get Fade Start Delay</summary>
        public float GetFadeStartDelay()  => 
            DecalComponent_methods.GetFadeStartDelay_method.Invoke(ObjPointer);

        ///<summary>setting decal material on decal component. This will force the decal to reattach</summary>
        public void SetDecalMaterial(MaterialInterface NewDecalMaterial)  => 
            DecalComponent_methods.SetDecalMaterial_method.Invoke(ObjPointer, NewDecalMaterial);

        ///<summary>Sets the decal's fade start time, duration and if the owning actor should be destroyed after the decal is fully faded out.</summary>
        ///<remarks>
        ///The default value of 0 for FadeStartDelay and FadeDuration makes the decal persistent. See DecalLifetimeOpacity material
        ///node to control the look of "fading out."
        ///
        ///@param StartDelay - Time in seconds to wait before beginning to fade out the decal.
        ///@param Duration - Time in second for the decal to fade out.
        ///@param DestroyOwnerAfterFade - Should the owning actor automatically be destroyed after it is completely faded out.
        ///</remarks>
        public void SetFadeOut(float StartDelay, float Duration, bool DestroyOwnerAfterFade)  => 
            DecalComponent_methods.SetFadeOut_method.Invoke(ObjPointer, StartDelay, Duration, DestroyOwnerAfterFade);

        ///<summary>Set the FadeScreenSize for this decal component</summary>
        public void SetFadeScreenSize(float NewFadeScreenSize)  => 
            DecalComponent_methods.SetFadeScreenSize_method.Invoke(ObjPointer, NewFadeScreenSize);

        ///<summary>Sets the sort order for the decal component. Higher values draw later (on top). This will force the decal to reattach</summary>
        public void SetSortOrder(int Value)  => 
            DecalComponent_methods.SetSortOrder_method.Invoke(ObjPointer, Value);
        ///<summary>Decal material.</summary>
        public unsafe MaterialInterface DecalMaterial {
            get {return DecalComponent_ptr->DecalMaterial;}
        }
        ///<summary>Controls the order in which decal elements are rendered.</summary>
        ///<remarks>
        ///Higher values draw later (on top).
        ///Setting many different sort orders on many different decals prevents sorting by state and can reduce performance.
        ///</remarks>
        public unsafe int SortOrder {
            get {return DecalComponent_ptr->SortOrder;}
        }
        ///<summary>Fade Screen Size</summary>
        public unsafe float FadeScreenSize {
            get {return DecalComponent_ptr->FadeScreenSize;}
        }
        ///<summary>Time in seconds to wait before beginning to fade out the decal. Set fade duration and start delay to 0 to make persistent.</summary>
        public unsafe float FadeStartDelay {
            get {return DecalComponent_ptr->FadeStartDelay;}
        }
        ///<summary>Time in seconds for the decal to fade out. Set fade duration and start delay to 0 to make persistent. Only fades in active simulation or game.</summary>
        public unsafe float FadeDuration {
            get {return DecalComponent_ptr->FadeDuration;}
        }
        public bool bDestroyOwnerAfterFade {
            get {return Main.GetGetBoolPropertyByName(this, "bDestroyOwnerAfterFade"); }
        }
        ///<summary>Decal size in local space (does not include the component scale), technically redundant but there for convenience</summary>
        public unsafe Vector DecalSize {
            get {return DecalComponent_ptr->DecalSize;}
        }
        static DecalComponent() {
            StaticClass = Main.GetClass("DecalComponent");
        }
        internal unsafe DecalComponent_fields* DecalComponent_ptr => (DecalComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DecalComponent(IntPtr p) => UObject.Make<DecalComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DecalComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DecalComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
