namespace RawYaml
{
    using System;
    using System.Collections.Generic;
    using YamlDotNet.Serialization;
    using System.Globalization;
    using Godot;

    public class SlotYaml
    {
        [YamlMember(Alias = "MonoBehaviour", ApplyNamingConventions = false)]
        public MonoBehaviour MonoBehaviour { get; set; }
    }

    public  class MonoBehaviour
    {
        [YamlMember(Alias = "m_ObjectHideFlags", ApplyNamingConventions = false)]
        public long m_ObjectHideFlags { get; set; }

        [YamlMember(Alias = "m_PrefabParentObject", ApplyNamingConventions = false)]
        public MGameObject MPrefabParentObject { get; set; }

        [YamlMember(Alias = "m_PrefabInternal", ApplyNamingConventions = false)]
        public MGameObject MPrefabInternal { get; set; }

        [YamlMember(Alias = "m_GameObject", ApplyNamingConventions = false)]
        public MGameObject MGameObject { get; set; }

        [YamlMember(Alias = "m_Enabled", ApplyNamingConventions = false)]
        public long MEnabled { get; set; }

        [YamlMember(Alias = "m_EditorHideFlags", ApplyNamingConventions = false)]
        public long MEditorHideFlags { get; set; }

        [YamlMember(Alias = "m_Script", ApplyNamingConventions = false)]
        public MScript MScript { get; set; }

        [YamlMember(Alias = "m_Name", ApplyNamingConventions = false)]
        public string MName { get; set; }

        [YamlMember(Alias = "m_EditorClassIdentifier", ApplyNamingConventions = false)]
        public object MEditorClassIdentifier { get; set; }

        [YamlMember(Alias = "slotName", ApplyNamingConventions = false)]
        public string SlotName { get; set; }

        [YamlMember(Alias = "material", ApplyNamingConventions = false)]
        public MScript Material { get; set; }

        [YamlMember(Alias = "overlayScale", ApplyNamingConventions = false)]
        public long OverlayScale { get; set; }

        [YamlMember(Alias = "animatedBoneNames", ApplyNamingConventions = false)]
        public object[] AnimatedBoneNames { get; set; }

        [YamlMember(Alias = "animatedBoneHashes", ApplyNamingConventions = false)]
        public object AnimatedBoneHashes { get; set; }

        [YamlMember(Alias = "slotDNA", ApplyNamingConventions = false)]
        public MGameObject SlotDna { get; set; }

        [YamlMember(Alias = "meshData", ApplyNamingConventions = false)]
        public MeshData MeshData { get; set; }

        [YamlMember(Alias = "subMeshIndex", ApplyNamingConventions = false)]
        public long SubMeshIndex { get; set; }

        [YamlMember(Alias = "slotGroup", ApplyNamingConventions = false)]
        public object SlotGroup { get; set; }

        [YamlMember(Alias = "tags", ApplyNamingConventions = false)]
        public object[] Tags { get; set; }

        [YamlMember(Alias = "CharacterBegun", ApplyNamingConventions = false)]
        public CharacterBegun CharacterBegun { get; set; }

        [YamlMember(Alias = "SlotAtlassed", ApplyNamingConventions = false)]
        public CharacterBegun SlotAtlassed { get; set; }

        [YamlMember(Alias = "DNAApplied", ApplyNamingConventions = false)]
        public CharacterBegun DnaApplied { get; set; }

        [YamlMember(Alias = "CharacterCompleted", ApplyNamingConventions = false)]
        public CharacterBegun CharacterCompleted { get; set; }

        [YamlMember(Alias = "animatedBones", ApplyNamingConventions = false)]
        public object[] AnimatedBones { get; set; }
    }

    public partial class CharacterBegun
    {
        [YamlMember(Alias = "m_PersistentCalls", ApplyNamingConventions = false)]
        public MPersistentCalls MPersistentCalls { get; set; }

        [YamlMember(Alias = "m_TypeName", ApplyNamingConventions = false)]
        public string MTypeName { get; set; }
    }

    public partial class MPersistentCalls
    {
        [YamlMember(Alias = "m_Calls", ApplyNamingConventions = false)]
        public object[] MCalls { get; set; }
    }

    public partial class MGameObject
    {
        [YamlMember(Alias = "fileID", ApplyNamingConventions = false)]
        public long FileId { get; set; }
    }

    public partial class MScript
    {
        [YamlMember(Alias = "fileID", ApplyNamingConventions = false)]
        public long FileId { get; set; }

        [YamlMember(Alias = "guid", ApplyNamingConventions = false)]
        public string Guid { get; set; }

        [YamlMember(Alias = "type", ApplyNamingConventions = false)]
        public long Type { get; set; }
    }

    public class MeshData
    {
        [YamlMember(Alias = "bindPoses", ApplyNamingConventions = false)]
        public Dictionary<string, double>[] BindPoses { get; set; }

