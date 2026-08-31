using UnityEngine;

public class EngelSpawn : MonoBehaviour
{

    public GameObject engelPrefab;
    public float spawnSuresi = 2f;
    private float kronometre = 0f;
    void Update()
    {
        kronometre+= Time.deltaTime;
        if (kronometre >= spawnSuresi)
        {
            Vector3 spawnpositon=new Vector3(10f,Random.Range(-2f, 2f),0f);
            Instantiate(engelPrefab, spawnpositon, Quaternion.identity);
            kronometre = 0f;
        }
    }
}
