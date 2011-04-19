Pick Akin
---------

You have to manage product codes for a specific inhouse portfolio. All product codes in your company follow a certain convention. A product code is separated into two parts - a single character department source qualifier and a unique product number.

#### An Enigma for products ####
Example Product Codes: `A1, B52, D2, X404`

The "department source qualifier" (aka DSQ)
	|
	v
	B52
	 ^^
	  |
	  The product number (aka PN)


Moreover, you have two separate lists of product codes at hand. The first list is from your CEO, while the second list origins from internal controlling department. Obviously, both lists are different. It's not only that one list contains product codes the other does not have, but as well that both lists seem to have different product numbering schemes.

#### Make your CEO happy ####
You have been assigned by your CEO to complete the following task:
Pick all "akin" products by examining their DSQ. If both lists contain product codes of same DSQ, remove them from original list and copy them over to a new "Akin"-List. Leave the remaining product codes as is.

The following two lists:

    ceoList = [A1,B2,A2,A3,C1,D1,E1,E2]
    controlList = [F1,D2,B2,B3,A4]
		  

Result ot following "Akin List" with modified CEO and control lists:

    akinList = [A1,B2,A2,A3,B3,A4,D1,D2,B2]
    ceoList = [C1,E1,E2]
    controlList = [F1]

#### Be smart ####
Let's put it straight: Write a program that takes two lists (`ceoList` and `controlList`) containing an arbitrary set of product codes in the above described format. The program produces three lists. The first list is the `akinList`, that is, the list of all akin products taken from the input lists. The remaining two lists are the reduced `ceoList` and `controlList`, respectively.  



About
-----
The kata stems from a real life scenario. Actually, I did not invent the kata, all credits go to its original inventor, [Dr.M][drm]. What I did is just to take the essence of the problem and rephrase it a little bit with a story. That's it.

The objective of this kata is to sharpen design skills for trivial algorithms. [Dr.M][drm] originally posted the problem alongside with a requirement of maximum time complexity O(n^2). A secondary requirement for the solution algorithm is terseness and expressiveness. The more elegant your algorithm is (with respect to the time complexity), the "better".

> __"Pick Akin"__ is a great little problem to chew on. It teaches you lightweight algorithm design while exposing you to the world of list processing and mingling. It is indeed a good code kata to practice your TDD / BDD skills.
> 
> This code kata is dedicated to its inventor, [Dr.M][drm].
> 
> [@ilkerde](http://ilker.de)

_(Source http://ilker.de/code-kata-pickakin)_

[drm]: http://swemusings.blogspot.com/ "SWE Musings, the blog of Dr.M"

