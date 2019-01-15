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

namespace UE4.NavigationSystem {
    ///<summary>
    ///Encapsulates NavLinkCustomInterface interface, can be used with Actors not relevant for navigation
    ///Additional functionality:
    ///- can be toggled
    ///- can create obstacle area for easier/forced separation of link end points
    ///</summary>
    ///<remarks>- can broadcast state changes to nearby agents</remarks>
    public unsafe partial class NavLinkCustomComponent : NavRelevantComponent  {
         //TODO: numeric uint32 NavLinkUserId
        ///<summary>area class to use when link is enabled</summary>
        public unsafe SubclassOf<NavArea> EnabledAreaClass {
            get {return NavLinkCustomComponent_ptr->EnabledAreaClass;}
            set {NavLinkCustomComponent_ptr->EnabledAreaClass = value;}
        }
        ///<summary>area class to use when link is disabled</summary>
        public unsafe SubclassOf<NavArea> DisabledAreaClass {
            get {return NavLinkCustomComponent_ptr->DisabledAreaClass;}
            set {NavLinkCustomComponent_ptr->DisabledAreaClass = value;}
        }
        ///<summary>start point, relative to owner</summary>
        public unsafe Vector LinkRelativeStart {
            get {return NavLinkCustomComponent_ptr->LinkRelativeStart;}
            set {NavLinkCustomComponent_ptr->LinkRelativeStart = value;}
        }
        ///<summary>end point, relative to owner</summary>
        public unsafe Vector LinkRelativeEnd {
            get {return NavLinkCustomComponent_ptr->LinkRelativeEnd;}
            set {NavLinkCustomComponent_ptr->LinkRelativeEnd = value;}
        }
        ///<summary>direction of link</summary>
        public unsafe byte LinkDirection {
            get {return NavLinkCustomComponent_ptr->LinkDirection;}
            set {NavLinkCustomComponent_ptr->LinkDirection = value;}
        }
        public bool bLinkEnabled {
            get {return Main.GetGetBoolPropertyByName(this, "bLinkEnabled"); }
            set {Main.SetGetBoolPropertyByName(this, "bLinkEnabled", value); }
        }
        public bool bNotifyWhenEnabled {
            get {return Main.GetGetBoolPropertyByName(this, "bNotifyWhenEnabled"); }
            set {Main.SetGetBoolPropertyByName(this, "bNotifyWhenEnabled", value); }
        }
        public bool bNotifyWhenDisabled {
            get {return Main.GetGetBoolPropertyByName(this, "bNotifyWhenDisabled"); }
            set {Main.SetGetBoolPropertyByName(this, "bNotifyWhenDisabled", value); }
        }
        public bool bCreateBoxObstacle {
            get {return Main.GetGetBoolPropertyByName(this, "bCreateBoxObstacle"); }
            set {Main.SetGetBoolPropertyByName(this, "bCreateBoxObstacle", value); }
        }
        ///<summary>offset of simple box obstacle</summary>
        public unsafe Vector ObstacleOffset {
            get {return NavLinkCustomComponent_ptr->ObstacleOffset;}
            set {NavLinkCustomComponent_ptr->ObstacleOffset = value;}
        }
        ///<summary>extent of simple box obstacle</summary>
        public unsafe Vector ObstacleExtent {
            get {return NavLinkCustomComponent_ptr->ObstacleExtent;}
            set {NavLinkCustomComponent_ptr->ObstacleExtent = value;}
        }
        ///<summary>area class for simple box obstacle</summary>
        public unsafe SubclassOf<NavArea> ObstacleAreaClass {
            get {return NavLinkCustomComponent_ptr->ObstacleAreaClass;}
            set {NavLinkCustomComponent_ptr->ObstacleAreaClass = value;}
        }
        ///<summary>radius of state change broadcast</summary>
        public unsafe float BroadcastRadius {
            get {return NavLinkCustomComponent_ptr->BroadcastRadius;}
            set {NavLinkCustomComponent_ptr->BroadcastRadius = value;}
        }
        ///<summary>interval for state change broadcast (0 = single broadcast)</summary>
        public unsafe float BroadcastInterval {
            get {return NavLinkCustomComponent_ptr->BroadcastInterval;}
            set {NavLinkCustomComponent_ptr->BroadcastInterval = value;}
        }
        ///<summary>trace channel for state change broadcast</summary>
        public unsafe byte BroadcastChannel {
            get {return NavLinkCustomComponent_ptr->BroadcastChannel;}
            set {NavLinkCustomComponent_ptr->BroadcastChannel = value;}
        }
        static NavLinkCustomComponent() {
            StaticClass = Main.GetClass("NavLinkCustomComponent");
        }
        internal unsafe NavLinkCustomComponent_fields* NavLinkCustomComponent_ptr => (NavLinkCustomComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator NavLinkCustomComponent(IntPtr p) => UObject.Make<NavLinkCustomComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static NavLinkCustomComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static NavLinkCustomComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
