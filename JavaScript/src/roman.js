const romanNumerals = {
  M: 1000,
  CM: 900,
  D: 500,
  CD: 400,
  C: 100,
  XC: 90,
  L: 50,
  XL: 40,
  X: 10,
  IX: 9,
  V: 5,
  IV: 4,
  I: 1,
};

// eslint-disable-next-line import/prefer-default-export
module.exports.convertToRoman = function convertToRoman(num) {
  const decimal = parseFloat(num, 10);

  if (!Number.isInteger(decimal) || decimal < 1) {
    throw new TypeError(`'${num}' is not a number`);
  }

  const result = Object.entries(romanNumerals).reduce(
    (acc, [romanKey, romanValue]) => {
      const factor = Math.floor(acc.decimalRest / romanValue);
      acc.romanResult += romanKey.repeat(factor);
      acc.decimalRest -= factor * romanValue;
      return acc;
    },
    {
      romanResult: '',
      decimalRest: decimal,
    },
  );

  return result.romanResult;
};

module.exports.convertToDecimal = function convertToDecimal(roman) {
  let accumulator = 0;
  for (let i = 0; i < roman.length; i++) {
      if (roman[i] === "I" && roman[i + 1] === "V") {
        accumulator += 4;
        i++;
      } else if (roman[i] === "I" && roman[i + 1] === "X") {
        accumulator += 9;
        i++;
      } else if (roman[i] === "X" && roman[i + 1] === "L") {
        accumulator += 40;
        i++;
      } else if (roman[i] === "X" && roman[i + 1] === "C") {
        accumulator += 90;
        i++;
      } else if (roman[i] === "C" && roman[i + 1] === "D") {
        accumulator += 400;
        i++;
      } else if (roman[i] === "C" && roman[i + 1] === "M") {
        accumulator += 900;
        i++;
      } else {
        accumulator += romanNumerals[roman[i]];
      }
    }
    return accumulator;
};