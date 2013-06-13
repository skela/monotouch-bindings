using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.ObjCRuntime;
using MonoTouch.CoreGraphics;
using MonoTouch.CoreAnimation;

namespace SVGKit {





	[BaseType (typeof (NSObject))]
	public partial interface SVGDocument {

		[Export ("title")]
		string Title { get; set; }

		[Export ("referrer")]
		string Referrer { get; set; }

		[Export ("domain")]
		string Domain { get; set; }

		[Export ("URL")]
		string Url { get; set; }

		[Export ("rootElement")]
		int RootElement { get; set; }

		[Export ("init")]
		IntPtr Constructor ();
	}

	[BaseType (typeof (NSObject))]
	public partial interface SVGElementInstance {

		[Export ("correspondingElement")]
		int CorrespondingElement { get; }

		[Export ("correspondingUseElement")]
		SVGUseElement CorrespondingUseElement { get; }

		[Export ("parentNode")]
		SVGElementInstance ParentNode { get; }

		[Export ("childNodes")]
		SVGElementInstanceList ChildNodes { get; }

		[Export ("firstChild")]
		SVGElementInstance FirstChild { get; }

		[Export ("lastChild")]
		SVGElementInstance LastChild { get; }

		[Export ("previousSibling")]
		SVGElementInstance PreviousSibling { get; }

