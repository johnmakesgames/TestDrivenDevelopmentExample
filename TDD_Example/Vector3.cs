using System;
using System.Collections.Generic;
using System.Text;

namespace TDD_Example
{
    public class Vector3
    {
        public float x;
        public float y;
        public float z;

        public Vector3()
        {
            x = 0;
            y = 0;
            z = 0;
        }

        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public float GetMagnitude()
        {
            float mag = 0;

            float xSquared = (float)Math.Pow(x, 2);
            float ySquared = (float)Math.Pow(y, 2);
            float zSquared = (float)Math.Pow(z, 2);

            mag = (float)Math.Sqrt(xSquared + ySquared + zSquared);
            return mag;
        }

        public void Normalize()
        {
            Vector3 normal = GetNormal();
            this.x = normal.x;
            this.y = normal.y;
            this.z = normal.z;
        }

        public Vector3 GetNormal()
        {
            float magnitude = GetMagnitude();
            float x = this.x / magnitude;
            float y = this.y / magnitude;
            float z = this.z / magnitude;

            Vector3 result = new Vector3(x, y, z);
            return result;
        }

        public float GetDotProduct(Vector3 v2)
        {
            float mag1 = this.GetMagnitude();
            float mag2 = v2.GetMagnitude();
            float dot = (this.x * v2.x) + (this.y * v2.y) + (this.z * v2.z);
            float product = dot / (mag1 * mag2);
            return product;
        }

        public static Vector3 operator +(Vector3 v1, Vector3 v2)
        {
            var result = new Vector3();

            result.x = v1.x + v2.x;
            result.y = v1.y + v2.y;
            result.z = v1.z + v2.z;

            return result;
        }
    }
}
