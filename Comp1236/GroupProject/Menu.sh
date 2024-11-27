#!/bin/bash

# Have user enter the password
pass="App1"

# loop through to give the user 3 chances to put the valid password
for (( i=0; i<3; i++ )) do
	read -p "Enter password: " code
    if [ $code = $pass ]
        then
            echo "You have entered the correct password. Welcome!"
            break
    else
        echo "Incorrect password!"
    fi
done

# Infinite loop, allows repetitive menu selection unless they select a valid choice
# Allows selection in a menu for task 1, 2, and 3 by A/B/C (not case sensitive)
# fourth case handles invalid user input
for ((;;))
do
	echo -e "\nPress A or a to calculate triangular numbers "
	echo -e "Press B or b to calculate numbers as products of successive numbers "
    echo -e "Press C or c to generate sequence by formula\n"
	read -p "Enter your menu choice: " choice

	case $choice in
	    "A" | "a") echo -e "You chose task 1\n " 
        . ./Task1.sh;;
        "B" | "b") echo -e "You chose task 2\n " 
        exit 1;;
	    "C" | "c") echo -e "You chose task 3\n "
        . ./Task3.sh;;
        *) echo -n "Invalid input! " ;;
	esac
done