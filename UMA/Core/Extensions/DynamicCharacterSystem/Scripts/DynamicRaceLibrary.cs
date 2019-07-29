using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
using System.Collections.Generic;

namespace UMA.CharacterSystem
{
	public class DynamicRaceLibrary : RaceLibrary
	{

		//extra fields for Dynamic Version
		public bool dynamicallyAddFromResources = true;
		
		public string resourcesFolderPath = "";
		public bool dynamicallyAddFromAssetBundles;
		
		public string assetBundleNamesToSearch = "";
		//This is a ditionary of asset bundles that were loaded into the library at runtime. 
		//CharacterAvatar can query this this to find out what asset bundles were required to create itself 
		//or other scripts can use it to find out which asset bundles are being used by the Libraries at any given point.
		public Dictionary<string, List<string>> assetBundlesUsedDict = new Dictionary<string, List<string>>();

		[System.NonSerialized]
		bool allStartingAssetsAdded = false;

		[System.NonSerialized]

		public bool downloadAssetsEnabled = true;

		public void Start()
		{
			assetBundlesUsedDict.Clear();
		}

		public void UpdateDynamicRaceLibrary(bool downloadAssets, int? raceHash = null)
		{
			if (allStartingAssetsAdded && raceHash == null)
				return;

			//Making the race library scan everything (by sending raceHash = null) only needs to happen once- at all other times a specific race will have been requested (and been added by dynamic asset loader) so it will already be here if it needs to be.
			if (raceHash == null && Application.isPlaying && allStartingAssetsAdded == false)
					allStartingAssetsAdded = true;

			if (DynamicAssetLoader.Instance != null)
				DynamicAssetLoader.Instance.AddAssets<RaceData>(ref assetBundlesUsedDict, dynamicallyAddFromResources, dynamicallyAddFromAssetBundles, downloadAssets, assetBundleNamesToSearch, resourcesFolderPath, raceHash, "", AddRaces);

		}

		public void UpdateDynamicRaceLibrary(string raceName)
		{
				DynamicAssetLoader.Instance.AddAssets<RaceData>(ref assetBundlesUsedDict, dynamicallyAddFromResources, dynamicallyAddFromAssetBundles, downloadAssetsEnabled, assetBundleNamesToSearch, resourcesFolderPath, null, raceName, AddRaces);
		}

	#pragma warning disable 618
		private void AddRaces(RaceData[] races)
		{
			int currentNumRaces = raceElementList.Length;
			foreach (RaceData race in races)
			{
					AddRace(race);
			}
			//Ensure the new races have keys in the DCS dictionary
			if (currentNumRaces != raceElementList.Length && Application.isPlaying)
			{
				if (UMAContext.Instance == null)
					UMAContext.FindInstance();
				if (UMAContext.Instance != null && UMAContext.Instance.dynamicCharacterSystem != null)
				{
					(UMAContext.Instance.dynamicCharacterSystem as DynamicCharacterSystem).RefreshRaceKeys();
				}
			}
		}
	#pragma warning restore 618

	#pragma warning disable 618
		//We need to override AddRace Too because if the element is not in the list anymore it causes an error...
		override public void AddRace(RaceData race)
		{
			if (race == null)
				return;
			race.UpdateDictionary();
			try
			{
				base.AddRace(race);
			}
			catch
			{
				//if there is an error it will be because RaceElementList contained an empty refrence
				List<RaceData> newRaceElementList = new List<RaceData>();
				for (int i = 0; i < raceElementList.Length; i++)
				{
					if (raceElementList[i] != null)
					{
						raceElementList[i].UpdateDictionary();
						newRaceElementList.Add(raceElementList[i]);
					}
				}
				raceElementList = newRaceElementList.ToArray();
				base.AddRace(race);
			}
		}
	#pragma warning restore 618
		//TODO if this works it should maybe be the other way round for backwards compatability- i.e. so unless you do something different this does what it always did do...
		public override RaceData GetRace(string raceName)
		{
			return GetRace(raceName, true);
		}
		public RaceData GetRace(string raceName, bool allowUpdate = true)
		{
			if ((raceName == null) || (raceName.Length == 0))
				return null;

			RaceData res;
			res = base.GetRace(raceName);

			if (res == null && allowUpdate)
			{
				//we try to load the race dynamically
				UpdateDynamicRaceLibrary(raceName);
				res = base.GetRace(raceName);
				if (res == null)
				{
					return null;
				}
			}
			return res;
		}
		public override RaceData GetRace(int nameHash)
		{
			return GetRace(nameHash, true);
		}
		public RaceData GetRace(int nameHash, bool allowUpdate = true)
		{
			if (nameHash == 0)
				return null;

			RaceData res;
			res = base.GetRace(nameHash);

			if (res == null && allowUpdate)
			{
				UpdateDynamicRaceLibrary(true, nameHash);
				res = base.GetRace(nameHash);
				if (res == null)
				{
					return null;
				}
			}
			return res;
		}
		/// <summary>
		/// Returns the current list of races without adding from assetBundles or Resources
		/// </summary>
		/// <returns></returns>
		public RaceData[] GetAllRacesBase()
		{
			return base.GetAllRaces();
		}
		/// <summary>
		/// Gets all the races that are available including in Resources (but does not cause downloads for races that are in assetbundles)
		/// </summary>
		/// <returns></returns>
		public override RaceData[] GetAllRaces()
		{
			UpdateDynamicRaceLibrary(false);
				return base.GetAllRaces();
		}

		/// <summary>
		/// Gets the originating asset bundle.
		/// </summary>
		/// <returns>The originating asset bundle.</returns>
		/// <param name="raceName">Race name.</param>
		public string GetOriginatingAssetBundle(string raceName)
		{
			string originatingAssetBundle = "";
			if (assetBundlesUsedDict.Count > 0)
			{
				foreach (KeyValuePair<string, List<string>> kp in assetBundlesUsedDict)
				{
					if (kp.Value.Contains(raceName))
					{
						originatingAssetBundle = kp.Key;
						break;
					}
				}
			}
			if (originatingAssetBundle == "")
			{
				if (Debug.isDebugBuild)
					Debug.Log(raceName + " was not found in any loaded AssetBundle");
			}
			else
			{
				if (Debug.isDebugBuild)
					Debug.Log("originatingAssetBundle for " + raceName + " was " + originatingAssetBundle);
			}
			return originatingAssetBundle;
		}
	}
}
