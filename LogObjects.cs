using UnityEngine;

public class LogObjects : MonoBehaviour
{
    private readonly string[] targetTags = new string[] {
        "MainCamera", "Player", "light", "Watermelon Sugar",
        "cube", "cylinder", "terrain", "ramp"
    };

    void Start() {
        foreach (string tag in targetTags) {
            GameObject[] foundObjects;

            try {
                foundObjects = GameObject.FindGameObjectsWithTag(tag);
            }
            catch {
                Debug.LogWarning($"Tag not found in project: '{tag}'");
                continue;
            }

            foreach (GameObject obj in foundObjects) {
                Vector3 position = obj.transform.position;
                Debug.Log($"Tag: {tag} - Object: {obj.name} - Position: {position}");
            }
        }
    }
}