        [YamlMember(Alias = "boneWeights", ApplyNamingConventions = false)]
        public BoneWeight[] BoneWeights { get; set; }

        [YamlMember(Alias = "vertices", ApplyNamingConventions = false)]
        public Vector3[] Vertices { get; set; }

        [YamlMember(Alias = "normals", ApplyNamingConventions = false)]
        public Vector3[] Normals { get; set; }

        [YamlMember(Alias = "tangents", ApplyNamingConventions = false)]
        public Tangents[] Tangents { get; set; }

        [YamlMember(Alias = "colors32", ApplyNamingConventions = false)]
        public object[] Colors32 { get; set; }

        [YamlMember(Alias = "uv", ApplyNamingConventions = false)]
        public Uv[] Uv { get; set; }

        [YamlMember(Alias = "uv2", ApplyNamingConventions = false)]
        public object[] Uv2 { get; set; }

        [YamlMember(Alias = "uv3", ApplyNamingConventions = false)]
        public object[] Uv3 { get; set; }

        [YamlMember(Alias = "uv4", ApplyNamingConventions = false)]
        public object[] Uv4 { get; set; }

        [YamlMember(Alias = "submeshes", ApplyNamingConventions = false)]
        public Submesh[] Submeshes { get; set; }

        [YamlMember(Alias = "umaBones", ApplyNamingConventions = false)]
        public UmaBone[] UmaBones { get; set; }

        [YamlMember(Alias = "umaBoneCount", ApplyNamingConventions = false)]
        public long UmaBoneCount { get; set; }

        [YamlMember(Alias = "rootBoneHash", ApplyNamingConventions = false)]
        public long RootBoneHash { get; set; }

        [YamlMember(Alias = "boneNameHashes", ApplyNamingConventions = false)]
        public string BoneNameHashes { get; set; }

        [YamlMember(Alias = "subMeshCount", ApplyNamingConventions = false)]
        public long SubMeshCount { get; set; }

        [YamlMember(Alias = "vertexCount", ApplyNamingConventions = false)]
        public long VertexCount { get; set; }

        [YamlMember(Alias = "RootBoneName", ApplyNamingConventions = false)]
        public string RootBoneName { get; set; }
    }

    public class BoneWeight
    {
        [YamlMember(Alias = "boneIndex0", ApplyNamingConventions = false)]
        public long BoneIndex0 { get; set; }

        [YamlMember(Alias = "boneIndex1", ApplyNamingConventions = false)]
        public long BoneIndex1 { get; set; }

        [YamlMember(Alias = "boneIndex2", ApplyNamingConventions = false)]
        public long BoneIndex2 { get; set; }

        [YamlMember(Alias = "boneIndex3", ApplyNamingConventions = false)]
        public long BoneIndex3 { get; set; }

        [YamlMember(Alias = "weight0", ApplyNamingConventions = false)]
        public double Weight0 { get; set; }

        [YamlMember(Alias = "weight1", ApplyNamingConventions = false)]
        public double Weight1 { get; set; }

        [YamlMember(Alias = "weight2", ApplyNamingConventions = false)]
        public double Weight2 { get; set; }

        [YamlMember(Alias = "weight3", ApplyNamingConventions = false)]
        public double Weight3 { get; set; }
    }

    public class Tangents
    {
        [YamlMember(Alias = "x", ApplyNamingConventions = false)]
        public float X { get; set; }

        [YamlMember(Alias = "y", ApplyNamingConventions = false)]
        public float Y { get; set; }

        [YamlMember(Alias = "z", ApplyNamingConventions = false)]
        public float Z { get; set; }

        [YamlMember(Alias = "w", ApplyNamingConventions = false)]
        public float W { get; set; }
    }

    public class Submesh
    {
        [YamlMember(Alias = "triangles", ApplyNamingConventions = false)]
        public string Triangles { get; set; }
    }

    public class UmaBone
    {
        [YamlMember(Alias = "position", ApplyNamingConventions = false)]
        public Tangents Position { get; set; }

        [YamlMember(Alias = "rotation", ApplyNamingConventions = false)]
        public Tangents Rotation { get; set; }

        [YamlMember(Alias = "scale", ApplyNamingConventions = false)]
        public Tangents Scale { get; set; }

        [YamlMember(Alias = "name", ApplyNamingConventions = false)]
        public string Name { get; set; }

        [YamlMember(Alias = "hash", ApplyNamingConventions = false)]
        public long Hash { get; set; }

        [YamlMember(Alias = "parent", ApplyNamingConventions = false)]
        public long Parent { get; set; }
    }

    public class Uv
    {
        [YamlMember(Alias = "x", ApplyNamingConventions = false)]
        public double X { get; set; }

        [YamlMember(Alias = "y", ApplyNamingConventions = false)]
        public double Y { get; set; }
    }
}
