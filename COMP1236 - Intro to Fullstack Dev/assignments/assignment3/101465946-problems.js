"use strict";
/* Elizabeth House
Student ID 101465946
03/14/2025
 */
// Define the 5 functions
// The 3rd argument that you could put in your callback function for reduce is the current index

// Function 1 : Circle Constructor
function Circle(radius)
{
    this.radius = radius;

    /* Get the area of the circle, using Math.PI to calculate 2πr
    * Return the radius rounded to 2 decimal points */
    this.area = function()
    {
        const area = Math.PI * this.radius * this.radius;

        return Math.round(area * 100) / 100;
    }

    this.perimeter = function()
    {
        const perimeter = 2 * Math.PI * this.radius;

        return Math.round(perimeter * 100) / 100;
    }
}

// Function 2 : Lucky Seven ---> Use arrow expression, array reduce function
const calculateSalary = (array) =>
{
    return array.reduce((accumulator, element, index) =>
    {
        let dailyPay = 0;
        let weekend = (index === 5 || index === 6) // weekends would be index 5 or 6 in the array (saturday & sunday)

        if (element > 8) // Check if the element in the array is over 8 for overtime pay
        {
            let overtimeHours = element - 8; // count the number of overtime hours

            if (weekend)
            {
                dailyPay = (8 * 10) + (overtimeHours * 15); // Calculate the daily pay w/ overtime
                dailyPay *= 2; // double it for the weekends
            }
            else
            {
                dailyPay = (8 * 10) + (overtimeHours * 15); // 8 hrs at regular pay, 15 at overtime pay
            }
        }
        else if (weekend)
        {
            dailyPay = element * 20; // Weekend pay is $20/hr
        }
        else
        {
            dailyPay = element * 10; // Standard pay is $10/hr
        }


        return accumulator + dailyPay;
    }, 0);
};

/* Function 3 : Index Multiplier ---> Use arrow expression, array reduce function
Uses similar logic to #2, but less complex calculation required
 */
const indexMultiplier = (array) =>
{
    return array.reduce((accumulator, element, index) =>
    {
        // returns the index * the specified element, which gets added to the result (accumulator)
        return accumulator + (element * index)
    }, 0);
};

// Function 4 : Filtered JSON ---> Use arrow expression, regex, array filter function
const filteredJSON = (array) =>
{
    return array.filter(e =>
    {
        if (e.id > 10) // We are looking for an ID that is over 10
        {
            const username = e.u.toLowerCase(); // convert to lowercase to ignore case sensitivity
            const pattern = /^[m-z]/; // regex to match usernames starting with a letter from m-z
            return pattern.test(username); // test the username to see if it returns true for the pattern
        }
        return false; // if the id isn't over 10, filter it out
    });
};

// Function 5 : Break Array ---> Use function expression with
// const name breakAway [anonymous function]
// Resource: Used https://www.geeksforgeeks.org/split-an-array-into-chunks-in-javascript/ for info on dividing arrays
const breakAway = function(array, n)
{
    let newArray = []; // create an empty array to hold the results

    /* loop through the array for the length of the given array.
    Use slice to slice the array in chunks of size n, and iterates
    until the entire array is divided up
     */
    for (let i = 0; i < array.length; i+= n)
    {
        newArray.push(array.slice(i, i + n));
    }
    return newArray;
}