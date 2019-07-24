using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Godot;

namespace UnityEngine
{
    //
    // Summary:
    //     Represents an axis aligned bounding box.
    public struct Bounds : IEquatable<Bounds>
    {
        //
        // Summary:
        //     Creates a new Bounds.
        //
        // Parameters:
        //   center:
        //     The location of the origin of the Bounds.
        //
        //   size:
        //     The dimensions of the Bounds.
        public Bounds(Vector3 center, Vector3 size)
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     The extents of the Bounding Box. This is always half of the size of the Bounds.
        public Vector3 extents { get; set; }
        //
        // Summary:
        //     The total size of the box. This is always twice as large as the extents.
        public Vector3 size { get; set; }
        //
        // Summary:
        //     The center of the bounding box.
        public Vector3 center { get; set; }
        //
        // Summary:
        //     The minimal point of the box. This is always equal to center-extents.
        public Vector3 min { get; set; }
        //
        // Summary:
        //     The maximal point of the box. This is always equal to center+extents.
        public Vector3 max { get; set; }

        //
        // Summary:
        //     The closest point on the bounding box.
        //
        // Parameters:
        //   point:
        //     Arbitrary point.
        //
        // Returns:
        //     The point on the bounding box or inside the bounding box.
        public Vector3 ClosestPoint(Vector3 point)
        {
            throw new NotImplementedException();
        }
        //
        // Summary:
        //     Is point contained in the bounding box?
        //
        // Parameters:
        //   point:

        public bool Contains(Vector3 point)
        {
            throw new NotImplementedException();
        }
        //
        // Summary:
        //     Grows the Bounds to include the point.
        //
        // Parameters:
        //   point:
        public void Encapsulate(Vector3 point)
        {
            throw new NotImplementedException();
        }
        //
        // Summary:
        //     Grow the bounds to encapsulate the bounds.
        //
        // Parameters:
        //   bounds:
        public void Encapsulate(Bounds bounds)
        {
            throw new NotImplementedException();
        }
        public override bool Equals(object other)
        {
            throw new NotImplementedException();
        }
        public bool Equals(Bounds other)
        {
            throw new NotImplementedException();
        }
        //
        // Summary:
        //     Expand the bounds by increasing its size by amount along each side.
        //
        // Parameters:
        //   amount:
        public void Expand(float amount)
        {
            throw new NotImplementedException();
        }
        //
        // Summary:
        //     Expand the bounds by increasing its size by amount along each side.
        //
        // Parameters:
        //   amount:
        public void Expand(Vector3 amount)
        {
            throw new NotImplementedException();
        }
        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
        //
        // Summary:
        //     Does ray intersect this bounding box?
        //
        // Parameters:
        //   ray:
        public bool IntersectRay(Ray ray)
        {
            throw new NotImplementedException();
        }
        public bool IntersectRay(Ray ray, out float distance)
        {
            throw new NotImplementedException();
        }
        //
        // Summary:
        //     Does another bounding box intersect with this bounding box?
        //
        // Parameters:
        //   bounds:
        public bool Intersects(Bounds bounds)
        {
            throw new NotImplementedException();
        }
        //
        // Summary:
        //     Sets the bounds to the min and max value of the box.
        //
        // Parameters:
        //   min:
        //
        //   max:
        public void SetMinMax(Vector3 min, Vector3 max)
        {
            throw new NotImplementedException();
        }
        //
        // Summary:
        //     The smallest squared distance between the point and this bounding box.
        //
        // Parameters:
        //   point:
        public float SqrDistance(Vector3 point)
        {
            throw new NotImplementedException();
        }
        //
        // Summary:
        //     Returns a nicely formatted string for the bounds.
        //
        // Parameters:
        //   format:
        public string ToString(string format)
        {
            throw new NotImplementedException();
        }
        //
        // Summary:
        //     Returns a nicely formatted string for the bounds.
        //
        // Parameters:
        //   format:
        public override string ToString()
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(Bounds lhs, Bounds rhs)
        {
            throw new NotImplementedException();
        }
        public static bool operator !=(Bounds lhs, Bounds rhs)
        {
            throw new NotImplementedException();
        }
    }
}
