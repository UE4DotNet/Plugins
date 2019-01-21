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
    ///<summary>A drawing canvas.</summary>
    public unsafe partial class Canvas : UObject  {

        ///<summary>Performs a deprojection of a screen space coordinate using the projection matrix set up for the Canvas.</summary>
        ///<remarks>
        ///@param ScreenPosition                        Screen space position to deproject to the World.
        ///@param WorldOrigin                           Vector which is the world position of the screen space position.
        ///@param WorldDirection                        Vector which can be used in a trace to determine what is "behind" the screen space position. Useful for object picking.
        ///</remarks>
        public (Vector, Vector) K2_Deproject(Vector2D ScreenPosition)  => 
            Canvas_methods.K2_Deproject_method.Invoke(ObjPointer, ScreenPosition);

        ///<summary>Draws a 3x3 grid border with tiled frame and tiled interior on the Canvas.</summary>
        ///<remarks>
        ///@param BorderTexture                         Texture to use for border.
        ///@param BackgroundTexture                     Texture to use for border background.
        ///@param LeftBorderTexture                     Texture to use for the tiling left border.
        ///@param RightBorderTexture            Texture to use for the tiling right border.
        ///@param TopBorderTexture                      Texture to use for the tiling top border.
        ///@param BottomBorderTexture           Texture to use for the tiling bottom border.
        ///@param ScreenPosition                        Screen space position to render the texture.
        ///@param ScreenSize                            Screen space size to render the texture.
        ///@param CoordinatePosition            Normalized UV starting coordinate to use when rendering the border texture.
        ///@param CoordinateSize                        Normalized UV size coordinate to use when rendering the border texture.
        ///@param RenderColor                           Color to tint the border.
        ///@param BorderScale                           Scale of the border.
        ///@param BackgroundScale                       Scale of the background.
        ///@param Rotation                                      Rotation, in degrees, to render the texture.
        ///@param PivotPoint                            Normalized pivot point to use when rotating the texture.
        ///@param CornerSize                            Frame corner size in percent of frame texture (should be < 0.5f).
        ///</remarks>
        public void K2_DrawBorder(Texture BorderTexture, Texture BackgroundTexture, Texture LeftBorderTexture, Texture RightBorderTexture, Texture TopBorderTexture, Texture BottomBorderTexture, Vector2D ScreenPosition, Vector2D ScreenSize, Vector2D CoordinatePosition, Vector2D CoordinateSize, LinearColor RenderColor, Vector2D BorderScale, Vector2D BackgroundScale, float Rotation, Vector2D PivotPoint, Vector2D CornerSize)  => 
            Canvas_methods.K2_DrawBorder_method.Invoke(ObjPointer, BorderTexture, BackgroundTexture, LeftBorderTexture, RightBorderTexture, TopBorderTexture, BottomBorderTexture, ScreenPosition, ScreenSize, CoordinatePosition, CoordinateSize, RenderColor, BorderScale, BackgroundScale, Rotation, PivotPoint, CornerSize);

        ///<summary>Draws an unfilled box on the Canvas.</summary>
        ///<remarks>
        ///@param ScreenPosition                        Screen space position to render the text.
        ///@param ScreenSize                            Screen space size to render the texture.
        ///@param Thickness                                     How many pixels thick the box lines should be.
        ///</remarks>
        public void K2_DrawBox(Vector2D ScreenPosition, Vector2D ScreenSize, float Thickness, LinearColor RenderColor)  => 
            Canvas_methods.K2_DrawBox_method.Invoke(ObjPointer, ScreenPosition, ScreenSize, Thickness, RenderColor);

        ///<summary>Draws a line on the Canvas.</summary>
        ///<remarks>
        ///@param ScreenPositionA               Starting position of the line in screen space.
        ///@param ScreenPositionB               Ending position of the line in screen space.
        ///@param Thickness                             How many pixels thick this line should be.
        ///@param RenderColor                   Color to render the line.
        ///</remarks>
        public void K2_DrawLine(Vector2D ScreenPositionA, Vector2D ScreenPositionB, float Thickness, LinearColor RenderColor)  => 
            Canvas_methods.K2_DrawLine_method.Invoke(ObjPointer, ScreenPositionA, ScreenPositionB, Thickness, RenderColor);

        ///<summary>Draws a material on the Canvas.</summary>
        ///<remarks>
        ///@param RenderMaterial                        Material to use when rendering. Remember that only the emissive channel is able to be rendered as no lighting is performed when rendering to the Canvas.
        ///@param ScreenPosition                        Screen space position to render the texture.
        ///@param ScreenSize                            Screen space size to render the texture.
        ///@param CoordinatePosition            Normalized UV starting coordinate to use when rendering the texture.
        ///@param CoordinateSize                        Normalized UV size coordinate to use when rendering the texture.
        ///@param Rotation                                      Rotation, in degrees, to render the texture.
        ///@param PivotPoint                            Normalized pivot point to use when rotating the texture.
        ///</remarks>
        public void K2_DrawMaterial(MaterialInterface RenderMaterial, Vector2D ScreenPosition, Vector2D ScreenSize, Vector2D CoordinatePosition, Vector2D CoordinateSize, float Rotation, Vector2D PivotPoint)  => 
            Canvas_methods.K2_DrawMaterial_method.Invoke(ObjPointer, RenderMaterial, ScreenPosition, ScreenSize, CoordinatePosition, CoordinateSize, Rotation, PivotPoint);

        ///<summary>Draws a set of triangles on the Canvas.</summary>
        ///<remarks>
        ///@param RenderMaterial                        Material to use when rendering. Remember that only the emissive channel is able to be rendered as no lighting is performed when rendering to the Canvas.
        ///@param Triangles                                     Triangles to render.
        ///</remarks>
        public void K2_DrawMaterialTriangle(MaterialInterface RenderMaterial, byte Triangles /*TODO: array TArray */)  => 
            Canvas_methods.K2_DrawMaterialTriangle_method.Invoke(ObjPointer, RenderMaterial, Triangles);

        ///<summary>Draws a polygon on the Canvas.</summary>
        ///<remarks>
        ///@param RenderTexture                         Texture to use when rendering the triangles. If no texture is set, then the default white texture is used.
        ///@param ScreenPosition                        Screen space position to render the text.
        ///@param Radius                                        How large in pixels this polygon should be.
        ///@param NumberOfSides                         How many sides this polygon should have. This should be above or equal to three.
        ///@param RenderColor                           Color to tint the polygon.
        ///</remarks>
        public void K2_DrawPolygon(Texture RenderTexture, Vector2D ScreenPosition, Vector2D Radius, int NumberOfSides, LinearColor RenderColor)  => 
            Canvas_methods.K2_DrawPolygon_method.Invoke(ObjPointer, RenderTexture, ScreenPosition, Radius, NumberOfSides, RenderColor);

        ///<summary>Draws text on the Canvas.</summary>
        ///<remarks>
        ///@param RenderFont                            Font to use when rendering the text. If this is null, then a default engine font is used.
        ///@param RenderText                            Text to render on the Canvas.
        ///@param ScreenPosition                        Screen space position to render the text.
        ///@param RenderColor                           Color to render the text.
        ///@param Kerning                                       Horizontal spacing adjustment to modify the spacing between each letter.
        ///@param ShadowColor                           Color to render the shadow of the text.
        ///@param ShadowOffset                          Pixel offset relative to the screen space position to render the shadow of the text.
        ///@param bCentreX                                      If true, then interpret the screen space position X coordinate as the center of the rendered text.
        ///@param bCentreY                                      If true, then interpret the screen space position Y coordinate as the center of the rendered text.
        ///@param bOutlined                                     If true, then the text should be rendered with an outline.
        ///@param OutlineColor                          Color to render the outline for the text.
        ///</remarks>
        public void K2_DrawText(Font RenderFont, string RenderText, Vector2D ScreenPosition, Vector2D Scale, LinearColor RenderColor, float Kerning, LinearColor ShadowColor, Vector2D ShadowOffset, bool bCentreX, bool bCentreY, bool bOutlined, LinearColor OutlineColor)  => 
            Canvas_methods.K2_DrawText_method.Invoke(ObjPointer, RenderFont, RenderText, ScreenPosition, Scale, RenderColor, Kerning, ShadowColor, ShadowOffset, bCentreX, bCentreY, bOutlined, OutlineColor);

        ///<summary>Draws a texture on the Canvas.</summary>
        ///<remarks>
        ///@param RenderTexture                         Texture to use when rendering. If no texture is set then this will use the default white texture.
        ///@param ScreenPosition                        Screen space position to render the texture.
        ///@param ScreenSize                            Screen space size to render the texture.
        ///@param CoordinatePosition            Normalized UV starting coordinate to use when rendering the texture.
        ///@param CoordinateSize                        Normalized UV size coordinate to use when rendering the texture.
        ///@param RenderColor                           Color to use when rendering the texture.
        ///@param BlendMode                                     Blending mode to use when rendering the texture.
        ///@param Rotation                                      Rotation, in degrees, to render the texture.
        ///@param PivotPoint                            Normalized pivot point to use when rotating the texture.
        ///</remarks>
        public void K2_DrawTexture(Texture RenderTexture, Vector2D ScreenPosition, Vector2D ScreenSize, Vector2D CoordinatePosition, Vector2D CoordinateSize, LinearColor RenderColor, byte BlendMode, float Rotation, Vector2D PivotPoint)  => 
            Canvas_methods.K2_DrawTexture_method.Invoke(ObjPointer, RenderTexture, ScreenPosition, ScreenSize, CoordinatePosition, CoordinateSize, RenderColor, BlendMode, Rotation, PivotPoint);

        ///<summary>Draws a set of triangles on the Canvas.</summary>
        ///<remarks>
        ///@param RenderTexture                         Texture to use when rendering the triangles. If no texture is set, then the default white texture is used.
        ///@param Triangles                                     Triangles to render.
        ///</remarks>
        public void K2_DrawTriangle(Texture RenderTexture, byte Triangles /*TODO: array TArray */)  => 
            Canvas_methods.K2_DrawTriangle_method.Invoke(ObjPointer, RenderTexture, Triangles);

        ///<summary>Performs a projection of a world space coordinates using the projection matrix set up for the Canvas.</summary>
        ///<remarks>
        ///@param WorldLocation                         World space location to project onto the Canvas rendering plane.
        ///@return                                                      Returns a vector where X, Y defines a screen space position representing the world space location.
        ///</remarks>
        public Vector K2_Project(Vector WorldLocation)  => 
            Canvas_methods.K2_Project_method.Invoke(ObjPointer, WorldLocation);

        ///<summary>Returns the wrapped text size in screen space coordinates.</summary>
        ///<remarks>
        ///@param RenderFont                            Font to use when determining the size of the text. If this is null, then a default engine font is used.
        ///@param RenderText                            Text to determine the size of.
        ///@return                                                      Returns the screen space size of the text.
        ///</remarks>
        public Vector2D K2_StrLen(Font RenderFont, string RenderText)  => 
            Canvas_methods.K2_StrLen_method.Invoke(ObjPointer, RenderFont, RenderText);

        ///<summary>Returns the clipped text size in screen space coordinates.</summary>
        ///<remarks>
        ///@param RenderFont                            Font to use when determining the size of the text. If this is null, then a default engine font is used.
        ///@param RenderText                            Text to determine the size of.
        ///@param Scale                                         Scale of the font to use when determining the size of the text.
        ///@return                                                      Returns the screen space size of the text.
        ///</remarks>
        public Vector2D K2_TextSize(Font RenderFont, string RenderText, Vector2D Scale)  => 
            Canvas_methods.K2_TextSize_method.Invoke(ObjPointer, RenderFont, RenderText, Scale);
        ///<summary>Modifiable properties.</summary>
        public unsafe float OrgX {
            get {return Canvas_ptr->OrgX;}
            set {Canvas_ptr->OrgX = value;}
        }
        ///<summary>Origin for drawing in X.</summary>
        public unsafe float OrgY {
            get {return Canvas_ptr->OrgY;}
            set {Canvas_ptr->OrgY = value;}
        }
        ///<summary>Origin for drawing in Y.</summary>
        public unsafe float ClipX {
            get {return Canvas_ptr->ClipX;}
            set {Canvas_ptr->ClipX = value;}
        }
        ///<summary>Bottom right clipping region.</summary>
        public unsafe float ClipY {
            get {return Canvas_ptr->ClipY;}
            set {Canvas_ptr->ClipY = value;}
        }
        ///<summary>Bottom right clipping region.</summary>
        public unsafe Color DrawColor {
            get {return Canvas_ptr->DrawColor;}
            set {Canvas_ptr->DrawColor = value;}
        }
        public bool bCenterX {
            get {return Main.GetGetBoolPropertyByName(this, "bCenterX"); }
            set {Main.SetGetBoolPropertyByName(this, "bCenterX", value); }
        }
        public bool bCenterY {
            get {return Main.GetGetBoolPropertyByName(this, "bCenterY"); }
            set {Main.SetGetBoolPropertyByName(this, "bCenterY", value); }
        }
        public bool bNoSmooth {
            get {return Main.GetGetBoolPropertyByName(this, "bNoSmooth"); }
            set {Main.SetGetBoolPropertyByName(this, "bNoSmooth", value); }
        }
        ///<summary>Don't bilinear filter.</summary>
        public unsafe int SizeX {
            get {return Canvas_ptr->SizeX;}
            set {Canvas_ptr->SizeX = value;}
        }
        ///<summary>Zero-based actual dimensions X.</summary>
        public unsafe int SizeY {
            get {return Canvas_ptr->SizeY;}
            set {Canvas_ptr->SizeY = value;}
        }
        ///<summary>Internal.</summary>
        public unsafe Plane ColorModulate {
            get {return Canvas_ptr->ColorModulate;}
            set {Canvas_ptr->ColorModulate = value;}
        }
        ///<summary>Default Texture</summary>
        public unsafe Texture2D DefaultTexture {
            get {return Canvas_ptr->DefaultTexture;}
            set {Canvas_ptr->DefaultTexture = value;}
        }
        ///<summary>Default texture to use</summary>
        public unsafe Texture2D GradientTexture0 {
            get {return Canvas_ptr->GradientTexture0;}
            set {Canvas_ptr->GradientTexture0 = value;}
        }
        ///<summary>Helper class to render 2d graphs on canvas</summary>
        public unsafe ReporterGraph ReporterGraph {
            get {return Canvas_ptr->ReporterGraph;}
            set {Canvas_ptr->ReporterGraph = value;}
        }
        static Canvas() {
            StaticClass = Main.GetClass("Canvas");
        }
        internal unsafe Canvas_fields* Canvas_ptr => (Canvas_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator Canvas(IntPtr p) => UObject.Make<Canvas>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static Canvas DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static Canvas New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
