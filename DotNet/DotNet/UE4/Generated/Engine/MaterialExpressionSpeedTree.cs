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
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>Material Expression Speed Tree</summary>
    public unsafe partial class MaterialExpressionSpeedTree : MaterialExpression  {
        ///<summary>Defaults to 'WindType' if not specified</summary>
        public unsafe ExpressionInput GeometryInput {
            get {return MaterialExpressionSpeedTree_ptr->GeometryInput;}
            set {MaterialExpressionSpeedTree_ptr->GeometryInput = value;}
        }
        ///<summary>Defaults to 'GeometryType' if not specified</summary>
        public unsafe ExpressionInput WindInput {
            get {return MaterialExpressionSpeedTree_ptr->WindInput;}
            set {MaterialExpressionSpeedTree_ptr->WindInput = value;}
        }
        ///<summary>Defaults to 'LODType' if not specified</summary>
        public unsafe ExpressionInput LODInput {
            get {return MaterialExpressionSpeedTree_ptr->LODInput;}
            set {MaterialExpressionSpeedTree_ptr->LODInput = value;}
        }
        ///<summary>An extra bending of the tree for local effects</summary>
        public unsafe ExpressionInput ExtraBendWS {
            get {return MaterialExpressionSpeedTree_ptr->ExtraBendWS;}
            set {MaterialExpressionSpeedTree_ptr->ExtraBendWS = value;}
        }
        ///<summary>The type of SpeedTree geometry on which this material will be used</summary>
        public unsafe byte GeometryType {
            get {return MaterialExpressionSpeedTree_ptr->GeometryType;}
            set {MaterialExpressionSpeedTree_ptr->GeometryType = value;}
        }
        ///<summary>The type of wind effect used on this tree. This can only go as high as it was in the SpeedTree Modeler, but you can set it to a lower option for lower quality wind and faster rendering.</summary>
        public unsafe byte WindType {
            get {return MaterialExpressionSpeedTree_ptr->WindType;}
            set {MaterialExpressionSpeedTree_ptr->WindType = value;}
        }
        ///<summary>The type of LOD to use</summary>
        public unsafe byte LODType {
            get {return MaterialExpressionSpeedTree_ptr->LODType;}
            set {MaterialExpressionSpeedTree_ptr->LODType = value;}
        }
        ///<summary>The threshold for triangles to be removed from the bilboard mesh when not facing the camera (0 = none pass, 1 = all pass).</summary>
        public unsafe float BillboardThreshold {
            get {return MaterialExpressionSpeedTree_ptr->BillboardThreshold;}
            set {MaterialExpressionSpeedTree_ptr->BillboardThreshold = value;}
        }
        public bool bAccurateWindVelocities {
            get {return Main.GetGetBoolPropertyByName(this, "bAccurateWindVelocities"); }
            set {Main.SetGetBoolPropertyByName(this, "bAccurateWindVelocities", value); }
        }
        static MaterialExpressionSpeedTree() {
            StaticClass = Main.GetClass("MaterialExpressionSpeedTree");
        }
        internal unsafe MaterialExpressionSpeedTree_fields* MaterialExpressionSpeedTree_ptr => (MaterialExpressionSpeedTree_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialExpressionSpeedTree(IntPtr p) => UObject.Make<MaterialExpressionSpeedTree>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialExpressionSpeedTree DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialExpressionSpeedTree New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
