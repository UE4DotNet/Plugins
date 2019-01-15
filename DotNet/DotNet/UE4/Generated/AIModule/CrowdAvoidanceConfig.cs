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


namespace UE4.AIModule{
        ///<summary>
        ///Crowd manager is responsible for handling crowds using Detour (Recast library)
        ///Agents will respect navmesh for all steering and avoidance updates,
        ///but it's slower than AvoidanceManager solution (RVO, cares only about agents)
        ///All agents will operate on the same navmesh data, which will be picked from
        ///navigation system defaults (UNavigationSystemV1::SupportedAgents[0])
        ///To use it, you have to add CrowdFollowingComponent to your agent
        ///(usually: replace class of PathFollowingComponent in AIController by adding
        /// those lines in controller's constructor
        /// ACrowdAIController::ACrowdAIController(const FObjectInitializer& ObjectInitializer)
        ///     : Super(ObjectInitializer.
        ///</summary>
        ///<remarks>
        ///SetDefaultSubobjectClass<UCrowdFollowingComponent>(TEXT("PathFollowingComponent")))
        ///
        /// or simply add both components and switch move requests between them)
        ///
        ///Actors that should be avoided, but are not being simulated by crowd (like players)
        ///should implement CrowdAgentInterface AND register/unregister themselves with crowd manager:
        ///
        /// UCrowdManager* CrowdManager = UCrowdManager::GetCurrent(this);
        /// if (CrowdManager)
        /// {
        ///    CrowdManager->RegisterAgent(this);
        /// }
        ///
        /// Check flags in CrowdDebugDrawing namespace (CrowdManager.cpp) for debugging options.
        ///</remarks>
        [StructLayout( LayoutKind.Explicit, Size=28 )]
        public unsafe struct CrowdAvoidanceConfig {
            [FieldOffset(0)] public float VelocityBias;

            [FieldOffset(4)] public float DesiredVelocityWeight;

            [FieldOffset(8)] public float CurrentVelocityWeight;

            [FieldOffset(12)] public float SideBiasWeight;

            [FieldOffset(16)] public float ImpactTimeWeight;

            [FieldOffset(20)] public float ImpactTimeRange;

            [FieldOffset(24)] public byte CustomPatternIdx;

            [FieldOffset(25)] public byte AdaptiveDivisions;

            [FieldOffset(26)] public byte AdaptiveRings;

            [FieldOffset(27)] public byte AdaptiveDepth;

        }
}
