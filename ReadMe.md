# Stacky

Stacky is a stack based interpreted language that I made in a few hours as a stepping stone in my journey to interpreters. Stacky is a simple language, only compromising of 19 instructions with 16 of them requiring no operands at all with the stack being 64 kilobytes in size.

The instructions are as follows

<table>
	<tr>
		<td><b>Instruction</b></td>
		<td><b>Description</b></td>
	</tr>
	<tr>
		<td>PUSH</td>
		<td>Pushes the byte value provided into the stack</td>
	</tr>
	<tr>
		<td>POP</td>
		<td>Pops the last value pushed from the stack</td>
	</tr>
	<tr>
		<td>POPP</td>
		<td>Pops the last value pushed from the stack and prints out the integer</td>
	</tr>
	<tr>
		<td>POPPC</td>
		<td>Pops the last value pushed from the stack and prints out the ASCII character</td>
	</tr>
	<tr>
		<td>ADD</td>
		<td>Pops the last two values from the stack, adds them, and pushes the result into the stack</td>
	</tr>
	<tr>
		<td>SUB</td>
		<td>Pops the last two values from the stack, subtracts them, and pushes the result into the stack</td>
	</tr>
	<tr>
		<td>MUL</td>
		<td>Pops the last two values from the stack, multiplies them, and pushes the result into the stack</td>
	</tr>
	<tr>
		<td>DIV</td>
		<td>Pops the last two values from the stack, divides them, and pushes the quotient into the stack</td>
	</tr>
	<tr>
		<td>MOD</td>
		<td>Pops the last two values from the stack, divides them, and pushes the remainder into the stack</td>
	</tr>
	<tr>
		<td>COPY</td>
		<td>Pops the last value from the stack and pushes it two times into the stack</td>
	</tr>
	<tr>
		<td>CCF</td>
		<td>Clears the conditional flag</td>
	</tr>
	<tr>
		<td>CMPE</td>
		<td>Pops the last two values from the stack and compares them, if they are equal the conditional flag is set to true</td>
	</tr>
	<tr>
		<td>CMPL</td>
		<td>Pops the last two values from the stack and compares them, if the first value is smaller than the second the conditional flag is set to true</td>
	</tr>
	<tr>
		<td>CMPG</td>
		<td>Pops the last two values from the stack and compares them, if the first value is bigger than the second the conditional flag is set to true</td>
	</tr>
	<tr>
		<td>JC</td>
		<td>Jumps to the specified line if the conditional flag is set to true</td>
	</tr>
	<tr>
		<td>JMP</td>
		<td>Jumps to the specified line</td>
	</tr>
	<tr>
		<td>RPUSH</td>
		<td>Read a key character from the keyboard as input and pushes the value into the stack</td>
	</tr>
	<tr>
		<td>NEWL</td>
		<td>Prints a new line character</td>
	</tr>
	<tr>
		<td>HAULT</td>
		<td>Stops the program and sets the exit code equal to the value provided</td>
	</tr>
</table>
