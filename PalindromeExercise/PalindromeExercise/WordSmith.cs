using System;
using System.Collections.Generic;
namespace PalindromeExercise
{
	public class WordSmith
	{
      
       public bool IsAPalindrome(string word)
        {
            var reverse = "";

            for( int i = word.Length -1; i >= 0; i--)
            {
                reverse += word[i]; 
            }

            if(word == reverse)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
       


    }
}

