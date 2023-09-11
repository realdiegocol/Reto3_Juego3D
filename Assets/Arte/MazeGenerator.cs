using UnityEngine;

public class MazeGenerator : MonoBehaviour
{
    public int width = 10;
    public int height = 10;
    public GameObject wallPrefab;

    private void Start()
    {
        GenerateMaze();
    }

    void GenerateMaze()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                Vector3 spawnPosition = new Vector3(x * 2, 0, y * 2); // Adjust 2 for wall spacing
                Instantiate(wallPrefab, spawnPosition, Quaternion.identity);
            }
        }
    }
}
