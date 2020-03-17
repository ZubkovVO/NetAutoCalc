using System;
using System.Text.RegularExpressions;

public class Validation
{

public static bool isValidEquation(string inputEquation)
{
    string strRegex = @"\d+\s[*+/-]\s\d+";
    Regex re = new Regex(strRegex);
    return re.IsMatch(inputEquation);
}

}
