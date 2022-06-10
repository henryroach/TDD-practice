# Roman Numerals

From [Wikipedia](https://en.wikipedia.org/wiki/Roman_numerals)

> The numeric system represented by Roman numerals originated in ancient Rome and remained the usual way of writing numbers throughout Europe well into the Late Middle Ages. Numbers in this system are represented by combinations of letters from the Latin alphabet. Roman numerals, as used today, are based on seven symbols:

| Symbol | Value |
| ------ | ----: |
| M      |  1000 |
| D      |   500 |
| C      |   100 |
| L      |    50 |
| X      |    10 |
| V      |     5 |
| I      |     1 |

> _Note that Roman numerals are not defined for zero or negative numbers!_

## Project setup

- Create the project from scratch using a suitable package and builder tool (maven/gradle/npm/yarn).
- Remember to include test tools and get a sanity test working as soon as possible.

## The solution

Build a small utility that can convert Arabic numbers to Roman numerals. Develop the solution by using a [TDD](https://www.codecademy.com/articles/tdd-red-green-refactor) style.

## Extra materials

- Make a wrapper so that the program can be called from the command line with a list of Arabic numbers
- Write a solution for converting in the opposite direction.

## Some test data

| Arabic |     Roman |
| ------ | --------: |
| -1     |     error |
| 0      |     error |
| 1      |         I |
| 5      |         V |
| 15     |        XV |
| 42     |      XLII |
| 9      |        IX |
| 94     |      XCIV |
| 1776   | MDCCLXXVI |
