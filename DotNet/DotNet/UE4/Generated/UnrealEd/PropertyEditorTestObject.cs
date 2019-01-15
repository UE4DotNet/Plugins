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
using UE4.UnrealEd.Native;
using UE4.Engine;

namespace UE4.UnrealEd {
    ///<summary>Property Editor Test Object</summary>
    public unsafe partial class PropertyEditorTestObject : UObject  {
        ///<summary>Int 8Property</summary>
        public unsafe sbyte Int8Property {
            get {return PropertyEditorTestObject_ptr->Int8Property;}
            set {PropertyEditorTestObject_ptr->Int8Property = value;}
        }
        ///<summary>Int 16roperty</summary>
        public unsafe short Int16roperty {
            get {return PropertyEditorTestObject_ptr->Int16roperty;}
            set {PropertyEditorTestObject_ptr->Int16roperty = value;}
        }
        ///<summary>Int 32Property</summary>
        public unsafe int Int32Property {
            get {return PropertyEditorTestObject_ptr->Int32Property;}
            set {PropertyEditorTestObject_ptr->Int32Property = value;}
        }
        ///<summary>Int 64Property</summary>
        public unsafe long Int64Property {
            get {return PropertyEditorTestObject_ptr->Int64Property;}
            set {PropertyEditorTestObject_ptr->Int64Property = value;}
        }
        ///<summary>Byte Property</summary>
        public unsafe byte ByteProperty {
            get {return PropertyEditorTestObject_ptr->ByteProperty;}
            set {PropertyEditorTestObject_ptr->ByteProperty = value;}
        }
         //TODO: numeric uint16 UnsignedInt16Property
         //TODO: numeric uint32 UnsignedInt32Property
         //TODO: numeric uint64 UnsignedInt64Property
        ///<summary>Float Property</summary>
        public unsafe float FloatProperty {
            get {return PropertyEditorTestObject_ptr->FloatProperty;}
            set {PropertyEditorTestObject_ptr->FloatProperty = value;}
        }
        ///<summary>Double Property</summary>
        public unsafe double DoubleProperty {
            get {return PropertyEditorTestObject_ptr->DoubleProperty;}
            set {PropertyEditorTestObject_ptr->DoubleProperty = value;}
        }
        ///<summary>Name Property</summary>
        public unsafe Name NameProperty {
            get {return PropertyEditorTestObject_ptr->NameProperty;}
            set {PropertyEditorTestObject_ptr->NameProperty = value;}
        }
        public bool BoolProperty {
            get {return Main.GetGetBoolPropertyByName(this, "BoolProperty"); }
            set {Main.SetGetBoolPropertyByName(this, "BoolProperty", value); }
        }
         //TODO: string FString StringProperty
         //TODO: text FText TextProperty
        ///<summary>Int Point Property</summary>
        public unsafe IntPoint IntPointProperty {
            get {return PropertyEditorTestObject_ptr->IntPointProperty;}
            set {PropertyEditorTestObject_ptr->IntPointProperty = value;}
        }
        ///<summary>Vector 3Property</summary>
        public unsafe Vector Vector3Property {
            get {return PropertyEditorTestObject_ptr->Vector3Property;}
            set {PropertyEditorTestObject_ptr->Vector3Property = value;}
        }
        ///<summary>Vector 2Property</summary>
        public unsafe Vector2D Vector2Property {
            get {return PropertyEditorTestObject_ptr->Vector2Property;}
            set {PropertyEditorTestObject_ptr->Vector2Property = value;}
        }
        ///<summary>Vector 4Property</summary>
        public unsafe Vector4 Vector4Property {
            get {return PropertyEditorTestObject_ptr->Vector4Property;}
            set {PropertyEditorTestObject_ptr->Vector4Property = value;}
        }
        ///<summary>Rotator Property</summary>
        public unsafe Rotator RotatorProperty {
            get {return PropertyEditorTestObject_ptr->RotatorProperty;}
            set {PropertyEditorTestObject_ptr->RotatorProperty = value;}
        }
        ///<summary>Object Property</summary>
        public unsafe UObject ObjectProperty {
            get {return PropertyEditorTestObject_ptr->ObjectProperty;}
            set {PropertyEditorTestObject_ptr->ObjectProperty = value;}
        }
        ///<summary>Class Property</summary>
        public unsafe SubclassOf<UObject> ClassProperty {
            get {return PropertyEditorTestObject_ptr->ClassProperty;}
            set {PropertyEditorTestObject_ptr->ClassProperty = value;}
        }
        ///<summary>Linear Color Property</summary>
        public unsafe LinearColor LinearColorProperty {
            get {return PropertyEditorTestObject_ptr->LinearColorProperty;}
            set {PropertyEditorTestObject_ptr->LinearColorProperty = value;}
        }
        ///<summary>Color Property</summary>
        public unsafe Color ColorProperty {
            get {return PropertyEditorTestObject_ptr->ColorProperty;}
            set {PropertyEditorTestObject_ptr->ColorProperty = value;}
        }
        ///<summary>Enum Property</summary>
        public unsafe byte EnumProperty {
            get {return PropertyEditorTestObject_ptr->EnumProperty;}
            set {PropertyEditorTestObject_ptr->EnumProperty = value;}
        }
        ///<summary>Matrix Property</summary>
        public unsafe Matrix MatrixProperty {
            get {return PropertyEditorTestObject_ptr->MatrixProperty;}
            set {PropertyEditorTestObject_ptr->MatrixProperty = value;}
        }
        ///<summary>Transform Property</summary>
        public unsafe Transform TransformProperty {
            get {return PropertyEditorTestObject_ptr->TransformProperty;}
            set {PropertyEditorTestObject_ptr->TransformProperty = value;}
        }
         //TODO: array not UObject TArray IntProperty32Array
         //TODO: array not UObject TArray BytePropertyArray
         //TODO: array not UObject TArray FloatPropertyArray
         //TODO: array not UObject TArray NamePropertyArray
         //TODO: array not UObject TArray BoolPropertyArray
         //TODO: array not UObject TArray StringPropertyArray
         //TODO: array not UObject TArray TextPropertyArray
         //TODO: array not UObject TArray Vector3PropertyArray
         //TODO: array not UObject TArray Vector2PropertyArray
         //TODO: array not UObject TArray Vector4PropertyArray
         //TODO: array not UObject TArray RotatorPropertyArray
        ///<summary>Object Property Array</summary>
        public ObjectArrayField<UObject> ObjectPropertyArray{ get {
            if(ObjectPropertyArray_store == null) ObjectPropertyArray_store = new ObjectArrayField<UObject> (&PropertyEditorTestObject_ptr->ObjectPropertyArray);
            return ObjectPropertyArray_store;
        } }
        private ObjectArrayField<UObject> ObjectPropertyArray_store;

