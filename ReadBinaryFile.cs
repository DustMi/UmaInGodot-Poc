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
        GD.Print(isSerializedFile);
        //confirm it is a serialized file
        //Read File
        return "";
    }
    const int MetadataMinSize = 16;
    public const int HeaderMinSize = 16;
    int metadataSize;
    uint fileSize;
    int generation;
    public static bool IsSerializedFileHeader(EndianReader reader)
		{
			if (reader.BaseStream.Position + HeaderMinSize > reader.BaseStream.Length)
			{
				return false;
			}
			int metadataSize = reader.ReadInt32();
			if (metadataSize < MetadataMinSize)
			{
				return false;
			}
			uint fileSize = reader.ReadUInt32();
			if (fileSize < HeaderMinSize + MetadataMinSize)
			{
				return false;
			}
			int generation = reader.ReadInt32();
			if (!Enum.IsDefined(typeof(FileGeneration), generation))
			{
				return false;
			}
			return true;
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