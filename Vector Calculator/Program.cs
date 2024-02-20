using System;

namespace Vector_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int UserInputX1;
            int UserInputY1;
            int UserInputZ1;
            int UserInputX2;
            int UserInputY2;
            int UserInputZ2;
            int UserInputX3;
            int UserInputY3;
            int UserInputZ3;
            int UserInputX4;
            int UserInputY4;
            int UserInputZ4;
            int UserInputScale;

            string UserNumber;



            //Add


            Console.WriteLine("ADDING");

            Console.WriteLine("The X of the 1st Vector");
            UserNumber = Console.ReadLine();
            UserInputX1 = Convert.ToInt32(UserNumber);

            Console.WriteLine("The Y of the 1st Vector");
            UserNumber = Console.ReadLine();
            UserInputY1 = Convert.ToInt32(UserNumber);

            Console.WriteLine("The Z of the 1st Vector");
            UserNumber = Console.ReadLine();
            UserInputZ1 = Convert.ToInt32(UserNumber);

            Vector userVector1 = new Vector(UserInputX1, UserInputY1, UserInputZ1);


            Console.WriteLine("The X of the 2nd Vector");
            UserNumber = Console.ReadLine();
            UserInputX2 = Convert.ToInt32(UserNumber);

            Console.WriteLine("The Y of the 2nd Vector");
            UserNumber = Console.ReadLine();
            UserInputY2 = Convert.ToInt32(UserNumber);

            Console.WriteLine("The Z of the 2nd Vector");
            UserNumber = Console.ReadLine();
            UserInputZ2 = Convert.ToInt32(UserNumber);

            Vector userVector2 = new Vector(UserInputX2, UserInputY2, UserInputZ2);

            Console.WriteLine(Vector.Add(userVector1, userVector2));



            //Subtract


            Console.WriteLine(" ");
            Console.WriteLine("SUBTRACTING");

            Console.WriteLine("The X of the 1st Vector");
            UserNumber = Console.ReadLine();
            UserInputX1 = Convert.ToInt32(UserNumber);

            Console.WriteLine("The Y of the 1st Vector");
            UserNumber = Console.ReadLine();
            UserInputY1 = Convert.ToInt32(UserNumber);

            Console.WriteLine("The Z of the 1st Vector");
            UserNumber = Console.ReadLine();
            UserInputZ1 = Convert.ToInt32(UserNumber);

            Vector userVector3 = new Vector(UserInputX1, UserInputY1, UserInputZ1);


            Console.WriteLine("The X of the 2nd Vector");
            UserNumber = Console.ReadLine();
            UserInputX2 = Convert.ToInt32(UserNumber);

            Console.WriteLine("The Y of the 2nd Vector");
            UserNumber = Console.ReadLine();
            UserInputY2 = Convert.ToInt32(UserNumber);

            Console.WriteLine("The Z of the 2nd Vector");
            UserNumber = Console.ReadLine();
            UserInputZ2 = Convert.ToInt32(UserNumber);

            Vector userVector4 = new Vector(UserInputX2, UserInputY2, UserInputZ2);

            Console.WriteLine(Vector.Subtract(userVector3, userVector4));


            // Negate

            Console.WriteLine(" ");
            Console.WriteLine("NEGATE");

            Console.WriteLine("The X of the 1st Vector");
            UserNumber = Console.ReadLine();
            UserInputX1 = Convert.ToInt32(UserNumber);

            Console.WriteLine("The Y of the 1st Vector");
            UserNumber = Console.ReadLine();
            UserInputY1 = Convert.ToInt32(UserNumber);

            Console.WriteLine("The Z of the 1st Vector");
            UserNumber = Console.ReadLine();
            UserInputZ1 = Convert.ToInt32(UserNumber);

            Vector userVector5 = new Vector(UserInputX1, UserInputY1, UserInputZ1);

            Console.WriteLine(Vector.Negate(userVector5));



            // Scale

            Console.WriteLine(" ");
            Console.WriteLine("SCALE");

            Console.WriteLine("The X of the 1st Vector");
            UserNumber = Console.ReadLine();
            UserInputX1 = Convert.ToInt32(UserNumber);

            Console.WriteLine("The Y of the 1st Vector");
            UserNumber = Console.ReadLine();
            UserInputY1 = Convert.ToInt32(UserNumber);

            Console.WriteLine("The Z of the 1st Vector");
            UserNumber = Console.ReadLine();
            UserInputZ1 = Convert.ToInt32(UserNumber);

            Console.WriteLine("The Scale you'd like to use");
            UserNumber = Console.ReadLine();
            UserInputScale = Convert.ToInt32(UserNumber);

            Vector userVector6 = new Vector(UserInputX1, UserInputY1, UserInputZ1);

            Console.WriteLine(Vector.Scale(userVector6, UserInputScale));


            // Magnitude

            Console.WriteLine(" ");
            Console.WriteLine("MAGNITUDE");

            Console.WriteLine("The X of the 1st Vector");
            UserNumber = Console.ReadLine();
            UserInputX1 = Convert.ToInt32(UserNumber);

            Console.WriteLine("The Y of the 1st Vector");
            UserNumber = Console.ReadLine();
            UserInputY1 = Convert.ToInt32(UserNumber);

            Console.WriteLine("The Z of the 1st Vector");
            UserNumber = Console.ReadLine();
            UserInputZ1 = Convert.ToInt32(UserNumber);

            Vector userVector7 = new Vector (UserInputX1, UserInputY1, UserInputZ1);

            Console.WriteLine(userVector7.GetMagnitude());


            // Direction

            Console.WriteLine(" ");
            Console.WriteLine("DIRECTION");

            Console.WriteLine("The X of the 1st Vector");
            UserNumber = Console.ReadLine();
            UserInputX1 = Convert.ToInt32(UserNumber);

            Console.WriteLine("The Y of the 1st Vector");
            UserNumber = Console.ReadLine();
            UserInputY1 = Convert.ToInt32(UserNumber);


            Vector userVector8 = new Vector(UserInputX1, UserInputY1, 0);

            Console.WriteLine(userVector8.GetDirection());


            // Normalize

            Console.WriteLine(" ");
            Console.WriteLine("NORMALIZE");

            Console.WriteLine("The X of the 1st Vector");
            UserNumber = Console.ReadLine();
            UserInputX1 = Convert.ToInt32(UserNumber);

            Console.WriteLine("The Y of the 1st Vector");
            UserNumber = Console.ReadLine();
            UserInputY1 = Convert.ToInt32(UserNumber);

            Console.WriteLine("The Z of the 1st Vector");
            UserNumber = Console.ReadLine();
            UserInputZ1 = Convert.ToInt32(UserNumber);


            Vector userVector9 = new Vector(UserInputX1, UserInputY1, UserInputZ1);

            Console.WriteLine(Vector.Normalize(userVector9));

            // Dot product

            Console.WriteLine(" ");
            Console.WriteLine("DOT PRODUCT");

            Console.WriteLine("The X of the 1st Vector");
            UserNumber = Console.ReadLine();
            UserInputX1 = Convert.ToInt32(UserNumber);

            Console.WriteLine("The Y of the 1st Vector");
            UserNumber = Console.ReadLine();
            UserInputY1 = Convert.ToInt32(UserNumber);

            Console.WriteLine("The Z of the 1st Vector");
            UserNumber = Console.ReadLine();
            UserInputZ1 = Convert.ToInt32(UserNumber);

            Vector userVector10 = new Vector(UserInputX1, UserInputY1, UserInputZ1);


            Console.WriteLine("The X of the 2nd Vector");
            UserNumber = Console.ReadLine();
            UserInputX2 = Convert.ToInt32(UserNumber);

            Console.WriteLine("The Y of the 2nd Vector");
            UserNumber = Console.ReadLine();
            UserInputY2 = Convert.ToInt32(UserNumber);

            Console.WriteLine("The Z of the 2nd Vector");
            UserNumber = Console.ReadLine();
            UserInputZ2 = Convert.ToInt32(UserNumber);

            Vector userVector11 = new Vector(UserInputX2, UserInputY2, UserInputZ2);

            Console.WriteLine(Vector.DotProduct(userVector10, userVector11));

            // Cross product

            Console.WriteLine(" ");
            Console.WriteLine("CROSS PRODUCT");

            Console.WriteLine("The X of the 1st Vector");
            UserNumber = Console.ReadLine();
            UserInputX1 = Convert.ToInt32(UserNumber);

            Console.WriteLine("The Y of the 1st Vector");
            UserNumber = Console.ReadLine();
            UserInputY1 = Convert.ToInt32(UserNumber);

            Console.WriteLine("The Z of the 1st Vector");
            UserNumber = Console.ReadLine();
            UserInputZ1 = Convert.ToInt32(UserNumber);

            Vector userVector12 = new Vector(UserInputX1, UserInputY1, UserInputZ1);


            Console.WriteLine("The X of the 2nd Vector");
            UserNumber = Console.ReadLine();
            UserInputX2 = Convert.ToInt32(UserNumber);

            Console.WriteLine("The Y of the 2nd Vector");
            UserNumber = Console.ReadLine();
            UserInputY2 = Convert.ToInt32(UserNumber);

            Console.WriteLine("The Z of the 2nd Vector");
            UserNumber = Console.ReadLine();
            UserInputZ2 = Convert.ToInt32(UserNumber);

            Vector userVector13 = new Vector(UserInputX2, UserInputY2, UserInputZ2);

            Console.WriteLine(Vector.CrossProduct(userVector12, userVector13));

            // Angle Between

            Console.WriteLine(" ");
            Console.WriteLine("ANGLE BETWEEN (Outputs in Rads)");

            Console.WriteLine("The X of the 1st Vector");
            UserNumber = Console.ReadLine();
            UserInputX3 = Convert.ToInt32(UserNumber);

            Console.WriteLine("The Y of the 1st Vector");
            UserNumber = Console.ReadLine();
            UserInputY3 = Convert.ToInt32(UserNumber);

            Console.WriteLine("The Z of the 1st Vector");
            UserNumber = Console.ReadLine();
            UserInputZ3 = Convert.ToInt32(UserNumber);

            Vector userVector14 = new Vector(UserInputX3, UserInputY3, UserInputZ3);


            Console.WriteLine("The X of the 2nd Vector");
            UserNumber = Console.ReadLine();
            UserInputX4 = Convert.ToInt32(UserNumber);

            Console.WriteLine("The Y of the 2nd Vector");
            UserNumber = Console.ReadLine();
            UserInputY4 = Convert.ToInt32(UserNumber);

            Console.WriteLine("The Z of the 2nd Vector");
            UserNumber = Console.ReadLine();
            UserInputZ4 = Convert.ToInt32(UserNumber);

            Vector userVector15 = new Vector(UserInputX4, UserInputY4, UserInputZ4);

            Console.WriteLine(Vector.AngleBetween(userVector14, userVector15));

            // Projection

            Console.WriteLine(" ");
            Console.WriteLine("PROJECTION");

            Console.WriteLine("The X of the 1st Vector");
            UserNumber = Console.ReadLine();
            UserInputX3 = Convert.ToInt32(UserNumber);

            Console.WriteLine("The Y of the 1st Vector");
            UserNumber = Console.ReadLine();
            UserInputY3 = Convert.ToInt32(UserNumber);

            Console.WriteLine("The Z of the 1st Vector");
            UserNumber = Console.ReadLine();
            UserInputZ3 = Convert.ToInt32(UserNumber);

            Vector userVector16 = new Vector(UserInputX3, UserInputY3, UserInputZ3);


            Console.WriteLine("The X of the 2nd Vector");
            UserNumber = Console.ReadLine();
            UserInputX4 = Convert.ToInt32(UserNumber);

            Console.WriteLine("The Y of the 2nd Vector");
            UserNumber = Console.ReadLine();
            UserInputY4 = Convert.ToInt32(UserNumber);

            Console.WriteLine("The Z of the 2nd Vector");
            UserNumber = Console.ReadLine();
            UserInputZ4 = Convert.ToInt32(UserNumber);

            Vector userVector17 = new Vector(UserInputX4, UserInputY4, UserInputZ4);

            Console.WriteLine(Vector.ProjectOnto(userVector16, userVector17));

        }
    }

    
}
