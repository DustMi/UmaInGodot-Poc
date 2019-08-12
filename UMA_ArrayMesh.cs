using Godot;
using System;
using System.Collections.Generic;
using UMA;
using System.IO;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using RawYaml;

public class UMA_ArrayMesh : Node
{
    const int NUMBER_OF_HEX_CHARACTERS_PER_VALUE = 8;
    const int ARRAY_VERTEX = 0;
    const int ARRAY_NORMAL = 1;
    const int ARRAY_TANGENTS = 2;
    const int ARRAY_COLOR = 3;
    const int ARRAY_TEX_UV= 4;
    const int ARRAY_TEX_UV2 = 5;
    const int ARRAY_BONES = 6;
    const int ARRAY_WEIGHTS = 7;
    const int ARRAY_INDEX = 8;
    const int ARRAY_MAX = 9;
    const int ARRAY_FORMAT_VERTEX = 1;
    const int ARRAY_FORMAT_NORMAL = 2;
    const int ARRAY_FORMAT_TANGENT = 4;
    const int ARRAY_FORMAT_COLOR = 8;
    const int ARRAY_FORMAT_TEX_UV = 16;
    const int ARRAY_FORMAT_TEX_UV2 = 32;
    const int ARRAY_FORMAT_BONES = 64;
    const int ARRAY_FORMAT_WEIGHTS = 128;
    const int ARRAY_FORMAT_INDEX = 256;
    const int ARRAY_WEIGHTS_SIZE = 4;
    // Called when the node enters the scene tree for the first time.
    ArrayMesh GodotArrayMesh = new ArrayMesh();
    Dictionary<string, RenderableSlot> renderableSlots = new Dictionary<string, RenderableSlot>();
    Dictionary<string, Godot.Collections.Array> arrayMeshSurfaces = new Dictionary<string, Godot.Collections.Array>();
    MeshInstance _meshNode;
    public UMA_ArrayMesh(MeshInstance meshNode ) {
        _meshNode = meshNode;
    }

    public override void _Ready()
    {
        
    }

    public void AddSlot(string surfaceName, RenderableSlot slot) {
        renderableSlots.Add(slot.SlotName, slot);
        if(arrayMeshSurfaces.ContainsKey(surfaceName)) {
            CombineSlotsToSurface(surfaceName, slot.MeshInfo);
        } else {
            arrayMeshSurfaces.Add(surfaceName, slot.MeshInfo);
        }
    }

    public void Render() {
        foreach(var surfaceName in arrayMeshSurfaces.Keys) {
            GodotArrayMesh.AddSurfaceFromArrays(Mesh.PrimitiveType.Triangles, arrayMeshSurfaces[surfaceName]);
            GodotArrayMesh.SurfaceSetName(GodotArrayMesh.GetSurfaceCount() -1  ,surfaceName);
        }
        var material = (SpatialMaterial)GD.Load("res://skin.material");

        //GD.Print(node.GetType());
        //GD.Print(node.Mesh.ToString());
        //myMesh.SurfaceSetMaterial(myMesh.GetSurfaceCount()-1, material);
        var surfaceIndex = GodotArrayMesh.SurfaceFindByName("MaleTorso");
        
        var newMaterial = new SpatialMaterial();

        var albedoTexture = new Texture3D();
        albedoTexture.SetPath("./UMA/Content/UMA_Core/HumanMale/Textures/Body/M_H_body1_Albedo.png");

        //GodotArrayMesh.SurfaceSetMaterial(newMaterial, material);

        _meshNode.SetMesh(GodotArrayMesh);
        //GD.Print(node.Mesh.ToString());
    }
    protected void CombineSlotsToSurface(string surfaceName, Godot.Collections.Array newMesh) {
        var surface = arrayMeshSurfaces[surfaceName];
        int originalVertexLength = ((Vector3[])surface[ARRAY_VERTEX]).Length;
        surface[ARRAY_VERTEX]   = CombineArrays<Vector3>((Vector3[])surface[ARRAY_VERTEX],   (Vector3[])newMesh[ARRAY_VERTEX]);
        surface[ARRAY_NORMAL]   = CombineArrays<Vector3>((Vector3[])surface[ARRAY_NORMAL],   (Vector3[])newMesh[ARRAY_NORMAL]);
        surface[ARRAY_TANGENTS] = CombineArrays<System.Single>((System.Single[])surface[ARRAY_TANGENTS], (System.Single[])newMesh[ARRAY_TANGENTS]);
        surface[ARRAY_TEX_UV]   = CombineArrays<Vector2>((Vector2[])surface[ARRAY_TEX_UV],   (Vector2[])newMesh[ARRAY_TEX_UV]);
        surface[ARRAY_TEX_UV2]  = CombineArrays<Vector2>((Vector2[])surface[ARRAY_TEX_UV2],  (Vector2[])newMesh[ARRAY_TEX_UV2]);
        surface[ARRAY_BONES]    = CombineArrays<int>    ((int[])    surface[ARRAY_BONES],    (int[])newMesh    [ARRAY_BONES]);
        surface[ARRAY_WEIGHTS]  = CombineArrays<float>  ((float[])  surface[ARRAY_WEIGHTS],  (float[])newMesh  [ARRAY_WEIGHTS]);
        surface[ARRAY_INDEX]    = CombineIndexArray     ((int[])    surface[ARRAY_INDEX],    (int[])newMesh    [ARRAY_INDEX], originalVertexLength);
        //surface[ARRAY_VERTEX]   = CombineArrays<Vector3>((Vector3[])surface[ARRAY_VERTEX],   (Vector3[])newMesh[ARRAY_VERTEX]);
    }
    protected T[] CombineArrays<T>(T[] a1, T[] a2) {
        if(a1 == null && a2 == null) {
            return null;
        }
        else if(a1 == null) {
            return a2;
        }
        else if(a2 == null) {
            return a1;
        } else {
            T[] CombinedArray = new T[a1.Length + a2.Length];
            a1.CopyTo(CombinedArray, 0);
            a2.CopyTo(CombinedArray, a1.Length);
            return CombinedArray;
        }
    }

    protected int[] CombineIndexArray(int[] original, int[] append, int originalVertexLength) {
        if(original == null && append == null) {
            return null;
        }
        else if(original == null) {
            return append;
        }
        else if(append == null) {
            return original;
        } else {
            int[] newArray = new int[original.Length + append.Length];
            original.CopyTo(newArray, 0);
            for(int i = 0; i < append.Length; i++){
                newArray[original.Length + i] = append[i] + originalVertexLength;
            }
            return newArray;
        }
    }
}
