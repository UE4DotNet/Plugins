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

using UE4.AnimationCore;
using UE4.Engine;

namespace UE4.AnimGraphRuntime{
        ///<summary>
        ///This is the node that apply corrective morphtarget for twist
        ///Good example is that if you twist your neck too far right or left, you're going to see odd stretch shape of neck,
        ///This node can detect the angle and apply morphtarget curve
        ///</summary>
        ///<remarks>This isn't the twist control node for bone twist</remarks>
        [StructLayout( LayoutKind.Explicit, Size=472 )]
        public unsafe struct AnimNode_TwistCorrectiveNode {
            ///<summary>Base Frame of the reference for the twist node</summary>
            [FieldOffset(336)] ReferenceBoneFrame BaseFrame;

            ///<summary>Transform component to use as input</summary>
            [FieldOffset(376)] ReferenceBoneFrame TwistFrame;

            ///<summary>Normal of the Plane that we'd like to calculate angle calculation from in BaseFrame. Please note we're looking for Normal Axis</summary>
            [FieldOffset(416)] Axis TwistPlaneNormalAxis;

            [FieldOffset(432)] public float RangeMax;

            [FieldOffset(436)] public float RemappedMin;

            [FieldOffset(440)] public float RemappedMax;

            ///<summary>Curve</summary>
            [FieldOffset(444)] AnimCurveParam Curve;

        }
}
