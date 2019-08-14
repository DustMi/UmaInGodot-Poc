using Godot;
using System;
using System.IO;

public class ReadBinaryFile : Node
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }
    long offset;
    long size;
    string filepath;
    public string FileText(string path) {
        //GetFileScheme
        FileStream stream = new FileStream(path, FileMode.Open);
        size = stream.Length;
        offset = 0;
        var reader = new EndianReader(stream, EndianType.BigEndian);
        bool isSerializedFile = IsSerializedFileHeader(reader);
		//metaReader.Close();
		GD.Print(isSerializedFile);
		//var fullReader = new EndianReader(stream, SwapEndianess ? EndianType.LittleEndian : EndianType.BigEndian);
		//GD.Print("sizeCalc: " + (int)(fileSize - stream.Position));
		string unityVersion = reader.ReadStringZeroTerm();
		var MetaRearder = new EndianReader(stream, EndianType.LittleEndian);
		GD.Print(unityVersion);//unity version
		uint platform = MetaRearder.ReadUInt32();
		GD.Print("platform: " + platform.ToString());//platform/ 4294967294
		GD.Print("SerializeTypeTrees:" + MetaRearder.ReadBoolean());//SerializeTypeTrees
		int RTTIBaseClassDescriptorArrayCount = MetaRearder.ReadInt32();  //should be 1
		GD.Print(RTTIBaseClassDescriptorArrayCount);
		var ClassID = MetaRearder.ReadInt32(); //classID type 114
		GD.Print(ClassID);
		var IsStrippedType = MetaRearder.ReadBoolean(); //false
		GD.Print(IsStrippedType);
		var ScriptID = MetaRearder.ReadInt16(); //0
		GD.Print(ScriptID);
		//scriptHash
		var Data0 = MetaRearder.ReadUInt32(); //1730628693
		GD.Print(Data0);
		var Data1 = MetaRearder.ReadUInt32(); //4260848438
		GD.Print(Data1);
		var Data2 = MetaRearder.ReadUInt32(); //1175725339
		GD.Print(Data2);
		var Data3 = MetaRearder.ReadUInt32(); //646866029
		GD.Print(Data3);
		GD.Print($"{Data0:x8}{Data1:x8}{Data2:x8}{Data3:x8}");
		//TypeHash
		var tData0 = MetaRearder.ReadUInt32(); //1730628693
		GD.Print(tData0);
		var tData1 = MetaRearder.ReadUInt32(); //4260848438
		GD.Print(tData1);
		var tData2 = MetaRearder.ReadUInt32(); //1175725339
		GD.Print(tData2);
		var tData3 = MetaRearder.ReadUInt32(); //646866029
		GD.Print(tData3);
		GD.Print($"{tData0:x8}{tData1:x8}{tData2:x8}{tData3:x8}");

		/*while(metaReader.BaseStream.Position < 30000) {
			var output = metaReader.ReadStringZeroTerm();
			GD.Print(output);
		}*/
        
        //confirm it is a serialized file
        //Read File
        return "";
    }
    const int MetadataMinSize = 16;
    public const int HeaderMinSize = 16;
    int metadataSize;
    uint fileSize;
    int generation;
	uint DataOffset;
	bool SwapEndianess;
	FileGeneration binaryType;
    public bool IsSerializedFileHeader(EndianReader reader)
		{
			if (reader.BaseStream.Position + HeaderMinSize > reader.BaseStream.Length)
			{
				return false;
			}
			metadataSize = reader.ReadInt32();
			if (metadataSize < MetadataMinSize)
			{
				return false;
			}
			fileSize = reader.ReadUInt32();
			if (fileSize < HeaderMinSize + MetadataMinSize)
			{
				return false;
			}
			generation = reader.ReadInt32();//17
			if (!Enum.IsDefined(typeof(FileGeneration), generation))
			{
				return false;
			}
			binaryType = (FileGeneration)generation;
			DataOffset = reader.ReadUInt32();//4096
			if (IsReadEndian(binaryType))
			{
				SwapEndianess = reader.ReadBoolean();//false = little endian, true = big endian
				reader.AlignStream(AlignType.Align4);
			}
			GD.Print("metadataSize: " + metadataSize); //3997
			GD.Print("fileSize: " + fileSize); //4832
			GD.Print("binaryType: " + binaryType);//FG_550_2018

			return true;
		}
		public static bool IsReadEndian(FileGeneration generation)
		{
			return generation >= FileGeneration.FG_350_47x;
		}
}
		
public enum FileGeneration
	{
		FG_120_200		= 5,
		FG_210_261		= 6,
		FG_300b			= 7,
		FG_300_342		= 8,
		FG_350_47x		= 9,
		FG_500a1		= 10,
		FG_500aunk		= 11,
		FG_500aunk1		= 12,
		FG_500aunk2		= 13,
		FG_500			= 14,
		FG_501_54		= 15,
		FG_5unknown		= 16,
		FG_550_2018		= 17,
		FG_2019aunk		= 18,
		FG_20191		= 19,
		FG_20192_x		= 20,
	}