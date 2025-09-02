"use strict";

const chai = window.chai;
const expect = chai.expect;

describe('Circle(radius)', () => {
    it('this Circle constructor with area and perimeter', () => {
        expect(new Circle(7).area()).to.deep.equal(153.94);
        expect(new Circle(7).perimeter()).to.deep.equal(43.98);
        expect(new Circle(16).area()).to.deep.equal(804.25);
        expect(new Circle(16).perimeter()).to.deep.equal(100.53);
        expect(new Circle(30).area()).to.deep.equal(2827.43);
        expect(new Circle(30).perimeter()).to.deep.equal(188.50);
    })
})

describe('calculateSalary(array)', () => {
    it('this function calculate and returns calculated total gross salary', () => {
        expect(calculateSalary([6, 6, 6, 6, 6, 6, 0])).to.deep.equal(420);
        expect(calculateSalary([12, 12, 12, 0, 0, 12, 12])).to.deep.equal(980);
        expect(calculateSalary([10, 10, 0, 0, 10, 10, 10])).to.deep.equal(770);
        expect(calculateSalary([8, 0, 0, 10, 8, 12, 4])).to.deep.equal(630);
        expect(calculateSalary([9, 9, 9, 9, 9, 0, 0])).to.deep.equal(475);
    })
})

describe('indexMultiplier(array)', () => {
    it('this function calculates the sum of all items in the array, each multiplied by its index', () => {
        expect(indexMultiplier([6, 16, 20, 18, 33])).to.deep.equal(242);
        expect(indexMultiplier([-9, -16, 3, 0])).to.deep.equal(-10);
        expect(indexMultiplier([8, 25, -300, 200])).to.deep.equal(25);
        expect(indexMultiplier([17, 3, 2, 45])).to.deep.equal(142);
        expect(indexMultiplier([2, -4, 26, -1])).to.deep.equal(45);
        expect(indexMultiplier([3, 27, 0, 280])).to.deep.equal(867);
    })
})

describe('filteredJSON(array)', () => {
    it('return filters an array of JSON elements (id greater than 10, username within [M-N])', () => {
        expect(filteredJSON([{ id: 6, u: "abba" }, { id: 13, u: "sally" }])).to.deep.equal([{ id: 13, u: "sally" }]);
        expect(filteredJSON([{ id: 4, u: "nana" }])).to.deep.equal([]);
        expect(filteredJSON([{ id: 12, u: "nana1" }])).to.deep.equal([{ id: 12, u: "nana1" }]);
        expect(filteredJSON([{ id: 18, u: "Zebra" }])).to.deep.equal([{ id: 18, u: "Zebra" }]);
        expect(filteredJSON([{ id: 3, u: "robert" }, { id: 15, u: "bob" }])).to.deep.equal([]);
        expect(filteredJSON([{ id: 15, u: "Robert" }])).to.deep.equal([{ id: 15, u: "Robert" }]);
        expect(filteredJSON([{ id: 10, u: "Fred" }])).to.deep.equal([]);
        expect(filteredJSON([{ id: 15, u: "Muffin1" }])).to.deep.equal([{ id: 15, u: "Muffin1" }]);
    })
})

describe('breakAway', () => {
    it('This function divides an array (first argument) into chuck of size n (second parameter)', () => {
        expect(breakAway([3, 9], 2)).to.deep.equal([[3, 9]])
        expect(breakAway([5, 15, 20, 19], 2)).to.deep.equal([[5, 15], [20, 19]])
        expect(breakAway([8, 7, 16, 20, 40], 2)).to.deep.equal([[8, 7], [16, 20], [40]])
        expect(breakAway([49, 208, 309, 180, 582, 409, 4509], 3)).to.deep.equal([[49, 208, 309], [180, 582, 409], [4509]])
        expect(breakAway([8, 16, 29, 30, 10], 1)).to.deep.equal([[8], [16], [29], [30], [10]])
        expect(breakAway([4, 2, 5, 0, 8, 6], 7)).to.deep.equal([[4, 2, 5, 0, 8, 6]])
    })
})