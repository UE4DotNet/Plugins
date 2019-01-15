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


namespace UE4.GraphEditor.Native {
    [StructLayout( LayoutKind.Explicit, Size=736 )]
    internal unsafe struct GraphEditorSettings_fields {
        [FieldOffset(56)] public byte DataPinStyle;
        [FieldOffset(57)] byte PanningMouseButton; //TODO: enum EGraphPanningMouseButton PanningMouseButton
        [FieldOffset(60)] public float PaddingAbovePin;
        [FieldOffset(64)] public float PaddingBelowPin;
        [FieldOffset(68)] public float PaddingRightOfInput;
        [FieldOffset(72)] public float PaddingLeftOfOutput;
        [FieldOffset(76)] public float PaddingTowardsNodeEdge;
        [FieldOffset(80)] public bool bTreatSplinesLikePins;
        [FieldOffset(84)] public float SplineHoverTolerance;
        [FieldOffset(88)] public float ForwardSplineHorizontalDeltaRange;
        [FieldOffset(92)] public float ForwardSplineVerticalDeltaRange;
        [FieldOffset(96)] public Vector2D ForwardSplineTangentFromHorizontalDelta;
        [FieldOffset(104)] public Vector2D ForwardSplineTangentFromVerticalDelta;
        [FieldOffset(112)] public float BackwardSplineHorizontalDeltaRange;
        [FieldOffset(116)] public float BackwardSplineVerticalDeltaRange;
        [FieldOffset(120)] public Vector2D BackwardSplineTangentFromHorizontalDelta;
        [FieldOffset(128)] public Vector2D BackwardSplineTangentFromVerticalDelta;
        [FieldOffset(136)] public LinearColor DefaultPinTypeColor;
        [FieldOffset(152)] public LinearColor ExecutionPinTypeColor;
        [FieldOffset(168)] public LinearColor BooleanPinTypeColor;
        [FieldOffset(184)] public LinearColor BytePinTypeColor;
        [FieldOffset(200)] public LinearColor ClassPinTypeColor;
        [FieldOffset(216)] public LinearColor IntPinTypeColor;
        [FieldOffset(232)] public LinearColor FloatPinTypeColor;
        [FieldOffset(248)] public LinearColor NamePinTypeColor;
        [FieldOffset(264)] public LinearColor SoftObjectPinTypeColor;
        [FieldOffset(280)] public LinearColor SoftClassPinTypeColor;
        [FieldOffset(296)] public LinearColor DelegatePinTypeColor;
        [FieldOffset(312)] public LinearColor ObjectPinTypeColor;
        [FieldOffset(328)] public LinearColor InterfacePinTypeColor;
        [FieldOffset(344)] public LinearColor StringPinTypeColor;
        [FieldOffset(360)] public LinearColor TextPinTypeColor;
        [FieldOffset(376)] public LinearColor StructPinTypeColor;
        [FieldOffset(392)] public LinearColor WildcardPinTypeColor;
        [FieldOffset(408)] public LinearColor VectorPinTypeColor;
        [FieldOffset(424)] public LinearColor RotatorPinTypeColor;
        [FieldOffset(440)] public LinearColor TransformPinTypeColor;
        [FieldOffset(456)] public LinearColor IndexPinTypeColor;
        [FieldOffset(472)] public LinearColor EventNodeTitleColor;
        [FieldOffset(488)] public LinearColor FunctionCallNodeTitleColor;
        [FieldOffset(504)] public LinearColor PureFunctionCallNodeTitleColor;
        [FieldOffset(520)] public LinearColor ParentFunctionCallNodeTitleColor;
        [FieldOffset(536)] public LinearColor FunctionTerminatorNodeTitleColor;
        [FieldOffset(552)] public LinearColor ExecBranchNodeTitleColor;
        [FieldOffset(568)] public LinearColor ExecSequenceNodeTitleColor;
        [FieldOffset(584)] public LinearColor ResultNodeTitleColor;
        [FieldOffset(600)] public LinearColor DefaultCommentNodeTitleColor;
        [FieldOffset(616)] public LinearColor PreviewNodeTitleColor;
        [FieldOffset(632)] public float DefaultDataWireThickness;
        [FieldOffset(636)] public float DefaultExecutionWireThickness;
        [FieldOffset(640)] public LinearColor TraceAttackColor;
        [FieldOffset(656)] public float TraceAttackWireThickness;
        [FieldOffset(660)] public float TraceAttackHoldPeriod;
        [FieldOffset(664)] public float TraceDecayPeriod;
        [FieldOffset(668)] public float TraceDecayExponent;
        [FieldOffset(672)] public LinearColor TraceSustainColor;
        [FieldOffset(688)] public float TraceSustainWireThickness;
        [FieldOffset(692)] public float TraceSustainHoldPeriod;
        [FieldOffset(696)] public LinearColor TraceReleaseColor;
        [FieldOffset(712)] public float TraceReleaseWireThickness;
        [FieldOffset(716)] public float TraceReleasePeriod;
        [FieldOffset(720)] public float TraceReleaseExponent;
        [FieldOffset(724)] public float TracePositionBonusPeriod;
        [FieldOffset(728)] public float TracePositionExponent;
    }
    internal unsafe struct GraphEditorSettings_methods {
    }
    internal unsafe struct GraphEditorSettings_events {
    }
}
