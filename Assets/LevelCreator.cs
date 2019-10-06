using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[System.Serializable]
public struct Assotiation
{
    public Color color;
    public GameObject prefab;
}

[System.Serializable]
public struct Layer
{
    const int TERRAIN_SCALE = 10;
    const int SEMANTICS_SCALE = 1;
    public List<Assotiation> Terrain;
    public List<Assotiation> Semantics;

    public Texture2D texture;

    public void GenerateLevel()
    {
        //TERRAIN
        Vector3 offset = new Vector3(-(float)texture.width / 2, 0, -(float)texture.height / 2);
        for (int i = 0; i < texture.width; i++)
        {
            for (int j = 0; j < texture.height; j++)
            {
                Color color = texture.GetPixel(i, j);
                int index = Terrain.FindIndex((assotiation) => assotiation.color == color);
                Debug.Log(i + " "+ j);
                Debug.Log(index);
                Debug.Log((Color32)color);
                MonoBehaviour.Instantiate(Terrain[index].prefab,
                    new Vector3(i * TERRAIN_SCALE, 0, j * TERRAIN_SCALE),
                    Quaternion.identity);
            }
        }
    }

}
public class LevelCreator : MonoBehaviour
{
    public static LevelCreator Instance;

    public Layer[] LevelLayers;

    private void Awake()
    {
        LevelLayers[0].GenerateLevel();
    }

}