		[Export ("nextSibling")]
		SVGElementInstance NextSibling { get; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface SVGElementInstanceList {

		[Export ("length")]
		uint Length { get; }

		[Export ("item:")]
		SVGElementInstance Item (uint index);

		[Export ("internalArray")]
		int InternalArray { get; set; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface SVGFitToViewBox {

		[Export ("viewBox")]
		RectangleF ViewBox { get; set; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface SVGHelperUtilities {

		[Static, Export ("transformRelativeIncludingViewportForTransformableOrViewportEstablishingElement:")]
		CGAffineTransform TransformRelativeIncludingViewportForTransformableOrViewportEstablishingElement (NSObject transformableOrSVGSVGElement);

		[Static, Export ("transformAbsoluteIncludingViewportForTransformableOrViewportEstablishingElement:")]
		CGAffineTransform TransformAbsoluteIncludingViewportForTransformableOrViewportEstablishingElement (NSObject transformableOrSVGSVGElement);

		[Static, Export ("configureCALayer:usingElement:")]
		void ConfigureCalAyer (CALayer layer, NSObject nonStylableElement);

		[Static, Export ("newCALayerForPathBasedSVGElement:withPath:")]
		CALayer NewCalAyerForPathBasedSvgeLement (NSObject svgElement, CGPath path);
	}


	[BaseType (typeof (NSObject))]
	public partial interface SVGLength {

		[Export ("unitType")]
		SVG_LENGTH_TYPE UnitType { get; }

		[Export ("value")]
		float Value { get; set; }

		[Export ("valueInSpecifiedUnits")]
		float ValueInSpecifiedUnits { get; set; }

		[Export ("valueAsString")]
		string ValueAsString { get; set; }

		[Export ("newValueSpecifiedUnits:valueInSpecifiedUnits:")]
		void NewValueSpecifiedUnits (SVG_LENGTH_TYPE unitType, float valueInSpecifiedUnits);

		[Export ("convertToSpecifiedUnits:")]
		void ConvertToSpecifiedUnits (SVG_LENGTH_TYPE unitType);

		[Export ("svgLengthZero")]
		SVGLength SvgLengthZero { get; }

		[Static, Export ("svgLengthFromNSString:")]
		SVGLength SvgLengthFromNssTring (string s);

		[Export ("pixelsValue")]
		float PixelsValue { get; }

		[Export ("numberValue")]
		float NumberValue { get; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface SVGMatrix {

		[Export ("a")]
		float A { get; set; }

		[Export ("b")]
		float B { get; set; }

		[Export ("c")]
		float C { get; set; }

		[Export ("d")]
		float D { get; set; }

		[Export ("e")]
		float E { get; set; }

		[Export ("f")]
		float F { get; set; }

		[Export ("multiply:")]
		SVGMatrix Multiply (SVGMatrix secondMatrix);

		[Export ("inverse")]
		SVGMatrix Inverse { get; }

		[Export ("translate:y:")]
		SVGMatrix Translate (float x, float y);

		[Export ("scale:")]
		SVGMatrix Scale (float scaleFactor);

		[Export ("scaleNonUniform:scaleFactorY:")]
		SVGMatrix ScaleNonUniform (float scaleFactorX, float scaleFactorY);

		[Export ("rotate:")]
		SVGMatrix Rotate (float angle);

		[Export ("rotateFromVector:y:")]
		SVGMatrix RotateFromVector (float x, float y);

		[Export ("flipX")]
		SVGMatrix FlipX { get; }

		[Export ("flipY")]
		SVGMatrix FlipY { get; }

		[Export ("skewX:")]
		SVGMatrix SkewX (float angle);

		[Export ("skewY:")]
		SVGMatrix SkewY (float angle);
	}

	[BaseType (typeof (NSObject))]
	public partial interface SVGPoint {

		[Export ("x")]
		float X { get; }

		[Export ("y")]
		float Y { get; }

		[Export ("matrixTransform:")]
		SVGPoint MatrixTransform (SVGMatrix matrix);
	}

	[BaseType (typeof (NSObject))]
	public partial interface SVGStylable   {

		[Export ("className")]
		string ClassName { get; set; }

		[Export ("style")]
		int Style { get; set; }

		[Export ("getPresentationAttribute:")]
		NSObject GetPresentationAttribute (string name);
	}

	public enum SvglEngthAdjust {
		SVGLengthAdjustUnknown = 0,
		SVGLengthAdjustSpacing = 1,
		SVGLengthAdjustSpacingAndGlyphs = 2
	}

	public partial interface SvgtExtContentElement : SVGStylable {

		[Export ("textLength")]
		SVGLength TextLength { get; }
	}

	[BaseType (typeof (SVGTextContentElement))]
	public partial interface SvgtExtPositioningElement {

		[Export ("x")]
		SVGLength X { get; }

		[Export ("y")]
		SVGLength Y { get; }

		[Export ("dx")]
		SVGLength Dx { get; }

		[Export ("dy")]
		SVGLength Dy { get; }

		[Export ("rotate")]
		SVGLength Rotate { get; }
	}

	[Category, BaseType (typeof (SVGTextPositioningElement))]
	public partial interface SVGTextPositioningElement {

		[Export ("x")]
		SVGLength X { get; set; }

		[Export ("y")]
		SVGLength Y { get; set; }

		[Export ("dx")]
		SVGLength Dx { get; set; }

		[Export ("dy")]
		SVGLength Dy { get; set; }

		[Export ("rotate")]
		SVGLength Rotate { get; set; }
	}



	[BaseType (typeof (NSObject))]
	public partial interface SVGTransformable  {

		[Export ("transform")]
		CGAffineTransform Transform { get; set; }
	}

	public partial interface SVGUseElement : SVGTransformable {

		[Export ("x")]
		SVGLength X { get; }

		[Export ("y")]
		SVGLength Y { get; }

		[Export ("width")]
		SVGLength Width { get; }

		[Export ("height")]
		SVGLength Height { get; }

		[Export ("instanceRoot")]
		SVGElementInstance InstanceRoot { get; }

		[Export ("animatedInstanceRoot")]
		SVGElementInstance AnimatedInstanceRoot { get; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface SVGViewSpec {

		[Export ("viewTarget")]
		SVGElement ViewTarget { get; }

		[Export ("viewBoxString")]
		string ViewBoxString { get; }

		[Export ("preserveAspectRatioString")]
		string PreserveAspectRatioString { get; }

		[Export ("transformString")]
		string TransformString { get; }

		[Export ("viewTargetString")]
		string ViewTargetString { get; }
	}

	[BaseType (typeof (SVGElement))]
	public partial interface BaseClassForAllSVGBasicShapes : SVGLayeredElement {

		[Export ("pathForShapeInRelativeCoords")]
		CGPath PathForShapeInRelativeCoords { get; }
	}

	[BaseType (typeof (SVGEllipseElement))]
	public partial interface SvgcIrcleElement {

		[Export ("r")]
		float R { get; }
	}

	public partial interface SVGElement {

		[Export ("identifier")]
		string Identifier { get; set; }

		[Export ("xmlbase")]
		string Xmlbase { get; set; }

		[Export ("rootOfCurrentDocumentFragment")]
		SVGElement RootOfCurrentDocumentFragment { get; set; }

		[Export ("viewportElement")]
		SVGElement ViewportElement { get; set; }

		[Export ("initWithLocalName:attributes:")]
		IntPtr Constructor (string n, NSMutableDictionary attributes);

		[Export ("initWithQualifiedName:inNameSpaceURI:attributes:")]
		IntPtr Constructor (string n, string nsURI, NSMutableDictionary attributes);

		[Export ("reCalculateAndSetViewportElementReferenceUsingFirstSVGAncestor:")]
		void ReCalculateAndSetViewportElementReferenceUsingFirstSvgaNcestor (SVGElement firstAncestor);

		[Export ("getAttributeAsSVGLength:")]
		NSObject GetAttributeAsSvglEngth (string attributeName);

		[Export ("cascadedValueForStylableProperty:")]
		string CascadedValueForStylableProperty (string stylableProperty);
	}

	[Category, BaseType (typeof (SVGElement))]
	public partial interface SVGElement {

		[Export ("shouldStoreContent")]
		bool ShouldStoreContent { get; }

		[Export ("loadDefaults")]
		void LoadDefaults ();

		[Export ("postProcessAttributesAddingErrorsTo:")]
		void PostProcessAttributesAddingErrorsTo (NSObject parseResult);
	}

	[BaseType (typeof (BaseClassForAllSVGBasicShapes))]
	public partial interface SvgeLlipseElement {

		[Export ("cx")]
		float Cx { get; }

		[Export ("cy")]
		float Cy { get; }

		[Export ("rx")]
		float Rx { get; }

		[Export ("ry")]
		float Ry { get; }
	}

	[BaseType (typeof (SVGElement))]
	public partial interface SvggRadientElement {

		[Export ("stops")]
		NSObject [] Stops { get; }

		[Export ("addStop:")]
		void AddStop (SVGGradientStop gradientStop);

		[Export ("newGradientLayerForObjectRect:viewportRect:")]
		CAGradientLayer NewGradientLayerForObjectRect (RectangleF objectRect, RectangleF viewportRect);
	}

	[BaseType (typeof (SVGElement))]
	public partial interface SVGGradientStop {

		[Export ("offset")]
		float Offset { get; }

		[Export ("stopOpacity")]
		float StopOpacity { get; }

		[Export ("stopColor")]
		int StopColor { get; }
	}

	[BaseType (typeof (SVGElement))]
	public partial interface SvggRoupElement : SVGLayeredElement {

		[Export ("opacity")]
		float Opacity { get; }
	}

	[BaseType (typeof (SVGElement))]
	public partial interface SvgiMageElement {

		[Export ("x")]
		float X { get; }

		[Export ("y")]
		float Y { get; }

		[Export ("width")]
		float Width { get; }

		[Export ("height")]
		float Height { get; }

		[Export ("href")]
		string Href { get; }
	}

	[BaseType (typeof (SVGElement))]
	public partial interface SVGLayeredElement
	{

		[Export ("newLayer")]
		CALayer NewLayer { get; }

		[Export ("layoutLayer:")]
		void LayoutLayer (CALayer layer);
	}

	[BaseType (typeof (BaseClassForAllSVGBasicShapes))]
	public partial interface SvglIneElement {

		[Export ("x1")]
		float X1 { get; }

		[Export ("y1")]
		float Y1 { get; }

		[Export ("x2")]
		float X2 { get; }

		[Export ("y2")]
		float Y2 { get; }
	}

	[BaseType (typeof (BaseClassForAllSVGBasicShapes))]
	public partial interface SvgrEctElement {

		[Export ("x")]
		int X { get; }

		[Export ("y")]
		int Y { get; }

		[Export ("width")]
		int Width { get; }

		[Export ("height")]
		int Height { get; }

		[Export ("rx")]
		int Rx { get; }

		[Export ("ry")]
		int Ry { get; }
	}

	[BaseType (typeof (SVGElement))]
	public partial interface SvgsvgeLement : SVGLayeredElement {

		[Export ("x")]
		int X { get; }

		[Export ("y")]
		int Y { get; }

		[Export ("width")]
		int Width { get; }

		[Export ("height")]
		int Height { get; }

		[Export ("contentScriptType")]
		string ContentScriptType { get; }

		[Export ("contentStyleType")]
		string ContentStyleType { get; }

		[Export ("viewport")]
		int Viewport { get; }

		[Export ("pixelUnitToMillimeterX")]
		float PixelUnitToMillimeterX { get; }

		[Export ("pixelUnitToMillimeterY")]
		float PixelUnitToMillimeterY { get; }

		[Export ("screenPixelToMillimeterX")]
		float ScreenPixelToMillimeterX { get; }

		[Export ("screenPixelToMillimeterY")]
		float ScreenPixelToMillimeterY { get; }

		[Export ("useCurrentView")]
		bool UseCurrentView { get; }

		[Export ("currentView")]
		int CurrentView { get; }

		[Export ("currentScale")]
		float CurrentScale { get; }

		[Export ("currentTranslate")]
		int CurrentTranslate { get; }

		[Export ("suspendRedraw:")]
		int SuspendRedraw (int maxWaitMilliseconds);

		[Export ("unsuspendRedraw:")]
		void UnsuspendRedraw (int suspendHandleID);

		[Export ("unsuspendRedrawAll")]
		void UnsuspendRedrawAll ();

		[Export ("forceRedraw")]
		void ForceRedraw ();

		[Export ("pauseAnimations")]
		void PauseAnimations ();

		[Export ("unpauseAnimations")]
		void UnpauseAnimations ();

		[Export ("animationsPaused")]
		bool AnimationsPaused { get; }

		[Export ("getCurrentTime")]
		float GetCurrentTime { get; }

		[Export ("currentTime")]
		float CurrentTime { set; }

		[Export ("getIntersectionList:referenceElement:")]
		NSObject GetIntersectionList (NSObject rect, SVGElement referenceElement);

		[Export ("getEnclosureList:referenceElement:")]
		NSObject GetEnclosureList (NSObject rect, SVGElement referenceElement);

		[Export ("checkIntersection:rect:")]
		bool CheckIntersection (SVGElement element, NSObject rect);

		[Export ("checkEnclosure:rect:")]
		bool CheckEnclosure (SVGElement element, NSObject rect);

		[Export ("deselectAll")]
		void DeselectAll ();

		[Export ("createSVGNumber")]
		NSObject CreateSvgnUmber { get; }

		[Export ("createSVGLength")]
		NSObject CreateSvglEngth { get; }

		[Export ("createSVGAngle")]
		NSObject CreateSvgaNgle { get; }

		[Export ("createSVGPoint")]
		NSObject CreateSvgpOint { get; }

		[Export ("createSVGMatrix")]
		NSObject CreateSvgmAtrix { get; }

		[Export ("createSVGRect")]
		NSObject CreateSvgrEct { get; }

		[Export ("createSVGTransform")]
		NSObject CreateSvgtRansform { get; }

		[Export ("createSVGTransformFromMatrix:")]
		NSObject CreateSvgtRansformFromMatrix (NSObject matrix);

		[Export ("getElementById:")]
		NSObject GetElementById (string elementId);

		[Export ("findFirstElementOfClass:")]
		SVGElement FindFirstElementOfClass (Class classe);
	}

	[Model]
	public partial interface SvgsTyleCatcher {

		[Export ("styleCatchLayer:forClass:")]
		void StyleCatchLayer (NSObject styledLayer, NSObject colorIndex);
	}

	[BaseType (typeof (NSObject))]
	public partial interface CALayerExporter {

		[Export ("rootView")]
		UIView RootView { get; set; }

		[Export ("delegate")]
		CALayerExporterDelegate Delegate { get; set; }

		[Export ("initWithView:")]
		CALayerExporter InitWithView (UIView v);

		[Export ("startExport")]
		void StartExport ();
	}

	[BaseType (typeof (NSObject))]
	public partial interface CALayerExporterDelegate  {

		[Export ("layerExporter:didParseLayer:withStatement:")]
		void LayerExporter (CALayerExporter exporter, CALayer layer, string statement);

		[Export ("layerExporterDidFinish:")]
		void LayerExporterDidFinish (CALayerExporter exporter);
	}

	[BaseType (typeof (NSObject))]
	public partial interface SVGKParseResult {

		[Export ("warnings")]
		NSMutableArray Warnings { get; set; }

		[Export ("errorsRecoverable")]
		NSMutableArray ErrorsRecoverable { get; set; }

		[Export ("errorsFatal")]
		NSMutableArray ErrorsFatal { get; set; }

		[Export ("libXMLFailed")]
		bool LibXmlfAiled { get; set; }

		[Export ("rootOfSVGTree")]
		SVGElement RootOfSvgtRee { get; set; }

		[Export ("parsedDocument")]
		SVGDocument ParsedDocument { get; set; }

		[Export ("namespacesEncountered")]
		NSMutableDictionary NamespacesEncountered { get; set; }

		[Export ("addSourceError:")]
		void AddSourceError (NSError fatalError);

		[Export ("addParseWarning:")]
		void AddParseWarning (NSError warning);

		[Export ("addParseErrorRecoverable:")]
		void AddParseErrorRecoverable (NSError recoverableError);

		[Export ("addParseErrorFatal:")]
		void AddParseErrorFatal (NSError fatalError);

		[Export ("addSAXError:")]
		void AddSaxeRror (NSError saxError);
	}

	[BaseType (typeof (NSObject))]
	public partial interface SvgkpArser {

		[Export ("source")]
		int Source { get; }

		[Export ("currentParseRun")]
		SVGKParseResult CurrentParseRun { get; }

		[Export ("parserExtensions")]
		NSMutableArray ParserExtensions { get; set; }

		[Export ("parserKnownNamespaces")]
		NSMutableDictionary ParserKnownNamespaces { get; set; }

		[Static, Export ("parseSourceUsingDefaultSVGKParser:")]
		SVGKParseResult ParseSourceUsingDefaultSvgkpArser (NSObject source);

		[Export ("parseSynchronously")]
		SVGKParseResult ParseSynchronously { get; }

		[Static, Export ("NSDictionaryFromCSSAttributes:")]
		NSDictionary NsdIctionaryFromCssaTtributes (NSObject styleAttribute);

		[Export ("initWithSource:")]
		IntPtr Constructor (NSObject doc);

		[Export ("addDefaultSVGParserExtensions")]
		void AddDefaultSvgpArserExtensions ();

		[Export ("addParserExtension:")]
		void AddParserExtension (SVGKParserExtension extension);
	}

	[Category,BaseType (typeof (NSObject))]
	public partial interface SVGKParserExtension  {

		[Export ("supportedNamespaces")]
		NSObject [] SupportedNamespaces { get; }

		[Export ("supportedTags")]
		NSObject [] SupportedTags { get; }

		[Export ("handleStartElement:document:namePrefix:namespaceURI:attributes:parseResult:parentNode:")]
		NSObject HandleStartElement (string name, NSObject document, string prefix, string XMLNSURI, NSMutableDictionary attributes, SVGKParseResult parseResult, NSObject parentNode);

		[Export ("handleEndElement:document:parseResult:")]
		void HandleEndElement (NSObject newNode, NSObject document, SVGKParseResult parseResult);
	}

	[BaseType (typeof (NSObject))]
	public partial interface SvgkpOintsAndPathsParser {

		[Static, Export ("readWhitespace:")]
		void ReadWhitespace (NSScanner scanner);

		[Static, Export ("readCommaAndWhitespace:")]
		void ReadCommaAndWhitespace (NSScanner scanner);

		[Static, Export ("readCoordinate:")]
		float ReadCoordinate (NSScanner scanner);

		[Static, Export ("readCoordinatePair:")]
		PointF ReadCoordinatePair (NSScanner scanner);

		[Static, Export ("readMovetoDrawtoCommandGroups:path:relativeTo:isRelative:")]
		PointF ReadMovetoDrawtoCommandGroups (NSScanner scanner, CGMutablePathRef path, PointF origin, bool isRelative);

		[Static, Export ("readMovetoDrawtoCommandGroup:path:relativeTo:isRelative:")]
		PointF ReadMovetoDrawtoCommandGroup (NSScanner scanner, CGMutablePathRef path, PointF origin, bool isRelative);

		[Static, Export ("readMovetoDrawto:path:relativeTo:isRelative:")]
		PointF ReadMovetoDrawto (NSScanner scanner, CGMutablePathRef path, PointF origin, bool isRelative);

		[Static, Export ("readMoveto:path:relativeTo:isRelative:")]
		PointF ReadMoveto (NSScanner scanner, CGMutablePathRef path, PointF origin, bool isRelative);

		[Static, Export ("readMovetoArgumentSequence:path:relativeTo:isRelative:")]
		PointF ReadMovetoArgumentSequence (NSScanner scanner, CGMutablePathRef path, PointF origin, bool isRelative);

		[Static, Export ("readLinetoCommand:path:relativeTo:isRelative:")]
		PointF ReadLinetoCommand (NSScanner scanner, CGMutablePathRef path, PointF origin, bool isRelative);

		[Static, Export ("readLinetoArgumentSequence:path:relativeTo:isRelative:")]
		PointF ReadLinetoArgumentSequence (NSScanner scanner, CGMutablePathRef path, PointF origin, bool isRelative);

		[Static, Export ("readVerticalLinetoCommand:path:relativeTo:")]
		PointF ReadVerticalLinetoCommand (NSScanner scanner, CGMutablePathRef path, PointF origin);

		[Static, Export ("readVerticalLinetoArgumentSequence:path:relativeTo:")]
		PointF ReadVerticalLinetoArgumentSequence (NSScanner scanner, CGMutablePathRef path, PointF origin);

		[Static, Export ("readHorizontalLinetoArgumentSequence:path:relativeTo:")]
		PointF ReadHorizontalLinetoArgumentSequence (NSScanner scanner, CGMutablePathRef path, PointF origin);

		[Static, Export ("readHorizontalLinetoCommand:path:relativeTo:")]
		PointF ReadHorizontalLinetoCommand (NSScanner scanner, CGMutablePathRef path, PointF origin);

		[Static, Export ("readQuadraticCurvetoCommand:path:relativeTo:isRelative:")]
		SVGCurve ReadQuadraticCurvetoCommand (NSScanner scanner, CGMutablePathRef path, PointF origin, bool isRelative);

		[Static, Export ("readQuadraticCurvetoArgumentSequence:path:relativeTo:isRelative:")]
		SVGCurve ReadQuadraticCurvetoArgumentSequence (NSScanner scanner, CGMutablePathRef path, PointF origin, bool isRelative);

		[Static, Export ("readQuadraticCurvetoArgument:path:relativeTo:")]
		SVGCurve ReadQuadraticCurvetoArgument (NSScanner scanner, CGMutablePathRef path, PointF origin);

		[Static, Export ("readCurvetoCommand:path:relativeTo:isRelative:")]
		SVGCurve ReadCurvetoCommand (NSScanner scanner, CGMutablePathRef path, PointF origin, bool isRelative);

		[Static, Export ("readCurvetoArgumentSequence:path:relativeTo:isRelative:")]
		SVGCurve ReadCurvetoArgumentSequence (NSScanner scanner, CGMutablePathRef path, PointF origin, bool isRelative);

		[Static, Export ("readCurvetoArgument:path:relativeTo:")]
		SVGCurve ReadCurvetoArgument (NSScanner scanner, CGMutablePathRef path, PointF origin);

		[Static, Export ("readSmoothCurvetoCommand:path:relativeTo:withPrevCurve:")]
		SVGCurve ReadSmoothCurvetoCommand (NSScanner scanner, CGMutablePathRef path, PointF origin, SVGCurve prevCurve);

		[Static, Export ("readSmoothCurvetoArgumentSequence:path:relativeTo:withPrevCurve:")]
		SVGCurve ReadSmoothCurvetoArgumentSequence (NSScanner scanner, CGMutablePathRef path, PointF origin, SVGCurve prevCurve);

		[Static, Export ("readSmoothCurvetoArgument:path:relativeTo:withPrevCurve:")]
		SVGCurve ReadSmoothCurvetoArgument (NSScanner scanner, CGMutablePathRef path, PointF origin, SVGCurve prevCurve);

		[Static, Export ("readCloseCommand:path:relativeTo:")]
		PointF ReadCloseCommand (NSScanner scanner, CGMutablePathRef path, PointF origin);
	}

	[BaseType (typeof (CALayer))]
	public partial interface SVGKLayer {

		[Export ("SVGImage")]
		int SVGImage { get; set; }

		[Export ("showBorder")]
		bool ShowBorder { get; set; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface SVGKImage {

		[Export ("UIImage")]
		UIImage UiiMage { get; }

		[Export ("source")]
		SVGKSource Source { get; }

		[Export ("parseErrorsAndWarnings")]
		int ParseErrorsAndWarnings { get; }

		[Export ("DOMDocument")]
		int DomdOcument { get; }

		[Export ("DOMTree")]
		int DomtRee { get; }

		[Export ("CALayerTree")]
		CALayer CalAyerTree { get; }

		[Export ("nameUsedToInstantiate")]
		string NameUsedToInstantiate { get; }

		[Static, Export ("imageNamed:")]
		SVGKImage ImageNamed (string name);

		[Static, Export ("imageWithContentsOfFile:")]
		SVGKImage ImageWithContentsOfFile (string path);

		[Static, Export ("imageWithData:")]
		SVGKImage ImageWithData (NSData data);

		[Static, Export ("imageWithSource:")]
		SVGKImage ImageWithSource (SVGKSource newSource);

		[Export ("initWithContentsOfFile:")]
		IntPtr Constructor (string path);

		[Export ("initWithData:")]
		IntPtr Constructor (NSData data);

		[Export ("size")]
		SizeF Size { get; set; }

		[Export ("drawAtPoint:")]
		void DrawAtPoint (PointF point);

		[Export ("scale")]
		float Scale { get; }

		[Export ("drawAtPoint:blendMode:alpha:")]
		void DrawAtPoint (PointF point, CGBlendMode blendMode, float alpha);

		[Export ("drawInRect:")]
		void DrawInRect (RectangleF rect);

		[Export ("drawInRect:blendMode:alpha:")]
		void DrawInRect (RectangleF rect, CGBlendMode blendMode, float alpha);

		[Export ("drawAsPatternInRect:")]
		void DrawAsPatternInRect (RectangleF rect);

		[Static, Export ("animatedImageNamed:duration:")]
		UIImage AnimatedImageNamed (string name, double duration);

		[Static, Export ("animatedResizableImageNamed:capInsets:duration:")]
		UIImage AnimatedResizableImageNamed (string name, UIEdgeInsets capInsets, double duration);

		[Static, Export ("animatedImageWithImages:duration:")]
		UIImage AnimatedImageWithImages (NSObject [] images, double duration);

		[Static, Export ("imageWithContentsOfURL:")]
		SVGKImage ImageWithContentsOfUrl (NSUrl url);

		[Export ("initWithSource:")]
		IntPtr Constructor (SVGKSource source);

		[Export ("initWithParsedSVG:")]
		IntPtr Constructor (NSObject parseResult);

		[Export ("newCALayerTree")]
		CALayer NewCalAyerTree { get; }

		[Export ("layerWithIdentifier:")]
		CALayer LayerWithIdentifier (string identifier);

		[Export ("layerWithIdentifier:layer:")]
		CALayer LayerWithIdentifier (string identifier, CALayer layer);

		[Export ("newCopyPositionedAbsoluteLayerWithIdentifier:")]
		CALayer NewCopyPositionedAbsoluteLayerWithIdentifier (string identifier);

		[Export ("newCopyPositionedAbsoluteOfLayer:")]
		CALayer NewCopyPositionedAbsoluteOfLayer (CALayer originalLayer);

		[Export ("dictionaryOfLayers")]
		NSDictionary DictionaryOfLayers { get; }

		[Export ("exportUIImageAntiAliased:curveFlatnessFactor:interpolationQuality:")]
		UIImage ExportUiiMageAntiAliased (bool shouldAntialias, float multiplyFlatness, CGInterpolationQuality interpolationQuality);

		[Export ("exportNSDataAntiAliased:curveFlatnessFactor:interpolationQuality:flipYaxis:")]
		NSData ExportNsdAtaAntiAliased (bool shouldAntialias, float multiplyFlatness, CGInterpolationQuality interpolationQuality, bool flipYaxis);

		[Export ("scaleToFitInside:")]
		void ScaleToFitInside (SizeF maxSize);
	}

	[BaseType (typeof (NSObject))]
	public partial interface SVGKSource {

		[Export ("svgLanguageVersion")]
		string SvgLanguageVersion { get; set; }

		[Export ("filePath")]
		string FilePath { get; set; }

		[Export ("URL")]
		NSUrl Url { get; set; }

		[Export ("stream")]
		NSInputStream Stream { get; set; }

		[Static, Export ("sourceFromFilename:")]
		SVGKSource SourceFromFileName (string p);

		[Static, Export ("sourceFromURL:")]
		SVGKSource SourceFromUrl (NSUrl u);

		[Static, Export ("sourceFromData:")]
		SVGKSource SourceFromData (NSData data);

		[Export ("initWithInputSteam:")]
		IntPtr Constructor (NSInputStream stream);
	}

	[Category, BaseType (typeof (NSCharacterSet))]
	public partial interface SvgkeXtensionsNscHaracterSet {

		[Export ("SVGWhitespaceCharacterSet")]
		NSCharacterSet SvgwHitespaceCharacterSet { get; }
	}

	[BaseType (typeof (SVGKImageView))]
	public partial interface SvgkfAstImageView {

		[Export ("tileRatio")]
		SizeF TileRatio { get; set; }

		[Export ("disableAutoRedrawAtHighestResolution")]
		bool DisableAutoRedrawAtHighestResolution { get; set; }

		[Static, Export ("svgImageHasNoGradients:")]
		bool SvgImageHasNoGradients (NSObject image);

		[Static, Export ("svgElementAndDescendentsHaveNoGradients:")]
		bool SvgElementAndDescendentsHaveNoGradients (NSObject element);
	}

	[BaseType (typeof (UIView))]
	public partial interface SvgkiMageView {

		[Export ("image")]
		int Image { get; set; }

		[Export ("showBorder")]
		bool ShowBorder { get; set; }

		[Export ("initWithSVGKImage:")]
		IntPtr Constructor (NSObject im);
	}

	[BaseType (typeof (NSObject))]
	public partial interface SVGKPattern {

		[Static, Export ("patternWithUIColor:")]
		SVGKPattern PatternWithUicOlor (UIColor color);

		[Static, Export ("patternWithImage:")]
		SVGKPattern PatternWithImage (UIImage image);

		[Export ("color")]
		UIColor Color { get; set; }

		[Export ("CGColor")]
		CGColor CgcOlor { get; }
	}
}
