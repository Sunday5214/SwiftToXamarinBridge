using Foundation;

namespace SwiftToSharpBinding
{
	// @interface AlertTesterProxy : NSObject
	[BaseType (typeof(NSObject))]
	interface AlertTesterProxy
	{
		// -(BOOL)errorReadingResultsWithQuestion:(NSString * _Nonnull)question text:(NSString * _Nonnull)text __attribute__((warn_unused_result("")));
		[Export ("errorReadingResultsWithQuestion:text:")]
		bool ErrorReadingResultsWithQuestion (string question, string text);
	}
}
