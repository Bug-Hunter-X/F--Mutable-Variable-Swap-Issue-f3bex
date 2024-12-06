let mutable x = 10
let mutable y = 20

let swap (x, y) = 
    let temp = x
    x <- y
    y <- temp
    (x,y)

let (x, y) = swap (x, y)
printf "%d %d" x y //This will print 20 10 which is correct

//Functional approach:
let swapFunctional x y = (y,x)
let (x1, y1) = swapFunctional x y
printf "%d %d" x1 y1