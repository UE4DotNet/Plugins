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
using UE4.GameplayTags;

namespace UE4.AIModule {
    ///<summary>Cooldown decorator node.</summary>
    ///<remarks>A decorator node that bases its condition on whether a cooldown timer based on a gameplay tag has expired.</remarks>
    public unsafe partial class BTDecorator_TagCooldown : BTDecorator  {
        ///<summary>Gameplay tag that will be used for the cooldown.</summary>
        public unsafe GameplayTag CooldownTag {
            get {return BTDecorator_TagCooldown_ptr->CooldownTag;}
            set {BTDecorator_TagCooldown_ptr->CooldownTag = value;}
        }
        ///<summary>Value we will add or set to the Cooldown tag when this node is deactivated.</summary>
        public unsafe float CooldownDuration {
            get {return BTDecorator_TagCooldown_ptr->CooldownDuration;}
            set {BTDecorator_TagCooldown_ptr->CooldownDuration = value;}
        }
        public bool bAddToExistingDuration {
            get {return Main.GetGetBoolPropertyByName(this, "bAddToExistingDuration"); }
            set {Main.SetGetBoolPropertyByName(this, "bAddToExistingDuration", value); }
        }
        public bool bActivatesCooldown {
            get {return Main.GetGetBoolPropertyByName(this, "bActivatesCooldown"); }
            set {Main.SetGetBoolPropertyByName(this, "bActivatesCooldown", value); }
        }
        static BTDecorator_TagCooldown() {
            StaticClass = Main.GetClass("BTDecorator_TagCooldown");
        }
        internal unsafe BTDecorator_TagCooldown_fields* BTDecorator_TagCooldown_ptr => (BTDecorator_TagCooldown_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTDecorator_TagCooldown(IntPtr p) => UObject.Make<BTDecorator_TagCooldown>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTDecorator_TagCooldown DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTDecorator_TagCooldown New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
