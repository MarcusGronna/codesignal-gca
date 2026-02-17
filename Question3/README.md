# Question 3: Character Frequency by Position

## Problem Description

Write a function that analyzes a string and returns a dictionary where:
- Keys are character positions (0-indexed) that contain digits
- Values are the count of how many times that specific digit appears in the entire string

Only include positions that contain digits (0-9). Ignore all other characters.

## Function Signature

```csharp
public static Dictionary<int, int> CharacterFrequencyByPosition(string? input)
```

## Parameters

- `input`: A string to analyze (can be null or empty)

## Return Value

- Returns a dictionary where keys are positions of digits and values are the frequency counts
- Returns an empty dictionary if the string is null, empty, or contains no digits
- Positions are 0-indexed based on the original string

## Examples

```csharp
CharacterFrequencyByPosition("a1b2c1") 
// returns { {1, 2}, {3, 1} }
// Position 1 has '1' which appears 2 times total
// Position 3 has '2' which appears 1 time total

CharacterFrequencyByPosition("hello123world321")
// returns { {5, 2}, {6, 2}, {7, 2}, {13, 2}, {14, 2}, {15, 2} }
// Position 5 has '1' (appears 2 times total), position 6 has '2' (appears 2 times total)
// Position 7 has '3' (appears 2 times total), and so on

CharacterFrequencyByPosition("no digits here")
// returns { } (empty dictionary)

CharacterFrequencyByPosition("")
// returns { } (empty dictionary)
```

## Constraints

- String length: 0 ≤ length ≤ 10,000
- Only ASCII characters
- Count frequency across the entire string for each digit found at a position
