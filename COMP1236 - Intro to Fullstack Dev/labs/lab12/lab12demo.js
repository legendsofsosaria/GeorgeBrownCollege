"use strict";
let z = 12;
console.log(z);
// z = "Goodbye"
z = 20;
console.log(z);
// let my_name: string = 5
let my_name = "Michael";
// let faculuty: boolean = true
let faculty = true;
// faculty = "Yes"
my_name = 5;
// my_name = true
// strings or numbers
// let students: string[] | number[] = ["Michael", "John", "Jane"]
let students = ["Michael", "John", "Jane"];
// students = [1, 2, 3]
students.push(1);
let students_full = ["Michael", 1010101, "John", 1010102, "Jane", 1010103];
students_full.push(1);
// Tuples, makes the order of the elements matter
let student1 = ["Michael", 1010101];
// let student1: [string, number] = [1010101, "Michael"]
student1.push(102);
let students_tuples = [
    ["Michael", 1010101],
    ["John", 1010102],
    ["Jane", 1010103],
];
students_tuples.push(["Sarah", 1010104]);
students_tuples[0].push(104);
console.log(students_tuples);
// Enums
// let member1: [string, string] = ["Michael", "Faculty"]
// let member2: [string, string] = ["John Doe", "Student"]
var CollegeMemberType;
(function (CollegeMemberType) {
    CollegeMemberType[CollegeMemberType["Student"] = 0] = "Student";
    CollegeMemberType[CollegeMemberType["Faculty"] = 1] = "Faculty";
    CollegeMemberType[CollegeMemberType["Admin"] = 2] = "Admin";
    CollegeMemberType[CollegeMemberType["Alumni"] = 3] = "Alumni";
})(CollegeMemberType || (CollegeMemberType = {}));
let member1 = ["Michael", CollegeMemberType.Faculty];
let member2 = ["John Doe", CollegeMemberType.Student];
console.log(CollegeMemberType.Student);
function checkCollegeMemberType(c) {
    if (c == CollegeMemberType.Student) {
        return "This is a student";
    }
    return "Unknown Type";
}
console.log(checkCollegeMemberType(member2[1]));
let out = checkCollegeMemberType(member1[1]);
console.log(out.length);
const lastName = "Hossain";
let isLoading;
