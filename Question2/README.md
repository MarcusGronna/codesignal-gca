# Question 2: Count Vowels in String

## Problem Description

Write a function that counts the number of vowels (a, e, i, o, u) in a given string. The function should be case-insensitive, meaning both uppercase and lowercase vowels should be counted.

## Function Signature

```csharp
public int CountVowels(string text)
```

## Input

- `text`: A string containing any characters (length between 0 and 1000)
- The string may contain letters, numbers, spaces, and special characters

## Output

- Returns an integer representing the total count of vowels in the string
- Both uppercase and lowercase vowels count (A, E, I, O, U, a, e, i, o, u)

## Examples

### Example 1

**Input:**
```
text = "Hello World"
```

**Output:**
```
3
```

**Explanation:** The vowels are 'e', 'o', and 'o'. Total count is 3.

### Example 2

**Input:**
```
text = "Programming"
```

**Output:**
```
3
```

**Explanation:** The vowels are 'o', 'a', and 'i'. Total count is 3.

## Constraints

- Time complexity should be O(n) where n is the length of the string
- Space complexity should be O(1)
