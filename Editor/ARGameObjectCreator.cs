﻿using UnityEngine;
using UnityEditor;

public class ARGameObjectCreator : MonoBehaviour
{
    static string pathToUse = "Assets/ARjs_Unity/Prefabs/";

    [MenuItem("GameObject/AR.js/ImageTarget", false, 9)]
    static void PlaceImageTargetPrefabInScene()
    {
        GameObject imageTarget = AssetDatabase.LoadAssetAtPath(pathToUse + "ImageTarget.prefab", typeof(GameObject)) as GameObject;
        GameObject sceneImageTarget = Instantiate(imageTarget, Vector3.zero, Quaternion.identity) as GameObject;
        HelperFunctions.AddTag("ImageTarget");
        sceneImageTarget.transform.tag = "ImageTarget";
        sceneImageTarget.name = "ImageTarget";
    }

    [MenuItem("GameObject/AR.js/Plane", false, 10)]
    static void PlacePlanePrefabInScene()
    {
        GameObject plane = AssetDatabase.LoadAssetAtPath(pathToUse + "Plane.prefab", typeof(GameObject)) as GameObject;
        GameObject scenePlane;
        if (Selection.activeGameObject != null)
        {
            scenePlane = Instantiate(plane, Vector3.zero, Quaternion.identity, Selection.activeGameObject.transform) as GameObject;
        }
        else
        {
            scenePlane = Instantiate(plane, Vector3.zero, Quaternion.identity);
        }

        HelperFunctions.AddTag("Plane");
        scenePlane.transform.tag = "Plane";
        scenePlane.name = "Plane";
    }

    [MenuItem("GameObject/AR.js/Cube", false, 11)]
    static void PlaceCubePrefabInScene()
    {
        GameObject cube = AssetDatabase.LoadAssetAtPath(pathToUse + "Cube.prefab", typeof(GameObject)) as GameObject;
        GameObject sceneCube;
        if (Selection.activeGameObject != null)
        {
            sceneCube = Instantiate(cube, Vector3.zero, Quaternion.identity, Selection.activeGameObject.transform) as GameObject;
        }
        else
        {
            sceneCube = Instantiate(cube, Vector3.zero, Quaternion.identity);
        }

        HelperFunctions.AddTag("Cube");
        sceneCube.transform.tag = "Cube";
        sceneCube.name = "Cube";
    }

    [MenuItem("GameObject/AR.js/Sphere", false, 12)]
    static void PlaceSpherePrefabInScene()
    {
        GameObject sphere = AssetDatabase.LoadAssetAtPath(pathToUse + "Sphere.prefab", typeof(GameObject)) as GameObject;
        GameObject sceneSphere;
        if (Selection.activeGameObject != null)
        {
            sceneSphere = Instantiate(sphere, Vector3.zero, Quaternion.identity, Selection.activeGameObject.transform) as GameObject;
        }
        else
        {
            sceneSphere = Instantiate(sphere, Vector3.zero, Quaternion.identity);
        }

        HelperFunctions.AddTag("Sphere");
        sceneSphere.transform.tag = "Sphere";
        sceneSphere.name = "Sphere";
    }

    [MenuItem("GameObject/AR.js/Cylinder", false, 13)]
    static void PlaceCylinderPrefabInScene()
    {
        GameObject cylinder = AssetDatabase.LoadAssetAtPath(pathToUse + "Cylinder.prefab", typeof(GameObject)) as GameObject;
        GameObject sceneCylinder;
        if (Selection.activeGameObject != null)
        {
            sceneCylinder = Instantiate(cylinder, Vector3.zero, Quaternion.identity, Selection.activeGameObject.transform) as GameObject;
        }
        else
        {
            sceneCylinder = Instantiate(cylinder, Vector3.zero, Quaternion.identity);
        }

        HelperFunctions.AddTag("Cylinder");
        sceneCylinder.transform.tag = "Cylinder";
        sceneCylinder.name = "Cylinder";
    }

    [MenuItem("AR.js/MakeButton", false, 14)]
    static void ConvertItemToButton()
    {
        GameObject obj = Selection.activeGameObject;
        obj.AddComponent<ButtonHelper>();
    }

    [MenuItem("AR.js/MakeButton", true)]
    static bool MakeButtonMenuOptionValidation()
    {
        GameObject obj = Selection.activeGameObject;
        if((obj.CompareTag("Cube") || obj.CompareTag("Plane") || obj.CompareTag("Sphere") || obj.CompareTag("Cylinder")) && obj.GetComponent<ButtonHelper>()==null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    [MenuItem("AR.js/MakeAnimation", false, 14)]
    static void ConvertItemToAnimation()
    {
        GameObject obj = Selection.activeGameObject;
        obj.AddComponent<AnimationHelper>();
        obj.AddComponent<CustomList>();
    }

    [MenuItem("AR.js/MakeAnimation", true)]
    static bool MakeAnimationMenuOptionValidation()
    {
        GameObject obj = Selection.activeGameObject;
        if ((obj.CompareTag("Cube") || obj.CompareTag("Plane") || obj.CompareTag("Sphere") || obj.CompareTag("Cylinder")) && obj.GetComponent<AnimationHelper>() == null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
