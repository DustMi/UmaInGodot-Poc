using UnityEngine;

namespace UMA
{
    [System.Serializable]
    public class AssetItem
    {
        #region Fields
        private System.Type _TheType;
        public string _BaseTypeName;
        public string _Name;
        public Object _SerializedItem;
        public string _Path;
		public string _Guid;
        public bool IsResource;
        public bool IsAssetBundle;
        #endregion
        #region Properties
        public System.Type _Type
        {
            get
            {
                if (_TheType != null) return _TheType;

                _TheType = UMAAssetIndexer.TypeFromString[_BaseTypeName];
                return _TheType;
            }
        }

        public AssetItem CreateSerializedItem(bool ForceItemSave)
        {
            if (ForceItemSave)
            {
                // If this flag is set, then we must serialize the item also (this is used when building the executable).
                return new AssetItem(this._Type, this._Name, this._Path, this.Item);
            }
            else
            {
                return new AssetItem(this._Type, this._Name, this._Path, null);
            }
        }

        public Object Item
        {
            get
            {
                return _SerializedItem;
            }
        }

        public string _AssetBaseName
        {
            get
            {
                return System.IO.Path.GetFileNameWithoutExtension(_Path);
            }
        }

		public void CachSerializedItem()
		{
			
		}

        public string EvilName
        {
            get
            {
                Object o = Item;

                if (!o)
                {
                    return "<Not Found!>";
                }
                if (o is SlotDataAsset)
                {
                    SlotDataAsset sd = o as SlotDataAsset;
                    return sd.slotName;
                }
                if (o is OverlayDataAsset)
                {
                    OverlayDataAsset od = o as OverlayDataAsset;
                    return od.overlayName;
                }
                if (o is RaceData)
                {
                    return (o as RaceData).raceName;
                }

                return o.name;
            }
        }
        #endregion
        #region Methods (edit time)
#if UNITY_EDITOR

        public void ReleaseItem()
        {
            _SerializedItem = null;
        }

        public string ToString(string SortOrder)
        {
            if (SortOrder == "AssetName")
                return _AssetBaseName;
            if (SortOrder == "FilePath")
                return _Path;
            return _Name;
        }

        public bool Equals(AssetItem other)
        {
            if (other == null)
                return false;

            if (UMAAssetIndexer.SortOrder == "AssetName")
            {
                if (this._AssetBaseName == other._AssetBaseName)
                    return true;
                else
                    return false;
            }

            if (UMAAssetIndexer.SortOrder == "FilePath")
            {
                if (this._Path == other._Path)
                    return true;
                else
                    return false;

            }

            if (this._Name == other._Name)
                return true;

            return false;
        }

        public int CompareTo(AssetItem other)
        {
            // A null value means that this object is greater.
            if (other == null)
                return 1;

            if (UMAAssetIndexer.SortOrder == "AssetName")
            {
                return (this._AssetBaseName.CompareTo(other._AssetBaseName));
            }

            if (UMAAssetIndexer.SortOrder == "FilePath")
            {
                return this._Path.CompareTo(other._Path);
            }

            return this._Name.CompareTo(other._Name);
        }

#endif
        #endregion
        #region Constructors
        public AssetItem(System.Type Type, string Name, string Path, Object Item)
        {
            if (Type == null) return;
            _TheType = Type;
            _BaseTypeName = Type.Name;
            _Name = Name;
            _SerializedItem = Item;
            _Path = Path;
			#if UNITY_EDITOR
			_Guid = AssetDatabase.AssetPathToGUID(_Path);
			#endif
        }
        public AssetItem(System.Type Type, Object Item)
        {
            if (Type == null) return;
#if UNITY_EDITOR
            _Path = AssetDatabase.GetAssetPath(Item.GetInstanceID());
			_Guid = AssetDatabase.AssetPathToGUID(_Path);
#endif
            _TheType = Type;
            _BaseTypeName = Type.Name;
            _SerializedItem = Item;
            _Name = EvilName;
        }
        #endregion
    }
}
