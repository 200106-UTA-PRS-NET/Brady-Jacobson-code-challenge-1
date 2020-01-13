using System;

namespace Challenge
{
    public class PalindromeClass
    {
        public bool checkPalindrome(string original)
        {
            //Sets up the string so that capital letters don't cause issues.
            string item = original.ToUpper();
            bool result = false;

            //Sets up which index of the string is checked at each comparison.
            int index1;
            int index2;
            index1 = 0;
            index2 = item.Length-1;

            //The for loop that's guaranteed to run through all characters of the string.
            for (int i = 0; i < item.Length; i++)
            {
                //If index1 passes index2, it shows the provided string is a palindrome.
                //We break out of the for loop and return true.
                if(index1 > index2)
                {
                    result = true;
                    break;
                }

                //If index1's value equals index2's value, the values are equal, and it's still
                //possibly a palindrome. We increment index1 and decrement index2.
                if (item[index1] == item[index2])
                {
                    index1++;
                    index2--;
                }

                //If they are not equal, we check to see if any of the values are spaces or punctuation.
                else
                {
                    //If the value of an index is not a letter or number, we increment or decrement the
                    //index and set the flag to true. 
                    bool checkFlag = false;
                    if (((int)item[index1] < 65 || (int)item[index1] > 90) && ((int)item[index1] < 48 || (int)item[index1] > 57))
                    { 
                        checkFlag = true;
                        index1++;
                    }
                    if (((int)item[index2] < 65 || (int)item[index2] > 90) && ((int)item[index2] < 48 || (int)item[index2] > 57))
                    {
                        checkFlag = true;
                        index2--;
                    }
                    //If the flag is false, the compared values are not equal and are either letters or numbers.
                    //That means it is not a palindrome and we return false after breaking.
                    if (checkFlag == false)
                    {
                        result = false;
                        break;
                    }
                }
            }
            return result;
        }
    }
}
