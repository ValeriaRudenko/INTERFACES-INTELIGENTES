using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WriteObjects : MonoBehaviour
{
    public string[] tagsToFind; // List of tags to search for (Player, tree, mushroom house, sphere, cube)

    // Start is called before the first frame update
    void Start()
    {
        // Loop through each tag in the tagsToFind array
        foreach (string tagToFind in tagsToFind)
        {
            // Find all GameObjects with the specified tag
            GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag(tagToFind);

            // Iterate through each object found
            foreach (GameObject obj in objectsWithTag)
            {
                // Log the name of each object along with the tag
                Debug.Log("Object in scene with tag " + tagToFind + ": " + obj.name);
            }
        }
    }
}
