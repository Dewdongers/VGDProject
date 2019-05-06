using UnityEngine;
using System.Collections;
using UnityEditor;

public class MakeWeaponObject
{
    [MenuItem("assets/Create/Weapon Object")]
    public static void Create()
    {
        WeaponObject asset = ScriptableObject.CreateInstance<MakeWeaponObject>();
        AssetDatabase.CreateAsset(asset, "Assets/NewWeaponObject.asset");
        AssetDatabase.SaveAssets();
        EditorUtility.FocusProjectWindow();
        Selection.activeObject = asset;
    }
}