using Godot;
using System;
using UMA.CharacterSystem;
using UMA;

public class StartScene : Spatial
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        DynamicCharacterAvatar characterAvatar= new DynamicCharacterAvatar();
        UMAGenerator generator = new UMAGenerator();
        characterAvatar.context = new UMA.UMAContext();
        UMATextRecipe textRecipe = new UMATextRecipe();
        textRecipe.recipeString = @"{""version"":3,""packedSlotDataList"":[],""slotsV2"":[],""slotsV3"":[{""id"":""MaleEyes"",""scale"":100,""copyIdx"":-1,""overlays"":[{""id"":""EyeOverlay"",""colorIdx"":3,""rect"":[0,0,0,0]},{""id"":""Default Eye Adjust"",""colorIdx"":2,""rect"":[0,0,0,0]}]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":""MaleInnerMouth"",""scale"":100,""copyIdx"":-1,""overlays"":[{""id"":""InnerMouth"",""colorIdx"":4,""rect"":[0,0,0,0]}]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":""MaleTorso"",""scale"":100,""copyIdx"":-1,""overlays"":[{""id"":""M_BodOverlay 1"",""colorIdx"":0,""rect"":[0,0,0,0]}]},{""id"":""MaleFeet"",""scale"":100,""copyIdx"":16,""overlays"":[]},{""id"":""MaleHands"",""scale"":100,""copyIdx"":16,""overlays"":[]},{""id"":""MaleLegs"",""scale"":100,""copyIdx"":16,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":"""",""scale"":1,""copyIdx"":-1,""overlays"":[]},{""id"":""M_Highpoly Head"",""scale"":100,""copyIdx"":-1,""overlays"":[{""id"":""M_Face"",""colorIdx"":0,""rect"":[0,0,0,0]}]}],""colors"":[],""fColors"":[{""name"":""Skin"",""colors"":[255,255,255,255,0,0,0,0,255,255,255,255,0,0,0,0,255,255,255,255,0,0,0,0]},{""name"":""Hair"",""colors"":[255,255,255,255,0,0,0,0,255,255,255,255,0,0,0,0,255,255,255,255,0,0,0,0]},{""name"":""Eyes"",""colors"":[255,255,255,255,0,0,0,0,255,255,255,255,0,0,0,0,255,255,255,255,0,0,0,0]},{""name"":""-"",""colors"":[255,255,255,255,0,0,0,0,255,255,255,255,0,0,0,0,255,255,255,255,0,0,0,0]},{""name"":""-"",""colors"":[234,234,234,255,0,0,0,0,255,255,255,255,0,0,0,0,255,255,255,255,0,0,0,0]}],""sharedColorCount"":3,""race"":""HumanMale"",""packedDna"":[{""dnaType"":""DynamicUMADna"",""dnaTypeHash"":815443803,""packedDna"":""{\""bDnaAsset\"":{\""instanceID\"":12024},\""bDnaAssetName\"":\""HumanMaleDynamicDnaAsset\"",\""bDnaSettings\"":[{\""name\"":\""skinGreenness\"",\""value\"":128},{\""name\"":\""skinBlueness\"",\""value\"":128},{\""name\"":\""skinRedness\"",\""value\"":128},{\""name\"":\""height\"",\""value\"":128},{\""name\"":\""headSize\"",\""value\"":128},{\""name\"":\""headWidth\"",\""value\"":128},{\""name\"":\""neckThickness\"",\""value\"":128},{\""name\"":\""armLength\"",\""value\"":128},{\""name\"":\""forearmLength\"",\""value\"":128},{\""name\"":\""armWidth\"",\""value\"":128},{\""name\"":\""forearmWidth\"",\""value\"":128},{\""name\"":\""handsSize\"",\""value\"":128},{\""name\"":\""feetSize\"",\""value\"":128},{\""name\"":\""legSeparation\"",\""value\"":128},{\""name\"":\""upperMuscle\"",\""value\"":128},{\""name\"":\""lowerMuscle\"",\""value\"":128},{\""name\"":\""upperWeight\"",\""value\"":128},{\""name\"":\""lowerWeight\"",\""value\"":128},{\""name\"":\""legsSize\"",\""value\"":128},{\""name\"":\""belly\"",\""value\"":128},{\""name\"":\""waist\"",\""value\"":128},{\""name\"":\""gluteusSize\"",\""value\"":128},{\""name\"":\""earsSize\"",\""value\"":128},{\""name\"":\""earsPosition\"",\""value\"":128},{\""name\"":\""earsRotation\"",\""value\"":128},{\""name\"":\""noseSize\"",\""value\"":128},{\""name\"":\""noseCurve\"",\""value\"":128},{\""name\"":\""noseWidth\"",\""value\"":128},{\""name\"":\""noseInclination\"",\""value\"":128},{\""name\"":\""nosePosition\"",\""value\"":128},{\""name\"":\""nosePronounced\"",\""value\"":128},{\""name\"":\""noseFlatten\"",\""value\"":128},{\""name\"":\""chinSize\"",\""value\"":128},{\""name\"":\""chinPronounced\"",\""value\"":128},{\""name\"":\""chinPosition\"",\""value\"":128},{\""name\"":\""mandibleSize\"",\""value\"":128},{\""name\"":\""jawsSize\"",\""value\"":128},{\""name\"":\""jawsPosition\"",\""value\"":128},{\""name\"":\""cheekSize\"",\""value\"":128},{\""name\"":\""cheekPosition\"",\""value\"":128},{\""name\"":\""lowCheekPronounced\"",\""value\"":128},{\""name\"":\""lowCheekPosition\"",\""value\"":128},{\""name\"":\""foreheadSize\"",\""value\"":128},{\""name\"":\""foreheadPosition\"",\""value\"":128},{\""name\"":\""lipsSize\"",\""value\"":128},{\""name\"":\""mouthSize\"",\""value\"":128},{\""name\"":\""eyeRotation\"",\""value\"":128},{\""name\"":\""eyeSize\"",\""value\"":128},{\""name\"":\""breastSize\"",\""value\"":128},{\""name\"":\""eyeSpacing\"",\""value\"":128}]}""}],""wardrobeSet"":[],""packedRecipeType"":""Standard""}";
        GD.Print(textRecipe.recipeString);
        characterAvatar.umaRecipe = textRecipe;
        characterAvatar.umaGenerator = generator;
        characterAvatar.Start();
        GD.Print("It actually made it to the end of the Start routine!");
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
