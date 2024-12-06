# F# Mutable Variable Swap Issue

This example demonstrates a common point of confusion in F# when dealing with mutable variables and pass-by-value semantics.  The `swap` function appears to correctly swap two mutable variables, but it doesn't behave as expected. The reason is that in F#, integers are passed by value, not by reference. Therefore, the swap function receives *copies* of the variables' values, not the variables themselves. Modifying the copies inside the function does not affect the original variables outside the function.

## Solution

The solution involves using tuples to pass values by reference, or using a more functional approach by returning a new tuple with swapped values.