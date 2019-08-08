using Godot;
using System;
using System.Collections.Generic;
using System.IO;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using RawYaml;

public class RenderableSlot : Node
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

    public Godot.Collections.Array MeshInfo;
    public string SlotName;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

    public RenderableSlot(string fileName) {
        StreamReader textReader = new StreamReader(fileName);
        textReader.ReadLine();
        textReader.ReadLine();
        textReader.ReadLine();
        var deserializer = new DeserializerBuilder()
                .WithNamingConvention(new CamelCaseNamingConvention())
                .Build();
        
        var slotData = deserializer.Deserialize<SlotYaml>(textReader);
        SlotName = slotData.MonoBehaviour.MName.ReplaceN(" ", string.Empty);
        GD.Print(SlotName);
        
        var verticeOrder = decodeUnitysCompressionSubMesh(slotData.MonoBehaviour.MeshData.Submeshes[0].Triangles);
        var surfaceArray = new Godot.Collections.Array();
        surfaceArray.Resize(ARRAY_MAX);
        surfaceArray[ARRAY_VERTEX] = slotData.MonoBehaviour.MeshData.Vertices;
        surfaceArray[ARRAY_NORMAL] = slotData.MonoBehaviour.MeshData.Normals;
        surfaceArray[ARRAY_TANGENTS] = CreateTangents(slotData.MonoBehaviour.MeshData.Tangents);
        surfaceArray[ARRAY_TEX_UV] = slotData.MonoBehaviour.MeshData.Uv;
        List<int> boneIndexes=new List<int>();
        List<float> boneWeights=new List<float>();
        FillBoneAndWeightArray(slotData.MonoBehaviour.MeshData.BoneWeights, boneIndexes, boneWeights);
        surfaceArray[ARRAY_BONES] = boneIndexes.ToArray();
        surfaceArray[ARRAY_WEIGHTS] = boneWeights.ToArray();
        surfaceArray[ARRAY_INDEX] = verticeOrder;
    }

    public int[] decodeUnitysCompressionSubMesh(string hexArray) {
        if(hexArray.Length % NUMBER_OF_HEX_CHARACTERS_PER_VALUE > 0) {
            throw new ArgumentOutOfRangeException(hexArray, "Length must be a multiple of 8");
        }
        var verticeOrder = new int[hexArray.Length/NUMBER_OF_HEX_CHARACTERS_PER_VALUE];
        for(int i = 0; i < hexArray.Length; i += NUMBER_OF_HEX_CHARACTERS_PER_VALUE) {
            char[] hexChar = new char[NUMBER_OF_HEX_CHARACTERS_PER_VALUE];
            hexChar[0] = hexArray[i + 6];
            hexChar[1] = hexArray[i + 7];
            hexChar[2] = hexArray[i + 4];
            hexChar[3] = hexArray[i + 5];
            hexChar[4] = hexArray[i + 2];
            hexChar[5] = hexArray[i + 3];
            hexChar[6] = hexArray[i + 0];
            hexChar[7] = hexArray[i + 1];
            string hexstring = new String(hexChar);
            int verticeNumber = int.Parse(hexstring, System.Globalization.NumberStyles.HexNumber);
            verticeOrder[(verticeOrder.Length - 1) - i/NUMBER_OF_HEX_CHARACTERS_PER_VALUE] = verticeNumber;
        }
        return verticeOrder;
    }

    public void FillBoneAndWeightArray(BoneWeight[] boneWeights, IList<int> boneIndexes, IList<float> weights){
        for(int i = 0; i < boneWeights.Length; i++) {
            boneIndexes.Add(boneWeights[i].BoneIndex0);
            boneIndexes.Add(boneWeights[i].BoneIndex1);
            boneIndexes.Add(boneWeights[i].BoneIndex2);
            boneIndexes.Add(boneWeights[i].BoneIndex3);
            weights.Add(boneWeights[i].Weight0);
            weights.Add(boneWeights[i].Weight1);
            weights.Add(boneWeights[i].Weight2);
            weights.Add(boneWeights[i].Weight3);
        }
    }

    public float[] CreateTangents(Tangents[] raw) {
        var returnValue = new float[raw.Length * 4];
        for(int i = 0; i < raw.Length; i += 4) {
            returnValue[i+0] = raw[i/4].X;
            returnValue[i+1] = raw[i/4].Y;
            returnValue[i+2] = raw[i/4].Z;
            returnValue[i+3] = -raw[i/4].W;
        }
        return returnValue;
    }
}
