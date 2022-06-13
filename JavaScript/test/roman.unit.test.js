const roman = require('../src/roman.js');

test('tests should be working', () => {
  expect(1).toBe(1);
});

/*
test('should not accept non-numbers', () => {
  expect(() => {
    roman.convertToRoman('not a number');
  }).toThrow(TypeError);
});

test('should not accept numbers below 1', () => {
  expect(() => {
    roman.convertToRoman(0);
  }).toThrowError(/0/);
});

test('should handle low number roman', () => {
  expect(roman.convertToRoman(1)).toBe('I');
});

test('should handle double digit number - additive', () => {
  expect(roman.convertToRoman(15)).toBe('XV');
});

test('should handle double digit number - subtraction', () => {
  expect(roman.convertToRoman(4)).toBe('IV');
});

test('should handle large numbers', () => {
  expect(roman.convertToRoman(1776)).toBe('MDCCLXXVI');
});

test('should handle shorthand', () => {
  expect(roman.convertToRoman(94)).toBe('XCIV');
});

test('should convert input values to integer if possible', () => {
  expect(roman.convertToRoman('9')).toBe('IX');
});

test('should handle low number decimal', () => {
  expect(roman.convertToDecimal('I')).toBe(1);
});

test('should handle double digit number - additive decimal', () => {
  expect(roman.convertToDecimal('XV')).toBe(15);
});

test('should handle double digit number - subtraction decimal', () => {
  expect(roman.convertToDecimal('IV')).toBe(4);
});

test('should handle large numbers decimal', () => {
  expect(roman.convertToDecimal('MDCCLXXVI')).toBe(1776);
});

test('should handle random number', () => {
  let decimalValue = Math.floor(Math.random() * 2000) + 1;
  let romanValue = roman.convertToRoman(decimalValue);

  expect(roman.convertToDecimal(romanValue)).toBe(decimalValue);
});
*/