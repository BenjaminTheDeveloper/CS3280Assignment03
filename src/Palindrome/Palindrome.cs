namespace Palindrome
{
    /// <summary>
    ///     Palindrome class is responsible for determining if an input is equal to a palindrome. 
    /// </summary>
    public class Palindrome
    {
        #region Methods

        /// <summary>
        ///     Is valid checks if a string (word or phrase) input is truely a panindrome.
        /// </summary>
        /// <param name="input">The input to validate.</param>
        /// <returns>If the input is a valid palindrome.</returns>
        public bool IsValid(string input)
        {
            var reversedInput = ""; 
                               
           for(int i = input.Length - 1; i >= 0; i--){
                reversedInput += input[i];
            }

            if(reversedInput.Equals(input)){
                return true; 
            }

            return false;
        }

        #endregion
    }
}
