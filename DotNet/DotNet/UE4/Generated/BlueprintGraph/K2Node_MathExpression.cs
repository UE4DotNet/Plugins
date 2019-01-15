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
    ///<summary>
    ///This node type acts like a collapsed node, a single node that represents
    ///a larger sub-network of nodes (contained within a sub-graph).
    ///</summary>
    ///<remarks>
    ///This node will
    ///take the math expression it was named with, and attempt to convert it into a
    ///series of math nodes. If it is unsuccessful, then it generates a series of
    ///actionable errors.
    ///</remarks>
    public unsafe partial class K2Node_MathExpression : K2Node_Composite  {
         //TODO: string FString Expression
        public bool bMadeAfterRotChange {
            get {return Main.GetGetBoolPropertyByName(this, "bMadeAfterRotChange"); }
            set {Main.SetGetBoolPropertyByName(this, "bMadeAfterRotChange", value); }
        }
        static K2Node_MathExpression() {
            StaticClass = Main.GetClass("K2Node_MathExpression");
        }
        internal unsafe K2Node_MathExpression_fields* K2Node_MathExpression_ptr => (K2Node_MathExpression_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator K2Node_MathExpression(IntPtr p) => UObject.Make<K2Node_MathExpression>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static K2Node_MathExpression DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static K2Node_MathExpression New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
