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


namespace UE4.Engine{
        ///<summary>
        ///This is the base of all runtime animation nodes
        ///To create a new animation node:
        ///  Create a struct derived from FAnimNode_Base - this is your runtime node
        ///</summary>
        ///<remarks>Create a class derived from UAnimGraphNode_Base, containing an instance of your runtime node as a member - this is your visual/editor-only node</remarks>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct AnimNode_Base {
            ///<summary>The default handler for graph-exposed inputs</summary>
            [FieldOffset(8)] ExposedValueHandler EvaluateGraphExposedInputs;

        }
}
