using System.Numerics;

namespace VariousStructs
{
    public struct Mat4x4
    {
        public float M11;
        public float M12;
        public float M13;
        public float M14;

        public float M21;
        public float M22;
        public float M23;
        public float M24;

        public float M31;
        public float M32;
        public float M33;
        public float M34;

        public float M41;
        public float M42;
        public float M43;
        public float M44;

        public static void MultiplyMatrixVector(Vector3 i, out Vector3 o, Mat4x4 m)
        {
            o = new Vector3
            {
                X = (i.X * m.M11) + (i.Y * m.M21) + (i.Z * m.M31) + m.M41,
                Y = (i.X * m.M12) + (i.Y * m.M22) + (i.Z * m.M32) + m.M42,
                Z = (i.X * m.M13) + (i.Y * m.M23) + (i.Z * m.M33) + m.M43
            };
            var w = (i.X * m.M14) + (i.Y * m.M24) + (i.Z * m.M34) + m.M44;

            if (w != 0)
            {
                o.X /= w;
                o.Y /= w;
                o.Z /= w;
            }
        }
    }
}
