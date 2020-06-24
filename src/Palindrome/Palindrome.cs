using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palindrome
{
    /// <summary>
    ///     Palindrome class is responsible for determining if an input is equal to a palindrome. 
    /// </summary>
    public class Palindrome
    {
        #region Methods

        /// <summary>
        ///     Is valid checks if a string (word or phrase) input is truely a palindrome.
        /// </summary>
        /// <param name="input">The input to validate.</param>
        /// <returns>If the input is a valid palindrome.</returns>
        public bool IsValid(string input)
        {
            string inputWithNoPunctuation = "";
            var sb = new StringBuilder();
            char[] punctuation = { '.', ',', ' ', '-', '(', ')', '!', '\'', '?', '`' };
            var reversedInput = "";


            if (input is null)
            {
                return false; 
            }

            //Take each character, if it is not found to be punctuation append it to the stringBuilder
            foreach (char atIndex in input)
            {
                if (!punctuation.Contains(atIndex))
                {
                    sb.Append(atIndex);
                }

            }

            // Set the new reformed input from string builder into a new variable inputWithNoPuncuation
           inputWithNoPunctuation = sb.ToString().ToLower();

           
           
                               
           for(int i = inputWithNoPunctuation.Length - 1; i >= 0; i--){
                reversedInput += inputWithNoPunctuation[i];
            }
           
            if (reversedInput.Equals(inputWithNoPunctuation)){
                return true; 
            }

            return false;
        }
        
        
        #endregion
    }
}
