/*
 Elizabeth House
 COMP1235 Lab 5b
*/

const my_data =
    {
        username: "ehouse-gbc",
        last_active_time: "2025-02-07 9:00",
        playlists: ["Metal", "Classic Rock", "Alternative"]
    }

console.log(my_data)

//Converting Object <=> JSON
const my_obj_json = JSON.stringify(my_data);
console.log(my_obj_json)

// Converting JSON <=> Object
const my_obj_json2 =
    `{
        "username": "ehouse-gbc",
        "last-active-time": "2025-02-07 9:00",
        "playlists": ["Metal", "Classic Rock", "Alternative"]
    }`;


console.log(my_obj_json2)

const my_obj2 = JSON.parse(my_obj_json2)
console.log(my_obj2)