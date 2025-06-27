public class Solution {

    public int RomanToInt(string s) {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        dict.Add('I', 1);
        dict.Add('V', 5);
        dict.Add('X', 10);
        dict.Add('L', 50);
        dict.Add('C', 100);
        dict.Add('D', 500);
        dict.Add('M', 1000);

        var chars = s.ToCharArray(); 
        int total = 0;
       
        for (int i = 0; i < chars.Length; i++) {
            var index = chars[i];

            if (i == chars.Length -1){
                total += dict[index];
                break;
            }

            var peek = chars[i + 1];

            if (dict[index] < dict[peek]) {
                total -= dict[index];
            } else {
                total += dict[index];
            }
        }
         return total;
    }
}
