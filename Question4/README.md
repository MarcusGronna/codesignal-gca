# Question 4: Reverse String

## Problem Description

Write a function that takes a string as input and returns the string reversed. All characters including spaces and special characters should be reversed.

## Function Signature

```csharp
public string ReverseString(string text)
```

## Input

- `text`: A string containing any characters (length between 0 and 1000)
- The string may contain letters, numbers, spaces, and special characters

## Output

- Returns a new string with all characters in reverse order
- If the input is an empty string, return an empty string

## Examples

### Example 1

**Input:**
```
text = "hello"
```

**Output:**
```
"olleh"
```

**Explanation:** The string "hello" reversed is "olleh".

### Example 2

**Input:**
```
text = "Hello World!"
```

**Output:**
```
"!dlroW olleH"
```

**Explanation:** All characters including the space and exclamation mark are reversed.

## Constraints

- Time complexity should be O(n) where n is the length of the string
- Space complexity should be O(n) for storing the reversed string
