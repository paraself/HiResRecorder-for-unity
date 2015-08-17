using UnityEngine;
using System.Collections;
using UnityEditor;

public class HiResRecorder_Editor  {

	[MenuItem("GameObject/Create HiResRecorder", false,10)]
	public static void CreateHiResRecorder(MenuCommand menuCommand) {
		HiResRecorder recorder = Object.FindObjectOfType<HiResRecorder>();
		if (recorder) {
			Debug.LogWarning("An instance of HiResRecorder already exists!");
			Selection.activeObject = recorder.gameObject;
		} else {
			// Create a custom game object
			GameObject go = new GameObject("HiResRecorder");
			go.AddComponent<HiResRecorder>();
			// Ensure it gets reparented if this was a context click (otherwise does nothing)
			GameObjectUtility.SetParentAndAlign(go, menuCommand.context as GameObject);
			// Register the creation in the undo system
			Undo.RegisterCreatedObjectUndo(go, "Create " + go.name);
			Selection.activeObject = go;
		
		}
	}

}


