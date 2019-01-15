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
using UE4.NavigationSystem;

namespace UE4.AIModule {
    ///<summary>Env Query Test Pathfinding</summary>
    public unsafe partial class EnvQueryTest_Pathfinding : EnvQueryTest  {
        ///<summary>testing mode</summary>
        public unsafe byte TestMode {
            get {return EnvQueryTest_Pathfinding_ptr->TestMode;}
            set {EnvQueryTest_Pathfinding_ptr->TestMode = value;}
        }
        ///<summary>context: other end of pathfinding test</summary>
        public unsafe SubclassOf<EnvQueryContext> Context {
            get {return EnvQueryTest_Pathfinding_ptr->Context;}
            set {EnvQueryTest_Pathfinding_ptr->Context = value;}
        }
        ///<summary>pathfinding direction</summary>
        public unsafe AIDataProviderBoolValue PathFromContext {
            get {return EnvQueryTest_Pathfinding_ptr->PathFromContext;}
            set {EnvQueryTest_Pathfinding_ptr->PathFromContext = value;}
        }
        ///<summary>if set, items with failed path will be invalidated (PathCost, PathLength)</summary>
        public unsafe AIDataProviderBoolValue SkipUnreachable {
            get {return EnvQueryTest_Pathfinding_ptr->SkipUnreachable;}
            set {EnvQueryTest_Pathfinding_ptr->SkipUnreachable = value;}
        }
        ///<summary>navigation filter to use in pathfinding</summary>
        public unsafe SubclassOf<NavigationQueryFilter> FilterClass {
            get {return EnvQueryTest_Pathfinding_ptr->FilterClass;}
            set {EnvQueryTest_Pathfinding_ptr->FilterClass = value;}
        }
        static EnvQueryTest_Pathfinding() {
            StaticClass = Main.GetClass("EnvQueryTest_Pathfinding");
        }
        internal unsafe EnvQueryTest_Pathfinding_fields* EnvQueryTest_Pathfinding_ptr => (EnvQueryTest_Pathfinding_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EnvQueryTest_Pathfinding(IntPtr p) => UObject.Make<EnvQueryTest_Pathfinding>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EnvQueryTest_Pathfinding DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EnvQueryTest_Pathfinding New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
