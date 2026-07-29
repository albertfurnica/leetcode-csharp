public class Solution {
    public string ReverseWords(string s) {
        StringBuilder _c = new StringBuilder();
StringBuilder c = new StringBuilder();
int i = s.Length - 1;

while (i >= 0)
{
    if (s[i] != ' ')
        _c.Append(s[i]);

    if (s[i] == ' ' || i == 0)
    {
        if (_c.Length > 0)
        {
            if (c.Length > 0)
            {
                c.Append(' ');
            }

            int j = _c.Length - 1;
            while (j >= 0)
            {
                c.Append(_c[j]);
                j--;
            }

            _c.Clear();
        }
    }
    i--;
}
return c.ToString();
       
    }
}