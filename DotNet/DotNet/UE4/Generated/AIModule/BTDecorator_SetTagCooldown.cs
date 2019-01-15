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
    ///<summary>Set tag cooldown decorator node.</summary>
    ///<remarks>A decorator node that sets a gameplay tag cooldown.</remarks>
    public unsafe partial class BTDecorator_SetTagCooldown : BTDecorator  {
        ///<summary>Gameplay tag that will be used for the cooldown.</summary>
        public unsafe GameplayTag CooldownTag {
            get {return BTDecorator_SetTagCooldown_ptr->CooldownTag;}
            set {BTDecorator_SetTagCooldown_ptr->CooldownTag = value;}
        }
        ///<summary>Value we will add or set to the Cooldown tag when this task runs.</summary>
        public unsafe float CooldownDuration {
            get {return BTDecorator_SetTagCooldown_ptr->CooldownDuration;}
            set {BTDecorator_SetTagCooldown_ptr->CooldownDuration = value;}
        }
        public bool bAddToExistingDuration {
            get {return Main.GetGetBoolPropertyByName(this, "bAddToExistingDuration"); }
            set {Main.SetGetBoolPropertyByName(this, "bAddToExistingDuration", value); }
        }
        static BTDecorator_SetTagCooldown() {
            StaticClass = Main.GetClass("BTDecorator_SetTagCooldown");
        }
        internal unsafe BTDecorator_SetTagCooldown_fields* BTDecorator_SetTagCooldown_ptr => (BTDecorator_SetTagCooldown_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTDecorator_SetTagCooldown(IntPtr p) => UObject.Make<BTDecorator_SetTagCooldown>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTDecorator_SetTagCooldown DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTDecorator_SetTagCooldown New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
