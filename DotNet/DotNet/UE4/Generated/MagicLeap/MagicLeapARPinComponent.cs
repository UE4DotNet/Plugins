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
using UE4.MagicLeap.Native;
using UE4.Engine;

namespace UE4.MagicLeap {
    ///<summary>Component to make content persist at locations in the real world.</summary>
    public unsafe partial class MagicLeapARPinComponent : SceneComponent  {

        ///<summary>Get the ID of the Pin the entity (component or actor) is currently pinned to.</summary>
        ///<remarks>
        ///@param PinID Output param for the ID of the Pin.
        ///@return True if an entity is currently pinned by this component and the output param is successfully populated.
        ///</remarks>
        public (FGuid, bool) GetPinnedPinID()  => 
            MagicLeapARPinComponent_methods.GetPinnedPinID_method.Invoke(ObjPointer);

        ///<summary>True if an entity (component or actor) is currently pinned by this component.</summary>
        ///<remarks>
        ///If true, the entity's transform will be locked. App needs to call UnPin() if it wants to move it again.
        ///If false, and you still want your content to persist, you will have to call PinSceneComponent() or PinActor() before EndPlay().
        ///@return True if an entity (component or actor) is currently pinned by this component.
        ///</remarks>
        public bool IsPinned()  => 
            MagicLeapARPinComponent_methods.IsPinned_method.Invoke(ObjPointer);

        ///<summary>Pin given Actor to the closest AR Pin in real-world.</summary>
        ///<remarks>
        ///OnPersistentEntityPinned event will be fired when a suitable AR Pin is found for this Actor.
        ///The Actor's transform will then be locked. App needs to call UnPin() if it wants to move the Actor again.
        ///@param ActorToPin Actor to pin to the world. Pass in this component's owner if app is using 'OnlyOnDataRestoration' or 'Always' AutoPinType.
        ///@return true if the Actor was accepted to be pinned, false otherwise.
        ///</remarks>
        public bool PinActor(Actor ActorToPin)  => 
            MagicLeapARPinComponent_methods.PinActor_method.Invoke(ObjPointer, ActorToPin);

        ///<summary>True if the AR Pin for the unique ID ObjectUID was restored from the app's local storage or was repliated over network.</summary>
        ///<remarks>
        ///Implies if content was already pinned earlier. Does not imply if that restored Pin is available in the current environment.
        ///@return True if the Pin data was restored from local storage or network.
        ///</remarks>
        public bool PinRestoredOrSynced()  => 
            MagicLeapARPinComponent_methods.PinRestoredOrSynced_method.Invoke(ObjPointer);

        ///<summary>Pin given SceneComponent to the closest AR Pin in real-world.</summary>
        ///<remarks>
        ///OnPersistentEntityPinned event will be fired when a suitable AR Pin is found for this component.
        ///The component's transform will then be locked. App needs to call UnPin() if it wants to move the component again.
        ///@param ComponentToPin SceneComponent to pin to the world. Pass in 'this' component if app is using 'OnlyOnDataRestoration' or 'Always' AutoPinType.
        ///@return true if the component was accepted to be pinned, false otherwise.
        ///</remarks>
        public bool PinSceneComponent(SceneComponent ComponentToPin)  => 
            MagicLeapARPinComponent_methods.PinSceneComponent_method.Invoke(ObjPointer, ComponentToPin);

        ///<summary>Detach or un-pin the currently pinned entity (component or actor) from the real-world.</summary>
        ///<remarks>
        ///Call this if you want to change the transform of a pinned entity.
        ///Note that if you still want your content to persist, you will have to call PinSceneComponent() or PinActor() before EndPlay().
        ///</remarks>
        public void UnPin()  => 
            MagicLeapARPinComponent_methods.UnPin_method.Invoke(ObjPointer);
         //TODO: string FString ObjectUID
         //TODO: enum EAutoPinType AutoPinType
        public bool bShouldPinActor {
            get {return Main.GetGetBoolPropertyByName(this, "bShouldPinActor"); }
            set {Main.SetGetBoolPropertyByName(this, "bShouldPinActor", value); }
        }
         //TODO: multicast delegate FPersistentEntityPinned OnPersistentEntityPinned
        ///<summary>Pinned CFUID</summary>
        public unsafe FGuid PinnedCFUID {
            get {return MagicLeapARPinComponent_ptr->PinnedCFUID;}
            set {MagicLeapARPinComponent_ptr->PinnedCFUID = value;}
        }
        ///<summary>Pinned Scene Component</summary>
        public unsafe SceneComponent PinnedSceneComponent {
            get {return MagicLeapARPinComponent_ptr->PinnedSceneComponent;}
            set {MagicLeapARPinComponent_ptr->PinnedSceneComponent = value;}
        }
        static MagicLeapARPinComponent() {
            StaticClass = Main.GetClass("MagicLeapARPinComponent");
        }
        internal unsafe MagicLeapARPinComponent_fields* MagicLeapARPinComponent_ptr => (MagicLeapARPinComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MagicLeapARPinComponent(IntPtr p) => UObject.Make<MagicLeapARPinComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MagicLeapARPinComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MagicLeapARPinComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
