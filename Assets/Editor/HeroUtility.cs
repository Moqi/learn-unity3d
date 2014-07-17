using UnityEngine;
using UnityEditor;
using System.Collections;
using System.IO;

public static class HeroUtility {

	public static Hero Create ( string _path, string _name ) {
		if ( new DirectoryInfo(_path).Exists == false ) {
			Debug.LogError ( "can't create asset, path not found" );
			return null;
		}
		if ( string.IsNullOrEmpty(_name) ) {
			Debug.LogError ( "can't create asset, the name is empty" );
			return null;
		}
		string assetPath = Path.Combine( _path, _name + ".asset" );
		

		Hero hero = ScriptableObject.CreateInstance<Hero>();
		AssetDatabase.CreateAsset(hero, assetPath);
		Selection.activeObject = hero;
		return hero;
	}


	[MenuItem ("Assets/Create/Hero")]
	static void Create () {
		string assetName = "New Hero";
		string assetPath = "Assets";
			if ( Selection.activeObject ) {
				assetPath = AssetDatabase.GetAssetPath(Selection.activeObject);
				if ( Path.GetExtension(assetPath) != "" ) {
					assetPath = Path.GetDirectoryName(assetPath);
				}
			}

		bool doCreate = true;
		string path = Path.Combine( assetPath, assetName + ".asset" );
		FileInfo fileInfo = new FileInfo(path);
		if ( fileInfo.Exists ) {
			doCreate = EditorUtility.DisplayDialog( assetName + " already exists.",
			                                       "Do you want to overwrite the old one?",
			                                       "Yes", "No" );
		}
		if ( doCreate ) {
			Hero hero = HeroUtility.Create ( assetPath, assetName );
			Selection.activeObject = hero;
		}
	}
}