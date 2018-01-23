using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using I2.Loc;

public class LocalisationConfig {

    [MenuItem("Assets/Configuration/Localisation")]
    public static void Config()
    {
        GameObject src = Resources.Load("I2Languages") as GameObject;
        Selection.activeObject = src;
        EditorUtility.FocusProjectWindow();
    }
}
