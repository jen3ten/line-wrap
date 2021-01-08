# Line Wrapper

Import of text document into Google docs confirms that line breaks occur in the middle of paragraphs and sentences.  Paragraphs are separated by a second line break.

StreamReader's ReadLine() method will read in the next line of text, which is everything until the next line break.

StreamReader's Peek() method returns the next available character as its ASCII integer value, but does not consume the character.  The use of Peek() method confirms that both spaces (ASCII decimal 32) and carriage returns (ASCII decimal 13) are used in the text document.  Carriage returns exist within a paragraphs, often in the middle of a sentence.  A combination of a space and carriage return separates each paragraph. 