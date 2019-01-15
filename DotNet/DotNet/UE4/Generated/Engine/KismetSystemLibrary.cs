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
    ///<summary>Kismet System Library</summary>
    public unsafe partial class KismetSystemLibrary : BlueprintFunctionLibrary  {

        ///<summary>Add Float History Sample</summary>
        public static DebugFloatHistory AddFloatHistorySample(float Value, DebugFloatHistory FloatHistory)  => 
            KismetSystemLibrary_methods.AddFloatHistorySample_method.Invoke(Value, FloatHistory);

        ///<summary>Returns an array of actors that overlap the given axis-aligned box.</summary>
        ///<remarks>
        ///@param WorldContext  World context
        ///@param BoxPos                Center of box.
        ///@param BoxExtent             Extents of box.
        ///@param Filter                Option to restrict results to only static or only dynamic.  For efficiency.
        ///@param ClassFilter   If set, will only return results of this class or subclasses of it.
        ///@param ActorsToIgnore                Ignore these actors in the list
        ///@param OutActors             Returned array of actors. Unsorted.
        ///@return                              true if there was an overlap that passed the filters, false otherwise.
        ///</remarks>
        public static (IReadOnlyCollection<Actor>, bool) BoxOverlapActors(UObject WorldContextObject, Vector BoxPos, Vector BoxExtent, byte ObjectTypes /*TODO: array TArray */, SubclassOf<UObject> ActorClassFilter, byte ActorsToIgnore /*TODO: array TArray */)  => 
            KismetSystemLibrary_methods.BoxOverlapActors_method.Invoke(WorldContextObject, BoxPos, BoxExtent, ObjectTypes, ActorClassFilter, ActorsToIgnore);

        ///<summary>Returns an array of components that overlap the given axis-aligned box.</summary>
        ///<remarks>
        ///@param WorldContext  World context
        ///@param BoxPos                Center of box.
        ///@param BoxExtent             Extents of box.
        ///@param Filter                Option to restrict results to only static or only dynamic.  For efficiency.
        ///@param ClassFilter   If set, will only return results of this class or subclasses of it.
        ///@param ActorsToIgnore                Ignore these actors in the list
        ///@param OutActors             Returned array of actors. Unsorted.
        ///@return                              true if there was an overlap that passed the filters, false otherwise.
        ///</remarks>
        public static (IReadOnlyCollection<PrimitiveComponent>, bool) BoxOverlapComponents(UObject WorldContextObject, Vector BoxPos, Vector Extent, byte ObjectTypes /*TODO: array TArray */, SubclassOf<UObject> ComponentClassFilter, byte ActorsToIgnore /*TODO: array TArray */)  => 
            KismetSystemLibrary_methods.BoxOverlapComponents_method.Invoke(WorldContextObject, BoxPos, Extent, ObjectTypes, ComponentClassFilter, ActorsToIgnore);

        ///<summary>Sweeps a box along the given line and returns all hits encountered.</summary>
        ///<remarks>
        ///This trace finds the objects that RESPONDS to the given TraceChannel
        ///
        ///@param Start                  Start of line segment.
        ///@param End                    End of line segment.
        ///@param HalfSize           Distance from the center of box along each axis
        ///@param Orientation    Orientation of the box
        ///@param TraceChannel
        ///@param bTraceComplex  True to test against complex collision, false to test against simplified collision.
        ///@param OutHits                A list of hits, sorted along the trace from start to finish. The blocking hit will be the last hit, if there was one.
        ///@return                               True if there was a blocking hit, false otherwise.
        ///</remarks>
        public static (IReadOnlyCollection<HitResult>, bool) BoxTraceMulti(UObject WorldContextObject, Vector Start, Vector End, Vector HalfSize, Rotator Orientation, byte TraceChannel, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime)  => 
            KismetSystemLibrary_methods.BoxTraceMulti_method.Invoke(WorldContextObject, Start, End, HalfSize, Orientation, TraceChannel, bTraceComplex, ActorsToIgnore, DrawDebugType, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);

        ///<summary>
        ///Sweep a box against the world and return all initial overlaps using a specific profile, then overlapping hits and then first blocking hit
        ///Results are sorted, so a blocking hit (if found) will be the last element of the array
        ///Only the single closest blocking result will be generated, no tests will be done after that
        ///@
        ///</summary>
        ///<remarks>
        ///param Start                  Start of line segment.
        ///@param End                    End of line segment.
        ///@param HalfSize           Distance from the center of box along each axis
        ///@param Orientation    Orientation of the box
        ///@param ProfileName    The 'profile' used to determine which components to hit
        ///@param bTraceComplex  True to test against complex collision, false to test against simplified collision.
        ///@param OutHits                A list of hits, sorted along the trace from start to finish. The blocking hit will be the last hit, if there was one.
        ///@return                               True if there was a blocking hit, false otherwise.
        ///</remarks>
        public static (IReadOnlyCollection<HitResult>, bool) BoxTraceMultiByProfile(UObject WorldContextObject, Vector Start, Vector End, Vector HalfSize, Rotator Orientation, Name ProfileName, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime)  => 
            KismetSystemLibrary_methods.BoxTraceMultiByProfile_method.Invoke(WorldContextObject, Start, End, HalfSize, Orientation, ProfileName, bTraceComplex, ActorsToIgnore, DrawDebugType, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);

        ///<summary>Sweeps a box along the given line and returns all hits encountered.</summary>
        ///<remarks>
        ///This only finds objects that are of a type specified by ObjectTypes.
        ///
        ///@param Start                  Start of line segment.
        ///@param End                    End of line segment.
        ///@param Orientation
        ///@param HalfSize               Radius of the sphere to sweep
        ///@param ObjectTypes    Array of Object Types to trace
        ///@param bTraceComplex  True to test against complex collision, false to test against simplified collision.
        ///@param OutHits                A list of hits, sorted along the trace from start to finish.  The blocking hit will be the last hit, if there was one.
        ///@return                               True if there was a hit, false otherwise.
        ///</remarks>
        public static (IReadOnlyCollection<HitResult>, bool) BoxTraceMultiForObjects(UObject WorldContextObject, Vector Start, Vector End, Vector HalfSize, Rotator Orientation, byte ObjectTypes /*TODO: array TArray */, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime)  => 
            KismetSystemLibrary_methods.BoxTraceMultiForObjects_method.Invoke(WorldContextObject, Start, End, HalfSize, Orientation, ObjectTypes, bTraceComplex, ActorsToIgnore, DrawDebugType, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);

        ///<summary>Sweeps a box along the given line and returns the first blocking hit encountered.</summary>
        ///<remarks>
        ///This trace finds the objects that RESPONDS to the given TraceChannel
        ///
        ///@param Start                  Start of line segment.
        ///@param End                    End of line segment.
        ///@param HalfSize           Distance from the center of box along each axis
        ///@param Orientation    Orientation of the box
        ///@param TraceChannel
        ///@param bTraceComplex  True to test against complex collision, false to test against simplified collision.
        ///@param OutHit                 Properties of the trace hit.
        ///@return                               True if there was a hit, false otherwise.
        ///</remarks>
        public static (HitResult, bool) BoxTraceSingle(UObject WorldContextObject, Vector Start, Vector End, Vector HalfSize, Rotator Orientation, byte TraceChannel, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime)  => 
            KismetSystemLibrary_methods.BoxTraceSingle_method.Invoke(WorldContextObject, Start, End, HalfSize, Orientation, TraceChannel, bTraceComplex, ActorsToIgnore, DrawDebugType, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);

        ///<summary>
        ///Sweep a box against the world and return the first blocking hit using a specific profile
        ///@
        ///</summary>
        ///<remarks>
        ///param Start                  Start of line segment.
        ///@param End                    End of line segment.
        ///@param HalfSize           Distance from the center of box along each axis
        ///@param Orientation    Orientation of the box
        ///@param ProfileName    The 'profile' used to determine which components to hit
        ///@param bTraceComplex  True to test against complex collision, false to test against simplified collision.
        ///@param OutHit                 Properties of the trace hit.
        ///@return                               True if there was a hit, false otherwise.
        ///</remarks>
        public static (HitResult, bool) BoxTraceSingleByProfile(UObject WorldContextObject, Vector Start, Vector End, Vector HalfSize, Rotator Orientation, Name ProfileName, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime)  => 
            KismetSystemLibrary_methods.BoxTraceSingleByProfile_method.Invoke(WorldContextObject, Start, End, HalfSize, Orientation, ProfileName, bTraceComplex, ActorsToIgnore, DrawDebugType, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);

        ///<summary>Sweeps a box along the given line and returns the first hit encountered.</summary>
        ///<remarks>
        ///This only finds objects that are of a type specified by ObjectTypes.
        ///
        ///@param Start                  Start of line segment.
        ///@param End                    End of line segment.
        ///@param Orientation
        ///@param HalfSize               Radius of the sphere to sweep
        ///@param ObjectTypes    Array of Object Types to trace
        ///@param bTraceComplex  True to test against complex collision, false to test against simplified collision.
        ///@param OutHit                 Properties of the trace hit.
        ///@return                               True if there was a hit, false otherwise.
        ///</remarks>
        public static (HitResult, bool) BoxTraceSingleForObjects(UObject WorldContextObject, Vector Start, Vector End, Vector HalfSize, Rotator Orientation, byte ObjectTypes /*TODO: array TArray */, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime)  => 
            KismetSystemLibrary_methods.BoxTraceSingleForObjects_method.Invoke(WorldContextObject, Start, End, HalfSize, Orientation, ObjectTypes, bTraceComplex, ActorsToIgnore, DrawDebugType, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);

        ///<summary>Gets the path string out of a Soft Class Path</summary>
        public static string BreakSoftClassPath(SoftClassPath InSoftClassPath)  => 
            KismetSystemLibrary_methods.BreakSoftClassPath_method.Invoke(InSoftClassPath);

        ///<summary>Gets the path string out of a Soft Object Path</summary>
        public static string BreakSoftObjectPath(SoftObjectPath InSoftObjectPath)  => 
            KismetSystemLibrary_methods.BreakSoftObjectPath_method.Invoke(InSoftObjectPath);

        ///<summary>Can Launch URL</summary>
        public static bool CanLaunchURL(string URL)  => 
            KismetSystemLibrary_methods.CanLaunchURL_method.Invoke(URL);

        ///<summary>Returns an array of actors that overlap the given capsule.</summary>
        ///<remarks>
        ///@param WorldContext  World context
        ///@param CapsulePos    Center of the capsule.
        ///@param Radius                Radius of capsule hemispheres and radius of center cylinder portion.
        ///@param HalfHeight    Half-height of the capsule (from center of capsule to tip of hemisphere.
        ///@param Filter                Option to restrict results to only static or only dynamic.  For efficiency.
        ///@param ClassFilter   If set, will only return results of this class or subclasses of it.
        ///@param ActorsToIgnore                Ignore these actors in the list
        ///@param OutActors             Returned array of actors. Unsorted.
        ///@return                              true if there was an overlap that passed the filters, false otherwise.
        ///</remarks>
        public static (IReadOnlyCollection<Actor>, bool) CapsuleOverlapActors(UObject WorldContextObject, Vector CapsulePos, float Radius, float HalfHeight, byte ObjectTypes /*TODO: array TArray */, SubclassOf<UObject> ActorClassFilter, byte ActorsToIgnore /*TODO: array TArray */)  => 
            KismetSystemLibrary_methods.CapsuleOverlapActors_method.Invoke(WorldContextObject, CapsulePos, Radius, HalfHeight, ObjectTypes, ActorClassFilter, ActorsToIgnore);

        ///<summary>Returns an array of components that overlap the given capsule.</summary>
        ///<remarks>
        ///@param WorldContext  World context
        ///@param CapsulePos    Center of the capsule.
        ///@param Radius                Radius of capsule hemispheres and radius of center cylinder portion.
        ///@param HalfHeight    Half-height of the capsule (from center of capsule to tip of hemisphere.
        ///@param Filter                Option to restrict results to only static or only dynamic.  For efficiency.
        ///@param ClassFilter   If set, will only return results of this class or subclasses of it.
        ///@param ActorsToIgnore                Ignore these actors in the list
        ///@param OutActors             Returned array of actors. Unsorted.
        ///@return                              true if there was an overlap that passed the filters, false otherwise.
        ///</remarks>
        public static (IReadOnlyCollection<PrimitiveComponent>, bool) CapsuleOverlapComponents(UObject WorldContextObject, Vector CapsulePos, float Radius, float HalfHeight, byte ObjectTypes /*TODO: array TArray */, SubclassOf<UObject> ComponentClassFilter, byte ActorsToIgnore /*TODO: array TArray */)  => 
            KismetSystemLibrary_methods.CapsuleOverlapComponents_method.Invoke(WorldContextObject, CapsulePos, Radius, HalfHeight, ObjectTypes, ComponentClassFilter, ActorsToIgnore);

        ///<summary>Sweeps a capsule along the given line and returns all hits encountered up to and including the first blocking hit.</summary>
        ///<remarks>
        ///This trace finds the objects that RESPOND to the given TraceChannel
        ///
        ///@param WorldContext  World context
        ///@param Start                 Start of line segment.
        ///@param End                   End of line segment.
        ///@param Radius                Radius of the capsule to sweep
        ///@param HalfHeight    Distance from center of capsule to tip of hemisphere endcap.
        ///@param TraceChannel
        ///@param bTraceComplex True to test against complex collision, false to test against simplified collision.
        ///@param OutHits               A list of hits, sorted along the trace from start to finish.  The blocking hit will be the last hit, if there was one.
        ///@return                              True if there was a blocking hit, false otherwise.
        ///</remarks>
        public static (IReadOnlyCollection<HitResult>, bool) CapsuleTraceMulti(UObject WorldContextObject, Vector Start, Vector End, float Radius, float HalfHeight, byte TraceChannel, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime)  => 
            KismetSystemLibrary_methods.CapsuleTraceMulti_method.Invoke(WorldContextObject, Start, End, Radius, HalfHeight, TraceChannel, bTraceComplex, ActorsToIgnore, DrawDebugType, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);

        ///<summary>
        ///Sweep a capsule against the world and return all initial overlaps using a specific profile, then overlapping hits and then first blocking hit
        ///Results are sorted, so a blocking hit (if found) will be the last element of the array
        ///Only the single closest blocking result will be generated, no tests will be done after that
        ///@
        ///</summary>
        ///<remarks>
        ///param WorldContext   World context
        ///@param Start                  Start of line segment.
        ///@param End                    End of line segment.
        ///@param Radius                 Radius of the capsule to sweep
        ///@param HalfHeight             Distance from center of capsule to tip of hemisphere endcap.
        ///@param ProfileName    The 'profile' used to determine which components to hit
        ///@param bTraceComplex  True to test against complex collision, false to test against simplified collision.
        ///@param OutHits                A list of hits, sorted along the trace from start to finish.  The blocking hit will be the last hit, if there was one.
        ///@return                               True if there was a blocking hit, false otherwise.
        ///</remarks>
        public static (IReadOnlyCollection<HitResult>, bool) CapsuleTraceMultiByProfile(UObject WorldContextObject, Vector Start, Vector End, float Radius, float HalfHeight, Name ProfileName, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime)  => 
            KismetSystemLibrary_methods.CapsuleTraceMultiByProfile_method.Invoke(WorldContextObject, Start, End, Radius, HalfHeight, ProfileName, bTraceComplex, ActorsToIgnore, DrawDebugType, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);

        ///<summary>Sweeps a capsule along the given line and returns all hits encountered.</summary>
        ///<remarks>
        ///This only finds objects that are of a type specified by ObjectTypes.
        ///
        ///@param WorldContext  World context
        ///@param Start                 Start of line segment.
        ///@param End                   End of line segment.
        ///@param Radius                Radius of the capsule to sweep
        ///@param HalfHeight    Distance from center of capsule to tip of hemisphere endcap.
        ///@param ObjectTypes   Array of Object Types to trace
        ///@param bTraceComplex True to test against complex collision, false to test against simplified collision.
        ///@param OutHits               A list of hits, sorted along the trace from start to finish.  The blocking hit will be the last hit, if there was one.
        ///@return                              True if there was a hit, false otherwise.
        ///</remarks>
        public static (IReadOnlyCollection<HitResult>, bool) CapsuleTraceMultiForObjects(UObject WorldContextObject, Vector Start, Vector End, float Radius, float HalfHeight, byte ObjectTypes /*TODO: array TArray */, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime)  => 
            KismetSystemLibrary_methods.CapsuleTraceMultiForObjects_method.Invoke(WorldContextObject, Start, End, Radius, HalfHeight, ObjectTypes, bTraceComplex, ActorsToIgnore, DrawDebugType, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);

        ///<summary>Sweeps a capsule along the given line and returns the first blocking hit encountered.</summary>
        ///<remarks>
        ///This trace finds the objects that RESPOND to the given TraceChannel
        ///
        ///@param WorldContext  World context
        ///@param Start                 Start of line segment.
        ///@param End                   End of line segment.
        ///@param Radius                Radius of the capsule to sweep
        ///@param HalfHeight    Distance from center of capsule to tip of hemisphere endcap.
        ///@param TraceChannel
        ///@param bTraceComplex True to test against complex collision, false to test against simplified collision.
        ///@param OutHit                Properties of the trace hit.
        ///@return                              True if there was a hit, false otherwise.
        ///</remarks>
        public static (HitResult, bool) CapsuleTraceSingle(UObject WorldContextObject, Vector Start, Vector End, float Radius, float HalfHeight, byte TraceChannel, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime)  => 
            KismetSystemLibrary_methods.CapsuleTraceSingle_method.Invoke(WorldContextObject, Start, End, Radius, HalfHeight, TraceChannel, bTraceComplex, ActorsToIgnore, DrawDebugType, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);

        ///<summary>
        ///Sweep a capsule against the world and return the first blocking hit using a specific profile
        ///@
        ///</summary>
        ///<remarks>
        ///param WorldContext   World context
        ///@param Start                  Start of line segment.
        ///@param End                    End of line segment.
        ///@param Radius                 Radius of the capsule to sweep
        ///@param HalfHeight             Distance from center of capsule to tip of hemisphere endcap.
        ///@param ProfileName    The 'profile' used to determine which components to hit
        ///@param bTraceComplex  True to test against complex collision, false to test against simplified collision.
        ///@param OutHit                 Properties of the trace hit.
        ///@return                               True if there was a hit, false otherwise.
        ///</remarks>
        public static (HitResult, bool) CapsuleTraceSingleByProfile(UObject WorldContextObject, Vector Start, Vector End, float Radius, float HalfHeight, Name ProfileName, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime)  => 
            KismetSystemLibrary_methods.CapsuleTraceSingleByProfile_method.Invoke(WorldContextObject, Start, End, Radius, HalfHeight, ProfileName, bTraceComplex, ActorsToIgnore, DrawDebugType, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);

        ///<summary>Sweeps a capsule along the given line and returns the first hit encountered.</summary>
        ///<remarks>
        ///This only finds objects that are of a type specified by ObjectTypes.
        ///
        ///@param WorldContext  World context
        ///@param Start                 Start of line segment.
        ///@param End                   End of line segment.
        ///@param Radius                Radius of the capsule to sweep
        ///@param HalfHeight    Distance from center of capsule to tip of hemisphere endcap.
        ///@param ObjectTypes   Array of Object Types to trace
        ///@param bTraceComplex True to test against complex collision, false to test against simplified collision.
        ///@param OutHit                Properties of the trace hit.
        ///@return                              True if there was a hit, false otherwise.
        ///</remarks>
        public static (HitResult, bool) CapsuleTraceSingleForObjects(UObject WorldContextObject, Vector Start, Vector End, float Radius, float HalfHeight, byte ObjectTypes /*TODO: array TArray */, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime)  => 
            KismetSystemLibrary_methods.CapsuleTraceSingleForObjects_method.Invoke(WorldContextObject, Start, End, Radius, HalfHeight, ObjectTypes, bTraceComplex, ActorsToIgnore, DrawDebugType, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);

        ///<summary>Deletes all unreferenced objects, keeping only referenced objects (this command will be queued and happen at the end of the frame)</summary>
        ///<remarks>Note: This can be a slow operation, and should only be performed where a hitch would be acceptable</remarks>
        public static void CollectGarbage()  => 
            KismetSystemLibrary_methods.CollectGarbage_method.Invoke();

        ///<summary>Returns an array of actors that overlap the given component.</summary>
        ///<remarks>
        ///@param Component                             Component to test with.
        ///@param ComponentTransform    Defines where to place the component for overlap testing.
        ///@param Filter                                Option to restrict results to only static or only dynamic.  For efficiency.
        ///@param ClassFilter                   If set, will only return results of this class or subclasses of it.
        ///@param ActorsToIgnore                Ignore these actors in the list
        ///@param OutActors                             Returned array of actors. Unsorted.
        ///@return                                              true if there was an overlap that passed the filters, false otherwise.
        ///</remarks>
        public static (IReadOnlyCollection<Actor>, bool) ComponentOverlapActors(PrimitiveComponent Component, Transform ComponentTransform, byte ObjectTypes /*TODO: array TArray */, SubclassOf<UObject> ActorClassFilter, byte ActorsToIgnore /*TODO: array TArray */)  => 
            KismetSystemLibrary_methods.ComponentOverlapActors_method.Invoke(Component, ComponentTransform, ObjectTypes, ActorClassFilter, ActorsToIgnore);

        ///<summary>Returns an array of components that overlap the given component.</summary>
        ///<remarks>
        ///@param Component                             Component to test with.
        ///@param ComponentTransform    Defines where to place the component for overlap testing.
        ///@param Filter                                Option to restrict results to only static or only dynamic.  For efficiency.
        ///@param ClassFilter                   If set, will only return results of this class or subclasses of it.
        ///@param ActorsToIgnore                Ignore these actors in the list
        ///@param OutActors                             Returned array of actors. Unsorted.
        ///@return                                              true if there was an overlap that passed the filters, false otherwise.
        ///</remarks>
        public static (IReadOnlyCollection<PrimitiveComponent>, bool) ComponentOverlapComponents(PrimitiveComponent Component, Transform ComponentTransform, byte ObjectTypes /*TODO: array TArray */, SubclassOf<UObject> ComponentClassFilter, byte ActorsToIgnore /*TODO: array TArray */)  => 
            KismetSystemLibrary_methods.ComponentOverlapComponents_method.Invoke(Component, ComponentTransform, ObjectTypes, ComponentClassFilter, ActorsToIgnore);

        ///<summary>
        ///Allows or inhibits screensaver
        ///@
        ///</summary>
        ///<remarks>param       bAllowScreenSaver               If false, don't allow screensaver if possible, otherwise allow default behavior</remarks>
        public static void ControlScreensaver(bool bAllowScreenSaver)  => 
            KismetSystemLibrary_methods.ControlScreensaver_method.Invoke(bAllowScreenSaver);

        ///<summary>Conv Class to Soft Class Reference</summary>
        public static byte /*TODO: soft class TSoftClassPtr<UObject> */ Conv_ClassToSoftClassReference(SubclassOf<UObject> Class)  => 
            KismetSystemLibrary_methods.Conv_ClassToSoftClassReference_method.Invoke(Class);

        ///<summary>Converts an interfance into an object</summary>
        public static UObject Conv_InterfaceToObject(byte Interface /*TODO: interface TScriptInterface */)  => 
            KismetSystemLibrary_methods.Conv_InterfaceToObject_method.Invoke(Interface);

        ///<summary>Conv Object to Soft Object Reference</summary>
        public static byte /*TODO: soft object TSoftObjectPtr<UObject>*/ Conv_ObjectToSoftObjectReference(UObject UObject)  => 
            KismetSystemLibrary_methods.Conv_ObjectToSoftObjectReference_method.Invoke(UObject);

        ///<summary>Converts a Primary Asset Id to a string. The other direction is not provided because it cannot be validated</summary>
        public static string Conv_PrimaryAssetIdToString(PrimaryAssetId PrimaryAssetId)  => 
            KismetSystemLibrary_methods.Conv_PrimaryAssetIdToString_method.Invoke(PrimaryAssetId);

        ///<summary>Converts a Primary Asset Type to a string. The other direction is not provided because it cannot be validated</summary>
        public static string Conv_PrimaryAssetTypeToString(PrimaryAssetType PrimaryAssetType)  => 
            KismetSystemLibrary_methods.Conv_PrimaryAssetTypeToString_method.Invoke(PrimaryAssetType);

        ///<summary>Conv Soft Class Reference to Class</summary>
        public static SubclassOf<UObject> Conv_SoftClassReferenceToClass(byte SoftClass /*TODO: soft class TSoftClassPtr<UObject>  */)  => 
            KismetSystemLibrary_methods.Conv_SoftClassReferenceToClass_method.Invoke(SoftClass);

        ///<summary>Converts a Soft Class Reference to a string. The other direction is not provided because it cannot be validated</summary>
        public static string Conv_SoftClassReferenceToString(byte SoftClassReference /*TODO: soft class TSoftClassPtr<UObject>  */)  => 
            KismetSystemLibrary_methods.Conv_SoftClassReferenceToString_method.Invoke(SoftClassReference);

        ///<summary>Conv Soft Object Reference to Object</summary>
        public static UObject Conv_SoftObjectReferenceToObject(byte SoftObject /*TODO: soft object TSoftObjectPtr<UObject> */)  => 
            KismetSystemLibrary_methods.Conv_SoftObjectReferenceToObject_method.Invoke(SoftObject);

        ///<summary>Converts a Soft Object Reference to a string. The other direction is not provided because it cannot be validated</summary>
        public static string Conv_SoftObjectReferenceToString(byte SoftObjectReference /*TODO: soft object TSoftObjectPtr<UObject> */)  => 
            KismetSystemLibrary_methods.Conv_SoftObjectReferenceToString_method.Invoke(SoftObjectReference);

        ///<summary>Mark as modified.</summary>
        public static void CreateCopyForUndoBuffer(UObject ObjectToModify)  => 
            KismetSystemLibrary_methods.CreateCopyForUndoBuffer_method.Invoke(ObjectToModify);

        ///<summary>Perform a latent action with a delay (specified in seconds).</summary>
        ///<remarks>
        ///Calling again while it is counting down will be ignored.
        ///
        ///@param WorldContext  World context.
        ///@param Duration              length of delay (in seconds).
        ///@param LatentInfo    The latent action.
        ///</remarks>
        public static void Delay(UObject WorldContextObject, float Duration, LatentActionInfo LatentInfo)  => 
            KismetSystemLibrary_methods.Delay_method.Invoke(WorldContextObject, Duration, LatentInfo);

        ///<summary>Does Implement Interface</summary>
        public static bool DoesImplementInterface(UObject TestObject, SubclassOf<Interface> Interface)  => 
            KismetSystemLibrary_methods.DoesImplementInterface_method.Invoke(TestObject, Interface);

        ///<summary>Draw directional arrow, pointing from LineStart to LineEnd.</summary>
        public static void DrawDebugArrow(UObject WorldContextObject, Vector LineStart, Vector LineEnd, float ArrowSize, LinearColor LineColor, float Duration, float Thickness)  => 
            KismetSystemLibrary_methods.DrawDebugArrow_method.Invoke(WorldContextObject, LineStart, LineEnd, ArrowSize, LineColor, Duration, Thickness);

        ///<summary>Draw a debug box</summary>
        public static void DrawDebugBox(UObject WorldContextObject, Vector Center, Vector Extent, LinearColor LineColor, Rotator Rotation, float Duration, float Thickness)  => 
            KismetSystemLibrary_methods.DrawDebugBox_method.Invoke(WorldContextObject, Center, Extent, LineColor, Rotation, Duration, Thickness);

        ///<summary>Draw a debug camera shape.</summary>
        public static void DrawDebugCamera(CameraActor CameraActor, LinearColor CameraColor, float Duration)  => 
            KismetSystemLibrary_methods.DrawDebugCamera_method.Invoke(CameraActor, CameraColor, Duration);

        ///<summary>Draw a debug capsule</summary>
        public static void DrawDebugCapsule(UObject WorldContextObject, Vector Center, float HalfHeight, float Radius, Rotator Rotation, LinearColor LineColor, float Duration, float Thickness)  => 
            KismetSystemLibrary_methods.DrawDebugCapsule_method.Invoke(WorldContextObject, Center, HalfHeight, Radius, Rotation, LineColor, Duration, Thickness);

        ///<summary>Draw a debug circle!</summary>
        public static void DrawDebugCircle(UObject WorldContextObject, Vector Center, float Radius, int NumSegments, LinearColor LineColor, float Duration, float Thickness, Vector YAxis, Vector ZAxis, bool bDrawAxis)  => 
            KismetSystemLibrary_methods.DrawDebugCircle_method.Invoke(WorldContextObject, Center, Radius, NumSegments, LineColor, Duration, Thickness, YAxis, ZAxis, bDrawAxis);

        ///<summary>Draw a debug cone</summary>
        public static void DrawDebugCone(UObject WorldContextObject, Vector Origin, Vector Direction, float Length, float AngleWidth, float AngleHeight, int NumSides, LinearColor LineColor, float Duration, float Thickness)  => 
            KismetSystemLibrary_methods.DrawDebugCone_method.Invoke(WorldContextObject, Origin, Direction, Length, AngleWidth, AngleHeight, NumSides, LineColor, Duration, Thickness);

        ///<summary>Draw a debug cone</summary>
        ///<remarks>Angles are specified in degrees</remarks>
        public static void DrawDebugConeInDegrees(UObject WorldContextObject, Vector Origin, Vector Direction, float Length, float AngleWidth, float AngleHeight, int NumSides, LinearColor LineColor, float Duration, float Thickness)  => 
            KismetSystemLibrary_methods.DrawDebugConeInDegrees_method.Invoke(WorldContextObject, Origin, Direction, Length, AngleWidth, AngleHeight, NumSides, LineColor, Duration, Thickness);

        ///<summary>Draw a debug coordinate system.</summary>
        public static void DrawDebugCoordinateSystem(UObject WorldContextObject, Vector AxisLoc, Rotator AxisRot, float Scale, float Duration, float Thickness)  => 
            KismetSystemLibrary_methods.DrawDebugCoordinateSystem_method.Invoke(WorldContextObject, AxisLoc, AxisRot, Scale, Duration, Thickness);

        ///<summary>Draw a debug cylinder</summary>
        public static void DrawDebugCylinder(UObject WorldContextObject, Vector Start, Vector End, float Radius, int Segments, LinearColor LineColor, float Duration, float Thickness)  => 
            KismetSystemLibrary_methods.DrawDebugCylinder_method.Invoke(WorldContextObject, Start, End, Radius, Segments, LineColor, Duration, Thickness);

        ///<summary>Draws a 2D Histogram of size 'DrawSize' based FDebugFloatHistory struct, using DrawLocation for the location in the world, rotation will face camera of first player.</summary>
        public static void DrawDebugFloatHistoryLocation(UObject WorldContextObject, DebugFloatHistory FloatHistory, Vector DrawLocation, Vector2D DrawSize, LinearColor DrawColor, float Duration)  => 
            KismetSystemLibrary_methods.DrawDebugFloatHistoryLocation_method.Invoke(WorldContextObject, FloatHistory, DrawLocation, DrawSize, DrawColor, Duration);

        ///<summary>Draws a 2D Histogram of size 'DrawSize' based FDebugFloatHistory struct, using DrawTransform for the position in the world.</summary>
        public static void DrawDebugFloatHistoryTransform(UObject WorldContextObject, DebugFloatHistory FloatHistory, Transform DrawTransform, Vector2D DrawSize, LinearColor DrawColor, float Duration)  => 
            KismetSystemLibrary_methods.DrawDebugFloatHistoryTransform_method.Invoke(WorldContextObject, FloatHistory, DrawTransform, DrawSize, DrawColor, Duration);

        ///<summary>Draws a debug frustum.</summary>
        public static void DrawDebugFrustum(UObject WorldContextObject, Transform FrustumTransform, LinearColor FrustumColor, float Duration, float Thickness)  => 
            KismetSystemLibrary_methods.DrawDebugFrustum_method.Invoke(WorldContextObject, FrustumTransform, FrustumColor, Duration, Thickness);

        ///<summary>Draw a debug line</summary>
        public static void DrawDebugLine(UObject WorldContextObject, Vector LineStart, Vector LineEnd, LinearColor LineColor, float Duration, float Thickness)  => 
            KismetSystemLibrary_methods.DrawDebugLine_method.Invoke(WorldContextObject, LineStart, LineEnd, LineColor, Duration, Thickness);

        ///<summary>Draws a debug plane.</summary>
        public static void DrawDebugPlane(UObject WorldContextObject, Plane PlaneCoordinates, Vector Location, float Size, LinearColor PlaneColor, float Duration)  => 
            KismetSystemLibrary_methods.DrawDebugPlane_method.Invoke(WorldContextObject, PlaneCoordinates, Location, Size, PlaneColor, Duration);

        ///<summary>Draw a debug point</summary>
        public static void DrawDebugPoint(UObject WorldContextObject, Vector Position, float Size, LinearColor PointColor, float Duration)  => 
            KismetSystemLibrary_methods.DrawDebugPoint_method.Invoke(WorldContextObject, Position, Size, PointColor, Duration);

        ///<summary>Draw a debug sphere</summary>
        public static void DrawDebugSphere(UObject WorldContextObject, Vector Center, float Radius, int Segments, LinearColor LineColor, float Duration, float Thickness)  => 
            KismetSystemLibrary_methods.DrawDebugSphere_method.Invoke(WorldContextObject, Center, Radius, Segments, LineColor, Duration, Thickness);

        ///<summary>Draw a debug string at a 3d world location.</summary>
        public static void DrawDebugString(UObject WorldContextObject, Vector TextLocation, string Text, Actor TestBaseActor, LinearColor TextColor, float Duration)  => 
            KismetSystemLibrary_methods.DrawDebugString_method.Invoke(WorldContextObject, TextLocation, Text, TestBaseActor, TextColor, Duration);

        ///<summary>Returns true if the values are equal (A == B)</summary>
        public static bool EqualEqual_PrimaryAssetId(PrimaryAssetId A, PrimaryAssetId B)  => 
            KismetSystemLibrary_methods.EqualEqual_PrimaryAssetId_method.Invoke(A, B);

        ///<summary>Returns true if the values are equal (A == B)</summary>
        public static bool EqualEqual_PrimaryAssetType(PrimaryAssetType A, PrimaryAssetType B)  => 
            KismetSystemLibrary_methods.EqualEqual_PrimaryAssetType_method.Invoke(A, B);

        ///<summary>Returns true if the values are equal (A == B)</summary>
        public static bool EqualEqual_SoftClassReference(byte A /*TODO: soft class TSoftClassPtr<UObject>  */, byte B /*TODO: soft class TSoftClassPtr<UObject>  */)  => 
            KismetSystemLibrary_methods.EqualEqual_SoftClassReference_method.Invoke(A, B);

        ///<summary>Returns true if the values are equal (A == B)</summary>
        public static bool EqualEqual_SoftObjectReference(byte A /*TODO: soft object TSoftObjectPtr<UObject> */, byte B /*TODO: soft object TSoftObjectPtr<UObject> */)  => 
            KismetSystemLibrary_methods.EqualEqual_SoftObjectReference_method.Invoke(A, B);

        ///<summary>
        ///Executes a console command, optionally on a specific controller
        ///@
        ///</summary>
        ///<remarks>
        ///param       Command                 Command to send to the console
        ///@param       SpecificPlayer  If specified, the console command will be routed through the specified player
        ///</remarks>
        public static void ExecuteConsoleCommand(UObject WorldContextObject, string Command, PlayerController SpecificPlayer)  => 
            KismetSystemLibrary_methods.ExecuteConsoleCommand_method.Invoke(WorldContextObject, Command, SpecificPlayer);

        ///<summary>Removes all debug strings.</summary>
        ///<remarks>
        ///@param WorldContext  World context
        ///</remarks>
        public static void FlushDebugStrings(UObject WorldContextObject)  => 
            KismetSystemLibrary_methods.FlushDebugStrings_method.Invoke(WorldContextObject);

        ///<summary>Flush all persistent debug lines and shapes.</summary>
        ///<remarks>
        ///@param WorldContext  World context
        ///</remarks>
        public static void FlushPersistentDebugLines(UObject WorldContextObject)  => 
            KismetSystemLibrary_methods.FlushPersistentDebugLines_method.Invoke(WorldContextObject);

        ///<summary>Forces closed any displayed ad.</summary>
        ///<remarks>
        ///Can lead to loss of revenue
        ///(iOS and Android only)
        ///</remarks>
        public static void ForceCloseAdBanner()  => 
            KismetSystemLibrary_methods.ForceCloseAdBanner_method.Invoke();

        ///<summary>Get Actor Bounds</summary>
        public static (Vector, Vector) GetActorBounds(Actor Actor)  => 
            KismetSystemLibrary_methods.GetActorBounds_method.Invoke(Actor);

        ///<summary>Returns an array of unique actors represented by the given list of components.</summary>
        ///<remarks>
        ///@param ComponentList         List of components.
        ///@param ClassFilter           If set, will only return results of this class or subclasses of it.
        ///@param OutActorList          Start of line segment.
        ///</remarks>
        public static IReadOnlyCollection<Actor> GetActorListFromComponentList(byte ComponentList /*TODO: array TArray */, SubclassOf<UObject> ActorClassFilter)  => 
            KismetSystemLibrary_methods.GetActorListFromComponentList_method.Invoke(ComponentList, ActorClassFilter);

        ///<summary>Retrieves the total number of Ad IDs that can be selected between</summary>
        public static int GetAdIDCount()  => 
            KismetSystemLibrary_methods.GetAdIDCount_method.Invoke();

        ///<summary>Returns the display name of a class</summary>
        public static string GetClassDisplayName(SubclassOf<UObject> Class)  => 
            KismetSystemLibrary_methods.GetClassDisplayName_method.Invoke(Class);

        ///<summary>Returns the Blueprint Class associated with a Primary Asset Id, this will only return a valid object if it is in memory, it will not load it</summary>
        public static SubclassOf<UObject> GetClassFromPrimaryAssetId(PrimaryAssetId PrimaryAssetId)  => 
            KismetSystemLibrary_methods.GetClassFromPrimaryAssetId_method.Invoke(PrimaryAssetId);

        ///<summary>Returns the command line that the process was launched with.</summary>
        public static string GetCommandLine()  => 
            KismetSystemLibrary_methods.GetCommandLine_method.Invoke();

        ///<summary>Get bounds</summary>
        public static (Vector, Vector, float) GetComponentBounds(SceneComponent Component)  => 
            KismetSystemLibrary_methods.GetComponentBounds_method.Invoke(Component);

        ///<summary>Attempts to retrieve the value of the specified float console variable, if it exists.</summary>
        ///<remarks>
        ///@param       VariableName    Name of the console variable to find.
        ///@return      The value if found, 0 otherwise.
        ///</remarks>
        public static float GetConsoleVariableFloatValue(UObject WorldContextObject, string VariableName)  => 
            KismetSystemLibrary_methods.GetConsoleVariableFloatValue_method.Invoke(WorldContextObject, VariableName);

        ///<summary>Attempts to retrieve the value of the specified integer console variable, if it exists.</summary>
        ///<remarks>
        ///@param       VariableName    Name of the console variable to find.
        ///@return      The value if found, 0 otherwise.
        ///</remarks>
        public static int GetConsoleVariableIntValue(UObject WorldContextObject, string VariableName)  => 
            KismetSystemLibrary_methods.GetConsoleVariableIntValue_method.Invoke(WorldContextObject, VariableName);

        ///<summary>Gets the list of windowed resolutions which are convenient for the current primary display size.</summary>
        ///<remarks>
        ///@return true if successfully queried the device for available resolutions.
        ///</remarks>
        public static (IReadOnlyCollection<IntPoint>, bool) GetConvenientWindowedResolutions()  => 
            KismetSystemLibrary_methods.GetConvenientWindowedResolutions_method.Invoke();

        ///<summary>Returns the list of loaded bundles for a given Primary Asset.</summary>
        ///<remarks>
        ///This will return false if the asset is not loaded at all.
        ///If ForceCurrentState is true it will return the current state even if a load is in process
        ///</remarks>
        public static (IReadOnlyCollection<Name>, bool) GetCurrentBundleState(PrimaryAssetId PrimaryAssetId, bool bForceCurrentState)  => 
            KismetSystemLibrary_methods.GetCurrentBundleState_method.Invoke(PrimaryAssetId, bForceCurrentState);

        ///<summary>
        ///Get the default language (for localization) used by this platform
        ///@
        ///</summary>
        ///<remarks>
        ///note This is typically the same as GetDefaultLocale unless the platform distinguishes between the two
        ///@note This should be returned in IETF language tag form:
        /// - A two-letter ISO 639-1 language code (eg, "zh")
        /// - An optional four-letter ISO 15924 script code (eg, "Hans")
        /// - An optional two-letter ISO 3166-1 country code (eg, "CN")
        ///@return The language as an IETF language tag (eg, "zh-Hans-CN")
        ///</remarks>
        public static string GetDefaultLanguage()  => 
            KismetSystemLibrary_methods.GetDefaultLanguage_method.Invoke();

        ///<summary>
        ///Get the default locale (for internationalization) used by this platform
        ///@
        ///</summary>
        ///<remarks>
        ///note This should be returned in IETF language tag form:
        /// - A two-letter ISO 639-1 language code (eg, "zh")
        /// - An optional four-letter ISO 15924 script code (eg, "Hans")
        /// - An optional two-letter ISO 3166-1 country code (eg, "CN")
        ///@return The locale as an IETF language tag (eg, "zh-Hans-CN")
        ///</remarks>
        public static string GetDefaultLocale()  => 
            KismetSystemLibrary_methods.GetDefaultLocale_method.Invoke();

        ///<summary>Returns the platform specific unique device id</summary>
        public static string GetDeviceId()  => 
            KismetSystemLibrary_methods.GetDeviceId_method.Invoke();

        ///<summary>Returns the display name (or actor label), for displaying as a debugging aid.</summary>
        ///<remarks>
        ///Note: In editor builds, this is the actor label.  In non-editor builds, this is the actual object name.  This function should not be used to uniquely identify actors!
        ///It is not localized and should not be used for display to an end user of a game.
        ///</remarks>
        public static string GetDisplayName(UObject UObject)  => 
            KismetSystemLibrary_methods.GetDisplayName_method.Invoke(UObject);

        ///<summary>Engine build number, for displaying to end users.</summary>
        public static string GetEngineVersion()  => 
            KismetSystemLibrary_methods.GetEngineVersion_method.Invoke();

        ///<summary>
        ///Retrieves the game's platform-specific bundle identifier or package name of the game
        ///@
        ///</summary>
        ///<remarks>return The game's bundle identifier or package name.</remarks>
        public static string GetGameBundleId()  => 
            KismetSystemLibrary_methods.GetGameBundleId_method.Invoke();

        ///<summary>Get the name of the current game</summary>
        public static string GetGameName()  => 
            KismetSystemLibrary_methods.GetGameName_method.Invoke();

        ///<summary>Get the current game time, in seconds.</summary>
        ///<remarks>
        ///This stops when the game is paused and is affected by slomo.
        ///
        ///@param WorldContextObject    World context
        ///</remarks>
        public static float GetGameTimeInSeconds(UObject WorldContextObject)  => 
            KismetSystemLibrary_methods.GetGameTimeInSeconds_method.Invoke(WorldContextObject);

        ///<summary>
        ///Returns the currency code associated with the device's locale
        ///@
        ///</summary>
        ///<remarks>return the currency code associated with the device's locale</remarks>
        public static string GetLocalCurrencyCode()  => 
            KismetSystemLibrary_methods.GetLocalCurrencyCode_method.Invoke();

        ///<summary>
        ///Returns the currency symbol associated with the device's locale
        ///@
        ///</summary>
        ///<remarks>return the currency symbol associated with the device's locale</remarks>
        public static string GetLocalCurrencySymbol()  => 
            KismetSystemLibrary_methods.GetLocalCurrencySymbol_method.Invoke();

        ///<summary>
        ///Gets the smallest Y resolution we want to support in the 3D view, clamped within reasons
        ///@
        ///</summary>
        ///<remarks>return value in pixels</remarks>
        public static int GetMinYResolutionFor3DView()  => 
            KismetSystemLibrary_methods.GetMinYResolutionFor3DView_method.Invoke();

        ///<summary>
        ///Gets the smallest Y resolution we want to support in the UI, clamped within reasons
        ///@
        ///</summary>
        ///<remarks>return value in pixels</remarks>
        public static int GetMinYResolutionForUI()  => 
            KismetSystemLibrary_methods.GetMinYResolutionForUI_method.Invoke();

        ///<summary>Returns the Object associated with a Primary Asset Id, this will only return a valid object if it is in memory, it will not load it</summary>
        public static UObject GetObjectFromPrimaryAssetId(PrimaryAssetId PrimaryAssetId)  => 
            KismetSystemLibrary_methods.GetObjectFromPrimaryAssetId_method.Invoke(PrimaryAssetId);

        ///<summary>Returns the actual object name.</summary>
        public static string GetObjectName(UObject UObject)  => 
            KismetSystemLibrary_methods.GetObjectName_method.Invoke(UObject);

        ///<summary>Returns the full path to the specified object.</summary>
        public static string GetPathName(UObject UObject)  => 
            KismetSystemLibrary_methods.GetPathName_method.Invoke(UObject);

        ///<summary>Get the current user name from the OS</summary>
        public static string GetPlatformUserName()  => 
            KismetSystemLibrary_methods.GetPlatformUserName_method.Invoke();

        ///<summary>
        ///Returns an array of the user's preferred languages in order of preference
        ///@
        ///</summary>
        ///<remarks>return An array of language IDs ordered from most preferred to least</remarks>
        public static IReadOnlyCollection<string> GetPreferredLanguages()  => 
            KismetSystemLibrary_methods.GetPreferredLanguages_method.Invoke();

        ///<summary>Returns the Primary Asset Id for a Class, this can return an invalid one if not registered</summary>
        public static PrimaryAssetId GetPrimaryAssetIdFromClass(SubclassOf<UObject> Class)  => 
            KismetSystemLibrary_methods.GetPrimaryAssetIdFromClass_method.Invoke(Class);

        ///<summary>Returns the Primary Asset Id for an Object, this can return an invalid one if not registered</summary>
        public static PrimaryAssetId GetPrimaryAssetIdFromObject(UObject UObject)  => 
            KismetSystemLibrary_methods.GetPrimaryAssetIdFromObject_method.Invoke(UObject);

        ///<summary>Returns the Primary Asset Id for a Soft Class Reference, this can return an invalid one if not registered</summary>
        public static PrimaryAssetId GetPrimaryAssetIdFromSoftClassReference(byte SoftClassReference /*TODO: soft class TSoftClassPtr<UObject>  */)  => 
            KismetSystemLibrary_methods.GetPrimaryAssetIdFromSoftClassReference_method.Invoke(SoftClassReference);

        ///<summary>Returns the Primary Asset Id for a Soft Object Reference, this can return an invalid one if not registered</summary>
        public static PrimaryAssetId GetPrimaryAssetIdFromSoftObjectReference(byte SoftObjectReference /*TODO: soft object TSoftObjectPtr<UObject> */)  => 
            KismetSystemLibrary_methods.GetPrimaryAssetIdFromSoftObjectReference_method.Invoke(SoftObjectReference);

        ///<summary>Returns list of PrimaryAssetIds for a PrimaryAssetType</summary>
        public static IReadOnlyCollection<PrimaryAssetId> GetPrimaryAssetIdList(PrimaryAssetType PrimaryAssetType)  => 
            KismetSystemLibrary_methods.GetPrimaryAssetIdList_method.Invoke(PrimaryAssetType);

        ///<summary>Returns the list of assets that are in a given bundle state.</summary>
        ///<remarks>
        ///Required Bundles must be specified
        ///If ExcludedBundles is not empty, it will not return any assets in those bundle states
        ///If ValidTypes is not empty, it will only return assets of those types
        ///If ForceCurrentState is true it will use the current state even if a load is in process
        ///</remarks>
        public static IReadOnlyCollection<PrimaryAssetId> GetPrimaryAssetsWithBundleState(byte RequiredBundles /*TODO: array TArray */, byte ExcludedBundles /*TODO: array TArray */, byte ValidTypes /*TODO: array TArray */, bool bForceCurrentState)  => 
            KismetSystemLibrary_methods.GetPrimaryAssetsWithBundleState_method.Invoke(RequiredBundles, ExcludedBundles, ValidTypes, bForceCurrentState);

        ///<summary>Get the content directory of the current project</summary>
        public static string GetProjectContentDirectory()  => 
            KismetSystemLibrary_methods.GetProjectContentDirectory_method.Invoke();

        ///<summary>Get the directory of the current project</summary>
        public static string GetProjectDirectory()  => 
            KismetSystemLibrary_methods.GetProjectDirectory_method.Invoke();

        ///<summary>Get the saved directory of the current project</summary>
        public static string GetProjectSavedDirectory()  => 
            KismetSystemLibrary_methods.GetProjectSavedDirectory_method.Invoke();

        ///<summary>Get the clamped state of r.</summary>
        ///<remarks>
        ///DetailMode, see console variable help (allows for scalability, cannot be used in construction scripts)
        ///0: low, show only object with DetailMode low or higher
        ///1: medium, show all object with DetailMode medium or higher
        ///2: high, show all objects
        ///</remarks>
        public static int GetRenderingDetailMode()  => 
            KismetSystemLibrary_methods.GetRenderingDetailMode_method.Invoke();

        ///<summary>Get the clamped state of r.</summary>
        ///<remarks>
        ///MaterialQualityLevel, see console variable help (allows for scalability, cannot be used in construction scripts)
        ///0: low
        ///1: high
        ///2: medium
        ///</remarks>
        public static int GetRenderingMaterialQualityLevel()  => 
            KismetSystemLibrary_methods.GetRenderingMaterialQualityLevel_method.Invoke();

        ///<summary>Returns the Blueprint Class Id associated with a Primary Asset Id, this works even if the asset is not loaded</summary>
        public static byte /*TODO: soft class TSoftClassPtr<UObject> */ GetSoftClassReferenceFromPrimaryAssetId(PrimaryAssetId PrimaryAssetId)  => 
            KismetSystemLibrary_methods.GetSoftClassReferenceFromPrimaryAssetId_method.Invoke(PrimaryAssetId);

        ///<summary>Returns the Object Id associated with a Primary Asset Id, this works even if the asset is not loaded</summary>
        public static byte /*TODO: soft object TSoftObjectPtr<UObject>*/ GetSoftObjectReferenceFromPrimaryAssetId(PrimaryAssetId PrimaryAssetId)  => 
            KismetSystemLibrary_methods.GetSoftObjectReferenceFromPrimaryAssetId_method.Invoke(PrimaryAssetId);

        ///<summary>Gets the list of support fullscreen resolutions.</summary>
        ///<remarks>
        ///@return true if successfully queried the device for available resolutions.
        ///</remarks>
        public static (IReadOnlyCollection<IntPoint>, bool) GetSupportedFullscreenResolutions()  => 
            KismetSystemLibrary_methods.GetSupportedFullscreenResolutions_method.Invoke();

        ///<summary>Returns the platform specific unique device id</summary>
        public static string GetUniqueDeviceId()  => 
            KismetSystemLibrary_methods.GetUniqueDeviceId_method.Invoke();

        ///<summary>Returns true if system default handling of volume up and volume down buttons enabled (Android only)</summary>
        public static bool GetVolumeButtonsHandledBySystem()  => 
            KismetSystemLibrary_methods.GetVolumeButtonsHandledBySystem_method.Invoke();

        ///<summary>Hides the ad banner (iAd on iOS, or AdMob on Android).</summary>
        ///<remarks>
        ///Will force close the ad if it's open
        ///(iOS and Android only)
        ///</remarks>
        public static void HideAdBanner()  => 
            KismetSystemLibrary_methods.HideAdBanner_method.Invoke();

        ///<summary>Returns true if controller id assigned to a gamepad (Android only)</summary>
        public static bool IsControllerAssignedToGamepad(int ControllerId)  => 
            KismetSystemLibrary_methods.IsControllerAssignedToGamepad_method.Invoke(ControllerId);

        ///<summary>Returns whether this is running on a dedicated server</summary>
        public static bool IsDedicatedServer(UObject WorldContextObject)  => 
            KismetSystemLibrary_methods.IsDedicatedServer_method.Invoke(WorldContextObject);

        ///<summary>Returns true if the requested interstitial ad is loaded and ready</summary>
        ///<remarks>(Android only)</remarks>
        public static bool IsInterstitialAdAvailable()  => 
            KismetSystemLibrary_methods.IsInterstitialAdAvailable_method.Invoke();

        ///<summary>Returns true if the requested interstitial ad has been successfully requested (false if load request fails)</summary>
        ///<remarks>(Android only)</remarks>
        public static bool IsInterstitialAdRequested()  => 
            KismetSystemLibrary_methods.IsInterstitialAdRequested_method.Invoke();

        ///<summary>Returns whether the player is logged in to the currently active online subsystem.</summary>
        ///<remarks>
        ///@param Player Specific player's login status to get. May not be supported on all platforms. If null, defaults to the player with ControllerId 0.
        ///</remarks>
        public static bool IsLoggedIn(PlayerController SpecificPlayer)  => 
            KismetSystemLibrary_methods.IsLoggedIn_method.Invoke(SpecificPlayer);

        ///<summary>Returns whether this is a build that is packaged for distribution</summary>
        public static bool IsPackagedForDistribution()  => 
            KismetSystemLibrary_methods.IsPackagedForDistribution_method.Invoke();

        ///<summary>Returns whether the world this object is in is the host or not</summary>
        public static bool IsServer(UObject WorldContextObject)  => 
            KismetSystemLibrary_methods.IsServer_method.Invoke(WorldContextObject);

        ///<summary>Returns whether this game instance is stand alone (no networking).</summary>
        public static bool IsStandalone(UObject WorldContextObject)  => 
            KismetSystemLibrary_methods.IsStandalone_method.Invoke(WorldContextObject);

        ///<summary>Return true if the object is usable : non-null and not pending kill</summary>
        public static bool IsValid(UObject UObject)  => 
            KismetSystemLibrary_methods.IsValid_method.Invoke(UObject);

        ///<summary>Return true if the class is usable : non-null and not pending kill</summary>
        public static bool IsValidClass(SubclassOf<UObject> Class)  => 
            KismetSystemLibrary_methods.IsValidClass_method.Invoke(Class);

        ///<summary>Returns true if the Primary Asset Id is valid</summary>
        public static bool IsValidPrimaryAssetId(PrimaryAssetId PrimaryAssetId)  => 
            KismetSystemLibrary_methods.IsValidPrimaryAssetId_method.Invoke(PrimaryAssetId);

        ///<summary>Returns list of Primary Asset Ids for a PrimaryAssetType</summary>
        public static bool IsValidPrimaryAssetType(PrimaryAssetType PrimaryAssetType)  => 
            KismetSystemLibrary_methods.IsValidPrimaryAssetType_method.Invoke(PrimaryAssetType);

        ///<summary>Returns true if the Soft Class Reference is not null</summary>
        public static bool IsValidSoftClassReference(byte SoftClassReference /*TODO: soft class TSoftClassPtr<UObject>  */)  => 
            KismetSystemLibrary_methods.IsValidSoftClassReference_method.Invoke(SoftClassReference);

        ///<summary>Returns true if the Soft Object Reference is not null</summary>
        public static bool IsValidSoftObjectReference(byte SoftObjectReference /*TODO: soft object TSoftObjectPtr<UObject> */)  => 
            KismetSystemLibrary_methods.IsValidSoftObjectReference_method.Invoke(SoftObjectReference);

        ///<summary>Clears a set timer.</summary>
        ///<remarks>
        ///@param Handle                The handle of the timer to clear.
        ///</remarks>
        public static void K2_ClearAndInvalidateTimerHandle(UObject WorldContextObject, TimerHandle Handle)  => 
            KismetSystemLibrary_methods.K2_ClearAndInvalidateTimerHandle_method.Invoke(WorldContextObject, Handle);

        ///<summary>Clears a set timer.</summary>
        ///<remarks>
        ///@param Object                Object that implements the delegate function. Defaults to self (this blueprint)
        ///@param FunctionName  Delegate function name. Can be a K2 function or a Custom Event.
        ///</remarks>
        public static void K2_ClearTimer(UObject UObject, string FunctionName)  => 
            KismetSystemLibrary_methods.K2_ClearTimer_method.Invoke(UObject, FunctionName);

        ///<summary>Clears a set timer.</summary>
        ///<remarks>
        ///@param Event  Can be a K2 function or a Custom Event.
        ///</remarks>
        public static void K2_ClearTimerDelegate(byte Delegate /*TODO: delegate FTimerDynamicDelegate */)  => 
            KismetSystemLibrary_methods.K2_ClearTimerDelegate_method.Invoke(Delegate);

        ///<summary>Clears a set timer.</summary>
        ///<remarks>
        ///@param Handle                The handle of the timer to clear.
        ///</remarks>
        public static void K2_ClearTimerHandle(UObject WorldContextObject, TimerHandle Handle)  => 
            KismetSystemLibrary_methods.K2_ClearTimerHandle_method.Invoke(WorldContextObject, Handle);

        ///<summary>Returns elapsed time for the given delegate (time since current countdown iteration began).</summary>
        ///<remarks>
        ///@param Object                Object that implements the delegate function. Defaults to self (this blueprint)
        ///@param FunctionName  Delegate function name. Can be a K2 function or a Custom Event.
        ///@return                              How long has elapsed since the current iteration of the timer began.
        ///</remarks>
        public static float K2_GetTimerElapsedTime(UObject UObject, string FunctionName)  => 
            KismetSystemLibrary_methods.K2_GetTimerElapsedTime_method.Invoke(UObject, FunctionName);

        ///<summary>Returns elapsed time for the given delegate (time since current countdown iteration began).</summary>
        ///<remarks>
        ///@param Event  Can be a K2 function or a Custom Event.
        ///@return                              How long has elapsed since the current iteration of the timer began.
        ///</remarks>
        public static float K2_GetTimerElapsedTimeDelegate(byte Delegate /*TODO: delegate FTimerDynamicDelegate */)  => 
            KismetSystemLibrary_methods.K2_GetTimerElapsedTimeDelegate_method.Invoke(Delegate);

        ///<summary>Returns elapsed time for the given handle (time since current countdown iteration began).</summary>
        ///<remarks>
        ///@param Handle                The handle of the timer to get the elapsed time of.
        ///@return                              How long has elapsed since the current iteration of the timer began.
        ///</remarks>
        public static float K2_GetTimerElapsedTimeHandle(UObject WorldContextObject, TimerHandle Handle)  => 
            KismetSystemLibrary_methods.K2_GetTimerElapsedTimeHandle_method.Invoke(WorldContextObject, Handle);

        ///<summary>Returns time until the timer will next execute its delegate.</summary>
        ///<remarks>
        ///@param Object                Object that implements the delegate function. Defaults to self (this blueprint)
        ///@param FunctionName  Delegate function name. Can be a K2 function or a Custom Event.
        ///@return                              How long is remaining in the current iteration of the timer.
        ///</remarks>
        public static float K2_GetTimerRemainingTime(UObject UObject, string FunctionName)  => 
            KismetSystemLibrary_methods.K2_GetTimerRemainingTime_method.Invoke(UObject, FunctionName);

        ///<summary>Returns time until the timer will next execute its delegate.</summary>
        ///<remarks>
        ///@param Event  Can be a K2 function or a Custom Event.
        ///@return                              How long is remaining in the current iteration of the timer.
        ///</remarks>
        public static float K2_GetTimerRemainingTimeDelegate(byte Delegate /*TODO: delegate FTimerDynamicDelegate */)  => 
            KismetSystemLibrary_methods.K2_GetTimerRemainingTimeDelegate_method.Invoke(Delegate);

        ///<summary>Returns time until the timer will next execute its handle.</summary>
        ///<remarks>
        ///@param Handle                The handle of the timer to time remaining of.
        ///@return                              How long is remaining in the current iteration of the timer.
        ///</remarks>
        public static float K2_GetTimerRemainingTimeHandle(UObject WorldContextObject, TimerHandle Handle)  => 
            KismetSystemLibrary_methods.K2_GetTimerRemainingTimeHandle_method.Invoke(WorldContextObject, Handle);

        ///<summary>Invalidate the supplied TimerHandle and return it.</summary>
        ///<remarks>
        ///@param Handle                The handle of the timer to invalidate.
        ///@return                              Return the invalidated timer handle for convenience.
        ///</remarks>
        public static TimerHandle K2_InvalidateTimerHandle(TimerHandle Handle)  => 
            KismetSystemLibrary_methods.K2_InvalidateTimerHandle_method.Invoke(Handle);

        ///<summary>Returns true if a timer exists and is active for the given delegate, false otherwise.</summary>
        ///<remarks>
        ///@param Object                Object that implements the delegate function. Defaults to self (this blueprint)
        ///@param FunctionName  Delegate function name. Can be a K2 function or a Custom Event.
        ///@return                              True if the timer exists and is active.
        ///</remarks>
        public static bool K2_IsTimerActive(UObject UObject, string FunctionName)  => 
            KismetSystemLibrary_methods.K2_IsTimerActive_method.Invoke(UObject, FunctionName);

        ///<summary>Returns true if a timer exists and is active for the given delegate, false otherwise.</summary>
        ///<remarks>
        ///@param Event  Can be a K2 function or a Custom Event.
        ///@return                              True if the timer exists and is active.
        ///</remarks>
        public static bool K2_IsTimerActiveDelegate(byte Delegate /*TODO: delegate FTimerDynamicDelegate */)  => 
            KismetSystemLibrary_methods.K2_IsTimerActiveDelegate_method.Invoke(Delegate);

        ///<summary>Returns true if a timer exists and is active for the given handle, false otherwise.</summary>
        ///<remarks>
        ///@param Handle                The handle of the timer to check whether it is active.
        ///@return                              True if the timer exists and is active.
        ///</remarks>
        public static bool K2_IsTimerActiveHandle(UObject WorldContextObject, TimerHandle Handle)  => 
            KismetSystemLibrary_methods.K2_IsTimerActiveHandle_method.Invoke(WorldContextObject, Handle);

        ///<summary>Returns true if a timer exists and is paused for the given delegate, false otherwise.</summary>
        ///<remarks>
        ///@param Object         Object that implements the delegate function. Defaults to self (this blueprint)
        ///@param FunctionName   Delegate function name. Can be a K2 function or a Custom Event.
        ///@return                               True if the timer exists and is paused.
        ///</remarks>
        public static bool K2_IsTimerPaused(UObject UObject, string FunctionName)  => 
            KismetSystemLibrary_methods.K2_IsTimerPaused_method.Invoke(UObject, FunctionName);

        ///<summary>Returns true if a timer exists and is paused for the given delegate, false otherwise.</summary>
        ///<remarks>
        ///@param Event  Can be a K2 function or a Custom Event.
        ///@return                              True if the timer exists and is paused.
        ///</remarks>
        public static bool K2_IsTimerPausedDelegate(byte Delegate /*TODO: delegate FTimerDynamicDelegate */)  => 
            KismetSystemLibrary_methods.K2_IsTimerPausedDelegate_method.Invoke(Delegate);

        ///<summary>Returns true if a timer exists and is paused for the given handle, false otherwise.</summary>
        ///<remarks>
        ///@param Handle                The handle of the timer to check whether it is paused.
        ///@return                              True if the timer exists and is paused.
        ///</remarks>
        public static bool K2_IsTimerPausedHandle(UObject WorldContextObject, TimerHandle Handle)  => 
            KismetSystemLibrary_methods.K2_IsTimerPausedHandle_method.Invoke(WorldContextObject, Handle);

        ///<summary>Returns whether the timer handle is valid.</summary>
        ///<remarks>
        ///This does not indicate that there is an active timer that this handle references, but rather that it once referenced a valid timer.
        ///@param Handle                The handle of the timer to check validity of.
        ///@return                              Whether the timer handle is valid.
        ///</remarks>
        public static bool K2_IsValidTimerHandle(TimerHandle Handle)  => 
            KismetSystemLibrary_methods.K2_IsValidTimerHandle_method.Invoke(Handle);

        ///<summary>Pauses a set timer at its current elapsed time.</summary>
        ///<remarks>
        ///@param Object                Object that implements the delegate function. Defaults to self (this blueprint)
        ///@param FunctionName  Delegate function name. Can be a K2 function or a Custom Event.
        ///</remarks>
        public static void K2_PauseTimer(UObject UObject, string FunctionName)  => 
            KismetSystemLibrary_methods.K2_PauseTimer_method.Invoke(UObject, FunctionName);

        ///<summary>Pauses a set timer at its current elapsed time.</summary>
        ///<remarks>
        ///@param Event  Can be a K2 function or a Custom Event.
        ///</remarks>
        public static void K2_PauseTimerDelegate(byte Delegate /*TODO: delegate FTimerDynamicDelegate */)  => 
            KismetSystemLibrary_methods.K2_PauseTimerDelegate_method.Invoke(Delegate);

        ///<summary>Pauses a set timer at its current elapsed time.</summary>
        ///<remarks>
        ///@param Handle                The handle of the timer to pause.
        ///</remarks>
        public static void K2_PauseTimerHandle(UObject WorldContextObject, TimerHandle Handle)  => 
            KismetSystemLibrary_methods.K2_PauseTimerHandle_method.Invoke(WorldContextObject, Handle);

        ///<summary>Set a timer to execute delegate.</summary>
        ///<remarks>
        ///Setting an existing timer will reset that timer with updated parameters.
        ///@param Object                Object that implements the delegate function. Defaults to self (this blueprint)
        ///@param FunctionName  Delegate function name. Can be a K2 function or a Custom Event.
        ///@param Time                  How long to wait before executing the delegate, in seconds. Setting a timer to <= 0 seconds will clear it if it is set.
        ///@param bLooping              true to keep executing the delegate every Time seconds, false to execute delegate only once.
        ///@return                              The timer handle to pass to other timer functions to manipulate this timer.
        ///</remarks>
        public static TimerHandle K2_SetTimer(UObject UObject, string FunctionName, float Time, bool bLooping)  => 
            KismetSystemLibrary_methods.K2_SetTimer_method.Invoke(UObject, FunctionName, Time, bLooping);

        ///<summary>Set a timer to execute delegate.</summary>
        ///<remarks>
        ///Setting an existing timer will reset that timer with updated parameters.
        ///@param Event                 Event. Can be a K2 function or a Custom Event.
        ///@param Time                  How long to wait before executing the delegate, in seconds. Setting a timer to <= 0 seconds will clear it if it is set.
        ///@param bLooping              True to keep executing the delegate every Time seconds, false to execute delegate only once.
        ///@return                              The timer handle to pass to other timer functions to manipulate this timer.
        ///</remarks>
        public static TimerHandle K2_SetTimerDelegate(byte Delegate /*TODO: delegate FTimerDynamicDelegate */, float Time, bool bLooping)  => 
            KismetSystemLibrary_methods.K2_SetTimerDelegate_method.Invoke(Delegate, Time, bLooping);

        ///<summary>Returns true is a timer for the given delegate exists, false otherwise.</summary>
        ///<remarks>
        ///@param Object         Object that implements the delegate function. Defaults to self (this blueprint)
        ///@param FunctionName   Delegate function name. Can be a K2 function or a Custom Event.
        ///@return                               True if the timer exists.
        ///</remarks>
        public static bool K2_TimerExists(UObject UObject, string FunctionName)  => 
            KismetSystemLibrary_methods.K2_TimerExists_method.Invoke(UObject, FunctionName);

        ///<summary>Returns true is a timer for the given delegate exists, false otherwise.</summary>
        ///<remarks>
        ///@param Event  Can be a K2 function or a Custom Event.
        ///@return                              True if the timer exists.
        ///</remarks>
        public static bool K2_TimerExistsDelegate(byte Delegate /*TODO: delegate FTimerDynamicDelegate */)  => 
            KismetSystemLibrary_methods.K2_TimerExistsDelegate_method.Invoke(Delegate);

        ///<summary>Returns true is a timer for the given handle exists, false otherwise.</summary>
        ///<remarks>
        ///@param Handle                The handle to check whether it exists.
        ///@return                              True if the timer exists.
        ///</remarks>
        public static bool K2_TimerExistsHandle(UObject WorldContextObject, TimerHandle Handle)  => 
            KismetSystemLibrary_methods.K2_TimerExistsHandle_method.Invoke(WorldContextObject, Handle);

        ///<summary>Resumes a paused timer from its current elapsed time.</summary>
        ///<remarks>
        ///@param Object                Object that implements the delegate function. Defaults to self (this blueprint)
        ///@param FunctionName  Delegate function name. Can be a K2 function or a Custom Event.
        ///</remarks>
        public static void K2_UnPauseTimer(UObject UObject, string FunctionName)  => 
            KismetSystemLibrary_methods.K2_UnPauseTimer_method.Invoke(UObject, FunctionName);

        ///<summary>Resumes a paused timer from its current elapsed time.</summary>
        ///<remarks>
        ///@param Event  Can be a K2 function or a Custom Event.
        ///</remarks>
        public static void K2_UnPauseTimerDelegate(byte Delegate /*TODO: delegate FTimerDynamicDelegate */)  => 
            KismetSystemLibrary_methods.K2_UnPauseTimerDelegate_method.Invoke(Delegate);

        ///<summary>Resumes a paused timer from its current elapsed time.</summary>
        ///<remarks>
        ///@param Handle                The handle of the timer to unpause.
        ///</remarks>
        public static void K2_UnPauseTimerHandle(UObject WorldContextObject, TimerHandle Handle)  => 
            KismetSystemLibrary_methods.K2_UnPauseTimerHandle_method.Invoke(WorldContextObject, Handle);

        ///<summary>Opens the specified URL in the platform's web browser of choice</summary>
        public static void LaunchURL(string URL)  => 
            KismetSystemLibrary_methods.LaunchURL_method.Invoke(URL);

        ///<summary>Does a collision trace along the given line and returns all hits encountered up to and including the first blocking hit.</summary>
        ///<remarks>
        ///This trace finds the objects that RESPOND to the given TraceChannel
        ///
        ///@param WorldContext  World context
        ///@param Start                 Start of line segment.
        ///@param End                   End of line segment.
        ///@param TraceChannel  The channel to trace
        ///@param bTraceComplex True to test against complex collision, false to test against simplified collision.
        ///@param OutHit                Properties of the trace hit.
        ///@return                              True if there was a blocking hit, false otherwise.
        ///</remarks>
        public static (IReadOnlyCollection<HitResult>, bool) LineTraceMulti(UObject WorldContextObject, Vector Start, Vector End, byte TraceChannel, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime)  => 
            KismetSystemLibrary_methods.LineTraceMulti_method.Invoke(WorldContextObject, Start, End, TraceChannel, bTraceComplex, ActorsToIgnore, DrawDebugType, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);

        ///<summary>
        ///Trace a ray against the world using a specific profile and return overlapping hits and then first blocking hit
        ///Results are sorted, so a blocking hit (if found) will be the last element of the array
        ///Only the single closest blocking result will be generated, no tests will be done after that
        ///@
        ///</summary>
        ///<remarks>
        ///param WorldContext   World context
        ///@param Start                  Start of line segment.
        ///@param End                    End of line segment.
        ///@param ProfileName    The 'profile' used to determine which components to hit
        ///@param bTraceComplex  True to test against complex collision, false to test against simplified collision.
        ///@param OutHit         Properties of the trace hit.
        ///@return                               True if there was a blocking hit, false otherwise.
        ///</remarks>
        public static (IReadOnlyCollection<HitResult>, bool) LineTraceMultiByProfile(UObject WorldContextObject, Vector Start, Vector End, Name ProfileName, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime)  => 
            KismetSystemLibrary_methods.LineTraceMultiByProfile_method.Invoke(WorldContextObject, Start, End, ProfileName, bTraceComplex, ActorsToIgnore, DrawDebugType, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);

        ///<summary>Does a collision trace along the given line and returns all hits encountered.</summary>
        ///<remarks>
        ///This only finds objects that are of a type specified by ObjectTypes.
        ///
        ///@param WorldContext  World context
        ///@param Start                 Start of line segment.
        ///@param End                   End of line segment.
        ///@param ObjectTypes   Array of Object Types to trace
        ///@param bTraceComplex True to test against complex collision, false to test against simplified collision.
        ///@param OutHit                Properties of the trace hit.
        ///@return                              True if there was a hit, false otherwise.
        ///</remarks>
        public static (IReadOnlyCollection<HitResult>, bool) LineTraceMultiForObjects(UObject WorldContextObject, Vector Start, Vector End, byte ObjectTypes /*TODO: array TArray */, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime)  => 
            KismetSystemLibrary_methods.LineTraceMultiForObjects_method.Invoke(WorldContextObject, Start, End, ObjectTypes, bTraceComplex, ActorsToIgnore, DrawDebugType, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);

        ///<summary>Does a collision trace along the given line and returns the first blocking hit encountered.</summary>
        ///<remarks>
        ///This trace finds the objects that RESPONDS to the given TraceChannel
        ///
        ///@param WorldContext  World context
        ///@param Start                 Start of line segment.
        ///@param End                   End of line segment.
        ///@param TraceChannel
        ///@param bTraceComplex True to test against complex collision, false to test against simplified collision.
        ///@param OutHit                Properties of the trace hit.
        ///@return                              True if there was a hit, false otherwise.
        ///</remarks>
        public static (HitResult, bool) LineTraceSingle(UObject WorldContextObject, Vector Start, Vector End, byte TraceChannel, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime)  => 
            KismetSystemLibrary_methods.LineTraceSingle_method.Invoke(WorldContextObject, Start, End, TraceChannel, bTraceComplex, ActorsToIgnore, DrawDebugType, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);

        ///<summary>
        ///Trace a ray against the world using a specific profile and return the first blocking hit
        ///@
        ///</summary>
        ///<remarks>
        ///param WorldContext   World context
        ///@param Start                  Start of line segment.
        ///@param End                    End of line segment.
        ///@param ProfileName    The 'profile' used to determine which components to hit
        ///@param bTraceComplex  True to test against complex collision, false to test against simplified collision.
        ///@param OutHit                 Properties of the trace hit.
        ///@return                               True if there was a hit, false otherwise.
        ///</remarks>
        public static (HitResult, bool) LineTraceSingleByProfile(UObject WorldContextObject, Vector Start, Vector End, Name ProfileName, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime)  => 
            KismetSystemLibrary_methods.LineTraceSingleByProfile_method.Invoke(WorldContextObject, Start, End, ProfileName, bTraceComplex, ActorsToIgnore, DrawDebugType, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);

        ///<summary>Does a collision trace along the given line and returns the first hit encountered.</summary>
        ///<remarks>
        ///This only finds objects that are of a type specified by ObjectTypes.
        ///
        ///@param WorldContext  World context
        ///@param Start                 Start of line segment.
        ///@param End                   End of line segment.
        ///@param ObjectTypes   Array of Object Types to trace
        ///@param bTraceComplex True to test against complex collision, false to test against simplified collision.
        ///@param OutHit                Properties of the trace hit.
        ///@return                              True if there was a hit, false otherwise.
        ///</remarks>
        public static (HitResult, bool) LineTraceSingleForObjects(UObject WorldContextObject, Vector Start, Vector End, byte ObjectTypes /*TODO: array TArray */, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime)  => 
            KismetSystemLibrary_methods.LineTraceSingleForObjects_method.Invoke(WorldContextObject, Start, End, ObjectTypes, bTraceComplex, ActorsToIgnore, DrawDebugType, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);

        ///<summary>Load Asset</summary>
        public static void LoadAsset(UObject WorldContextObject, byte Asset /*TODO: soft object TSoftObjectPtr<UObject> */, byte OnLoaded /*TODO: delegate FOnAssetLoaded */, LatentActionInfo LatentInfo)  => 
            KismetSystemLibrary_methods.LoadAsset_method.Invoke(WorldContextObject, Asset, OnLoaded, LatentInfo);

        ///<summary>Load Asset Class</summary>
        public static void LoadAssetClass(UObject WorldContextObject, byte AssetClass /*TODO: soft class TSoftClassPtr<UObject>  */, byte OnLoaded /*TODO: delegate FOnAssetClassLoaded */, LatentActionInfo LatentInfo)  => 
            KismetSystemLibrary_methods.LoadAssetClass_method.Invoke(WorldContextObject, AssetClass, OnLoaded, LatentInfo);

        ///<summary>Will load a fullscreen interstitial AdMob ad.</summary>
        ///<remarks>
        ///Call this before using ShowInterstitialAd
        ///(Android only)
        ///
        ///@param AdIdIndex The index of the ID to select for the ad to show
        ///</remarks>
        public static void LoadInterstitialAd(int AdIdIndex)  => 
            KismetSystemLibrary_methods.LoadInterstitialAd_method.Invoke(AdIdIndex);

        ///<summary>
        ///Creates a literal bool
        ///@
        ///</summary>
        ///<remarks>
        ///param       Value   value to set the bool to
        ///@return      The literal bool
        ///</remarks>
        public static bool MakeLiteralBool(bool Value)  => 
            KismetSystemLibrary_methods.MakeLiteralBool_method.Invoke(Value);

        ///<summary>
        ///Creates a literal byte
        ///@
        ///</summary>
        ///<remarks>
        ///param       Value   value to set the byte to
        ///@return      The literal byte
        ///</remarks>
        public static byte MakeLiteralByte(byte Value)  => 
            KismetSystemLibrary_methods.MakeLiteralByte_method.Invoke(Value);

        ///<summary>
        ///Creates a literal float
        ///@
        ///</summary>
        ///<remarks>
        ///param       Value   value to set the float to
        ///@return      The literal float
        ///</remarks>
        public static float MakeLiteralFloat(float Value)  => 
            KismetSystemLibrary_methods.MakeLiteralFloat_method.Invoke(Value);

        ///<summary>
        ///Creates a literal integer
        ///@
        ///</summary>
        ///<remarks>
        ///param       Value   value to set the integer to
        ///@return      The literal integer
        ///</remarks>
        public static int MakeLiteralInt(int Value)  => 
            KismetSystemLibrary_methods.MakeLiteralInt_method.Invoke(Value);

        ///<summary>
        ///Creates a literal name
        ///@
        ///</summary>
        ///<remarks>
        ///param       Value   value to set the name to
        ///@return      The literal name
        ///</remarks>
        public static Name MakeLiteralName(Name Value)  => 
            KismetSystemLibrary_methods.MakeLiteralName_method.Invoke(Value);

        ///<summary>
        ///Creates a literal string
        ///@
        ///</summary>
        ///<remarks>
        ///param       Value   value to set the string to
        ///@return      The literal string
        ///</remarks>
        public static string MakeLiteralString(string Value)  => 
            KismetSystemLibrary_methods.MakeLiteralString_method.Invoke(Value);

        ///<summary>
        ///Creates a literal FText
        ///@
        ///</summary>
        ///<remarks>
        ///param       Value   value to set the FText to
        ///@return      The literal FText
        ///</remarks>
        public static byte /*TODO: text FText*/ MakeLiteralText(byte Value /*TODO: text FText */)  => 
            KismetSystemLibrary_methods.MakeLiteralText_method.Invoke(Value);

        ///<summary>Builds a SoftClassPath struct. Generally you should be using Soft Class References/Ptr types instead</summary>
        public static SoftClassPath MakeSoftClassPath(string PathString)  => 
            KismetSystemLibrary_methods.MakeSoftClassPath_method.Invoke(PathString);

        ///<summary>Builds a SoftObjectPath struct. Generally you should be using Soft Object References/Ptr types instead</summary>
        public static SoftObjectPath MakeSoftObjectPath(string PathString)  => 
            KismetSystemLibrary_methods.MakeSoftObjectPath_method.Invoke(PathString);

        ///<summary>* Interpolate a component to the specified relative location and rotation over the course of OverTime seconds.</summary>
        ///<remarks>
        ///* @param Component                                             Component to interpolate
        ///* @param TargetRelativeLocation                Relative target location
        ///* @param TargetRelativeRotation                Relative target rotation
        ///* @param bEaseOut                                              if true we will ease out (ie end slowly) during interpolation
        ///* @param bEaseIn                                               if true we will ease in (ie start slowly) during interpolation
        ///* @param OverTime                                              duration of interpolation
        ///* @param bForceShortestRotationPath    if true we will always use the shortest path for rotation
        ///* @param MoveAction                                    required movement behavior @see EMoveComponentAction
        ///* @param LatentInfo                                    The latent action
        ///</remarks>
        public static void MoveComponentTo(SceneComponent Component, Vector TargetRelativeLocation, Rotator TargetRelativeRotation, bool bEaseOut, bool bEaseIn, float OverTime, bool bForceShortestRotationPath, byte MoveAction, LatentActionInfo LatentInfo)  => 
            KismetSystemLibrary_methods.MoveComponentTo_method.Invoke(Component, TargetRelativeLocation, TargetRelativeRotation, bEaseOut, bEaseIn, OverTime, bForceShortestRotationPath, MoveAction, LatentInfo);

        ///<summary>Returns true if the values are not equal (A != B)</summary>
        public static bool NotEqual_PrimaryAssetId(PrimaryAssetId A, PrimaryAssetId B)  => 
            KismetSystemLibrary_methods.NotEqual_PrimaryAssetId_method.Invoke(A, B);

        ///<summary>Returns true if the values are not equal (A != B)</summary>
        public static bool NotEqual_PrimaryAssetType(PrimaryAssetType A, PrimaryAssetType B)  => 
            KismetSystemLibrary_methods.NotEqual_PrimaryAssetType_method.Invoke(A, B);

        ///<summary>Returns true if the values are not equal (A != B)</summary>
        public static bool NotEqual_SoftClassReference(byte A /*TODO: soft class TSoftClassPtr<UObject>  */, byte B /*TODO: soft class TSoftClassPtr<UObject>  */)  => 
            KismetSystemLibrary_methods.NotEqual_SoftClassReference_method.Invoke(A, B);

        ///<summary>Returns true if the values are not equal (A != B)</summary>
        public static bool NotEqual_SoftObjectReference(byte A /*TODO: soft object TSoftObjectPtr<UObject> */, byte B /*TODO: soft object TSoftObjectPtr<UObject> */)  => 
            KismetSystemLibrary_methods.NotEqual_SoftObjectReference_method.Invoke(A, B);

        ///<summary>
        ///Prints a string to the log, and optionally, to the screen
        ///If Print To Log is true, it will be visible in the Output Log window.
        ///</summary>
        ///<remarks>
        ///Otherwise it will be logged only as 'Verbose', so it generally won't show up.
        ///
        ///@param       InString                The string to log out
        ///@param       bPrintToScreen  Whether or not to print the output to the screen
        ///@param       bPrintToLog             Whether or not to print the output to the log
        ///@param       bPrintToConsole Whether or not to print the output to the console
        ///@param       TextColor               Whether or not to print the output to the console
        ///@param       Duration                The display duration (if Print to Screen is True). Using negative number will result in loading the duration time from the config.
        ///</remarks>
        public static void PrintString(UObject WorldContextObject, string InString, bool bPrintToScreen, bool bPrintToLog, LinearColor TextColor, float Duration)  => 
            KismetSystemLibrary_methods.PrintString_method.Invoke(WorldContextObject, InString, bPrintToScreen, bPrintToLog, TextColor, Duration);

        ///<summary>
        ///Prints text to the log, and optionally, to the screen
        ///If Print To Log is true, it will be visible in the Output Log window.
        ///</summary>
        ///<remarks>
        ///Otherwise it will be logged only as 'Verbose', so it generally won't show up.
        ///
        ///@param       InText                  The text to log out
        ///@param       bPrintToScreen  Whether or not to print the output to the screen
        ///@param       bPrintToLog             Whether or not to print the output to the log
        ///@param       bPrintToConsole Whether or not to print the output to the console
        ///@param       TextColor               Whether or not to print the output to the console
        ///@param       Duration                The display duration (if Print to Screen is True). Using negative number will result in loading the duration time from the config.
        ///</remarks>
        public static void PrintText(UObject WorldContextObject, byte InText /*TODO: text FText */, bool bPrintToScreen, bool bPrintToLog, LinearColor TextColor, float Duration)  => 
            KismetSystemLibrary_methods.PrintText_method.Invoke(WorldContextObject, InText, bPrintToScreen, bPrintToLog, TextColor, Duration);

        ///<summary>Prints a warning string to the log and the screen.</summary>
        ///<remarks>
        ///Meant to be used as a way to inform the user that they misused the node.
        ///
        ///WARNING!! Don't change the signature of this function without fixing up all nodes using it in the compiler
        ///
        ///@param       InString                The string to log out
        ///</remarks>
        public static void PrintWarning(string InString)  => 
            KismetSystemLibrary_methods.PrintWarning_method.Invoke(InString);

        ///<summary>
        ///Exit the current game
        ///@
        ///</summary>
        ///<remarks>param       SpecificPlayer  The specific player to quit the game. If not specified, player 0 will quit.</remarks>
        public static void QuitGame(UObject WorldContextObject, PlayerController SpecificPlayer, byte QuitPreference)  => 
            KismetSystemLibrary_methods.QuitGame_method.Invoke(WorldContextObject, SpecificPlayer, QuitPreference);

        ///<summary>Requests permission to send remote notifications to the user's device.</summary>
        ///<remarks>(Android and iOS only)</remarks>
        public static void RegisterForRemoteNotifications()  => 
            KismetSystemLibrary_methods.RegisterForRemoteNotifications_method.Invoke();

        ///<summary>Resets the gamepad to player controller id assignments (Android only)</summary>
        public static void ResetGamepadAssignments()  => 
            KismetSystemLibrary_methods.ResetGamepadAssignments_method.Invoke();

        ///<summary>* Resets the gamepad assignment to player controller id (Android only)</summary>
        public static void ResetGamepadAssignmentToController(int ControllerId)  => 
            KismetSystemLibrary_methods.ResetGamepadAssignmentToController_method.Invoke(ControllerId);

        ///<summary>Perform a latent action with a retriggerable delay (specified in seconds).</summary>
        ///<remarks>
        ///Calling again while it is counting down will reset the countdown to Duration.
        ///
        ///@param WorldContext  World context.
        ///@param Duration              length of delay (in seconds).
        ///@param LatentInfo    The latent action.
        ///</remarks>
        public static void RetriggerableDelay(UObject WorldContextObject, float Duration, LatentActionInfo LatentInfo)  => 
            KismetSystemLibrary_methods.RetriggerableDelay_method.Invoke(WorldContextObject, Duration, LatentInfo);

        ///<summary>Set a bool property by name</summary>
        public static void SetBoolPropertyByName(UObject UObject, Name PropertyName, bool Value)  => 
            KismetSystemLibrary_methods.SetBoolPropertyByName_method.Invoke(UObject, PropertyName, Value);

        ///<summary>Set an uint8 or enum property by name</summary>
        public static void SetBytePropertyByName(UObject UObject, Name PropertyName, byte Value)  => 
            KismetSystemLibrary_methods.SetBytePropertyByName_method.Invoke(UObject, PropertyName, Value);

        ///<summary>Set a CLASS property by name</summary>
        public static void SetClassPropertyByName(UObject UObject, Name PropertyName, SubclassOf<UObject> Value)  => 
            KismetSystemLibrary_methods.SetClassPropertyByName_method.Invoke(UObject, PropertyName, Value);

        ///<summary>Set a CollisionProfileName property by name</summary>
        public static void SetCollisionProfileNameProperty(UObject UObject, Name PropertyName, CollisionProfileName Value)  => 
            KismetSystemLibrary_methods.SetCollisionProfileNameProperty_method.Invoke(UObject, PropertyName, Value);

        ///<summary>Set a float property by name</summary>
        public static void SetFloatPropertyByName(UObject UObject, Name PropertyName, float Value)  => 
            KismetSystemLibrary_methods.SetFloatPropertyByName_method.Invoke(UObject, PropertyName, Value);

        ///<summary>Set an INTERFACE property by name</summary>
        public static void SetInterfacePropertyByName(UObject UObject, Name PropertyName, byte Value /*TODO: interface TScriptInterface */)  => 
            KismetSystemLibrary_methods.SetInterfacePropertyByName_method.Invoke(UObject, PropertyName, Value);

        ///<summary>Set an int32 property by name</summary>
        public static void SetIntPropertyByName(UObject UObject, Name PropertyName, int Value)  => 
            KismetSystemLibrary_methods.SetIntPropertyByName_method.Invoke(UObject, PropertyName, Value);

        ///<summary>Set a LINEAR COLOR property by name</summary>
        public static void SetLinearColorPropertyByName(UObject UObject, Name PropertyName, LinearColor Value)  => 
            KismetSystemLibrary_methods.SetLinearColorPropertyByName_method.Invoke(UObject, PropertyName, Value);

        ///<summary>Set a NAME property by name</summary>
        public static void SetNamePropertyByName(UObject UObject, Name PropertyName, Name Value)  => 
            KismetSystemLibrary_methods.SetNamePropertyByName_method.Invoke(UObject, PropertyName, Value);

        ///<summary>Set an OBJECT property by name</summary>
        public static void SetObjectPropertyByName(UObject UObject, Name PropertyName, UObject Value)  => 
            KismetSystemLibrary_methods.SetObjectPropertyByName_method.Invoke(UObject, PropertyName, Value);

        ///<summary>Set a ROTATOR property by name</summary>
        public static void SetRotatorPropertyByName(UObject UObject, Name PropertyName, Rotator Value)  => 
            KismetSystemLibrary_methods.SetRotatorPropertyByName_method.Invoke(UObject, PropertyName, Value);

        ///<summary>Set a SOFTCLASS property by name</summary>
        public static void SetSoftClassPropertyByName(UObject UObject, Name PropertyName, byte Value /*TODO: soft class TSoftClassPtr<UObject>  */)  => 
            KismetSystemLibrary_methods.SetSoftClassPropertyByName_method.Invoke(UObject, PropertyName, Value);

        ///<summary>Set a SOFTOBJECT property by name</summary>
        public static void SetSoftObjectPropertyByName(UObject UObject, Name PropertyName, byte Value /*TODO: soft object TSoftObjectPtr<UObject> */)  => 
            KismetSystemLibrary_methods.SetSoftObjectPropertyByName_method.Invoke(UObject, PropertyName, Value);

        ///<summary>Set a STRING property by name</summary>
        public static void SetStringPropertyByName(UObject UObject, Name PropertyName, string Value)  => 
            KismetSystemLibrary_methods.SetStringPropertyByName_method.Invoke(UObject, PropertyName, Value);

        ///<summary>Set a custom structure property by name</summary>
        public static void SetStructurePropertyByName(UObject UObject, Name PropertyName, GenericStruct Value)  => 
            KismetSystemLibrary_methods.SetStructurePropertyByName_method.Invoke(UObject, PropertyName, Value);

        ///<summary>Sets the state of the transition message rendered by the viewport.</summary>
        ///<remarks>
        ///(The blue text displayed when the game is paused and so forth.)
        ///
        ///@param WorldContextObject    World context
        ///@param State                                 set true to suppress transition message
        ///</remarks>
        public static void SetSuppressViewportTransitionMessage(UObject WorldContextObject, bool bState)  => 
            KismetSystemLibrary_methods.SetSuppressViewportTransitionMessage_method.Invoke(WorldContextObject, bState);

        ///<summary>Set a TEXT property by name</summary>
        public static void SetTextPropertyByName(UObject UObject, Name PropertyName, byte Value /*TODO: text FText */)  => 
            KismetSystemLibrary_methods.SetTextPropertyByName_method.Invoke(UObject, PropertyName, Value);

        ///<summary>Set a TRANSFORM property by name</summary>
        public static void SetTransformPropertyByName(UObject UObject, Name PropertyName, Transform Value)  => 
            KismetSystemLibrary_methods.SetTransformPropertyByName_method.Invoke(UObject, PropertyName, Value);

        ///<summary>Tells the engine what the user is doing for debug, analytics, etc.</summary>
        public static void SetUserActivity(UserActivity UserActivity)  => 
            KismetSystemLibrary_methods.SetUserActivity_method.Invoke(UserActivity);

        ///<summary>Set a VECTOR property by name</summary>
        public static void SetVectorPropertyByName(UObject UObject, Name PropertyName, Vector Value)  => 
            KismetSystemLibrary_methods.SetVectorPropertyByName_method.Invoke(UObject, PropertyName, Value);

        ///<summary>
        ///Allows or inhibits system default handling of volume up and volume down buttons (Android only)
        ///@
        ///</summary>
        ///<remarks>param       bEnabled                                If true, allow Android to handle volume up and down events</remarks>
        public static void SetVolumeButtonsHandledBySystem(bool bEnabled)  => 
            KismetSystemLibrary_methods.SetVolumeButtonsHandledBySystem_method.Invoke(bEnabled);

        ///<summary>Sets the game window title</summary>
        public static void SetWindowTitle(byte Title /*TODO: text FText */)  => 
            KismetSystemLibrary_methods.SetWindowTitle_method.Invoke(Title);

        ///<summary>
        ///Will show an ad banner (iAd on iOS, or AdMob on Android) on the top or bottom of screen, on top of the GL view (doesn't resize the view)
        ///(iOS and Android only)
        ///@
        ///</summary>
        ///<remarks>
        ///param AdIdIndex The index of the ID to select for the ad to show
        ///@param bShowOnBottomOfScreen If true, the iAd will be shown at the bottom of the screen, top otherwise
        ///</remarks>
        public static void ShowAdBanner(int AdIdIndex, bool bShowOnBottomOfScreen)  => 
            KismetSystemLibrary_methods.ShowAdBanner_method.Invoke(AdIdIndex, bShowOnBottomOfScreen);

        ///<summary>Shows the loaded interstitial ad (loaded with LoadInterstitialAd)</summary>
        ///<remarks>(Android only)</remarks>
        public static void ShowInterstitialAd()  => 
            KismetSystemLibrary_methods.ShowInterstitialAd_method.Invoke();

        ///<summary>
        ///Displays the built-in achievements GUI (iOS and Android only; this function may be renamed or moved in a future release)
        ///@
        ///</summary>
        ///<remarks>param SpecificPlayer Specific player's achievements to show. May not be supported on all platforms. If null, defaults to the player with ControllerId 0</remarks>
        public static void ShowPlatformSpecificAchievementsScreen(PlayerController SpecificPlayer)  => 
            KismetSystemLibrary_methods.ShowPlatformSpecificAchievementsScreen_method.Invoke(SpecificPlayer);

        ///<summary>Displays the built-in leaderboard GUI (iOS and Android only; this function may be renamed or moved in a future release)</summary>
        public static void ShowPlatformSpecificLeaderboardScreen(string CategoryName)  => 
            KismetSystemLibrary_methods.ShowPlatformSpecificLeaderboardScreen_method.Invoke(CategoryName);

        ///<summary>Returns an array of actors that overlap the given sphere.</summary>
        ///<remarks>
        ///@param WorldContext  World context
        ///@param SpherePos             Center of sphere.
        ///@param SphereRadius  Size of sphere.
        ///@param Filter                Option to restrict results to only static or only dynamic.  For efficiency.
        ///@param ClassFilter   If set, will only return results of this class or subclasses of it.
        ///@param ActorsToIgnore                Ignore these actors in the list
        ///@param OutActors             Returned array of actors. Unsorted.
        ///@return                              true if there was an overlap that passed the filters, false otherwise.
        ///</remarks>
        public static (IReadOnlyCollection<Actor>, bool) SphereOverlapActors(UObject WorldContextObject, Vector SpherePos, float SphereRadius, byte ObjectTypes /*TODO: array TArray */, SubclassOf<UObject> ActorClassFilter, byte ActorsToIgnore /*TODO: array TArray */)  => 
            KismetSystemLibrary_methods.SphereOverlapActors_method.Invoke(WorldContextObject, SpherePos, SphereRadius, ObjectTypes, ActorClassFilter, ActorsToIgnore);

        ///<summary>Returns an array of components that overlap the given sphere.</summary>
        ///<remarks>
        ///@param WorldContext  World context
        ///@param SpherePos             Center of sphere.
        ///@param SphereRadius  Size of sphere.
        ///@param Filter                Option to restrict results to only static or only dynamic.  For efficiency.
        ///@param ClassFilter   If set, will only return results of this class or subclasses of it.
        ///@param ActorsToIgnore                Ignore these actors in the list
        ///@param OutActors             Returned array of actors. Unsorted.
        ///@return                              true if there was an overlap that passed the filters, false otherwise.
        ///</remarks>
        public static (IReadOnlyCollection<PrimitiveComponent>, bool) SphereOverlapComponents(UObject WorldContextObject, Vector SpherePos, float SphereRadius, byte ObjectTypes /*TODO: array TArray */, SubclassOf<UObject> ComponentClassFilter, byte ActorsToIgnore /*TODO: array TArray */)  => 
            KismetSystemLibrary_methods.SphereOverlapComponents_method.Invoke(WorldContextObject, SpherePos, SphereRadius, ObjectTypes, ComponentClassFilter, ActorsToIgnore);

        ///<summary>Sweeps a sphere along the given line and returns all hits encountered up to and including the first blocking hit.</summary>
        ///<remarks>
        ///This trace finds the objects that RESPOND to the given TraceChannel
        ///
        ///@param WorldContext  World context
        ///@param Start                 Start of line segment.
        ///@param End                   End of line segment.
        ///@param Radius                Radius of the sphere to sweep
        ///@param TraceChannel
        ///@param bTraceComplex True to test against complex collision, false to test against simplified collision.
        ///@param OutHits               A list of hits, sorted along the trace from start to finish.  The blocking hit will be the last hit, if there was one.
        ///@return                              True if there was a blocking hit, false otherwise.
        ///</remarks>
        public static (IReadOnlyCollection<HitResult>, bool) SphereTraceMulti(UObject WorldContextObject, Vector Start, Vector End, float Radius, byte TraceChannel, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime)  => 
            KismetSystemLibrary_methods.SphereTraceMulti_method.Invoke(WorldContextObject, Start, End, Radius, TraceChannel, bTraceComplex, ActorsToIgnore, DrawDebugType, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);

        ///<summary>
        ///Sweep a sphere against the world and return all initial overlaps using a specific profile, then overlapping hits and then first blocking hit
        ///Results are sorted, so a blocking hit (if found) will be the last element of the array
        ///Only the single closest blocking result will be generated, no tests will be done after that
        ///@
        ///</summary>
        ///<remarks>
        ///param WorldContext   World context
        ///@param Start                  Start of line segment.
        ///@param End                    End of line segment.
        ///@param Radius         Radius of the sphere to sweep
        ///@param ProfileName    The 'profile' used to determine which components to hit
        ///@param bTraceComplex  True to test against complex collision, false to test against simplified collision.
        ///@param OutHits                A list of hits, sorted along the trace from start to finish.  The blocking hit will be the last hit, if there was one.
        ///@return                               True if there was a blocking hit, false otherwise.
        ///</remarks>
        public static (IReadOnlyCollection<HitResult>, bool) SphereTraceMultiByProfile(UObject WorldContextObject, Vector Start, Vector End, float Radius, Name ProfileName, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime)  => 
            KismetSystemLibrary_methods.SphereTraceMultiByProfile_method.Invoke(WorldContextObject, Start, End, Radius, ProfileName, bTraceComplex, ActorsToIgnore, DrawDebugType, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);

        ///<summary>Sweeps a sphere along the given line and returns all hits encountered.</summary>
        ///<remarks>
        ///This only finds objects that are of a type specified by ObjectTypes.
        ///
        ///@param WorldContext  World context
        ///@param Start                 Start of line segment.
        ///@param End                   End of line segment.
        ///@param Radius                Radius of the sphere to sweep
        ///@param ObjectTypes   Array of Object Types to trace
        ///@param bTraceComplex True to test against complex collision, false to test against simplified collision.
        ///@param OutHits               A list of hits, sorted along the trace from start to finish.  The blocking hit will be the last hit, if there was one.
        ///@return                              True if there was a hit, false otherwise.
        ///</remarks>
        public static (IReadOnlyCollection<HitResult>, bool) SphereTraceMultiForObjects(UObject WorldContextObject, Vector Start, Vector End, float Radius, byte ObjectTypes /*TODO: array TArray */, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime)  => 
            KismetSystemLibrary_methods.SphereTraceMultiForObjects_method.Invoke(WorldContextObject, Start, End, Radius, ObjectTypes, bTraceComplex, ActorsToIgnore, DrawDebugType, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);

        ///<summary>Sweeps a sphere along the given line and returns the first blocking hit encountered.</summary>
        ///<remarks>
        ///This trace finds the objects that RESPONDS to the given TraceChannel
        ///
        ///@param Start                 Start of line segment.
        ///@param End                   End of line segment.
        ///@param Radius                Radius of the sphere to sweep
        ///@param TraceChannel
        ///@param bTraceComplex True to test against complex collision, false to test against simplified collision.
        ///@param OutHit                Properties of the trace hit.
        ///@return                              True if there was a hit, false otherwise.
        ///</remarks>
        public static (HitResult, bool) SphereTraceSingle(UObject WorldContextObject, Vector Start, Vector End, float Radius, byte TraceChannel, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime)  => 
            KismetSystemLibrary_methods.SphereTraceSingle_method.Invoke(WorldContextObject, Start, End, Radius, TraceChannel, bTraceComplex, ActorsToIgnore, DrawDebugType, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);

        ///<summary>
        ///Sweep a sphere against the world and return the first blocking hit using a specific profile
        ///@
        ///</summary>
        ///<remarks>
        ///param Start                  Start of line segment.
        ///@param End                    End of line segment.
        ///@param Radius                 Radius of the sphere to sweep
        ///@param ProfileName    The 'profile' used to determine which components to hit
        ///@param bTraceComplex  True to test against complex collision, false to test against simplified collision.
        ///@param OutHit                 Properties of the trace hit.
        ///@return                               True if there was a hit, false otherwise.
        ///</remarks>
        public static (HitResult, bool) SphereTraceSingleByProfile(UObject WorldContextObject, Vector Start, Vector End, float Radius, Name ProfileName, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime)  => 
            KismetSystemLibrary_methods.SphereTraceSingleByProfile_method.Invoke(WorldContextObject, Start, End, Radius, ProfileName, bTraceComplex, ActorsToIgnore, DrawDebugType, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);

        ///<summary>Sweeps a sphere along the given line and returns the first hit encountered.</summary>
        ///<remarks>
        ///This only finds objects that are of a type specified by ObjectTypes.
        ///
        ///@param Start                 Start of line segment.
        ///@param End                   End of line segment.
        ///@param Radius                Radius of the sphere to sweep
        ///@param ObjectTypes   Array of Object Types to trace
        ///@param bTraceComplex True to test against complex collision, false to test against simplified collision.
        ///@param OutHit                Properties of the trace hit.
        ///@return                              True if there was a hit, false otherwise.
        ///</remarks>
        public static (HitResult, bool) SphereTraceSingleForObjects(UObject WorldContextObject, Vector Start, Vector End, float Radius, byte ObjectTypes /*TODO: array TArray */, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, byte DrawDebugType, bool bIgnoreSelf, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime)  => 
            KismetSystemLibrary_methods.SphereTraceSingleForObjects_method.Invoke(WorldContextObject, Start, End, Radius, ObjectTypes, bTraceComplex, ActorsToIgnore, DrawDebugType, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);

        ///<summary>Prints a stack trace to the log, so you can see how a blueprint got to this node</summary>
        public static void StackTrace()  => 
            KismetSystemLibrary_methods.StackTrace_method.Invoke();

        ///<summary>Unloads a primary asset, which allows it to be garbage collected if nothing else is referencing it</summary>
        public static void UnloadPrimaryAsset(PrimaryAssetId PrimaryAssetId)  => 
            KismetSystemLibrary_methods.UnloadPrimaryAsset_method.Invoke(PrimaryAssetId);

        ///<summary>Unloads a primary asset, which allows it to be garbage collected if nothing else is referencing it</summary>
        public static void UnloadPrimaryAssetList(byte PrimaryAssetIdList /*TODO: array TArray */)  => 
            KismetSystemLibrary_methods.UnloadPrimaryAssetList_method.Invoke(PrimaryAssetIdList);

        ///<summary>Requests Requests unregistering from receiving remote notifications to the user's device.</summary>
        ///<remarks>(Android only)</remarks>
        public static void UnregisterForRemoteNotifications()  => 
            KismetSystemLibrary_methods.UnregisterForRemoteNotifications_method.Invoke();
        static KismetSystemLibrary() {
            StaticClass = Main.GetClass("KismetSystemLibrary");
        }
        internal unsafe KismetSystemLibrary_fields* KismetSystemLibrary_ptr => (KismetSystemLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator KismetSystemLibrary(IntPtr p) => UObject.Make<KismetSystemLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static KismetSystemLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static KismetSystemLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
