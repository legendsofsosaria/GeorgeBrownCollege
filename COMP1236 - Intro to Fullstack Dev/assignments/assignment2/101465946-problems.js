/*
Elizabeth House
COMP1235 Assignment 2
StudentID 101465946

References:
https://www.tutorialspoint.com/find-digit-with-javascript-regexp
 • I don't know if this is allowed, but I used this for function #1 because I couldn't find anything
in the textbook that helped me solve this.

Function 2
 • Used the textbook's example of a nested function

Function 3
https://www.w3schools.com/jsref/jsref_filter.asp
 • Combined with function #1 and spread operator to return a filtered array

Function 4, built on above function examples
https://www.w3schools.com/jsref/jsref_tofixed.asp
 • Used for rounding

Function 5
 • This probably isn't the most efficient way to do this,
 but it was the best idea I had for how to tackle the issue.
 Used textbook for info on arrays, strings, and arrow functions
*/

"use strict";

// Function 1: Find the Number of Digits in an Argument
function _findNumOfDigits(arg)
{
    // First convert the argument to a string
    const str = arg.toString();

    // Use regex to find all digits in the string globally
    const digits = str.match(/\d/g);

    // Return length of digits or 0 if none
    return digits ? digits.length : 0;
}

// Function 2: Surplus Function
function _surplus(str)
{
    // set a variable for the original function argument
    let argString = str;
    function inner()
    {
        // Inner function returns the argument string
        return argString;
    };

    // Outer function returns the inner function
    return inner;
}

// Function 3: Strings with Numbers
function _strNumbers(array)
{
    const arr = [...array];
    // Filter the elements for digits
    let containsDigits = arr.filter(element => /\d/.test(element));

    // Handle empty arrays
    if (containsDigits.length > 0)
        return containsDigits;
    else
        return [];
}
// Function 4: Class Grading
function _determineClassGrading(array)
{
    let sum = 0;

    // Loop through the array and add the elements
    for (let i= 0; i < array.length; i++)
    {
        sum += array[i];
    }

    // Get the average
    let length = array.length;
    let average = Math.round((sum / length) * 10) / 10;

    // Filter the array to get passing and failing grades and count them
    let passingGrades = array.filter(num => num > 49);
    let failingGrades = array.filter(num => num < 50);
    let passingLength = passingGrades.length;
    let failingLength = failingGrades.length;

    // Create a new array with the passing length, failing length, and average
    const newArray = [passingLength, failingLength, average]

    return newArray;
}

// Function 5: Move Capital Letters
let _moveCapitalLetters = (string) =>
{
    const lowerArray = [];
    const upperArray = [];

    // Loop through the length of the string
    for (let i = 0; i < string.length; i++)
    {
        const char = string[i];

        // Use regex to check if character is uppercase
        if (char.match(/[A-Z]/))
        {
            upperArray.push(char); // Store the uppercase letter in an array
        }
        // Use regex to check if character is lowercase
        else if (char.match(/[a-z]/))
        {
            lowerArray.push(char); // Store the lowercase letter in an array
        }
    }

    const newArray =  upperArray.concat(lowerArray); // merge the 2 arrays using concat

    return newArray.join(''); // Convert it back to a string
}