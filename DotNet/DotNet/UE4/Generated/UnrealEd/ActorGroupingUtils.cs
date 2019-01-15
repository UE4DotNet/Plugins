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
using UE4.UnrealEd.Native;

namespace UE4.UnrealEd {
    ///<summary>Helper class for grouping actors in the level editor</summary>
    public unsafe partial class ActorGroupingUtils : UObject  {

        ///<summary>Activates "Add to Group" mode which allows the user to select a group to append current selection</summary>
        public void AddSelectedToGroup()  => 
            ActorGroupingUtils_methods.AddSelectedToGroup_method.Invoke(ObjPointer);

        ///<summary>Convenience method for accessing grouping utils in a blueprint or script</summary>
        public static ActorGroupingUtils Get()  => 
            ActorGroupingUtils_methods.Get_method.Invoke();

        ///<summary>Creates a new group from the provided list of actors removing the actors from any existing groups they are already in</summary>
        public void GroupActors(byte ActorsToGroup /*TODO: array TArray */)  => 
            ActorGroupingUtils_methods.GroupActors_method.Invoke(ObjPointer, ActorsToGroup);

        ///<summary>Creates a new group from the current selection removing the actors from any existing groups they are already in</summary>
        public void GroupSelected()  => 
            ActorGroupingUtils_methods.GroupSelected_method.Invoke(ObjPointer);

        ///<summary>Is Grouping Active</summary>
        public static bool IsGroupingActive()  => 
            ActorGroupingUtils_methods.IsGroupingActive_method.Invoke();

        ///<summary>Locks any groups in the current selection</summary>
        public void LockSelectedGroups()  => 
            ActorGroupingUtils_methods.LockSelectedGroups_method.Invoke(ObjPointer);

        ///<summary>Removes any groups or actors in the current selection from their immediate parent.</summary>
        ///<remarks>If all actors/subgroups are removed, the parent group will be destroyed.</remarks>
        public void RemoveSelectedFromGroup()  => 
            ActorGroupingUtils_methods.RemoveSelectedFromGroup_method.Invoke(ObjPointer);

        ///<summary>Set Grouping Active</summary>
        public static void SetGroupingActive(bool bInGroupingActive)  => 
            ActorGroupingUtils_methods.SetGroupingActive_method.Invoke(bInGroupingActive);

        ///<summary>Disbands any groups that the provided actors belong to, does not attempt to maintain any hierarchy</summary>
        public void UngroupActors(byte ActorsToUngroup /*TODO: array TArray */)  => 
            ActorGroupingUtils_methods.UngroupActors_method.Invoke(ObjPointer, ActorsToUngroup);

        ///<summary>Disbands any groups in the current selection, does not attempt to maintain any hierarchy</summary>
        public void UngroupSelected()  => 
            ActorGroupingUtils_methods.UngroupSelected_method.Invoke(ObjPointer);

        ///<summary>Unlocks any groups in the current selection</summary>
        public void UnlockSelectedGroups()  => 
            ActorGroupingUtils_methods.UnlockSelectedGroups_method.Invoke(ObjPointer);
        static ActorGroupingUtils() {
            StaticClass = Main.GetClass("ActorGroupingUtils");
        }
        internal unsafe ActorGroupingUtils_fields* ActorGroupingUtils_ptr => (ActorGroupingUtils_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ActorGroupingUtils(IntPtr p) => UObject.Make<ActorGroupingUtils>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ActorGroupingUtils DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ActorGroupingUtils New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
