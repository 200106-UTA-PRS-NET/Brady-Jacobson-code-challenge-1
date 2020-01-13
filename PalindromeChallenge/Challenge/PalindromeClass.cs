using System;

namespace Challenge
{
    public class PalindromeClass
    {
        public bool checkPalindrome(string original)
        {
            string item = original.ToUpper();
            bool result = false;
            int index1;
            int index2;
            index1 = 0;
            index2 = item.Length-1;
            char aa = 'a';
            
            for (int i = 0; i < item.Length; i++)
            {
                if(index1 > index2)
                {
                    result = true;
                    break;
                }

                if (item[index1] == item[index2])
                {
                    index1++;
                    index2--;
                }
                else
                {
                    if (item[index1] == ' ' || item[index2] == ' ')
                    {
                        if (item[index1] == ' ')
                            index1++;
                        if (item[index2] == ' ')
                            index2--;
                    }
                    else
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
