using static System.Console;
using System.Globalization;

class PhotoDemo
{
    public static void Main()
    {
        Photo stdPhoto = new Photo();
        Photo customPhoto = new Photo();
        MattedPhoto mattedPhoto = new MattedPhoto();
        FramedPhoto framedPhoto = new FramedPhoto();
        //code the rest of the method
        //From the assignment instructions:
        //Create a class named Photo that includes fields for width and height in inches and properties for each field. 
        //The class should contain get and set accessors named Width and Height respectively.
        //...8-inch by 10-inch photo, ...10-inch by 12-inch photo, and ...other size (because custom cutting is required). 
        //note that the Photo class does not have a Color Property

        //HINT: Set the properties for each of the above Photo objects (instances) as per the instructions
		//here are the standard photo properties being set. You do the same with the customPhoto, mattedPhoto, and framedPhoto objects
		stdPhoto.Width = 8;
        stdPhoto.Height = 10;

        //HINT: (3) Do this third - set customPhoto properties

        //HINT: (8) Do this eighth - set mattedPhoto properties

        //HINT: (13) Do this thirteenth - set framedPhoto properties
        
        //HINT: use WriteLine statements to call each Photo objects' overridden ToString method to display output
		//here is the call to the stdPhoto object's overridden ToString method. You do the same with the customPhoto, mattedPhoto, and framedPhoto objects
		WriteLine(stdPhoto.ToString());

        //HINT: (4) Do this fourth - call customPhoto ToString method here

        //HINT: (9) Do this ninth - call mattedPhoto ToString method here

        //HINT: (14) Do this fourteenth - call framedPhoto ToString method here
		
    }
}

class Photo
{
    private double width = 0;
    private double height = 0;
    protected double price;
    private const double STDWIDTH1 = 8;
    private const double STDHEIGHT1 = 10;
    private const double STDPRICE1 = 3.99;
    private const double STDWIDTH2 = 10;
    private const double STDHEIGHT2 = 12;
    private const double STDPRICE2 = 5.99;
    private const double CUSTOMPRICE = 9.99;
    public double Width
    {
        get
        {
            return width;
        }
        set
        {
            width = value;
            SetPrice(0);
        }
    }
    public double Height
    {
        get
        {
            return height;
        }
        set
        {
            height = value;
            SetPrice(0);
        }
    }
    public double Price
    {
        get
        {
            return price;
        }
    }
    //From the instructions:
    //Include a protected price field, and set it to $3.99 for an 8-inch by 10-inch photo, 
    //$5.99 for a 10-inch by 12-inch photo, and $9.99 for any other size (because custom cutting is required).
    protected void SetPrice(double premium)
    {
        //code this

        //HINT: (2) Do this second
        //HINT: use a condition to check the width and height to set the price as either the STDHEIGHT1, 
        //STDHEIGHT2, or CUSTOMPRICE (that gets the premium added to the price) price value.
    }
    public override string ToString()
    {
        //code this
        //From the assignment instructions:
        //Also include a ToString() method that returns a string constructed from the return value of 
        //the object’s GetType() method and the values of the fields.
        //An example of the program is shown below:
        //Photo    8 X 10   Price: $3.99
        //Photo    8 X 9   Price: $9.99

        //HINT: (1) Do this first
        //HINT: use GetType() with the Width, Height, and Price properties in a return statement
    }
}

class MattedPhoto : Photo
{
    //code this
    //From the instructions:
    //The MattedPhoto class includes a string field named Color to hold a color....
    //The price for a MattedPhoto increases by $10 over its base cost....

    //HINT: (5) Do this fifth - set Premium constant and Color property
    //HINT: set a Premium constant for the MattedPhoto ($10)
    //HINT: set a Color auto-implemented property

    //From the instructions:
    //Each subclass should include a ToString()method that overrides the parent class version.
    //ToString() method start
        //HINT (6): do this sixth - create ToString method and call the SetPrice(PREMIUM) method here
        
        //...returns a string constructed from the return value of 
        //the object’s GetType() method and the values of the fields.
        //An example of the program is shown below:
        //MattedPhoto    white matting 10 X 12   Price: $15.99

        //HINT (7): do this seventh
        //HINT: use GetType() with the Color matting, Width, Height, and Price properties in a return statement

    //ToString() method end
}

class FramedPhoto : Photo
{
    //code this
    //From the instructions:
    //...and the FramedPhoto class includes two string fields that hold the frame’s material (such as silver) 
    //and style (such as modern), named Material and Style respectively
    //....the price for a FramedPhoto increases by $25 over its base cost

    //HINT (10) - do this tenth - set Premium const and Material and Style properties
    //HINT: set a Premium constant for the FramedPhoto ($25)
    //HINT: set a Material and Style auto-implemented properties
    
    //From the instructions:
    //Each subclass should include a ToString()method that overrides the parent class version.
    //ToString() method start
        //HINT (11): do this eleventh - create ToString method and call the SetPrice(PREMIUM) method here

        //HINT: call the SetPrice(PREMIUM) method here
	    //...returns a string constructed from the return value of 
        //the object’s GetType() method and the values of the fields.
        //An example of the program is shown below:
        //FramedPhoto    modern, silver frame. 8 X 10   Price: $28.99

        //HINT (12): do this twelfth
        //HINT: use GetType() with the Style, Material frame, Width, Height, and Price properties in a return statement
        
    //ToString() method end
}