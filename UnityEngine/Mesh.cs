using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{ 
    public class Mesh : Object
    {
        public BoneWeight[] boneWeights;
        public Matrix4x4[] bindposes;
        public Color32[] colors32;
        public Vector3[] vertices;
        public Vector3[] normals;
        public Vector2[] uv;
        public Vector2[] uv2;
        public Vector2[] uv3;
        public Vector2[] uv4;
        public int[] triangles;
        public Vector4[] tangents;
        public int subMeshCount;
        public int vertexCount => vertices?.Length ?? 0;

        public int blendShapeCount { get; }
        public int GetBlendShapeIndex(string blendShapeName)
        {
            throw new NotImplementedException();
        }

        public string GetBlendShapeName(int shapeIndex)
        {
            throw new NotImplementedException();
        }

        public void SetVertices(List<Vector3> inVertices)
        {
            throw new NotImplementedException();
        }
        public void SetUVs(int channel, List<Vector2> uvs)
        {
            throw new NotImplementedException();
        }
        public void SetTriangles(int[] triangles, int submesh)
        {
            throw new NotImplementedException();
        }
        public void SetTriangles(List<int> triangles, int submesh)
        {
            throw new NotImplementedException();
        }
        public void SetTangents(List<Vector4> inTangents)
        {
            throw new NotImplementedException();
        }
        public void SetNormals(List<Vector3> inNormals)
        {
            throw new NotImplementedException();
        }
        public void SetColors(List<Color> inColors)
        {
            throw new NotImplementedException();
        }
        public void SetColors(List<Color32> inColors)
        {
            throw new NotImplementedException();
        }
        public void RecalculateBounds()
        {
            throw new NotImplementedException();
        }
        public int[] GetTriangles(int submesh)
        {
            throw new NotImplementedException();
        }

        public float GetBlendShapeFrameWeight(int shapeIndex, int frameIndex)
        {
            throw new NotImplementedException();
        }

        public void GetBlendShapeFrameVertices(int shapeIndex, int frameIndex, Vector3[] deltaVertices,
            Vector3[] deltaNormals, Vector3[] deltaTangents)
        {
            throw new NotImplementedException();
        }

        public int GetBlendShapeFrameCount(int shapeIndex)
        {
            throw new NotImplementedException();
        }

        public void ClearBlendShapes()
        {
            throw new NotImplementedException();
        }

        public void AddBlendShapeFrame(string shapeName, float frameWeight, Vector3[] deltaVertices,
            Vector3[] deltaNormals, Vector3[] deltaTangents)
        {
            throw new NotImplementedException();
        }
    }
}
