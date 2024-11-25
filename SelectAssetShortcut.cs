using UnityEditor;
using UnityEngine;

/*
 * Fables Alive Games - Custom Unity Editor Shortcut
 * ---------------------------------------------------
 * This script adds a custom Unity Editor shortcut for selecting 
 * the Prefab asset of the currently selected GameObject in the Hierarchy.
 * Shortcut: Ctrl + Alt + Shift + S
 * 
 * How to Use:
 * - Select a GameObject in the Hierarchy.
 * - Press the shortcut keys (Ctrl + Alt + Shift + S).
 * - The corresponding Prefab asset will be highlighted in the Project window.
 * 
 * Created for improving workflow efficiency.
 */
public class SelectAssetShortcut
{
    [MenuItem("Assets/Select Prefab Asset %#&s")] // Ctrl+ Alt + Shift + S Hotkey
    static void SelectPrefabAsset()
    {
        if (Selection.activeGameObject != null)
        {
            GameObject selectedObject = Selection.activeGameObject;
            GameObject prefab = PrefabUtility.GetCorrespondingObjectFromSource(selectedObject);
            
            if (prefab != null)
            {
                Selection.activeObject = prefab;
                EditorGUIUtility.PingObject(prefab);
            }
            else
            {
                Debug.LogWarning("Selected Object is nota Prefab.");
            }
        }
        else
        {
            Debug.LogWarning("No Object Selected.");
        }
    }
}
