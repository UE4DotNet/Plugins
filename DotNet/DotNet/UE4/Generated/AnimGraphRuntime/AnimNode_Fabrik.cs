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

using UE4.Engine;

namespace UE4.AnimGraphRuntime{
        ///<summary>Controller which implements the FABRIK IK approximation algorithm -  see http://www.academia.edu/9165835/FABRIK_A_fast_iterative_solver_for_the_Inverse_Kinematics_problem for details</summary>
        [StructLayout( LayoutKind.Explicit, Size=640 )]
        public unsafe struct AnimNode_Fabrik {
            ///<summary>Coordinates for target location of tip bone - if EffectorLocationSpace is bone, this is the offset from Target Bone to use as target location</summary>
            [FieldOffset(336)] Transform EffectorTransform;

            [FieldOffset(384)] public byte EffectorTransformSpace;

            ///<summary>If EffectorTransformSpace is a bone, this is the bone to use. *</summary>
            [FieldOffset(416)] BoneSocketTarget EffectorTarget;

            [FieldOffset(528)] public byte EffectorRotationSource;

            ///<summary>Name of tip bone</summary>
            [FieldOffset(532)] BoneReference TipBone;

            ///<summary>Name of the root bone</summary>
            [FieldOffset(556)] BoneReference RootBone;

            [FieldOffset(580)] public float Precision;

            [FieldOffset(584)] public int MaxIterations;

            [FieldOffset(588)] public bool bEnableDebugDraw;

        }
}
