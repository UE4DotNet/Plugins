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
using UE4.GameplayTasks.Native;

namespace UE4.GameplayTasks {
    ///<summary>Gameplay Task Claim Resource</summary>
    public unsafe partial class GameplayTask_ClaimResource : GameplayTask  {

        ///<summary>Claim Resource</summary>
        public static GameplayTask_ClaimResource ClaimResource(byte InTaskOwner /*TODO: interface TScriptInterface */, SubclassOf<GameplayTaskResource> ResourceClass, byte Priority, Name TaskInstanceName)  => 
            GameplayTask_ClaimResource_methods.ClaimResource_method.Invoke(InTaskOwner, ResourceClass, Priority, TaskInstanceName);

        ///<summary>Claim Resources</summary>
        public static GameplayTask_ClaimResource ClaimResources(byte InTaskOwner /*TODO: interface TScriptInterface */, byte ResourceClasses /*TODO: array TArray */, byte Priority, Name TaskInstanceName)  => 
            GameplayTask_ClaimResource_methods.ClaimResources_method.Invoke(InTaskOwner, ResourceClasses, Priority, TaskInstanceName);
        static GameplayTask_ClaimResource() {
            StaticClass = Main.GetClass("GameplayTask_ClaimResource");
        }
        internal unsafe GameplayTask_ClaimResource_fields* GameplayTask_ClaimResource_ptr => (GameplayTask_ClaimResource_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GameplayTask_ClaimResource(IntPtr p) => UObject.Make<GameplayTask_ClaimResource>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GameplayTask_ClaimResource DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GameplayTask_ClaimResource New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
