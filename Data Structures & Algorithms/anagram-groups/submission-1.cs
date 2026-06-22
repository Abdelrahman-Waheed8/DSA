public class anagramGp {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> hashmap = new();
        char[] sorted ;
        List<List<string>> result = new();
        List<string> anagrams = new();
        List<string> sortedstrings = [];

        for(int i = 0; i< strs.Length; i++)
        {
            sorted = strs[i].ToCharArray();
            Array.Sort(sorted);
            sortedstrings.Add(new string(sorted));
            if(hashmap.ContainsKey(sortedstrings[i]))
            {
                hashmap[sortedstrings[i]].Add(strs[i]);
            }
            else
            {
                hashmap.Add(sortedstrings[i], new List<string> { strs[i]});
            }
        }

        foreach(var kvp in hashmap)
        {
            result.Add(kvp.Value);
        }
        return result;
    }
}
