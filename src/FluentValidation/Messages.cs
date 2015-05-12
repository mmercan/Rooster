
namespace FluentValidation.Resources
{

    public class Messages
    {
 
        public static string CreditCardError
        {
            get { return "'{PropertyName}' is not a valid credit card number."; }
        }

        /// <summary>
        ///   Looks up a localized string similar to &apos;{PropertyName}&apos; is not a valid email address..
        /// </summary>
        public static string email_error
        {
            get
            {
                return "'{PropertyName}' is not a valid email address.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to &apos;{PropertyName}&apos; should be equal to &apos;{ComparisonValue}&apos;..
        /// </summary>
        public static string equal_error
        {
            get { return "'{PropertyName}' should be equal to '{ComparisonValue}'."; }
        }

        /// <summary>
        ///   Looks up a localized string similar to &apos;{PropertyName}&apos; must be {MaxLength} characters in length. You entered {TotalLength} characters..
        /// </summary>
        public static string exact_length_error
        {
            get
            {
                return "'{PropertyName}' must be {MaxLength} characters in length. You entered {TotalLength} characters.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to &apos;{PropertyName}&apos; must be between {From} and {To} (exclusive). You entered {Value}..
        /// </summary>
        public static string exclusivebetween_error
        {
            get { return "'{PropertyName}' must be between {From} and {To} (exclusive). You entered {Value}."; }
        }

        /// <summary>
        ///   Looks up a localized string similar to &apos;{PropertyName}&apos; must be greater than &apos;{ComparisonValue}&apos;..
        /// </summary>
        public static string greaterthan_error
        {
            get { return "'{PropertyName}' must be greater than '{ComparisonValue}'."; }
        }

        /// <summary>
        ///   Looks up a localized string similar to &apos;{PropertyName}&apos; must be greater than or equal to &apos;{ComparisonValue}&apos;..
        /// </summary>
        public static string greaterthanorequal_error
        {
            get { return "'{PropertyName}' must be greater than or equal to '{ComparisonValue}'."; }
        }

        /// <summary>
        ///   Looks up a localized string similar to &apos;{PropertyName}&apos; must be between {From} and {To}. You entered {Value}..
        /// </summary>
        public static string inclusivebetween_error
        {
            get { return "'{PropertyName}' must be between {From} and {To}. You entered {Value}."; }
        }

        /// <summary>
        ///   Looks up a localized string similar to &apos;{PropertyName}&apos; must be between {MinLength} and {MaxLength} characters. You entered {TotalLength} characters..
        /// </summary>
        public static string length_error
        {
            get
            {
                return "'{PropertyName}' must be between {MinLength} and {MaxLength} characters. You entered {TotalLength} characters.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to &apos;{PropertyName}&apos; must be less than &apos;{ComparisonValue}&apos;..
        /// </summary>
        public static string lessthan_error
        {
            get
            {
                return "'{PropertyName}' must be less than '{ComparisonValue}'.";
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to &apos;{PropertyName}&apos; must be less than or equal to &apos;{ComparisonValue}&apos;..
        /// </summary>
        public static string lessthanorequal_error
        {
            get { return "'{PropertyName}' must be less than or equal to '{ComparisonValue}'."; }
        }

        /// <summary>
        ///   Looks up a localized string similar to &apos;{PropertyName}&apos; should not be empty..
        /// </summary>
        public static string notempty_error
        {
            get { return "'{PropertyName}' should not be empty."; }
        }

        /// <summary>
        ///   Looks up a localized string similar to &apos;{PropertyName}&apos; should not be equal to &apos;{ComparisonValue}&apos;..
        /// </summary>
        public static string notequal_error
        {
            get { return "'{PropertyName}' should not be equal to '{ComparisonValue}'."; }
        }

        /// <summary>
        ///   Looks up a localized string similar to &apos;{PropertyName}&apos; must not be empty..
        /// </summary>
        public static string notnull_error
        {
            get { return "'{PropertyName}' must not be empty."; }
        }

        /// <summary>
        ///   Looks up a localized string similar to The specified condition was not met for &apos;{PropertyName}&apos;..
        /// </summary>
        public static string predicate_error
        {
            get { return "The specified condition was not met for '{PropertyName}'."; }
        }

        /// <summary>
        ///   Looks up a localized string similar to &apos;{PropertyName}&apos; is not in the correct format..
        /// </summary>
        public static string regex_error
        {
            get { return "'{PropertyName}' is not in the correct format."; }
        }

        /// <summary>
        ///   Looks up a localized string similar to &apos;{PropertyName}&apos; may not be more than {expectedPrecision} digits in total, with allowance for {expectedScale} decimals. {digits} digits and {actualScale} decimals were found..
        /// </summary>
        public static string scale_precision_error
        {
            get
            {
                return
                    "'{PropertyName}' may not be more than {expectedPrecision} digits in total, with allowance for {expectedScale} decimals. {digits} digits and {actualScale} decimals were found.";
            }
        }
    }
}
