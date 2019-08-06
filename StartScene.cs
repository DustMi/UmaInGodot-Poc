using Godot;
using System;
using UMA.CharacterSystem;
using System.Collections.Generic;
using UMA;
using System.IO;
using YamlDotNet;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using RawYaml;


public class StartScene : Spatial
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
    
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        StreamReader textReader = new StreamReader(@"./UMA/Content/UMA_Core/HumanMale/Slots/Body/UMA_Human_Male_Legs_Slot.asset");
        textReader.ReadLine();
        textReader.ReadLine();
        textReader.ReadLine();
        var deserializer = new DeserializerBuilder()
                .WithNamingConvention(new CamelCaseNamingConvention())
                .Build();
        
        var slotData = deserializer.Deserialize<SlotYaml>(textReader);
        
        GD.Print(slotData.MonoBehaviour.MName);
        
        var verticeOrder = decodeUnitysCompressionSubMesh(slotData.MonoBehaviour.MeshData.Submeshes[0].Triangles);
        var surfaceArray = new Godot.Collections.Array();
        surfaceArray.Resize(ARRAY_MAX);
        surfaceArray[ARRAY_VERTEX] = slotData.MonoBehaviour.MeshData.Vertices;
        surfaceArray[ARRAY_NORMAL] = slotData.MonoBehaviour.MeshData.Normals;
        surfaceArray[ARRAY_TANGENTS] = CreateTangents(slotData.MonoBehaviour.MeshData.Tangents);
        surfaceArray[ARRAY_TEX_UV] = slotData.MonoBehaviour.MeshData.Uv;
        surfaceArray[ARRAY_INDEX] = verticeOrder;

        ArrayMesh legMesh = new ArrayMesh();
        legMesh.AddSurfaceFromArrays(Mesh.PrimitiveType.Triangles, surfaceArray, null, ARRAY_FORMAT_VERTEX + ARRAY_FORMAT_NORMAL + ARRAY_FORMAT_TANGENT + ARRAY_FORMAT_TANGENT);
        var legMaterial = (SpatialMaterial)GD.Load("res://skin.material");
        GD.Print("Surface Count" + legMesh.GetSurfaceCount());
        var node = (MeshInstance)FindNode("UmaMeshNode");
        

        GD.Print(node.GetType());
        GD.Print(node.Mesh.ToString());
        legMesh.SurfaceSetMaterial(0, legMaterial);
        node.SetMesh(legMesh);
        GD.Print(node.Mesh.ToString());
        
        /*
        DynamicCharacterAvatar characterAvatar= new DynamicCharacterAvatar();

        DynamicAssetLoader.Instance = new DynamicAssetLoader();

        UMA.UMAContext.Instance = new UMA.UMAContext();
        characterAvatar.context = UMA.UMAContext.Instance;
        UMA.UMAContext.Instance.raceLibrary = new DynamicRaceLibrary();

        UMATextRecipe textRecipe = new UMATextRecipe();
        textRecipe.recipeString = @"{""version"":3,""packedSlotDataList"":[],""slotsV2"":[],""slotsV3"":[{""id"":""MaleEyes"",""scale"":100,""copyIdx"":-1,""overlays"":[{""id"":""EyeOverlay"",""colorIdx"":3,""rect"":[0,0,0,0]},{""id"":""Default Eye Adjust"",""colorIdx"":2,""rect"":[0,0,0,0]}]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":""MaleInnerMouth"",""scale"":100,""copyIdx"":-1,""overlays"":[{""id"":""InnerMouth"",""colorIdx"":4,""rect"":[0,0,0,0]}]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":""MaleTorso"",""scale"":100,""copyIdx"":-1,""overlays"":[{""id"":""M_BodOverlay 1"",""colorIdx"":0,""rect"":[0,0,0,0]}]},{""id"":""MaleFeet"",""scale"":100,""copyIdx"":16,""overlays"":[]},{""id"":""MaleHands"",""scale"":100,""copyIdx"":16,""overlays"":[]},{""id"":""MaleLegs"",""scale"":100,""copyIdx"":16,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":""M_Highpoly Head"",""scale"":100,""copyIdx"":-1,""overlays"":[{""id"":""M_Face"",""colorIdx"":0,""rect"":[0,0,0,0]}]}],""colors"":[],""fColors"":[{""name"":""Skin"",""colors"":[255,255,255,255,0,0,0,0,255,255,255,255,0,0,0,0,255,255,255,255,0,0,0,0]},{""name"":""Hair"",""colors"":[255,255,255,255,0,0,0,0,255,255,255,255,0,0,0,0,255,255,255,255,0,0,0,0]},{""name"":""Eyes"",""colors"":[255,255,255,255,0,0,0,0,255,255,255,255,0,0,0,0,255,255,255,255,0,0,0,0]},{""name"":""-"",""colors"":[255,255,255,255,0,0,0,0,255,255,255,255,0,0,0,0,255,255,255,255,0,0,0,0]},{""name"":""-"",""colors"":[234,234,234,255,0,0,0,0,255,255,255,255,0,0,0,0,255,255,255,255,0,0,0,0]}],""sharedColorCount"":3,""race"":""HumanMale"",""packedDna"":[{""dnaType"":""DynamicUMADna"",""dnaTypeHash"":815443803,""packedDna"":""{\""bDnaAsset\"":{\""instanceID\"":12024},\""bDnaAssetName\"":\""HumanMaleDynamicDnaAsset\"",\""bDnaSettings\"":[{\""name\"":\""skinGreenness\"",\""value\"":128},{\""name\"":\""skinBlueness\"",\""value\"":128},{\""name\"":\""skinRedness\"",\""value\"":128},{\""name\"":\""height\"",\""value\"":128},{\""name\"":\""headSize\"",\""value\"":128},{\""name\"":\""headWidth\"",\""value\"":128},{\""name\"":\""neckThickness\"",\""value\"":128},{\""name\"":\""armLength\"",\""value\"":128},{\""name\"":\""forearmLength\"",\""value\"":128},{\""name\"":\""armWidth\"",\""value\"":128},{\""name\"":\""forearmWidth\"",\""value\"":128},{\""name\"":\""handsSize\"",\""value\"":128},{\""name\"":\""feetSize\"",\""value\"":128},{\""name\"":\""legSeparation\"",\""value\"":128},{\""name\"":\""upperMuscle\"",\""value\"":128},{\""name\"":\""lowerMuscle\"",\""value\"":128},{\""name\"":\""upperWeight\"",\""value\"":128},{\""name\"":\""lowerWeight\"",\""value\"":128},{\""name\"":\""legsSize\"",\""value\"":128},{\""name\"":\""belly\"",\""value\"":128},{\""name\"":\""waist\"",\""value\"":128},{\""name\"":\""gluteusSize\"",\""value\"":128},{\""name\"":\""earsSize\"",\""value\"":128},{\""name\"":\""earsPosition\"",\""value\"":128},{\""name\"":\""earsRotation\"",\""value\"":128},{\""name\"":\""noseSize\"",\""value\"":128},{\""name\"":\""noseCurve\"",\""value\"":128},{\""name\"":\""noseWidth\"",\""value\"":128},{\""name\"":\""noseInclination\"",\""value\"":128},{\""name\"":\""nosePosition\"",\""value\"":128},{\""name\"":\""nosePronounced\"",\""value\"":128},{\""name\"":\""noseFlatten\"",\""value\"":128},{\""name\"":\""chinSize\"",\""value\"":128},{\""name\"":\""chinPronounced\"",\""value\"":128},{\""name\"":\""chinPosition\"",\""value\"":128},{\""name\"":\""mandibleSize\"",\""value\"":128},{\""name\"":\""jawsSize\"",\""value\"":128},{\""name\"":\""jawsPosition\"",\""value\"":128},{\""name\"":\""cheekSize\"",\""value\"":128},{\""name\"":\""cheekPosition\"",\""value\"":128},{\""name\"":\""lowCheekPronounced\"",\""value\"":128},{\""name\"":\""lowCheekPosition\"",\""value\"":128},{\""name\"":\""foreheadSize\"",\""value\"":128},{\""name\"":\""foreheadPosition\"",\""value\"":128},{\""name\"":\""lipsSize\"",\""value\"":128},{\""name\"":\""mouthSize\"",\""value\"":128},{\""name\"":\""eyeRotation\"",\""value\"":128},{\""name\"":\""eyeSize\"",\""value\"":128},{\""name\"":\""breastSize\"",\""value\"":128},{\""name\"":\""eyeSpacing\"",\""value\"":128}]}""}],""wardrobeSet"":[],""packedRecipeType"":""Standard""}";
        GD.Print(textRecipe.recipeString);
        characterAvatar.umaRecipe = textRecipe;

        UMAGenerator generator = new UMAGenerator();
        characterAvatar.umaGenerator = generator;

        characterAvatar.Start();
        GD.Print("It actually made it to the end of the Start routine!");*/
    
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

    public float[][] CreateTangents(Tangents[] library, int[]correctOrder) {
        var returnValue = new float[correctOrder.Length][];
        for(int i = 0; i < correctOrder.Length; i++) {
            returnValue[i] = new float[] {
                library[correctOrder[i]].X,
                library[correctOrder[i]].Y,
                library[correctOrder[i]].Z,
                library[correctOrder[i]].W
                };
        }
        return returnValue;
    }

    public Vector3[] PutVectorsIntoCorrectOrder(Vector3[] library, int[] correctOrder) {
        Vector3[] returnValue = new Vector3[correctOrder.Length];
        for(int i = 0; i < correctOrder.Length; i++) {
            returnValue[i] = library[correctOrder[i]];
        }
        return returnValue;
    }

    //In the real version, this will need to be optimized to bitshifting
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
}
