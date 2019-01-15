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
using UE4.BlueprintGraph.Native;

namespace UE4.BlueprintGraph {
    ///<summary>K2Node Tunnel</summary>
    public unsafe partial class K2Node_Tunnel : K2Node_EditablePinBase  {
        ///<summary>The output pins of this tunnel node came from the input pins of OutputSourceNode</summary>
        public unsafe K2Node_Tunnel OutputSourceNode {
            get {return K2Node_Tunnel_ptr->OutputSourceNode;}
            set {K2Node_Tunnel_ptr->OutputSourceNode = value;}
        }
        ///<summary>The input pins of this tunnel go to the output pins of InputSinkNode</summary>
        public unsafe K2Node_Tunnel InputSinkNode {
            get {return K2Node_Tunnel_ptr->InputSinkNode;}
            set {K2Node_Tunnel_ptr->InputSinkNode = value;}
        }
        public bool bCanHaveInputs {
            get {return Main.GetGetBoolPropertyByName(this, "bCanHaveInputs"); }
            set {Main.SetGetBoolPropertyByName(this, "bCanHaveInputs", value); }
        }
        public bool bCanHaveOutputs {
            get {return Main.GetGetBoolPropertyByName(this, "bCanHaveOutputs"); }
            set {Main.SetGetBoolPropertyByName(this, "bCanHaveOutputs", value); }
        }
        ///<summary>
        ///The metadata for the function/subgraph associated with this tunnel node; it's only editable and used
        ///on the tunnel entry node inside the subgraph or macro.
        ///</summary>
        ///<remarks>This structure is ignored on any other tunnel nodes.</remarks>
        public unsafe KismetUserDeclaredFunctionMetadata MetaData {
            get {return K2Node_Tunnel_ptr->MetaData;}
            set {K2Node_Tunnel_ptr->MetaData = value;}
        }
        static K2Node_Tunnel() {
            StaticClass = Main.GetClass("K2Node_Tunnel");
        }
        internal unsafe K2Node_Tunnel_fields* K2Node_Tunnel_ptr => (K2Node_Tunnel_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator K2Node_Tunnel(IntPtr p) => UObject.Make<K2Node_Tunnel>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static K2Node_Tunnel DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static K2Node_Tunnel New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
