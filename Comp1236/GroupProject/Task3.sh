#!/bin/bash
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
