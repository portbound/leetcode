public bool IsPalindrome(int x) {
	string str = x.ToString();
	string reversed = new string(str.ToCharArray().Reverse().ToArray());

	if (str == reversed) {
		return true;
	}
	return false;
}
