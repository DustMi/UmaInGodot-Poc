using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Godot;

namespace UnityEngine
{
    public class Collider : Component
    {
        public Collider()
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Enabled Colliders will collide with other Colliders, disabled Colliders won't.
        public bool enabled { get; set; }
        //
        // Summary:
        //     The rigidbody the collider is attached to.
        public Rigidbody attachedRigidbody { get; }
        //
        // Summary:
        //     Is the collider a trigger?
        public bool isTrigger { get; set; }
        //
        // Summary:
        //     Contact offset value of this collider.
        public float contactOffset { get; set; }
        //
        // Summary:
        //     The world space bounding volume of the collider (Read Only).
        public Bounds bounds { get; }
        //
        // Summary:
        //     The shared physic material of this collider.

        //
        // Summary:
        //     Returns a point on the collider that is closest to a given location.
        //
        // Parameters:
        //   position:
        //     Location you want to find the closest point to.
        //
        // Returns:
        //     The point on the collider that is closest to the specified location.
        public Vector3 ClosestPoint(Vector3 position)
        {
            throw new NotImplementedException();
        }
        //
        // Summary:
        //     The closest point to the bounding box of the attached collider.
        //
        // Parameters:
        //   position:
        public Vector3 ClosestPointOnBounds(Vector3 position)
        {
            throw new NotImplementedException();
        }
        public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance)
        {
            throw new NotImplementedException();
        }
    }
}