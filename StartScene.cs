using Godot;
using System;
using System.Collections.Generic;
using UMA;
using System.IO;
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
    const int ARRAY_WEIGHTS_SIZE = 4;

    
    
    public static Dictionary<string, string> slotFileLookup = new Dictionary<string, string>() {
        {"MaleEyes"       , "./UMA/Content/UMA_Core/HumanMale/Slots/Body/UMA_Human_Male_Eyes_Slot.asset"},
        {"MaleInnerMouth" , "./UMA/Content/UMA_Core/HumanMale/Slots/Body/UMA_Human_Male_InnerMouth_Slot.asset"},
        {"MaleTorso"      , "./UMA/Content/UMA_Core/HumanMale/Slots/Body/UMA_Human_Male_Torso_Slot.asset"},
        {"MaleFeet"       , "./UMA/Content/UMA_Core/HumanMale/Slots/Body/UMA_Human_Male_Feet_Slot.asset"},
        {"MaleHands"      , "./UMA/Content/UMA_Core/HumanMale/Slots/Body/UMA_Human_Male_Hands_Slot.asset"},
        {"MaleLegs"       , "./UMA/Content/UMA_Core/HumanMale/Slots/Body/UMA_Human_Male_Legs_Slot.asset"},
        {"M_Highpoly Head", "./UMA/Content/UMA_Core/HumanMale/Slots/Body/MidPoly/UMA_Human_Male_Head_Mid_Slot.asset"},
        //{"Mist", "should%cause$an\\error#"}
    };
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        UMATextRecipe textRecipe = new UMATextRecipe();
        textRecipe.recipeString = @"{""version"":3,""packedSlotDataList"":[],""slotsV2"":[],""slotsV3"":[{""id"":""MaleEyes"",""scale"":100,""copyIdx"":-1,""overlays"":[{""id"":""EyeOverlay"",""colorIdx"":3,""rect"":[0,0,0,0]},{""id"":""Default Eye Adjust"",""colorIdx"":2,""rect"":[0,0,0,0]}]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":""MaleInnerMouth"",""scale"":100,""copyIdx"":-1,""overlays"":[{""id"":""InnerMouth"",""colorIdx"":4,""rect"":[0,0,0,0]}]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":""MaleTorso"",""scale"":100,""copyIdx"":-1,""overlays"":[{""id"":""M_BodOverlay 1"",""colorIdx"":0,""rect"":[0,0,0,0]}]},{""id"":""MaleFeet"",""scale"":100,""copyIdx"":16,""overlays"":[]},{""id"":""MaleHands"",""scale"":100,""copyIdx"":16,""overlays"":[]},{""id"":""MaleLegs"",""scale"":100,""copyIdx"":16,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":""M_Highpoly Head"",""scale"":100,""copyIdx"":-1,""overlays"":[{""id"":""M_Face"",""colorIdx"":0,""rect"":[0,0,0,0]}]}],""colors"":[],""fColors"":[{""name"":""Skin"",""colors"":[255,255,255,255,0,0,0,0,255,255,255,255,0,0,0,0,255,255,255,255,0,0,0,0]},{""name"":""Hair"",""colors"":[255,255,255,255,0,0,0,0,255,255,255,255,0,0,0,0,255,255,255,255,0,0,0,0]},{""name"":""Eyes"",""colors"":[255,255,255,255,0,0,0,0,255,255,255,255,0,0,0,0,255,255,255,255,0,0,0,0]},{""name"":""-"",""colors"":[255,255,255,255,0,0,0,0,255,255,255,255,0,0,0,0,255,255,255,255,0,0,0,0]},{""name"":""-"",""colors"":[234,234,234,255,0,0,0,0,255,255,255,255,0,0,0,0,255,255,255,255,0,0,0,0]}],""sharedColorCount"":3,""race"":""HumanMale"",""packedDna"":[{""dnaType"":""DynamicUMADna"",""dnaTypeHash"":815443803,""packedDna"":""{\""bDnaAsset\"":{\""instanceID\"":12024},\""bDnaAssetName\"":\""HumanMaleDynamicDnaAsset\"",\""bDnaSettings\"":[{\""name\"":\""skinGreenness\"",\""value\"":128},{\""name\"":\""skinBlueness\"",\""value\"":128},{\""name\"":\""skinRedness\"",\""value\"":128},{\""name\"":\""height\"",\""value\"":128},{\""name\"":\""headSize\"",\""value\"":128},{\""name\"":\""headWidth\"",\""value\"":128},{\""name\"":\""neckThickness\"",\""value\"":128},{\""name\"":\""armLength\"",\""value\"":128},{\""name\"":\""forearmLength\"",\""value\"":128},{\""name\"":\""armWidth\"",\""value\"":128},{\""name\"":\""forearmWidth\"",\""value\"":128},{\""name\"":\""handsSize\"",\""value\"":128},{\""name\"":\""feetSize\"",\""value\"":128},{\""name\"":\""legSeparation\"",\""value\"":128},{\""name\"":\""upperMuscle\"",\""value\"":128},{\""name\"":\""lowerMuscle\"",\""value\"":128},{\""name\"":\""upperWeight\"",\""value\"":128},{\""name\"":\""lowerWeight\"",\""value\"":128},{\""name\"":\""legsSize\"",\""value\"":128},{\""name\"":\""belly\"",\""value\"":128},{\""name\"":\""waist\"",\""value\"":128},{\""name\"":\""gluteusSize\"",\""value\"":128},{\""name\"":\""earsSize\"",\""value\"":128},{\""name\"":\""earsPosition\"",\""value\"":128},{\""name\"":\""earsRotation\"",\""value\"":128},{\""name\"":\""noseSize\"",\""value\"":128},{\""name\"":\""noseCurve\"",\""value\"":128},{\""name\"":\""noseWidth\"",\""value\"":128},{\""name\"":\""noseInclination\"",\""value\"":128},{\""name\"":\""nosePosition\"",\""value\"":128},{\""name\"":\""nosePronounced\"",\""value\"":128},{\""name\"":\""noseFlatten\"",\""value\"":128},{\""name\"":\""chinSize\"",\""value\"":128},{\""name\"":\""chinPronounced\"",\""value\"":128},{\""name\"":\""chinPosition\"",\""value\"":128},{\""name\"":\""mandibleSize\"",\""value\"":128},{\""name\"":\""jawsSize\"",\""value\"":128},{\""name\"":\""jawsPosition\"",\""value\"":128},{\""name\"":\""cheekSize\"",\""value\"":128},{\""name\"":\""cheekPosition\"",\""value\"":128},{\""name\"":\""lowCheekPronounced\"",\""value\"":128},{\""name\"":\""lowCheekPosition\"",\""value\"":128},{\""name\"":\""foreheadSize\"",\""value\"":128},{\""name\"":\""foreheadPosition\"",\""value\"":128},{\""name\"":\""lipsSize\"",\""value\"":128},{\""name\"":\""mouthSize\"",\""value\"":128},{\""name\"":\""eyeRotation\"",\""value\"":128},{\""name\"":\""eyeSize\"",\""value\"":128},{\""name\"":\""breastSize\"",\""value\"":128},{\""name\"":\""eyeSpacing\"",\""value\"":128}]}""}],""wardrobeSet"":[],""packedRecipeType"":""Standard""}";
        UMAPackedRecipeBase.UMAPackRecipe packRecipe = textRecipe.PackedLoad();
        GD.Print(packRecipe.slotsV3.Length);
        var node = (MeshInstance)GetNode("/root/Spatial/UmaMeshNode");
        UMA_ArrayMesh uma = new UMA_ArrayMesh(node);
        foreach(var slot in packRecipe.slotsV3) {
            if(!string.IsNullOrWhiteSpace(slot.id)) {
                var fileName = slotFileLookup[slot.id];
                RenderableSlot rs = new RenderableSlot(fileName);
                string LayerName = slot.copyIdx == -1 ? slot.id : packRecipe.slotsV3[slot.copyIdx].id;
                uma.AddSlot(LayerName, rs);
            }
        }
        uma.Render();

        //RenderSlot(@"./UMA/Content/UMA_Core/HumanMale/Slots/Body/UMA_Human_Male_Legs_Slot.asset");
        //RenderSlot(@"./UMA/Content/UMA_Core/HumanMale/Slots/Body/UMA_Human_Male_Feet_Slot.asset");
        //StreamReader textReader = new StreamReader(@"./UMA/Content/UMA_Core/HumanMale/Slots/Body/UMA_Human_Male_Legs_Slot.asset");
        /*
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
        IList<int> boneIndexes=new List<int>();
        IList<float> boneWeights=new List<float>();
        FillBoneAndWeightArray(slotData.MonoBehaviour.MeshData.BoneWeights, boneIndexes, boneWeights);
        surfaceArray[ARRAY_BONES] = boneIndexes;
        surfaceArray[ARRAY_WEIGHTS] = boneWeights;
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
        */
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
/*
    public void RenderSlot(string fileName) {
        StreamReader textReader = new StreamReader(fileName);
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
        List<int> boneIndexes=new List<int>();
        List<float> boneWeights=new List<float>();
        FillBoneAndWeightArray(slotData.MonoBehaviour.MeshData.BoneWeights, boneIndexes, boneWeights);
        surfaceArray[ARRAY_BONES] = boneIndexes.ToArray();
        surfaceArray[ARRAY_WEIGHTS] = boneWeights.ToArray();
        surfaceArray[ARRAY_INDEX] = verticeOrder;

        myMesh.AddSurfaceFromArrays(Mesh.PrimitiveType.Triangles, surfaceArray, null, ARRAY_FORMAT_VERTEX + ARRAY_FORMAT_NORMAL + ARRAY_FORMAT_TANGENT + ARRAY_FORMAT_TANGENT);
        var material = (SpatialMaterial)GD.Load("res://skin.material");
        GD.Print("Surface Count" + myMesh.GetSurfaceCount());
        var node = (MeshInstance)FindNode("UmaMeshNode");
        

        GD.Print(node.GetType());
        GD.Print(node.Mesh.ToString());
        myMesh.SurfaceSetMaterial(myMesh.GetSurfaceCount()-1, material);
        node.SetMesh(myMesh);
        GD.Print(node.Mesh.ToString());
    }*/
}
