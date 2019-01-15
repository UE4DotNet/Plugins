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

namespace UE4.AIModule {
    ///<summary>Projects points on navigation or geometry, will modify value of projected items.</summary>
    ///<remarks>Works only on item type: point</remarks>
    public unsafe partial class EnvQueryTest_Project : EnvQueryTest  {
        ///<summary>trace params</summary>
        public unsafe EnvTraceData ProjectionData {
            get {return EnvQueryTest_Project_ptr->ProjectionData;}
            set {EnvQueryTest_Project_ptr->ProjectionData = value;}
        }
        static EnvQueryTest_Project() {
            StaticClass = Main.GetClass("EnvQueryTest_Project");
        }
        internal unsafe EnvQueryTest_Project_fields* EnvQueryTest_Project_ptr => (EnvQueryTest_Project_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EnvQueryTest_Project(IntPtr p) => UObject.Make<EnvQueryTest_Project>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EnvQueryTest_Project DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EnvQueryTest_Project New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
