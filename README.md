# Roman Numerals Converter

## Overview
C# Console App that converts numbers to Roman Numerals and vice versa. It has been created to solve a technical exercise.

The solution demonstrates some Clean Code techniques and includes Unit Tests, but it's not intended to be a production ready system.

## Roman Numerals Guide

| Symbol | Value |
| ------ | ----- |
| I      | 1     |
| V      | 5     |
| X      | 10    |
| L      | 50    |
| C      | 100   |
| D      | 500   |
| M      | 1000  |

Numbers are formed by combining symbols together and adding the values. So II is two ones, i.e. 2, and XIII is a ten and three ones, i.e. 13.

There is no zero in this system, so 207, for example, is CCVII.

Symbols are placed from left to right in order of value, starting with the largest. However, in specific cases, to prevent four characters being repeated in succession (e.g. XXXX) these can be reduced using subtractive notation as follows:

* the numeral I can be placed before V and X to make 4 units (IV) and 9 units (IX)
* X can be placed before L and C to make 40 (XL) and 90 (XC)
* C can be placed before D and M to make 400 (CD) and 900 (CM) according to the same pattern

An example of the above rules would be 1904:
This is composed of 1 (one thousand), 9 (nine hundreds), 0 (zero tens), and 4 (four ones). 
To write the Roman Numeral, each of the non-zero digits should be treated separately.

Thus 1000 = M, 900 = CM, 4 = IV. Therefore, 1904 is MCMIV.

Other examples of Roman Numerals:
* 1954 is MCMLIV
* 1990 is MCMXC
* 2014 is MMXIV

Due to the limitations of the roman number system, only convert numbers from 1 to 3999.