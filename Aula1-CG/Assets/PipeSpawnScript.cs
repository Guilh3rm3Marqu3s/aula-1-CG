using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float yPosition = 0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate) timer = timer + Time.deltaTime;
        else { spawnPipe(); timer = 0; }

    }

    void spawnPipe()
    {
        Camera cam = Camera.main;
        float screenRight = cam.ViewportToWorldPoint(new Vector3(1, 0, cam.nearClipPlane)).x;
        Vector3 spawnPosition = new Vector3(screenRight + 1f, yPosition, 0);
       Instantiate(pipe, spawnPosition,Quaternion.identity);
    }
}
