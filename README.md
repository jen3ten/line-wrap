# Line Wrapper

An import of the text document into Google docs confirms that line breaks occur in the middle of paragraphs and sentences.  Paragraphs are separated by a second line break.

StreamReader's ReadLine() method will read in the next line of text, which is everything until the next line break.

StreamReader's Peek() method returns the next available character as its ASCII integer value, but does not consume the character.  The use of Peek() method confirms that both spaces (ASCII decimal 32) and carriage returns (ASCII decimal 13) are used in the text document.  Carriage returns exist within a paragraphs, often in the middle of a sentence.  A combination of a space and carriage return separates each paragraph. 

This application first converts the stream to a list of paragraphs with the ConvertTextFileToParagraphList() method.  Lines are read until a space is found between paragraphs.

Individual paragraphs are printed to the console in substrings that are no longer than 80 characters with the AddLineWrapToParagraph() method.

A screen shot of the result can be found in the [word-wrap-results.png](./word-wrap-results.png) file.

