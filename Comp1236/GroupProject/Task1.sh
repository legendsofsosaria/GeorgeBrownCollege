#!/bin/bash

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