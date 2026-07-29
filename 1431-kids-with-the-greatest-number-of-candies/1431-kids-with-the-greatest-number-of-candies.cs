public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        if (candies.Length < 2 || candies.Length > 100 || extraCandies < 1 || extraCandies > 50)
            throw new ArgumentException("Introduce correct data!");
        int n = candies.Length;
        int maxi = candies.Max();
        IList<bool> _result = new List<bool>();
        for (int i = 0; i < n; i++)
        {
            if (candies[i] + extraCandies >= maxi)
                _result.Add(true);
            else
                _result.Add(false);
        }

        return _result;
    }
}