        ///<summary>Actor Property Array</summary>
        public ObjectArrayField<Actor> ActorPropertyArray{ get {
            if(ActorPropertyArray_store == null) ActorPropertyArray_store = new ObjectArrayField<Actor> (&PropertyEditorTestObject_ptr->ActorPropertyArray);
            return ActorPropertyArray_store;
        } }
        private ObjectArrayField<Actor> ActorPropertyArray_store;

         //TODO: array not UObject TArray LinearColorPropertyArray
         //TODO: array not UObject TArray ColorPropertyArray
         //TODO: array not UObject TArray EnumPropertyArray
         //TODO: array not UObject TArray StructPropertyArray
         //TODO: array not UObject TArray FixedArrayOfInts
        ///<summary>Static Array Of Ints</summary>
        public unsafe int StaticArrayOfInts {
            get {return PropertyEditorTestObject_ptr->StaticArrayOfInts;}
            set {PropertyEditorTestObject_ptr->StaticArrayOfInts = value;}
        }
        ///<summary>Static Array Of Ints with Enum Labels</summary>
        public unsafe int StaticArrayOfIntsWithEnumLabels {
            get {return PropertyEditorTestObject_ptr->StaticArrayOfIntsWithEnumLabels;}
            set {PropertyEditorTestObject_ptr->StaticArrayOfIntsWithEnumLabels = value;}
        }
        ///<summary>This is a custom tooltip that should be shown</summary>
        public unsafe float FloatPropertyWithClampedRange {
            get {return PropertyEditorTestObject_ptr->FloatPropertyWithClampedRange;}
            set {PropertyEditorTestObject_ptr->FloatPropertyWithClampedRange = value;}
        }
        ///<summary>Int Property with Clamped Range</summary>
        public unsafe int IntPropertyWithClampedRange {
            get {return PropertyEditorTestObject_ptr->IntPropertyWithClampedRange;}
            set {PropertyEditorTestObject_ptr->IntPropertyWithClampedRange = value;}
        }
        ///<summary>Int That Cannot be Changed</summary>
        public unsafe int IntThatCannotBeChanged {
            get {return PropertyEditorTestObject_ptr->IntThatCannotBeChanged;}
            set {PropertyEditorTestObject_ptr->IntThatCannotBeChanged = value;}
        }
         //TODO: string FString StringThatCannotBeChanged
        ///<summary>Object That Cannot be Changed</summary>
        public unsafe PrimitiveComponent ObjectThatCannotBeChanged {
            get {return PropertyEditorTestObject_ptr->ObjectThatCannotBeChanged;}
            set {PropertyEditorTestObject_ptr->ObjectThatCannotBeChanged = value;}
        }
         //TODO: string FString StringPasswordProperty
         //TODO: text FText TextPasswordProperty
        ///<summary>This Is Broken if Its Visible in ADetails View</summary>
        public unsafe PropertyEditorTestBasicStruct ThisIsBrokenIfItsVisibleInADetailsView {
            get {return PropertyEditorTestObject_ptr->ThisIsBrokenIfItsVisibleInADetailsView;}
            set {PropertyEditorTestObject_ptr->ThisIsBrokenIfItsVisibleInADetailsView = value;}
        }
        ///<summary>Struct with Multiple Instances 1</summary>
        public unsafe PropertyEditorTestBasicStruct StructWithMultipleInstances1 {
            get {return PropertyEditorTestObject_ptr->StructWithMultipleInstances1;}
            set {PropertyEditorTestObject_ptr->StructWithMultipleInstances1 = value;}
        }
        public bool bEditConditionStructWithMultipleInstances2 {
            get {return Main.GetGetBoolPropertyByName(this, "bEditConditionStructWithMultipleInstances2"); }
            set {Main.SetGetBoolPropertyByName(this, "bEditConditionStructWithMultipleInstances2", value); }
        }
        ///<summary>Struct with Multiple Instances 2</summary>
        public unsafe PropertyEditorTestBasicStruct StructWithMultipleInstances2 {
            get {return PropertyEditorTestObject_ptr->StructWithMultipleInstances2;}
            set {PropertyEditorTestObject_ptr->StructWithMultipleInstances2 = value;}
        }
        ///<summary>Asset Reference Custom Struct</summary>
        public unsafe SoftObjectPath AssetReferenceCustomStruct {
            get {return PropertyEditorTestObject_ptr->AssetReferenceCustomStruct;}
            set {PropertyEditorTestObject_ptr->AssetReferenceCustomStruct = value;}
        }
        ///<summary>Asset Reference Custom Struct with Thumbnail</summary>
        public unsafe SoftObjectPath AssetReferenceCustomStructWithThumbnail {
            get {return PropertyEditorTestObject_ptr->AssetReferenceCustomStructWithThumbnail;}
            set {PropertyEditorTestObject_ptr->AssetReferenceCustomStructWithThumbnail = value;}
        }
        public bool bEditCondition {
            get {return Main.GetGetBoolPropertyByName(this, "bEditCondition"); }
            set {Main.SetGetBoolPropertyByName(this, "bEditCondition", value); }
        }
        ///<summary>Simple Property with Edit Condition</summary>
        public unsafe int SimplePropertyWithEditCondition {
            get {return PropertyEditorTestObject_ptr->SimplePropertyWithEditCondition;}
            set {PropertyEditorTestObject_ptr->SimplePropertyWithEditCondition = value;}
        }
        public bool bEditConditionAssetReferenceCustomStructWithEditCondition {
            get {return Main.GetGetBoolPropertyByName(this, "bEditConditionAssetReferenceCustomStructWithEditCondition"); }
            set {Main.SetGetBoolPropertyByName(this, "bEditConditionAssetReferenceCustomStructWithEditCondition", value); }
        }
        ///<summary>Asset Reference Custom Struct with Edit Condition</summary>
        public unsafe SoftObjectPath AssetReferenceCustomStructWithEditCondition {
            get {return PropertyEditorTestObject_ptr->AssetReferenceCustomStructWithEditCondition;}
            set {PropertyEditorTestObject_ptr->AssetReferenceCustomStructWithEditCondition = value;}
        }
         //TODO: array not UObject TArray ArrayOfStructs
        ///<summary>Edit Inline New Static Mesh Component</summary>
        public unsafe StaticMeshComponent EditInlineNewStaticMeshComponent {
            get {return PropertyEditorTestObject_ptr->EditInlineNewStaticMeshComponent;}
            set {PropertyEditorTestObject_ptr->EditInlineNewStaticMeshComponent = value;}
        }
        ///<summary>Array Of Edit Inline New SMCs</summary>
        public ObjectArrayField<StaticMeshComponent> ArrayOfEditInlineNewSMCs{ get {
            if(ArrayOfEditInlineNewSMCs_store == null) ArrayOfEditInlineNewSMCs_store = new ObjectArrayField<StaticMeshComponent> (&PropertyEditorTestObject_ptr->ArrayOfEditInlineNewSMCs);
            return ArrayOfEditInlineNewSMCs_store;
        } }
        private ObjectArrayField<StaticMeshComponent> ArrayOfEditInlineNewSMCs_store;

