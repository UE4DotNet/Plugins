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
using UE4.GraphEditor.Native;

namespace UE4.GraphEditor {
    ///<summary>Implements settings for the graph editor.</summary>
    public unsafe partial class GraphEditorSettings : UObject  {
        ///<summary>The visual styling to use for graph editor pins (in Blueprints, materials, etc...)</summary>
        public unsafe byte DataPinStyle {
            get {return GraphEditorSettings_ptr->DataPinStyle;}
            set {GraphEditorSettings_ptr->DataPinStyle = value;}
        }
         //TODO: enum EGraphPanningMouseButton PanningMouseButton
        ///<summary>The amount of padding above a pin (defaults to 4)</summary>
        public unsafe float PaddingAbovePin {
            get {return GraphEditorSettings_ptr->PaddingAbovePin;}
            set {GraphEditorSettings_ptr->PaddingAbovePin = value;}
        }
        ///<summary>The amount of padding below a pin (defaults to 4)</summary>
        public unsafe float PaddingBelowPin {
            get {return GraphEditorSettings_ptr->PaddingBelowPin;}
            set {GraphEditorSettings_ptr->PaddingBelowPin = value;}
        }
        ///<summary>The amount of horizontal padding towards the center of a node on an input pin (defaults to 10)</summary>
        public unsafe float PaddingRightOfInput {
            get {return GraphEditorSettings_ptr->PaddingRightOfInput;}
            set {GraphEditorSettings_ptr->PaddingRightOfInput = value;}
        }
        ///<summary>The amount of horizontal padding towards the center of a node on an output pin (defaults to 10)</summary>
        public unsafe float PaddingLeftOfOutput {
            get {return GraphEditorSettings_ptr->PaddingLeftOfOutput;}
            set {GraphEditorSettings_ptr->PaddingLeftOfOutput = value;}
        }
        ///<summary>The amount of padding towards the node edge (defaults to 10, can be negative to make pins overlap or stick out of a node</summary>
        public unsafe float PaddingTowardsNodeEdge {
            get {return GraphEditorSettings_ptr->PaddingTowardsNodeEdge;}
            set {GraphEditorSettings_ptr->PaddingTowardsNodeEdge = value;}
        }
        public bool bTreatSplinesLikePins {
            get {return Main.GetGetBoolPropertyByName(this, "bTreatSplinesLikePins"); }
            set {Main.SetGetBoolPropertyByName(this, "bTreatSplinesLikePins", value); }
        }
        ///<summary>The distance threshold controlling how close the mouse has to be to the spline in order to trigger a hover response</summary>
        public unsafe float SplineHoverTolerance {
            get {return GraphEditorSettings_ptr->SplineHoverTolerance;}
            set {GraphEditorSettings_ptr->SplineHoverTolerance = value;}
        }
        ///<summary>The maximum value to clamp the absolute value of the horizontal distance between endpoints when calculating tangents (when the wire is moving forward)</summary>
        public unsafe float ForwardSplineHorizontalDeltaRange {
            get {return GraphEditorSettings_ptr->ForwardSplineHorizontalDeltaRange;}
            set {GraphEditorSettings_ptr->ForwardSplineHorizontalDeltaRange = value;}
        }
        ///<summary>The maximum value to clamp the absolute value of the vertical distance between endpoints when calculating tangents (when the wire is moving forward)</summary>
        public unsafe float ForwardSplineVerticalDeltaRange {
            get {return GraphEditorSettings_ptr->ForwardSplineVerticalDeltaRange;}
            set {GraphEditorSettings_ptr->ForwardSplineVerticalDeltaRange = value;}
        }
        ///<summary>The amount that the horizontal delta affects the generated tangent handle of splines (when the wire is moving forward)</summary>
        public unsafe Vector2D ForwardSplineTangentFromHorizontalDelta {
            get {return GraphEditorSettings_ptr->ForwardSplineTangentFromHorizontalDelta;}
            set {GraphEditorSettings_ptr->ForwardSplineTangentFromHorizontalDelta = value;}
        }
        ///<summary>The amount that the vertical delta affects the generated tangent handle of splines (when the wire is moving forward)</summary>
        public unsafe Vector2D ForwardSplineTangentFromVerticalDelta {
            get {return GraphEditorSettings_ptr->ForwardSplineTangentFromVerticalDelta;}
            set {GraphEditorSettings_ptr->ForwardSplineTangentFromVerticalDelta = value;}
        }
        ///<summary>The maximum value to clamp the absolute value of the horizontal distance between endpoints when calculating tangents (when the wire is moving backwards)</summary>
        public unsafe float BackwardSplineHorizontalDeltaRange {
            get {return GraphEditorSettings_ptr->BackwardSplineHorizontalDeltaRange;}
            set {GraphEditorSettings_ptr->BackwardSplineHorizontalDeltaRange = value;}
        }
        ///<summary>The maximum value to clamp the absolute value of the vertical distance between endpoints when calculating tangents (when the wire is moving backwards)</summary>
        public unsafe float BackwardSplineVerticalDeltaRange {
            get {return GraphEditorSettings_ptr->BackwardSplineVerticalDeltaRange;}
            set {GraphEditorSettings_ptr->BackwardSplineVerticalDeltaRange = value;}
        }
        ///<summary>The amount that the horizontal delta affects the generated tangent handle of splines (when the wire is moving backwards)</summary>
        public unsafe Vector2D BackwardSplineTangentFromHorizontalDelta {
            get {return GraphEditorSettings_ptr->BackwardSplineTangentFromHorizontalDelta;}
            set {GraphEditorSettings_ptr->BackwardSplineTangentFromHorizontalDelta = value;}
        }
        ///<summary>The amount that the vertical delta affects the generated tangent handle of splines (when the wire is moving backwards)</summary>
        public unsafe Vector2D BackwardSplineTangentFromVerticalDelta {
            get {return GraphEditorSettings_ptr->BackwardSplineTangentFromVerticalDelta;}
            set {GraphEditorSettings_ptr->BackwardSplineTangentFromVerticalDelta = value;}
        }
        ///<summary>The default color is used only for types not specifically defined below.  Generally if it's seen, it means another type needs to be defined so that the wire in question can have an appropriate color.</summary>
        public unsafe LinearColor DefaultPinTypeColor {
            get {return GraphEditorSettings_ptr->DefaultPinTypeColor;}
            set {GraphEditorSettings_ptr->DefaultPinTypeColor = value;}
        }
        ///<summary>Execution pin type color</summary>
        public unsafe LinearColor ExecutionPinTypeColor {
            get {return GraphEditorSettings_ptr->ExecutionPinTypeColor;}
            set {GraphEditorSettings_ptr->ExecutionPinTypeColor = value;}
        }
        ///<summary>Boolean pin type color</summary>
        public unsafe LinearColor BooleanPinTypeColor {
            get {return GraphEditorSettings_ptr->BooleanPinTypeColor;}
            set {GraphEditorSettings_ptr->BooleanPinTypeColor = value;}
        }
        ///<summary>Byte pin type color</summary>
        public unsafe LinearColor BytePinTypeColor {
            get {return GraphEditorSettings_ptr->BytePinTypeColor;}
            set {GraphEditorSettings_ptr->BytePinTypeColor = value;}
        }
        ///<summary>Class pin type color</summary>
        public unsafe LinearColor ClassPinTypeColor {
            get {return GraphEditorSettings_ptr->ClassPinTypeColor;}
            set {GraphEditorSettings_ptr->ClassPinTypeColor = value;}
        }
        ///<summary>Integer pin type color</summary>
        public unsafe LinearColor IntPinTypeColor {
            get {return GraphEditorSettings_ptr->IntPinTypeColor;}
            set {GraphEditorSettings_ptr->IntPinTypeColor = value;}
        }
        ///<summary>Floating-point pin type color</summary>
        public unsafe LinearColor FloatPinTypeColor {
            get {return GraphEditorSettings_ptr->FloatPinTypeColor;}
            set {GraphEditorSettings_ptr->FloatPinTypeColor = value;}
        }
        ///<summary>Name pin type color</summary>
        public unsafe LinearColor NamePinTypeColor {
            get {return GraphEditorSettings_ptr->NamePinTypeColor;}
            set {GraphEditorSettings_ptr->NamePinTypeColor = value;}
        }
        ///<summary>Asset pin type color</summary>
        public unsafe LinearColor SoftObjectPinTypeColor {
            get {return GraphEditorSettings_ptr->SoftObjectPinTypeColor;}
            set {GraphEditorSettings_ptr->SoftObjectPinTypeColor = value;}
        }
        ///<summary>Asset Class pin type color</summary>
        public unsafe LinearColor SoftClassPinTypeColor {
            get {return GraphEditorSettings_ptr->SoftClassPinTypeColor;}
            set {GraphEditorSettings_ptr->SoftClassPinTypeColor = value;}
        }
        ///<summary>Delegate pin type color</summary>
        public unsafe LinearColor DelegatePinTypeColor {
            get {return GraphEditorSettings_ptr->DelegatePinTypeColor;}
            set {GraphEditorSettings_ptr->DelegatePinTypeColor = value;}
        }
        ///<summary>Object pin type color</summary>
        public unsafe LinearColor ObjectPinTypeColor {
            get {return GraphEditorSettings_ptr->ObjectPinTypeColor;}
            set {GraphEditorSettings_ptr->ObjectPinTypeColor = value;}
        }
        ///<summary>Interface pin type color</summary>
        public unsafe LinearColor InterfacePinTypeColor {
            get {return GraphEditorSettings_ptr->InterfacePinTypeColor;}
            set {GraphEditorSettings_ptr->InterfacePinTypeColor = value;}
        }
        ///<summary>String pin type color</summary>
        public unsafe LinearColor StringPinTypeColor {
            get {return GraphEditorSettings_ptr->StringPinTypeColor;}
            set {GraphEditorSettings_ptr->StringPinTypeColor = value;}
        }
        ///<summary>Text pin type color</summary>
        public unsafe LinearColor TextPinTypeColor {
            get {return GraphEditorSettings_ptr->TextPinTypeColor;}
            set {GraphEditorSettings_ptr->TextPinTypeColor = value;}
        }
        ///<summary>Struct pin type color</summary>
        public unsafe LinearColor StructPinTypeColor {
            get {return GraphEditorSettings_ptr->StructPinTypeColor;}
            set {GraphEditorSettings_ptr->StructPinTypeColor = value;}
        }
        ///<summary>Wildcard pin type color</summary>
        public unsafe LinearColor WildcardPinTypeColor {
            get {return GraphEditorSettings_ptr->WildcardPinTypeColor;}
            set {GraphEditorSettings_ptr->WildcardPinTypeColor = value;}
        }
        ///<summary>Vector pin type color</summary>
        public unsafe LinearColor VectorPinTypeColor {
            get {return GraphEditorSettings_ptr->VectorPinTypeColor;}
            set {GraphEditorSettings_ptr->VectorPinTypeColor = value;}
        }
        ///<summary>Rotator pin type color</summary>
        public unsafe LinearColor RotatorPinTypeColor {
            get {return GraphEditorSettings_ptr->RotatorPinTypeColor;}
            set {GraphEditorSettings_ptr->RotatorPinTypeColor = value;}
        }
        ///<summary>Transform pin type color</summary>
        public unsafe LinearColor TransformPinTypeColor {
            get {return GraphEditorSettings_ptr->TransformPinTypeColor;}
            set {GraphEditorSettings_ptr->TransformPinTypeColor = value;}
        }
        ///<summary>Index pin type color</summary>
        public unsafe LinearColor IndexPinTypeColor {
            get {return GraphEditorSettings_ptr->IndexPinTypeColor;}
            set {GraphEditorSettings_ptr->IndexPinTypeColor = value;}
        }
        ///<summary>Event node title color</summary>
        public unsafe LinearColor EventNodeTitleColor {
            get {return GraphEditorSettings_ptr->EventNodeTitleColor;}
            set {GraphEditorSettings_ptr->EventNodeTitleColor = value;}
        }
        ///<summary>CallFunction node title color</summary>
        public unsafe LinearColor FunctionCallNodeTitleColor {
            get {return GraphEditorSettings_ptr->FunctionCallNodeTitleColor;}
            set {GraphEditorSettings_ptr->FunctionCallNodeTitleColor = value;}
        }
        ///<summary>Pure function call node title color</summary>
        public unsafe LinearColor PureFunctionCallNodeTitleColor {
            get {return GraphEditorSettings_ptr->PureFunctionCallNodeTitleColor;}
            set {GraphEditorSettings_ptr->PureFunctionCallNodeTitleColor = value;}
        }
        ///<summary>Parent class function call node title color</summary>
        public unsafe LinearColor ParentFunctionCallNodeTitleColor {
            get {return GraphEditorSettings_ptr->ParentFunctionCallNodeTitleColor;}
            set {GraphEditorSettings_ptr->ParentFunctionCallNodeTitleColor = value;}
        }
        ///<summary>Function Terminator node title color</summary>
        public unsafe LinearColor FunctionTerminatorNodeTitleColor {
            get {return GraphEditorSettings_ptr->FunctionTerminatorNodeTitleColor;}
            set {GraphEditorSettings_ptr->FunctionTerminatorNodeTitleColor = value;}
        }
        ///<summary>Exec Branch node title color</summary>
        public unsafe LinearColor ExecBranchNodeTitleColor {
            get {return GraphEditorSettings_ptr->ExecBranchNodeTitleColor;}
            set {GraphEditorSettings_ptr->ExecBranchNodeTitleColor = value;}
        }
        ///<summary>Exec Sequence node title color</summary>
        public unsafe LinearColor ExecSequenceNodeTitleColor {
            get {return GraphEditorSettings_ptr->ExecSequenceNodeTitleColor;}
            set {GraphEditorSettings_ptr->ExecSequenceNodeTitleColor = value;}
        }
        ///<summary>Result node title color</summary>
        public unsafe LinearColor ResultNodeTitleColor {
            get {return GraphEditorSettings_ptr->ResultNodeTitleColor;}
            set {GraphEditorSettings_ptr->ResultNodeTitleColor = value;}
        }
        ///<summary>Default Comment node title color</summary>
        public unsafe LinearColor DefaultCommentNodeTitleColor {
            get {return GraphEditorSettings_ptr->DefaultCommentNodeTitleColor;}
            set {GraphEditorSettings_ptr->DefaultCommentNodeTitleColor = value;}
        }
        ///<summary>Preview node title color</summary>
        public unsafe LinearColor PreviewNodeTitleColor {
            get {return GraphEditorSettings_ptr->PreviewNodeTitleColor;}
            set {GraphEditorSettings_ptr->PreviewNodeTitleColor = value;}
        }
        ///<summary>The thickness of a data wire</summary>
        public unsafe float DefaultDataWireThickness {
            get {return GraphEditorSettings_ptr->DefaultDataWireThickness;}
            set {GraphEditorSettings_ptr->DefaultDataWireThickness = value;}
        }
        ///<summary>The thickness of an execution wire when not debugging</summary>
        public unsafe float DefaultExecutionWireThickness {
            get {return GraphEditorSettings_ptr->DefaultExecutionWireThickness;}
            set {GraphEditorSettings_ptr->DefaultExecutionWireThickness = value;}
        }
        ///<summary>The color to display execution wires that were just executed</summary>
        public unsafe LinearColor TraceAttackColor {
            get {return GraphEditorSettings_ptr->TraceAttackColor;}
            set {GraphEditorSettings_ptr->TraceAttackColor = value;}
        }
        ///<summary>Trace Attack Wire Thickness</summary>
        public unsafe float TraceAttackWireThickness {
            get {return GraphEditorSettings_ptr->TraceAttackWireThickness;}
            set {GraphEditorSettings_ptr->TraceAttackWireThickness = value;}
        }
        ///<summary>How long is the attack color fully visible</summary>
        public unsafe float TraceAttackHoldPeriod {
            get {return GraphEditorSettings_ptr->TraceAttackHoldPeriod;}
            set {GraphEditorSettings_ptr->TraceAttackHoldPeriod = value;}
        }
        ///<summary>How long does it take to fade from the attack to the sustain color</summary>
        public unsafe float TraceDecayPeriod {
            get {return GraphEditorSettings_ptr->TraceDecayPeriod;}
            set {GraphEditorSettings_ptr->TraceDecayPeriod = value;}
        }
        ///<summary>Trace Decay Exponent</summary>
        public unsafe float TraceDecayExponent {
            get {return GraphEditorSettings_ptr->TraceDecayExponent;}
            set {GraphEditorSettings_ptr->TraceDecayExponent = value;}
        }
        ///<summary>Trace Sustain Color</summary>
        public unsafe LinearColor TraceSustainColor {
            get {return GraphEditorSettings_ptr->TraceSustainColor;}
            set {GraphEditorSettings_ptr->TraceSustainColor = value;}
        }
        ///<summary>Trace Sustain Wire Thickness</summary>
        public unsafe float TraceSustainWireThickness {
            get {return GraphEditorSettings_ptr->TraceSustainWireThickness;}
            set {GraphEditorSettings_ptr->TraceSustainWireThickness = value;}
        }
        ///<summary>How long is the sustain color fully visible</summary>
        public unsafe float TraceSustainHoldPeriod {
            get {return GraphEditorSettings_ptr->TraceSustainHoldPeriod;}
            set {GraphEditorSettings_ptr->TraceSustainHoldPeriod = value;}
        }
        ///<summary>The color to fade to for execution wires on release</summary>
        public unsafe LinearColor TraceReleaseColor {
            get {return GraphEditorSettings_ptr->TraceReleaseColor;}
            set {GraphEditorSettings_ptr->TraceReleaseColor = value;}
        }
        ///<summary>The thickness to drop down to during release / for unexecuted wires when debugging</summary>
        public unsafe float TraceReleaseWireThickness {
            get {return GraphEditorSettings_ptr->TraceReleaseWireThickness;}
            set {GraphEditorSettings_ptr->TraceReleaseWireThickness = value;}
        }
        ///<summary>How long does it take to fade from the sustain to the release color</summary>
        public unsafe float TraceReleasePeriod {
            get {return GraphEditorSettings_ptr->TraceReleasePeriod;}
            set {GraphEditorSettings_ptr->TraceReleasePeriod = value;}
        }
        ///<summary>Trace Release Exponent</summary>
        public unsafe float TraceReleaseExponent {
            get {return GraphEditorSettings_ptr->TraceReleaseExponent;}
            set {GraphEditorSettings_ptr->TraceReleaseExponent = value;}
        }
        ///<summary>How much of a bonus does an exec get for being near the top of the trace stack, and how does that fall off with position?</summary>
        public unsafe float TracePositionBonusPeriod {
            get {return GraphEditorSettings_ptr->TracePositionBonusPeriod;}
            set {GraphEditorSettings_ptr->TracePositionBonusPeriod = value;}
        }
        ///<summary>Trace Position Exponent</summary>
        public unsafe float TracePositionExponent {
            get {return GraphEditorSettings_ptr->TracePositionExponent;}
            set {GraphEditorSettings_ptr->TracePositionExponent = value;}
        }
        static GraphEditorSettings() {
            StaticClass = Main.GetClass("GraphEditorSettings");
        }
        internal unsafe GraphEditorSettings_fields* GraphEditorSettings_ptr => (GraphEditorSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GraphEditorSettings(IntPtr p) => UObject.Make<GraphEditorSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GraphEditorSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GraphEditorSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
