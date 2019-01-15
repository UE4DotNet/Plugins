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
        ///<summary>Properties of representation of an 'agent' (or Pawn) used by AI navigation/pathfinding.</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct NavAgentProperties {
            [FieldOffset(4)] public float AgentRadius;

            [FieldOffset(8)] public float AgentHeight;

            [FieldOffset(12)] public float AgentStepHeight;

            [FieldOffset(16)] public float NavWalkingSearchHeightScale;

            ///<summary>UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = MovementProperties)</summary>
            ///<remarks>TSubclassOf<ANavigationData> PreferredNavData;</remarks>
            [FieldOffset(24)] SoftClassPath PreferredNavData;

        }
}
