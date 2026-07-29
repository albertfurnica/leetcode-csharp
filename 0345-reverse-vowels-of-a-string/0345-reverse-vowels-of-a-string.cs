public class Solution {
    public string ReverseVowels(string s) 
    {
        int i = 0, j = s.Length - 1;
        char[] _c = s.ToCharArray();
while (i < j)
{
    if (s[i] is 'a' or 'e' or 'i' or 'o' or 'u' or 'A' or 'E' or 'I' or 'O' or 'U')
    {
        if (s[j] is 'a' or 'e' or 'i' or 'o' or 'u' or 'A' or 'E' or 'I' or 'O' or 'U')
        {
            char _temp = s[i];
            _c[i] = _c[j];
            _c[j] = _temp;
            
            i++;
            j--;
        }
        else
            j--;
    }
    else
        i++;
}
    s = new string(_c);
    return s;
    }
}