# Mars Rover

A terminal app for moving Rovers around on the surface of Mars.

## The Plan
- Create a program that moves Rovers around a 6x6 square.
- The rovers will take commands as a series of Chars provided by the user as a string input
- A map of the square will be presented between inputs
- Show the course of the rover before confirming the movement
- User can control multiple rovers with numbers before the movement input
- Rovers can pick up samples using arms and take photographs

### Potential Extra Features
- Larger area to move
- Power ups
- Dangerous Terrain
- Life?


#### Instruction Parsing
1. User should enter instructions via the terminal
2. Parse Plateau size
3. Parse Rover initial position
4. Parse Instructions to Move Rover

##### Instruction Parser Tests
1. Return empty list when empty string is passed
2. Return list with one value when passed single character string
2. Return list with no values when passed single invalid character string
3. Return list with multiple values when passed string with multiple characters
4. Return an error when invalid data is passed.

##### Instruction Set Tests
1. Return an empty list when passing no values
2. Return empty list when no vaues are created
3. Return list with one value and return list with that instruction