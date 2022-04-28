# Approximating Pi

### What?
I remember seeing something similar in an early probability course at uni, but with a triangle. I then stumbled upon the same challenge: _how can you approximate Pi using a uniform distribution?_

### How?
Well the answer is that for a number of `n` points uniformly distributed between `[0, 1)` you can basically take the ratio of points inside a circule of radius one, and a square of perimiter 4. 

### Invocation
Something like `dotnet run Program.fs`
