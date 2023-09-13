
using System.Runtime.InteropServices.Marshalling;
using System.Text.RegularExpressions;

public class Sum
{
    public string sumStrings(string number1, string number2)
    {
        string result = string.Empty;

        //check if number1 and number2 strings contains only numbers
        if(!isNumber(number1)) return "Number 1 must contain only numeric characters";
        if(!isNumber(number2)) return "Number 2 must contain only numeric characters";

        //check the strings length and complete with 0 the shorter one
        int len1 = number1.Length;
        int len2 = number2.Length;
        if (len1 > len2) number2 = new string('0', len1 - len2) + number2;
        if (len2 > len1) number1 = new string('0', len2 - len1) + number1;

        //sum numbers
        char[] array1 = number1.ToCharArray();
        char[] array2 = number2.ToCharArray();
        int carry = 0;
        for (int i = array1.Length -1 ; i >= 0; i--)
        {
            //sum the 2 digtis at the i position plus the carry from previous operation
            int sum = int.Parse(array1[i].ToString()) + int.Parse(array2[i].ToString()) + carry;
            carry = 0; //reset carry
            //if the sum is > 9, then take only the right figit and carry = 1 for the next operation
            if (sum > 9) 
            {
                carry = 1;
                sum -= 10;
            }
            //add the number at the left of the result
            result = sum.ToString() + result;
        }

        //if the last sum > 9, the carry will be = 1, so it must be added to the result        
        if (carry == 1) result = carry.ToString() + result; 

        return result;
    }

    private bool isNumber(string number)
    {
        if(string.IsNullOrEmpty(number)) return false;

        foreach(char c in number)
        {            
            if(!char.IsDigit(c))
            {
                return false;
            }
        }

        return true;
    }
    
}
