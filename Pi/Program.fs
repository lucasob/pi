open System

type Coordinate = {X: double; Y: double}

// Coordinate where X, Y are both contained in [lower, upper)
let RandomCoordinate () =
    { X = (Random().NextDouble()); Y = (Random().NextDouble()) }
    
// Need a representation of all coordinates in our range
let GenerateRandomCoordinates (num: int) =
    [ for _ in 1..num do RandomCoordinate() ]

// Need to know if a given coordinate falls within a circle of some radius
let ContainedWithinRadius (radius: double) (coordinate: Coordinate) =
    (coordinate.X ** 2.) + (coordinate.Y ** 2.) <= radius 
    
let CalculatePi (samplePoints: int) =
    let coords = (GenerateRandomCoordinates samplePoints)
    let withinRadius = List.filter (ContainedWithinRadius 1.0) coords
    let ratio = ((List.length withinRadius |> double) / (List.length coords |> double))
    
    // This might not be obvious: but essentially in the question we can *only* consider the coordinates
    // from [0, 1). Now, this is 1/4 of a circle, and as such, we must change the equation for the area of
    // a circle from x ** 2 + y ** 2 = r to be (1/4 (...))
    // Or, alternatively, bc multiplication is commutative, i can just pull the 4 out here :D 
    4. * ratio


[<EntryPoint>]
let main _ =
    printfn $"Pi is: %f{CalculatePi 1000000}" 
    0 // return an integer exit code