#!/bin/bash

# -----------------
#  TASK FUNCTIONS 
# -----------------
task1()
{
    # Get input from the user for min and max values
    read -p "Enter the minimum value: " min

        while [[ ! $min =~ ^[0-9]+$ || $min -le 0 ]]; do
            echo "The minimum value must be a positive non-zero integer. Please enter another value."
            echo
            read -p "Enter the minimum value: " min
        done

    read -p "Enter the maximum value: " max

        while [[ ! $max =~ ^[0-9]+$ || $max -le 0 || $max -le $min ]]; do
                echo "The maximum value cannot be less than or equal to the minimum."
                echo "Please enter another value."
                echo
                read -p "Enter the maximum value: " max
        done
    echo

    # Initialize variables
    totalOdd=0
    totalEven=0
    oddProduct=1
    evenProduct=1
    n=1

    # Find the starting point (min)
    while true; do
        T=$((n * (n + 1) / 2))
    
        if ((T >= min)); then
            break
        fi
        n=$((n+1))
    done


    # Loop to find triangular numbers in range
    while true; do
    # Calculate triangular numbers 
        T=$((n * (n + 1) / 2))

        if ((T > max)); then
            break
        fi

        if ((T % 2 == 0)); then
            echo "$T is even"
            totalEven=$((totalEven + 1))
            evenProduct=$((evenProduct * T))
        else
            echo "$T is odd"
            totalOdd=$((totalOdd + 1))
            oddProduct=$((oddProduct * T))
        fi

        # Increment to calculate next triangular number
        n=$((n+1))
    done

    # Output info to user
    echo
    echo "Total odd triangular numbers is: $totalOdd"
    echo "Total even triangular numbers is: $totalEven"
    echo
    echo "Product of odd triangular numbers is: $oddProduct"
    echo "Product of even triangular numbers is: $evenProduct"
}

task2()
{
    # Request user input with validation for non-negative values
    while true; do
        read -p "Please provide the starting number for calculating the successive products: " start
        if [[ $start =~ ^[0-9]+$ ]]; then
            break
        else
            echo "Please enter a valid non-negative number."
        fi
    done

    while true; do
        read -p "How many products do you wish to calculate? " num_products
        if [[ $num_products =~ ^[0-9]+$ ]] && (( num_products > 0 )); then
            break
        else
            echo "Please enter a valid positive number."
        fi
    done

    while true; do
        read -p "Enter a positive number to check if it is divisible by these products: " divisor
        if [[ $divisor =~ ^[0-9]+$ ]] && (( divisor > 0 )); then
            break
        else
            echo "Please enter a valid positive number."
        fi
    done

    echo "Beginning the calculation of successive products, starting with $start..."

    # Initialize counter for loop iterations
    counter=1

    while [[ $counter -le $num_products ]]; do
        # Compute the product of the current and next number
        product=$(( start * (start + 1) ))

        # Display the product and determine if it's a factor of the divisor
        echo -n "Product: $product - "

        if (( divisor % product == 0 )); then
            echo "This is a divisor of $divisor."
        else
            echo "This is NOT a divisor of $divisor."
        fi

        # Increase the starting number for the next calculation
        start=$(( start + 1 ))

        # Move to the next iteration
        counter=$(( counter + 1 ))
    done
}

task3()
{
    # Input a, b, and c, values

    while true; do
    echo "Enter non-negative integer values for a, b, and c: " 
    
        read -p "a: " a
        read -p "b: " b
        read -p "c: " c

# Validate non-negative integer input (a, b, and c)

    if (( a >= 0 && b >= 0 && c >= 0 )); then

        echo "Valid input for a, b, and c: values are non-negative integers."
        break
    else
        echo "Invalid input for a, b, and c: values must be non-negative integers."
        fi
    done

# Input n1 and n2 values

    while true; do
    echo "Enter natural number values for range [n1, n2]: " 
    
        read -p "n1: " n1
        read -p "n2: " n2

# Validate natural number input (n1 and n2)

    if (( n1 >= 1 && n2 >= 1 && n1 <= n2 )); then
            
        echo "Valid input for n1 and n2: values are natural numbers and n1 <= n2."
        break
    else
        echo "Invalid input for n1 and n2: values must be natural numbers and n1 <= n2."
        fi
    done

# Print sequence terms

    echo "The terms of the sequence are:"
    terms=()
    
    for (( n = n1; n <= n2; n++ )); do
        term=$(( $a * ($n**3) + $b * $n + $c ))
            terms+=("$term")
    done
        echo "${terms[@]}"

# Calculate product of first and last terms

    first_term=$(( $a * ($n1**3) + $b * $n1 + $c ))

        last_term=$(( $a * ($n2**3) + $b * $n2 + $c ))
        
            product=$(( $first_term * $last_term ))
    
    echo "The product of the first and last terms is: $product"

# Check if product is a multiple of 4

    if (( product % 4 == 0 )); then

        echo "The product is a multiple of 4."
    else
        echo "The product is not a multiple of 4."
    fi
}


# -----------------
#       MENU 
# -----------------
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
# fourth case handles exiting, fifth case invalid user input
for ((;;))
do
	echo -e "\nPress A or a to calculate triangular numbers "
	echo -e "Press B or b to calculate numbers as products of successive numbers "
    echo -e "Press C or c to generate sequence by formula"
    echo -e "Press E or e to exit"
    echo
	read -p "Enter your menu choice: " choice

	case $choice in
	    "A" | "a") echo -e "You chose task 1\n " 
        task1;;
        "B" | "b") echo -e "You chose task 2\n " 
        task2;;
	    "C" | "c") echo -e "You chose task 3\n "
        task3;;
        "E" | "e") echo -e "You chose to exit. Goodbye."
        exit 1;;
        *) echo -n "Invalid input! " ;;
	esac
done


