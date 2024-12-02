#!/bin/bash
  
# Request user input
read -p "Please provide the starting number for calculating the successive products: " start
read -p "How many products do you wish to calculate? " num_products
read -p "Enter a positive number to check if it is divisible by these products: " divisor

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
