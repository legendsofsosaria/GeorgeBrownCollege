"use strict";

/* References:
Function 1: https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Math/random
*/


// Function 1: Random Number ✔ Works
async function getRandomNumber()
{
    let promise = new Promise((resolve) =>
    {
        // Delay of 500ms to simulate an async operation, use math random to get a number between 1-5, floor to round down to get int
        setTimeout(() => resolve(Math.floor(Math.random() * (5 - 1) + 1), 500));
    });

    // Await the promise to get the result
    let result = await promise;

    return result;
}

// Function 2: Get City Data, this isn't working consistently. Gives message about throttling 99% of the time.
async function getCityData(city)
{
    try
    {
        // API Url to fetch data from
        const response = await fetch(`https://geocode.xyz/${city}?json=1`);

        // Throw error if response fails
        if (!response.ok)
        {
            throw new Error(`HTTP error: ${response.status}`);
        }

        // Parse response to JSON
        const cityData = await response.json();
        return cityData;
    }
    catch(error)
    {
        console.error("Could not get city data: " + error);
        return null;
    }
}

// Function 3: Fetch Product ✔ Works
async function fetchProducts(id)
{
    try
    {
        // API Url to fetch data from
        const response = await fetch(`https://dummyjson.com/products/${id}`);

        // Throw error if response fails
        if (!response.ok)
        {
            throw new Error(`HTTP error: ${response.status}`);
        }

        // Parse response to JSON
        const productInfo = await response.json();

        return productInfo.title; // Return the title of the product
    }
    catch(error)
    {
        return `Could not get products: ${error}`;
    }
}

// Function 4: Search Store Price ✔ Works
async function searchStorePrice(product_name)
{
    try
    {
        // API Url to fetch data from
        const response = await fetch('https://mdn.github.io/learning-area/javascript/apis/fetching-data/can-store/products.json');

        // Throw error if response fails
        if (!response.ok)
        {
            throw new Error(`HTTP error: ${response.status}`);
        }

        // Parse response to JSON
        const productData = await response.json();

        // Use array.prototype.find() to find the product by name and check if it matches product_name
        const foundItem = productData.find(item => item.name === product_name);

        // If the item is found, return the price
        if (foundItem)
        {
            return foundItem.price;
        }
        else
            return console.error("Error fetching data: Product not found");
    }
    catch (error)
    {
        console.error('Error fetching data:', error);
    }
}

// Function 5: Star Wars API ✔ Works (had to add longer timeout for this one as well as it was exceeding the 2000ms limit)
async function getStarWarsCharacters()
{
    try
    {
        // API Url to fetch data from
        const response = await fetch(`https://swapi.dev/api/people/`);

        // Throw error if response fails
        if (!response.ok)
        {
            throw new Error(`HTTP error: ${response.status}`);
        }

        // Parse response to JSON
        const data = await response.json();
        let characters = {}; // Create empty JSON obj to store characters

        // Use for each to iterate through the data and get the name and url and put into characters
        data.results.forEach((element) =>
        {
            characters[element.name] = element.url;
        });

        return { characters }; // Return the characters JSON obj
    }
    catch(error)
    {
        console.error("Could not get star wars characters: " + error);
        return null;
    }
}