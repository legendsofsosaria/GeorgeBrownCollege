/*
 Elizabeth House
 COMP1235 Assignment 2
 StudentID 101465946
*/

"use strict";

const chai = window.chai;
const expect = chai.expect;


// Test Function 1
describe('_findNumOfDigits', () =>
{
    it('Check the number of digits in an argument',  () =>
    {
        expect(_findNumOfDigits(1000)).to.deep.equal(4)
    })
    it('Check the number of digits in an argument',  () =>
    {
        expect(_findNumOfDigits("abcd")).to.deep.equal(0)
    })
    it('Check the number of digits in an argument',  () =>
    {
        expect(_findNumOfDigits(12)).to.deep.equal(2)
    })
    it('Check the number of digits in an argument',  () =>
    {
        expect(_findNumOfDigits("COMP1235")).to.deep.equal(4)
    })
    it('Check the number of digits in an argument',  () =>
    {
        expect(_findNumOfDigits(0)).to.deep.equal(1)
    })
    it('Check the number of digits in an argument',  () =>
    {
        expect(_findNumOfDigits("C1O2M3P5")).to.deep.equal(4)
    })
})

// Test Function 2
describe('_surplus', () =>
    {
        it('Takes a string argument and returns a function that returns the string argument.', () =>
        {
            expect(_surplus("orange")()).to.deep.equal("orange")
        })
        it('Takes a string argument and returns a function that returns the string argument.', () =>
        {
            expect(_surplus("pear")()).to.deep.equal("pear")
        })
        it('Takes a string argument and returns a function that returns the string argument.', () =>
        {
            expect(_surplus("")()).to.deep.equal("")
        })
    }
)

// Test Function 3
describe('_strNumbers', () =>
{
    it('Takes an array of strings and outputs strings from source arrays with numbers in them.', () =>
    {
        expect(_strNumbers(["1a", "a", "2b", "b"])).to.deep.equal(["1a", "2b"])
    })
    it('Takes an array of strings and outputs strings from source arrays with numbers in them.', () =>
    {
        expect(_strNumbers(["abc", "abc10"])).to.deep.equal(["abc10"])
    })
    it('Takes an array of strings and outputs strings from source arrays with numbers in them.', () =>
    {
        expect(_strNumbers(["abc", "ab10c", "a10bc", "bcd"])).to.deep.equal(["ab10c", "a10bc"])
    })
    it('Takes an array of strings and outputs strings from source arrays with numbers in them.', () =>
    {
        expect(_strNumbers(["this is a test", "test1"])).to.deep.equal(["test1"])
    })
    it('Takes an array of strings and outputs strings from source arrays with numbers in them.', () =>
    {
        expect(_strNumbers(["test"])).to.deep.equal([])
    })
})
// Test Function 4
describe('_determineClassGrading', () =>
{
    it('Takes an array of numbers representing a students grade and returns # of passing, # of failing, and average', () =>
    {
        expect(_determineClassGrading([50, 51, 80, 45])).to.deep.equal([3, 1, 56.5])
    })
    it('Takes an array of numbers representing a students grade and returns # of passing, # of failing, and average', () =>
    {
        expect(_determineClassGrading([35, 45, 25, 10, 6, 33])).to.deep.equal([0, 6, 25.7])
    })
    it('Takes an array of numbers representing a students grade and returns # of passing, # of failing, and average', () =>
    {
        expect(_determineClassGrading([80, 90])).to.deep.equal([2, 0, 85.0])
    })
})

// Test Function 5
describe('_moveCapitalLetters', () =>
{
    it('Takes a string and groups upper and lowercase letters, placing uppercase in beginning of the string', () =>
    {
        expect(_moveCapitalLetters("hApPy")).to.deep.equal("APhpy")
    })
    it('Takes a string and groups upper and lowercase letters, placing uppercase in beginning of the string',  () =>
    {
        expect(_moveCapitalLetters("moveMENT")).to.deep.equal("MENTmove")
    })
    it('Takes a string and groups upper and lowercase letters, placing uppercase in beginning of the string',  () =>
    {
        expect(_moveCapitalLetters("shOrtCAKE")).to.deep.equal("OCAKEshrt")
    })
})