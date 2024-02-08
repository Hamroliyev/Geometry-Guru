public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome Geometry Guru Application.");
        Console.WriteLine("How can I help you with geometry.");
        Console.WriteLine("1 - Basic geometry.");
        Console.WriteLine("2 - The area of circle.");
        Console.WriteLine("3 - Check for triangle.");
        Console.Write("Choose your choice : ");
        
        string inputChoice = Console.ReadLine();
        string choice = inputChoice switch
        {
            "1" => @$"              Geometry is the branch of mathematics that deals with shapes, angles, dimensions and sizes of 
            a variety of things we see in everyday life. Geometry is derived from Ancient Greek words – ‘Geo’ means
            ‘Earth’ and ‘metron’ means ‘measurement’. In Euclidean geometry, there are two-dimensional shapes and 
            three-dimensional shapes.  

            In a plane geometry, 2d shapes such as triangles, squares, rectangles, circles are also called flat shapes. 
            In solid geometry, 3d shapes such as a cube, cuboid, cone, etc. are also called solids. The basic geometry is 
            based on points, lines and planes explained in coordinate geometry. 

            The different types of shapes in geometry help us to understand the shapes day to day life. With the help of 
            geometric concepts, we can calculate the area, perimeter and volume of shapes. ",
            
            "2" => @$"              The area of a circle is the amount of space enclosed within the boundary of a circle. The region 
            within the boundary of the circle is the area occupied by the circle. It may also be referred to as the total 
            number of square units inside that circle. Area of Circle = πr^2 or πd^2/4 in square units, where

                        (Pi) π = 22/7 or 3.14.
                        r = radius of the circle
                        d = diameter of the circle
                        Pi (π) is the ratio of circumference to diameter of any circle. 
                        It is a special mathematical constant.",
            "3" => @$"              This theorem simply states that the sum of two sides of a triangle must be greater than the third side.
            If this is true for all three combinations, then you will have a valid triangle. You'll have to go through these
            combinations one by one to make sure that the triangle is possible. You can also think of the triangle as having 
            the side lengths a, b, and c and the theorem being an inequality, which states: a+b > c, a+c > b, and b+c > a."
        };

        Console.WriteLine("Read information based your choice...\n");
        Console.WriteLine(choice);
    }
}