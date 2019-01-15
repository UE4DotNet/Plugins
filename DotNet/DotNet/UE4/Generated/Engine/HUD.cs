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
    ///<summary>Base class of the heads-up display.</summary>
    ///<remarks>
    ///This has a canvas and a debug canvas on which primitives can be drawn.
    ///It also contains a list of simple hit boxes that can be used for simple item click detection.
    ///A method of rendering debug text is also included.
    ///Provides some simple methods for rendering text, textures, rectangles and materials which can also be accessed from blueprints.
    ///@see UCanvas
    ///@see FHUDHitBox
    ///@see FDebugTextInfo
    ///</remarks>
    public unsafe partial class HUD : Actor  {

        ///<summary>Hook to allow blueprints to do custom HUD drawing.</summary>
        ///<remarks>
        ///@see bSuppressNativeHUD to control HUD drawing in base class.
        ///Note:  the canvas resource used for drawing is only valid during this event, it will not be valid if drawing functions are called later (e.g. after a Delay node).
        ///</remarks>
        public event ReceiveDrawHUD_delegate ReceiveDrawHUD;
        public delegate void ReceiveDrawHUD_delegate(int SizeX, int SizeY);
        internal void on_ReceiveDrawHUD(int SizeX, int SizeY) =>
            ReceiveDrawHUD?.Invoke(SizeX, SizeY);


        ///<summary>Called when a hit box is moused over.</summary>
        public event ReceiveHitBoxBeginCursorOver_delegate ReceiveHitBoxBeginCursorOver;
        public delegate void ReceiveHitBoxBeginCursorOver_delegate(Name BoxName);
        internal void on_ReceiveHitBoxBeginCursorOver(Name BoxName) =>
            ReceiveHitBoxBeginCursorOver?.Invoke(BoxName);


        ///<summary>Called when a hit box is clicked on. Provides the name associated with that box.</summary>
        public event ReceiveHitBoxClick_delegate ReceiveHitBoxClick;
        public delegate void ReceiveHitBoxClick_delegate(Name BoxName);
        internal void on_ReceiveHitBoxClick(Name BoxName) =>
            ReceiveHitBoxClick?.Invoke(BoxName);


        ///<summary>Called when a hit box no longer has the mouse over it.</summary>
        public event ReceiveHitBoxEndCursorOver_delegate ReceiveHitBoxEndCursorOver;
        public delegate void ReceiveHitBoxEndCursorOver_delegate(Name BoxName);
        internal void on_ReceiveHitBoxEndCursorOver(Name BoxName) =>
            ReceiveHitBoxEndCursorOver?.Invoke(BoxName);


        ///<summary>Called when a hit box is unclicked. Provides the name associated with that box.</summary>
        public event ReceiveHitBoxRelease_delegate ReceiveHitBoxRelease;
        public delegate void ReceiveHitBoxRelease_delegate(Name BoxName);
        internal void on_ReceiveHitBoxRelease(Name BoxName) =>
            ReceiveHitBoxRelease?.Invoke(BoxName);


        ///<summary>
        ///Add a hitbox to the hud
        ///@
        ///</summary>
        ///<remarks>
        ///param Position                      Coordinates of the top left of the hit box.
        ///@param Size                          Size of the hit box.
        ///@param Name                          Name of the hit box.
        ///@param bConsumesInput        Whether click processing should continue if this hit box is clicked.
        ///@param Priority                      The priority of the box used for layering. Larger values are considered first.  Equal values are considered in the order they were added.
        ///</remarks>
        public void AddHitBox(Vector2D Position, Vector2D Size, Name InName, bool bConsumesInput, int Priority)  => 
            HUD_methods.AddHitBox_method.Invoke(ObjPointer, Position, Size, InName, bConsumesInput, Priority);

        ///<summary>Transforms a 2D screen location into a 3D location and direction</summary>
        public (Vector, Vector) Deproject(float ScreenX, float ScreenY)  => 
            HUD_methods.Deproject_method.Invoke(ObjPointer, ScreenX, ScreenY);

        ///<summary>Draws a 2D line on the HUD.</summary>
        ///<remarks>
        ///@param StartScreenX          Screen-space X coordinate of start of the line.
        ///@param StartScreenY          Screen-space Y coordinate of start of the line.
        ///@param EndScreenX            Screen-space X coordinate of end of the line.
        ///@param EndScreenY            Screen-space Y coordinate of end of the line.
        ///@param LineColor                     Color to draw line
        ///@param LineThickness         Thickness of the line to draw
        ///</remarks>
        public void DrawLine(float StartScreenX, float StartScreenY, float EndScreenX, float EndScreenY, LinearColor LineColor, float LineThickness)  => 
            HUD_methods.DrawLine_method.Invoke(ObjPointer, StartScreenX, StartScreenY, EndScreenX, EndScreenY, LineColor, LineThickness);

        ///<summary>Draws a material-textured quad on the HUD.</summary>
        ///<remarks>
        ///@param Material                      Material to use
        ///@param ScreenX                       Screen-space X coordinate of upper left corner of the quad.
        ///@param ScreenY                       Screen-space Y coordinate of upper left corner of the quad.
        ///@param ScreenW                       Screen-space width of the quad (in pixels).
        ///@param ScreenH                       Screen-space height of the quad (in pixels).
        ///@param MaterialU                     Texture-space U coordinate of upper left corner of the quad
        ///@param MaterialV                     Texture-space V coordinate of upper left corner of the quad.
        ///@param MaterialUWidth        Texture-space width of the quad (in normalized UV distance).
        ///@param MaterialVHeight       Texture-space height of the quad (in normalized UV distance).
        ///@param Scale                         Amount to scale the entire texture (horizontally and vertically)
        ///@param bScalePosition        Whether the "Scale" parameter should also scale the position of this draw call.
        ///@param Rotation                      Amount to rotate this quad
        ///@param RotPivot                      Location (as proportion of quad, 0-1) to rotate about
        ///</remarks>
        public void DrawMaterial(MaterialInterface Material, float ScreenX, float ScreenY, float ScreenW, float ScreenH, float MaterialU, float MaterialV, float MaterialUWidth, float MaterialVHeight, float Scale, bool bScalePosition, float Rotation, Vector2D RotPivot)  => 
            HUD_methods.DrawMaterial_method.Invoke(ObjPointer, Material, ScreenX, ScreenY, ScreenW, ScreenH, MaterialU, MaterialV, MaterialUWidth, MaterialVHeight, Scale, bScalePosition, Rotation, RotPivot);

        ///<summary>Draws a material-textured quad on the HUD.</summary>
        ///<remarks>
        ///Assumes UVs such that the entire material is shown.
        ///@param Material                      Material to use
        ///@param ScreenX                       Screen-space X coordinate of upper left corner of the quad.
        ///@param ScreenY                       Screen-space Y coordinate of upper left corner of the quad.
        ///@param ScreenW                       Screen-space width of the quad (in pixels).
        ///@param ScreenH                       Screen-space height of the quad (in pixels).
        ///@param Scale                         Amount to scale the entire texture (horizontally and vertically)
        ///@param bScalePosition        Whether the "Scale" parameter should also scale the position of this draw call.
        ///</remarks>
        public void DrawMaterialSimple(MaterialInterface Material, float ScreenX, float ScreenY, float ScreenW, float ScreenH, float Scale, bool bScalePosition)  => 
            HUD_methods.DrawMaterialSimple_method.Invoke(ObjPointer, Material, ScreenX, ScreenY, ScreenW, ScreenH, Scale, bScalePosition);

        ///<summary>Draw Material Triangle</summary>
        public void DrawMaterialTriangle(MaterialInterface Material, Vector2D V0_Pos, Vector2D V1_Pos, Vector2D V2_Pos, Vector2D V0_UV, Vector2D V1_UV, Vector2D V2_UV, LinearColor V0_Color, LinearColor V1_Color, LinearColor V2_Color)  => 
            HUD_methods.DrawMaterialTriangle_method.Invoke(ObjPointer, Material, V0_Pos, V1_Pos, V2_Pos, V0_UV, V1_UV, V2_UV, V0_Color, V1_Color, V2_Color);

        ///<summary>Draws a colored untextured quad on the HUD.</summary>
        ///<remarks>
        ///@param RectColor                     Color of the rect. Can be translucent.
        ///@param ScreenX                       Screen-space X coordinate of upper left corner of the quad.
        ///@param ScreenY                       Screen-space Y coordinate of upper left corner of the quad.
        ///@param ScreenW                       Screen-space width of the quad (in pixels).
        ///@param ScreenH                       Screen-space height of the quad (in pixels).
        ///</remarks>
        public void DrawRect(LinearColor RectColor, float ScreenX, float ScreenY, float ScreenW, float ScreenH)  => 
            HUD_methods.DrawRect_method.Invoke(ObjPointer, RectColor, ScreenX, ScreenY, ScreenW, ScreenH);

        ///<summary>Draws a string on the HUD.</summary>
        ///<remarks>
        ///@param Text                          String to draw
        ///@param TextColor                     Color to draw string
        ///@param ScreenX                       Screen-space X coordinate of upper left corner of the string.
        ///@param ScreenY                       Screen-space Y coordinate of upper left corner of the string.
        ///@param Font                          Font to draw text.  If NULL, default font is chosen.
        ///@param Scale                         Scale multiplier to control size of the text.
        ///@param bScalePosition        Whether the "Scale" parameter should also scale the position of this draw call.
        ///</remarks>
        public void DrawText(string Text, LinearColor TextColor, float ScreenX, float ScreenY, Font Font, float Scale, bool bScalePosition)  => 
            HUD_methods.DrawText_method.Invoke(ObjPointer, Text, TextColor, ScreenX, ScreenY, Font, Scale, bScalePosition);

        ///<summary>Draws a textured quad on the HUD.</summary>
        ///<remarks>
        ///@param Texture                       Texture to draw.
        ///@param ScreenX                       Screen-space X coordinate of upper left corner of the quad.
        ///@param ScreenY                       Screen-space Y coordinate of upper left corner of the quad.
        ///@param ScreenW                       Screen-space width of the quad (in pixels).
        ///@param ScreenH                       Screen-space height of the quad (in pixels).
        ///@param TextureU                      Texture-space U coordinate of upper left corner of the quad
        ///@param TextureV                      Texture-space V coordinate of upper left corner of the quad.
        ///@param TextureUWidth         Texture-space width of the quad (in normalized UV distance).
        ///@param TextureVHeight        Texture-space height of the quad (in normalized UV distance).
        ///@param TintColor                     Vertex color for the quad.
        ///@param BlendMode                     Controls how to blend this quad with the scene. Translucent by default.
        ///@param Scale                         Amount to scale the entire texture (horizontally and vertically)
        ///@param bScalePosition        Whether the "Scale" parameter should also scale the position of this draw call.
        ///@param Rotation                      Amount to rotate this quad
        ///@param RotPivot                      Location (as proportion of quad, 0-1) to rotate about
        ///</remarks>
        public void DrawTexture(Texture Texture, float ScreenX, float ScreenY, float ScreenW, float ScreenH, float TextureU, float TextureV, float TextureUWidth, float TextureVHeight, LinearColor TintColor, byte BlendMode, float Scale, bool bScalePosition, float Rotation, Vector2D RotPivot)  => 
            HUD_methods.DrawTexture_method.Invoke(ObjPointer, Texture, ScreenX, ScreenY, ScreenW, ScreenH, TextureU, TextureV, TextureUWidth, TextureVHeight, TintColor, BlendMode, Scale, bScalePosition, Rotation, RotPivot);

        ///<summary>Draws a textured quad on the HUD.</summary>
        ///<remarks>
        ///Assumes 1:1 texel density.
        ///@param Texture                       Texture to draw.
        ///@param ScreenX                       Screen-space X coordinate of upper left corner of the quad.
        ///@param ScreenY                       Screen-space Y coordinate of upper left corner of the quad.
        ///@param Scale                         Scale multiplier to control size of the text.
        ///@param bScalePosition        Whether the "Scale" parameter should also scale the position of this draw call.
        ///</remarks>
        public void DrawTextureSimple(Texture Texture, float ScreenX, float ScreenY, float Scale, bool bScalePosition)  => 
            HUD_methods.DrawTextureSimple_method.Invoke(ObjPointer, Texture, ScreenX, ScreenY, Scale, bScalePosition);

        ///<summary>Returns the array of actors inside a selection rectangle, with a class filter.</summary>
        ///<remarks>
        ///Sample usage:
        ///
        ///      TArray<AStaticMeshActor*> ActorsInSelectionRect;
        ///             Canvas->GetActorsInSelectionRectangle<AStaticMeshActor>(FirstPoint,SecondPoint,ActorsInSelectionRect);
        ///
        ///
        ///@param FirstPoint                                    The first point, or anchor of the marquee box. Where the dragging of the marquee started in screen space.
        ///@param SecondPoint                                   The second point, where the mouse cursor currently is / the other point of the box selection, in screen space.
        ///@return OutActors                                    The actors that are within the selection box according to selection rule
        ///@param bIncludeNonCollidingComponents        Whether to include even non-colliding components of the actor when determining its bounds
        ///@param bActorMustBeFullyEnclosed     The Selection rule: whether the selection box can partially intersect Actor, or must fully enclose the Actor.
        ///</remarks>
        public IReadOnlyCollection<Actor> GetActorsInSelectionRectangle(SubclassOf<Actor> ClassFilter, Vector2D FirstPoint, Vector2D SecondPoint, bool bIncludeNonCollidingComponents, bool bActorMustBeFullyEnclosed)  => 
            HUD_methods.GetActorsInSelectionRectangle_method.Invoke(ObjPointer, ClassFilter, FirstPoint, SecondPoint, bIncludeNonCollidingComponents, bActorMustBeFullyEnclosed);

        ///<summary>Returns the Pawn for this HUD's player.</summary>
        public Pawn GetOwningPawn()  => 
            HUD_methods.GetOwningPawn_method.Invoke(ObjPointer);

        ///<summary>Returns the PlayerController for this HUD's player.</summary>
        public PlayerController GetOwningPlayerController()  => 
            HUD_methods.GetOwningPlayerController_method.Invoke(ObjPointer);

        ///<summary>Returns the width and height of a string.</summary>
        ///<remarks>
        ///@param Text                          String to draw
        ///@param OutWidth                      Returns the width in pixels of the string.
        ///@param OutHeight                     Returns the height in pixels of the string.
        ///@param Font                          Font to draw text.  If NULL, default font is chosen.
        ///@param Scale                         Scale multiplier to control size of the text.
        ///</remarks>
        public (float, float) GetTextSize(string Text, Font Font, float Scale)  => 
            HUD_methods.GetTextSize_method.Invoke(ObjPointer, Text, Font, Scale);

        ///<summary>Transforms a 3D world-space vector into 2D screen coordinates</summary>
        public Vector Project(Vector Location)  => 
            HUD_methods.Project_method.Invoke(ObjPointer, Location);
        ///<summary>PlayerController which owns this HUD.</summary>
        public unsafe PlayerController PlayerOwner {
            get {return HUD_ptr->PlayerOwner;}
        }
        public bool bLostFocusPaused {
            get {return Main.GetGetBoolPropertyByName(this, "bLostFocusPaused"); }
        }
        public bool bShowHUD {
            get {return Main.GetGetBoolPropertyByName(this, "bShowHUD"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowHUD", value); }
        }
        public bool bShowDebugInfo {
            get {return Main.GetGetBoolPropertyByName(this, "bShowDebugInfo"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowDebugInfo", value); }
        }
        ///<summary>Current target in our considered Targets list for 'showdebug'</summary>
        public unsafe int CurrentTargetIndex {
            get {return HUD_ptr->CurrentTargetIndex;}
            set {HUD_ptr->CurrentTargetIndex = value;}
        }
        public bool bShowHitBoxDebugInfo {
            get {return Main.GetGetBoolPropertyByName(this, "bShowHitBoxDebugInfo"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowHitBoxDebugInfo", value); }
        }
        public bool bShowOverlays {
            get {return Main.GetGetBoolPropertyByName(this, "bShowOverlays"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowOverlays", value); }
        }
        public bool bEnableDebugTextShadow {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableDebugTextShadow"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableDebugTextShadow", value); }
        }
        ///<summary>Holds a list of Actors that need PostRender() calls.</summary>
        public ObjectArrayField<Actor> PostRenderedActors{ get {
            if(PostRenderedActors_store == null) PostRenderedActors_store = new ObjectArrayField<Actor> (&HUD_ptr->PostRenderedActors);
            return PostRenderedActors_store;
        } }
        private ObjectArrayField<Actor> PostRenderedActors_store;

         //TODO: array not UObject TArray DebugDisplay
         //TODO: array not UObject TArray ToggledDebugCategories
        ///<summary>Canvas to Draw HUD on.  Only valid during PostRender() event.</summary>
        public unsafe Canvas Canvas {
            get {return HUD_ptr->Canvas;}
            set {HUD_ptr->Canvas = value;}
        }
        ///<summary>'Foreground' debug canvas, will draw in front of Slate UI.</summary>
        public unsafe Canvas DebugCanvas {
            get {return HUD_ptr->DebugCanvas;}
            set {HUD_ptr->DebugCanvas = value;}
        }
         //TODO: array not UObject TArray DebugTextList
        ///<summary>Class filter for selecting 'ShowDebugTargetActor' when 'bShowDebugForReticleTarget' is true.</summary>
        public unsafe SubclassOf<Actor> ShowDebugTargetDesiredClass {
            get {return HUD_ptr->ShowDebugTargetDesiredClass;}
            set {HUD_ptr->ShowDebugTargetDesiredClass = value;}
        }
        ///<summary>Show Debug Actor used if 'bShowDebugForReticleTarget' is true, only updated if trace from reticle hit a new Actor of class 'ShowDebugTargetDesiredClass'</summary>
        public unsafe Actor ShowDebugTargetActor {
            get {return HUD_ptr->ShowDebugTargetActor;}
            set {HUD_ptr->ShowDebugTargetActor = value;}
        }
        static HUD() {
            StaticClass = Main.GetClass("HUD");
            HUD_events.ReceiveDrawHUD_event.Setup();
            HUD_events.ReceiveHitBoxBeginCursorOver_event.Setup();
            HUD_events.ReceiveHitBoxClick_event.Setup();
            HUD_events.ReceiveHitBoxEndCursorOver_event.Setup();
            HUD_events.ReceiveHitBoxRelease_event.Setup();
        }
        internal unsafe HUD_fields* HUD_ptr => (HUD_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator HUD(IntPtr p) => UObject.Make<HUD>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static HUD DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static HUD New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
