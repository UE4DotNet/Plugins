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
    ///<summary>UObject wrapper for FNavigationPath</summary>
    public unsafe partial class NavigationPath : UObject  {

        ///<summary>Enable Debug Drawing</summary>
        public void EnableDebugDrawing(bool bShouldDrawDebugData, LinearColor PathColor)  => 
            NavigationPath_methods.EnableDebugDrawing_method.Invoke(ObjPointer, bShouldDrawDebugData, PathColor);

        ///<summary>if enabled path will request recalculation if it gets invalidated due to a change to underlying navigation</summary>
        public void EnableRecalculationOnInvalidation(byte DoRecalculation)  => 
            NavigationPath_methods.EnableRecalculationOnInvalidation_method.Invoke(ObjPointer, DoRecalculation);

        ///<summary>UObject end</summary>
        public string GetDebugString()  => 
            NavigationPath_methods.GetDebugString_method.Invoke(ObjPointer);

        ///<summary>Get Path Cost</summary>
        public float GetPathCost()  => 
            NavigationPath_methods.GetPathCost_method.Invoke(ObjPointer);

        ///<summary>Get Path Length</summary>
        public float GetPathLength()  => 
            NavigationPath_methods.GetPathLength_method.Invoke(ObjPointer);

        ///<summary>Is Partial</summary>
        public bool IsPartial()  => 
            NavigationPath_methods.IsPartial_method.Invoke(ObjPointer);

        ///<summary>Is String Pulled</summary>
        public bool IsStringPulled()  => 
            NavigationPath_methods.IsStringPulled_method.Invoke(ObjPointer);

        ///<summary>Is Valid</summary>
        public bool IsValid()  => 
            NavigationPath_methods.IsValid_method.Invoke(ObjPointer);
         //TODO: multicast delegate FOnNavigationPathUpdated PathUpdatedNotifier
         //TODO: array not UObject TArray PathPoints
        ///<summary>Recalculate on Invalidation</summary>
        public unsafe byte RecalculateOnInvalidation {
            get {return NavigationPath_ptr->RecalculateOnInvalidation;}
        }
        static NavigationPath() {
            StaticClass = Main.GetClass("NavigationPath");
        }
        internal unsafe NavigationPath_fields* NavigationPath_ptr => (NavigationPath_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator NavigationPath(IntPtr p) => UObject.Make<NavigationPath>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static NavigationPath DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static NavigationPath New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
