public class EmailValidator
    {
        public static void Main(string[] args)
        {
            // Sample data array
            string[] emails = {"d@gmail.com", 
                               "x@yahoo.com" , 
                               "y@topsecret.gov" ,
                               "xyz@yahoo" , 
                               "@gmail.com" ,
                               "xxxxxgmail.com"};
            
            // Loops to go through array and validate data          
            for(int i = 0; i < emails.Length;i++)
            {
                   Validate(emails[i]);
            }
        }
        
        public static void Validate(string email)
        {
            string PATTERN = @"\S{1,}" + // Minimum of 1 non-whitespace character
                             "@" + // @ symbol
                             @"\S{1,}" + // Minimum of 1 non-whitespace character
                             @"(\.com|\.gov|\.edu|\.co|\.org){1,}$"; // Tail
            
            // New Regex object constructed with the pattern
            Regex regex = new Regex(PATTERN);
            
            // Print whether it is valid or not using ternary statement
            Console.WriteLine(regex.IsMatch(email) ? email + " is a valid email." : email + " is NOT a valid email.");
        }
        
    }
