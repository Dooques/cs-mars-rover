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

### Model Layer
- Enum classes for Instruction (M, L, R) & Direction (N, E, S, W)
- Plateau Size record - stores int Height and Width
- Position Record - Stores X, Y & Direction 

### Parsing Layer
- Data Manager stores data for the program in memory
	- Contains Plateau Size, Starting Position of Rover & next Instruction
- Input Parser takes string inputs and converts them to usable instructions for the Logic Layer.
	- Separate methods for Plateau, Position and Instructions.
