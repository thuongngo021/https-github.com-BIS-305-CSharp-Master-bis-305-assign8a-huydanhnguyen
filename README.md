# BIS 305 Assignment 8A - Program Exercise 10-2.

Create an application class named PhotoDemo that demonstrates the methods of three 
related classes for a company that develops photographs.

Create a class named Photo that includes fields for width and height in inches and 
properties for each field. The class should contain get and set accessors named Width 
and Height respectively.

Include a protected price field, and set it to $3.99 for an 8-inch by 10-inch 
photo, $5.99 for a 10-inch by 12-inch photo, and $9.99 for any other size (because 
custom cutting is required). The price field requires a get accessor but no set accessor.

Also include a ToString() method that returns a string constructed from the return 
value of the object’s GetType() method and the values of the fields.

Derive two subclasses— MattedPhoto and FramedPhoto.

The MattedPhoto class includes a string field named Color to hold a color, and the 
FramedPhoto class includes two string fields that hold the frame’s material (such 
as silver) and style (such as modern), named Material and Style respectively.

The price for a MattedPhoto increases by $10 over its base cost, and the price for 
a FramedPhoto increases by $25 over its base cost. Each subclass should include a 
ToString()method that overrides the parent class version.

An example of the program outcome is shown below:
```html
Photo    8 X 10   Price: $3.99
Photo    8 X 9   Price: $9.99
MattedPhoto    white matting 10 X 12   Price: $15.99
FramedPhoto    modern, silver frame. 8 X 10   Price: $28.99
```

**NOTE** that in order to pass this repo's tests, in addition to MindTap, to prepend the $ to currency values, use the `CultureInfo.GetCultureInfo` method. In order to do this, include the statement `using System.Globalization;` at the top of your program and format the output statements as follows: 

```csharp
  WriteLine("This is an example: {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));
```
