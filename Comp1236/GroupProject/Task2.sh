#!/bin/bash
  
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
