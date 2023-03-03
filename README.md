# Applaudo Challenges Week 1
This repository stores the 3 challenges i had to resolve for the first week on the .NET Applaudo Trainee Program.

## Challenge 1
Write a function that takes a string of parentheses, and determines if the order of the parentheses
is valid. The function should return true if the string is valid, and false if it's invalid.

Examples:
- "()" => true
- ")(()))" => false
- "(" => false
- "(())((()())())" => true

Constraints:
- 0 <= input.length <= 100
 
Along with opening (() and closing ()) parenthesis, input may contain any valid ASCII characters.
Furthermore, the input string may be empty and/or not contain any parentheses at all. Do not
treat other forms of brackets as parentheses (e.g. [], {}, <>). 

## Challenge 2
Create a function taking a positive integer as its parameter and returning a string containing the
Roman Numeral representation of that integer.

Modern Roman numerals are written by expressing each digit separately starting with the left
most digit and skipping any digit with a value of zero. In Roman numerals 1990 is rendered:
10002M, 900=CM, 90=XC; resulting in MCMXC. 2008 is written as 2000=MM, 8=Vlll; or MMVIII.
1666 uses each Roman symbol in descending order: MDCLXVI.

Example:

RomanConvert.Solution(1000) -- should return "M"

Help:
| Symbol | Value |
| ------ | ----- |
| I | 1 |
| V | 5 |
| X | 10 |
| L | 50 |
| C | 100 |
| D | 500 |
| M | 1000 |

Remember that there can't be more than 3 identical symbols in a row.
More about roman numerals - http://en.wikipedia.org/wiki/Roman numerals.

## Challenge 3
When you post a message on Facebook, depending on the number of people who like your post,
Facebook displays different information.

- If no one likes your post, it doesn't display anything.
- If only one person likes your post, it displays: [Friend's Name] likes your post.
- If two people like your post, it displays: [Friend I] and [Friend 2] like your post.
- If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of
  Other People] others like your post.

Write a program and continuously ask the user to enter different names, until the user presses
Enter (without supplying a name). Depending on the number of names provided, display a
message based on the above pattern.