        ///<summary>Texture Prop</summary>
        public unsafe Texture TextureProp {
            get {return PropertyEditorTestObject_ptr->TextureProp;}
            set {PropertyEditorTestObject_ptr->TextureProp = value;}
        }
        ///<summary>Static Mesh Prop</summary>
        public unsafe StaticMesh StaticMeshProp {
            get {return PropertyEditorTestObject_ptr->StaticMeshProp;}
            set {PropertyEditorTestObject_ptr->StaticMeshProp = value;}
        }
        ///<summary>Any Material Interface</summary>
        public unsafe MaterialInterface AnyMaterialInterface {
            get {return PropertyEditorTestObject_ptr->AnyMaterialInterface;}
            set {PropertyEditorTestObject_ptr->AnyMaterialInterface = value;}
        }
        ///<summary>Only Actors Allowed</summary>
        public unsafe Actor OnlyActorsAllowed {
            get {return PropertyEditorTestObject_ptr->OnlyActorsAllowed;}
            set {PropertyEditorTestObject_ptr->OnlyActorsAllowed = value;}
        }
         //TODO: set TSet Int32Set
         //TODO: set TSet FloatSet
         //TODO: set TSet StringSet
         //TODO: set TSet ObjectSet
         //TODO: set TSet ActorSet
         //TODO: set TSet EditColorSet
         //TODO: set TSet NameSet
         //TODO: map TMap Int32ToStringMap
         //TODO: map TMap StringToColorMap
         //TODO: map TMap Int32ToStructMap
         //TODO: map TMap StringToFloatMap
         //TODO: map TMap StringToObjectMap
         //TODO: map TMap StringToActorMap
         //TODO: map TMap ObjectToInt32Map
         //TODO: map TMap ObjectToColorMap
         //TODO: map TMap IntToEnumMap
         //TODO: map TMap NameToNameMap
         //TODO: set TSet LinearColorSet
         //TODO: set TSet VectorSet
         //TODO: map TMap LinearColorToStringMap
         //TODO: map TMap VectorToFloatMap
         //TODO: map TMap LinearColorToVectorMap
         //TODO: interface TScriptInterface BlendableInterface
         //TODO: interface TScriptInterface AnimClassInterface
         //TODO: interface TScriptInterface LightPropagationVolumeBlendable
        ///<summary>
        ///Allows either an object that's derived from UTexture or IBlendableInterface, to ensure that Object Property handles know how to
        ///filter for AllowedClasses correctly.
        ///</summary>
        public unsafe UObject TextureOrBlendableInterface {
            get {return PropertyEditorTestObject_ptr->TextureOrBlendableInterface;}
            set {PropertyEditorTestObject_ptr->TextureOrBlendableInterface = value;}
        }
        static PropertyEditorTestObject() {
            StaticClass = Main.GetClass("PropertyEditorTestObject");
        }
        internal unsafe PropertyEditorTestObject_fields* PropertyEditorTestObject_ptr => (PropertyEditorTestObject_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PropertyEditorTestObject(IntPtr p) => UObject.Make<PropertyEditorTestObject>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PropertyEditorTestObject DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PropertyEditorTestObject New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
