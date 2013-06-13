using System;

using MonoMac.Foundation;

namespace MonoTouch.Foundation {

	[BaseType (typeof (NSObject))]
	public partial interface NSScanner : NSCopying {

		[Export ("string")]
		string String { get; }

		[Export ("scanLocation")]
		uint ScanLocation { get; set; }

		[Export ("charactersToBeSkipped")]
		NSCharacterSet CharactersToBeSkipped { set; }

		[Export ("caseSensitive")]
		bool CaseSensitive { set; }

		[Export ("locale")]
		NSObject Locale { set; }
	}

	[Category, BaseType (typeof (NSScanner))]
	public partial interface NseXtendedScannerNssCanner {

		[Export ("charactersToBeSkipped")]
		NSCharacterSet CharactersToBeSkipped { get; }

		[Export ("caseSensitive")]
		bool CaseSensitive { get; }

		[Export ("locale")]
		NSObject Locale { get; }

		[Export ("scanInt:")]
		bool ScanInt (out int value);

		[Export ("scanInteger:")]
		bool ScanInteger (out int value);

		[Export ("scanHexLongLong:")]
		bool ScanHexLongLong (out ulong result);

		[Export ("scanHexFloat:")]
		bool ScanHexFloat (out float result);

		[Export ("scanHexDouble:")]
		bool ScanHexDouble (out double result);

		[Export ("scanHexInt:")]
		bool ScanHexInt (out uint value);

		[Export ("scanLongLong:")]
		bool ScanLongLong (out long value);

		[Export ("scanFloat:")]
		bool ScanFloat (out float value);

		[Export ("scanDouble:")]
		bool ScanDouble (out double value);

		[Export ("scanString:intoString:")]
		bool ScanString (string str, out string value);

		[Export ("scanCharactersFromSet:intoString:")]
		bool ScanCharactersFromSet (NSCharacterSet set, out string value);

		[Export ("scanUpToString:intoString:")]
		bool ScanUpToString (string string, out string value);

		[Export ("scanUpToCharactersFromSet:intoString:")]
		bool ScanUpToCharactersFromSet (NSCharacterSet set, out string value);

		[Export ("isAtEnd")]
		bool IsAtEnd { get; }

		[Export ("initWithString:")]
		IntPtr Constructor (string str);

		[Static, Export ("scannerWithString:")]
		NSObject ScannerWithString (string str);

		[Static, Export ("localizedScannerWithString:")]
		NSObject LocalizedScannerWithString (string string);
	}
}
