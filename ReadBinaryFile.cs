using Godot;
using System;
using System.IO;
using System.Collections.Generic;

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
        //FileStream stream = new FileStream(path, FileMode.Open);
		FileStream stream = System.IO.File.OpenRead(path);
        size = stream.Length;
        offset = 0;
        var reader = new EndianReader(stream, EndianType.BigEndian);
        bool isSerializedFile = IsSerializedFileHeader(reader);
		//metaReader.Close();
		GD.Print(isSerializedFile);
		//var fullReader = new EndianReader(stream, SwapEndianess ? EndianType.LittleEndian : EndianType.BigEndian);
		//GD.Print("sizeCalc: " + (int)(fileSize - stream.Position));
		string unityVersion = reader.ReadStringZeroTerm();
		var MetaReader = new EndianReader(stream, EndianType.LittleEndian);
		GD.Print(unityVersion);//unity version
		uint platform = MetaReader.ReadUInt32();
		GD.Print("platform: " + platform.ToString());//platform/ 4294967294
		GD.Print("SerializeTypeTrees:" + MetaReader.ReadBoolean());//SerializeTypeTrees
		int RTTIBaseClassDescriptorArrayCount = MetaReader.ReadInt32();  //should be 1
		GD.Print(RTTIBaseClassDescriptorArrayCount);
		var ClassID = MetaReader.ReadInt32(); //classID type 114
		GD.Print(ClassID);
		var IsStrippedType = MetaReader.ReadBoolean(); //false
		GD.Print(IsStrippedType);
		var ScriptID = MetaReader.ReadInt16(); //0
		GD.Print(ScriptID);
		//scriptHash
		var Data0 = MetaReader.ReadUInt32(); //1730628693
		GD.Print(Data0);
		var Data1 = MetaReader.ReadUInt32(); //4260848438
		GD.Print(Data1);
		var Data2 = MetaReader.ReadUInt32(); //1175725339
		GD.Print(Data2);
		var Data3 = MetaReader.ReadUInt32(); //646866029
		GD.Print(Data3);
		GD.Print($"{Data0:x8}{Data1:x8}{Data2:x8}{Data3:x8}");
		//TypeHash
		var tData0 = MetaReader.ReadUInt32(); //1730628693
		GD.Print(tData0);
		var tData1 = MetaReader.ReadUInt32(); //4260848438
		GD.Print(tData1);
		var tData2 = MetaReader.ReadUInt32(); //1175725339
		GD.Print(tData2);
		var tData3 = MetaReader.ReadUInt32(); //646866029
		GD.Print(tData3);
		GD.Print($"{tData0:x8}{tData1:x8}{tData2:x8}{tData3:x8}");
		var nodeCount = MetaReader.ReadInt32(); //118
		GD.Print("Node Count: " + nodeCount);
		var stringSize = MetaReader.ReadInt32(); //700
		GD.Print("string size: " + stringSize);
		long stringPosition = MetaReader.BaseStream.Position + nodeCount * 24; //24 could be 32. See: GetNodSize
		List<string> variableNames = new List<string>();
		for (int i = 0; i < nodeCount; i++)
		{
			var Version = MetaReader.ReadUInt16();
			var Depth = MetaReader.ReadByte();
			var IsArray = MetaReader.ReadBoolean();
			uint type = MetaReader.ReadUInt32();
			uint name = MetaReader.ReadUInt32();
			var ByteSize = MetaReader.ReadInt32();
			var Index = MetaReader.ReadInt32();
			var MetaFlag = MetaReader.ReadUInt32();
			/*might need this if "unknown"
			if (IsReadUnknown(reader.Generation))
			{ 
				Unknown1 = reader.ReadUInt32();
				Unknown2 = reader.ReadUInt32();
			}*/
			var Type = readString(MetaReader, stringPosition, type);
			var Name = readString(MetaReader, stringPosition, name);
			GD.Print(Name + " of type: " + Type);
		}

		/*while(metaReader.BaseStream.Position < 30000) {
			var output = metaReader.ReadStringZeroTerm();
			GD.Print(output);
		}*/
        
        //confirm it is a serialized file
        //Read File
        return "";
    }

	private static string readString(EndianReader reader, long stringPosition, uint value) {
		bool isCustomType = (value & 0x80000000) == 0;
		if (isCustomType)
		{
			long position = reader.BaseStream.Position;
			reader.BaseStream.Position = stringPosition + value;
			string stringValue = reader.ReadStringZeroTerm();
			reader.BaseStream.Position = position;
			return stringValue;
		}
		else
		{
			uint type = value & 0x7FFFFFFF;
			TreeNodeType nodeType = (TreeNodeType)type;
			if (!Enum.IsDefined(typeof(TreeNodeType), nodeType))
			{
				throw new Exception($"Unsupported asset class type name '{nodeType}''");
			}
			return nodeType.ToTypeString();
		}
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