# Question 3: Palindrome Check

## Problem Description

Write a function that checks if a given string is a palindrome. A palindrome is a word, phrase, or sequence that reads the same backward as forward (ignoring spaces and case).

## Function Signature

```csharp
public static bool IsPalindrome(string input)
```

## Parameters

- `input`: A string to check

## Return Value

- Returns `true` if the string is a palindrome
- Returns `false` otherwise
- Returns `true` for empty or null strings

## Examples

```csharp
IsPalindrome("racecar") // returns true
IsPalindrome("hello") // returns false
IsPalindrome("A man a plan a canal Panama") // returns true
IsPalindrome("") // returns true
```

## Constraints

- String length: 0 ≤ length ≤ 10,000
- Ignore case and spaces when checking
