# Question 3: Is Palindrome

## Problem Description
Write a function that checks if a given string is a palindrome. A palindrome is a word, phrase, or sequence that reads the same backward as forward (ignoring spaces and case).

## Function Signature
```csharp
public bool IsPalindrome(string text)
```

## Parameters
- `text`: A string to check

## Returns
- `true` if the string is a palindrome (case-insensitive, ignoring spaces), `false` otherwise

## Examples

### Example 1:
**Input:** `"racecar"`  
**Output:** `true`  
**Explanation:** "racecar" reads the same forwards and backwards

### Example 2:
**Input:** `"hello"`  
**Output:** `false`  
**Explanation:** "hello" backwards is "olleh"

### Example 3:
**Input:** `"A man a plan a canal Panama"`  
**Output:** `true`  
**Explanation:** Ignoring spaces and case: "amanaplanacanalpanama" is a palindrome

### Example 4:
**Input:** `""`  
**Output:** `true`  
**Explanation:** Empty string is considered a palindrome

### Example 5:
**Input:** `"a"`  
**Output:** `true`  
**Explanation:** Single character is a palindrome

## Constraints
- 0 ≤ text length ≤ 1000
- Text contains only letters and spaces
- Comparison should be case-insensitive
- Spaces should be ignored
