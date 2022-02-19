# This is description of this programm.

My programm is consist from 3 methods.

## **1 method is *"HowManyWordsInLine"***

This method take string variable after user entered it. 

**This method return data type *int*** and it counts numbers of words in user's line, or rather numbers of "space" between words.

**One input arguments** is string variable that was entered by user.

## **2 method is *"CreateNewArray"***

**This method return data type *string [ ]***. 

**Two input arguments**. One of it is string variable the same as in method *"HowManyWordsInLine"*. Second argument is *int* result of working "HowManyWordsInLine" method.

There is creating new variable with data type string [ ]. Size of this array depends on *int* argument. There is cycle for moving inside of another argument. It's user's text. So while progamm don't find " " will be filled current element of newer array. When programm find " " it means number of element (increment) increase on 1 and will be filled next element.

## **3 method is *"ShowImportant"***

**This method return nothing (data type is "void")**

**One input argument**. It's array, that was created in second method.

There is a cycle for moving inside of this new array, but there is a condition that will help to catch words that have 5 or more character.
