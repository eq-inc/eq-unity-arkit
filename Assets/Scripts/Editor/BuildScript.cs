using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BuildScript{
	public static void Build(){
		string[] scenes = {
			"./Assets/Scenes/Top.unity",
            "./Assets/UnityARKitPlugin/Examples/AddRemoveAnchorExample/AddRemoveAnchorScene.unity",
            "./Assets/UnityARKitPlugin/Examples/FaceTracking/FaceAnchorScene.unity",
            "./Assets/UnityARKitPlugin/Examples/FaceTracking/FaceBlendshapeScene.unity",
            "./Assets/UnityARKitPlugin/Examples/FaceTracking/FaceBlendshapeSloth.unity",
            "./Assets/UnityARKitPlugin/Examples/FaceTracking/FaceDirectionalLightEstimate.unity",
            "./Assets/UnityARKitPlugin/Examples/FaceTracking/FaceMeshScene.unity",
            "./Assets/UnityARKitPlugin/Examples/FocusSquare/FocusSquareScene.unity",
            "./Assets/UnityARKitPlugin/Examples/UnityARBallz/UnityARBallz.unity",
            "./Assets/UnityARKitPlugin/Examples/UnityARKitScene/UnityARKitScene.unity",
            "./Assets/UnityARKitPlugin/Examples/UnityAROcclusion/UnityAROcclusion.unity",
            "./Assets/UnityARKitPlugin/Examples/UnityARShadows/UnityARShadows.unity",
            "./Assets/UnityARKitPlugin/Examples/UnityParticlePainter/UnityParticlePainter.unity",
        };

        string errorMessage = BuildPipeline.BuildPlayer(scenes, "./xcode", BuildTarget.iOS, BuildOptions.Development);
        if (!string.IsNullOrEmpty(errorMessage))
        {
            Debug.LogError("[Error!] " + errorMessage);
        }
        else
        {
            Debug.Log("[Success!]");
        }
    }
}