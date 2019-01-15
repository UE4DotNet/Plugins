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
using UE4.NavigationSystem;

namespace UE4.AIModule {
    ///<summary>Nav Link Proxy</summary>
    public unsafe partial class NavLinkProxy : Actor  {

        ///<summary>called when agent reaches smart link during path following, use ResumePathFollowing() to give control back</summary>
        public event ReceiveSmartLinkReached_delegate ReceiveSmartLinkReached;
        public delegate Vector ReceiveSmartLinkReached_delegate(Actor Agent, Vector Destination);
        internal Vector on_ReceiveSmartLinkReached(Actor Agent, Vector Destination) =>
            ReceiveSmartLinkReached != null ? ReceiveSmartLinkReached(Agent, Destination) : Destination;


        ///<summary>check if any agent is moving through smart link right now</summary>
        public bool HasMovingAgents()  => 
            NavLinkProxy_methods.HasMovingAgents_method.Invoke(ObjPointer);

        ///<summary>check if smart link is enabled</summary>
        public bool IsSmartLinkEnabled()  => 
            NavLinkProxy_methods.IsSmartLinkEnabled_method.Invoke(ObjPointer);

        ///<summary>resume normal path following</summary>
        public void ResumePathFollowing(Actor Agent)  => 
            NavLinkProxy_methods.ResumePathFollowing_method.Invoke(ObjPointer, Agent);

        ///<summary>change state of smart link</summary>
        public void SetSmartLinkEnabled(bool bEnabled)  => 
            NavLinkProxy_methods.SetSmartLinkEnabled_method.Invoke(ObjPointer, bEnabled);
         //TODO: array not UObject TArray PointLinks
         //TODO: array not UObject TArray SegmentLinks
        ///<summary>Smart link: can affect path following</summary>
        public unsafe NavLinkCustomComponent SmartLinkComp {
            get {return NavLinkProxy_ptr->SmartLinkComp;}
            set {NavLinkProxy_ptr->SmartLinkComp = value;}
        }
        public bool bSmartLinkIsRelevant {
            get {return Main.GetGetBoolPropertyByName(this, "bSmartLinkIsRelevant"); }
            set {Main.SetGetBoolPropertyByName(this, "bSmartLinkIsRelevant", value); }
        }
        ///<summary>Editor Preview</summary>
        public unsafe NavLinkRenderingComponent EdRenderComp {
            get {return NavLinkProxy_ptr->EdRenderComp;}
            set {NavLinkProxy_ptr->EdRenderComp = value;}
        }
        ///<summary>Sprite Component</summary>
        public unsafe BillboardComponent SpriteComponent {
            get {return NavLinkProxy_ptr->SpriteComponent;}
            set {NavLinkProxy_ptr->SpriteComponent = value;}
        }
         //TODO: multicast delegate FSmartLinkReachedSignature OnSmartLinkReached
        static NavLinkProxy() {
            StaticClass = Main.GetClass("NavLinkProxy");
            NavLinkProxy_events.ReceiveSmartLinkReached_event.Setup();
        }
        internal unsafe NavLinkProxy_fields* NavLinkProxy_ptr => (NavLinkProxy_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator NavLinkProxy(IntPtr p) => UObject.Make<NavLinkProxy>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static NavLinkProxy DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static NavLinkProxy New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
