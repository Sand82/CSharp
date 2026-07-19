namespace Predicate
{
    public class LengthChecker
    {
        private string? stringToCheck;
        
        public LengthChecker(string? stringToCheck)
        {
            this.stringToCheck = stringToCheck;
            IntToCheck = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
        }

        public List<int> IntToCheck { get; set; }

        public bool IsStringLong( Predicate<string> stringChecker) 
            => stringChecker(stringToCheck!);        

        public bool HasStringWantedCharacter(Predicate<char> stringChecker, char character)
            => stringChecker(character);

        public bool HasWantedNumber(Predicate<int> stringChecker, int number) 
            => stringChecker(number);

        public string GetString()
        {
            return stringToCheck!;
        }
    }
}
