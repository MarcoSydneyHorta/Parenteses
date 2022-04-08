using System;
using System.Collections.Generic;
using System.Text;

namespace Parenteses
{
    class Solution
    {

        public bool IsValid(string s)
        {

            int tam = s.Length;
            int[] num = new int[tam];
            bool val;
            
            val = ConverteNumero(s, num); // Translate string s to int[] num
           
            if (val == true)
            {
                for (int i = 0; i < tam; i++)
                {
                    if (i < (tam / 2))
                    {
                        if (num[i + 1] % 2 == 0)
                        {
                            if (num[i + 1] == num[i] + 1)
                                val = true;
                            else
                            {
                                val = false;
                                break;
                            }
                        }
                        else
                        {
                            val = true;
                        }
                    }
                    else
                    {
                        if (num[i] % 2 == 0)
                        {
                            if (num[i] == num[i - 1] + 1)
                                val = true;
                            else if (num[i] == num[tam - i - 1] + 1)
                                val = true;
                            else
                            {
                                val = false;
                                break;
                            }
                        }
                        else
                        {
                            val = true;
                        }
                    }
                }
            }
            return val;           
        }

        public bool ConverteNumero(string s, int[] ss)
        {
            
            int tam = s.Length;
            char c;
            bool valid = false;
            if (tam <= 104) // Restricted by client
            {
                valid = true;
                for (int i = 0; i < tam; i++) // Transfers each character to the respective number
                {
                    c = s[i];
                    switch (c)
                    {
                        case '(':
                            ss[i] = 1;
                            break;
                        case ')':
                            ss[i] = 2;
                            break;
                        case '{':
                            ss[i] = 3;
                            break;
                        case '}':
                            ss[i] = 4;
                            break;
                        case '[':
                            ss[i] = 5;
                            break;
                        case ']':
                            ss[i] = 6;
                            break;
                        default:
                            valid = false; // Invalid character
                            break;
                    }
                }
            }
            return valid;
        }
    }
    
}
