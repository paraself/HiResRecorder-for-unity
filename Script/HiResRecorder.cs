using UnityEngine;
using System.Collections;
using System.IO;

public class HiResRecorder : MonoBehaviour {
	
	public KeyCode key;
	public int frameRate;
	
	bool isCapturing = false;
	string prefix,path;
	int folderIndex = 0;
	int imgIndex = 0;
	float localDeltaTime,prevTime,fixedDeltaTimeCache;
	
	void Start () {
		DontDestroyOnLoad(this.gameObject);
		fixedDeltaTimeCache = Time.fixedDeltaTime;
		prefix = Application.dataPath+"/HiResRecorder/";
	}
	
	
	void LateUpdate () {
		
		localDeltaTime = Time.realtimeSinceStartup - prevTime;
		prevTime = Time.realtimeSinceStartup;
		
		if (Input.GetKeyDown(key)) {
			isCapturing = !isCapturing;
			if (isCapturing) {
				folderIndex+=1;
				imgIndex = 0;
				path = prefix+"IMG Sequence "+folderIndex;
				if (Directory.Exists(path)==false) 
					Directory.CreateDirectory(path);
				path = path + "/";
				
			} else {
				Time.timeScale = 1f;
				//Time.fixedDeltaTime = fixedDeltaTimeCache;
			}
		}
		if (isCapturing){
			Application.CaptureScreenshot(path+imgIndex.ToString("D8")+".png");
			imgIndex+=1;
			Time.timeScale = 1.0f/localDeltaTime/frameRate;
			//Time.fixedDeltaTime = fixedDeltaTimeCache / Time.timeScale;
		}
	}
}
