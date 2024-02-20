using System;

namespace Vector_Calculator
{
    public class Vector
    {
        public static readonly Vector Zero = new Vector(1, 1, 1);
        public static readonly Vector One = new Vector(0, 0, 0);

        public double x;
        public double y;
        public double z;

        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return $"<{x}, {y}, {z}>";
        }

        public double GetMagnitude()
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
        }

        public double GetDirection()
        {
            return Math.Atan(y / x);
        }

        public static Vector Add(Vector v1, Vector v2)
        {
            return new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }

        public static Vector Negate(Vector v1)
        {
            return new Vector(v1.x * -1, v1.y * -1, v1.z * -1);
        }

        public static Vector Subtract(Vector v1, Vector v2)
        {
            return new Vector(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        }

        public static Vector Scale(Vector v1, double scaleNum)
        {
            return new Vector(v1.x * scaleNum, v1.y * scaleNum, v1.z * scaleNum);
        }

        public static Vector Normalize(Vector v)
        {
            return new Vector(v.x / v.GetMagnitude(), v.y / v.GetMagnitude(), v.z / v.GetMagnitude());
        }

        public static double DotProduct(Vector v1, Vector v2)
        {
            return (v1.x * v2.x) + (v1.y * v2.y) + (v1.z * v2.z);
        }

        public static Vector CrossProduct(Vector v1, Vector v2)
        {
            return new Vector((v1.y * v2.z) - (v1.z * v2.y), (v1.z * v2.x) - (v1.x * v2.z), (v1.x * v2.y) - (v1.y * v2.x));
        }

        public static double AngleBetween(Vector v1, Vector v2)
        {
            return Math.Acos(DotProduct(v1, v2) / (v1.GetMagnitude() * v2.GetMagnitude()));
        }

        public static Vector ProjectOnto(Vector v1, Vector v2)
        {
            double NewScale = DotProduct(v1, v2) / (Math.Pow(v2.GetMagnitude(), 2));
            return Vector.Scale(v2, NewScale);
        }
    }
}
