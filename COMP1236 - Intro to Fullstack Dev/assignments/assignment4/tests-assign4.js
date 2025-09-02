"use strict";

const chai = window.chai;
const expect = chai.expect;

describe('getRandomNumber()', () =>  {
    it('This asyn/wait function get a random number between 1-5',  async () => {
        expect(await getRandomNumber()).to.be.closeTo(1, 5)
        expect(await getRandomNumber()).to.be.closeTo(0, 4)
        expect(await getRandomNumber()).to.be.closeTo(0, 5)
    })
})

describe('getCityData()', () =>  {
    it('This asyn/wait function calls geocode to return data associated with a city',  async function () {
        this.timeout(5000); // added extra timeout to allow for geocode to return data
        expect((await getCityData("Halifax")).longt).to.deep.equal("-63.60666");
        expect((await getCityData("Windsor")).latt).to.deep.equal("-82.98184");
        expect((await getCityData("Ottawa")).longt).to.deep.equal("-75.71011");
    })
})

describe('fetchProducts()', () =>  {
    it('This asyn/wait function fetchs products from the dummy json products api',  async () => {
        expect(await fetchProducts(5)).to.deep.equal("Red Nail Polish");
        expect(await fetchProducts(16)).to.deep.equal("Apple");
        expect(await fetchProducts(18)).to.deep.equal("Cat Food");
        expect(await fetchProducts(900)).to.deep.equal("Could not get products: Error: HTTP error: 404");
    })
})

describe('searchStorePrice()', () =>  {
    it('This asyn/wait function search products from store json api',  async () => {
        expect(await searchStorePrice("kidney beans")).to.deep.equal(0.58);
        expect(await searchStorePrice("hot dogs")).to.deep.equal(1.99);
        expect(await searchStorePrice("mushy peas")).to.deep.equal(0.58);
        expect(await searchStorePrice("corned beef")).to.deep.equal(2.39);
    })
})


describe('getStarWarsCharacters()', () =>  {
    it('This promise calls the star wars api, returing JSON object {key, value} of characters', async function () {
        this.timeout(5000); // added extra timeout to allow time for the star wars api to return data (response time was exceeding the 2000ms limit)
        expect((await getStarWarsCharacters()).characters["Darth Vader"]).to.deep.equal("https://swapi.dev/api/people/4/");
        expect((await getStarWarsCharacters()).characters["Obi-Wan Kenobi"]).to.deep.equal("https://swapi.dev/api/people/10/");
        expect((await getStarWarsCharacters()).characters["R5-D4"]).to.deep.equal("https://swapi.dev/api/people/8/");
    })
})