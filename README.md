# MarsRovers

General Approach:
1. Using the description of the problem, extract all major nouns and verbs.
2. Nouns will represent the classes to implement.
3. Verbs will represent the methods to implement.
4. Also identify candidates for enumerations, constants and exceptions.

Assumptions:
1. Two rovers may not occupy the same location on the plateau.  If rover B is about to move such that it would collide (or co-occupy) a location with rover A, the program will throw an exception and halt the progress of rover B.  Rover B will remain in its current position without performing additional instructions.
2. In the interest of not wanting to have rovers damaged, if a rover is about to move such that it would go beyond the boundary of the plateau, effectively falling off the plateau, the program will throw an exception and halt the progress of that rover.  The rover will remain in its current position without performing additional instructions.
3. Rovers will always be deployed such that the intial state does not violate either of the previous two assumptions.  In other words, all rovers will initially occupy a unique and valid location on the plateau.
