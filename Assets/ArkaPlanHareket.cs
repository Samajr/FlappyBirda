using UnityEngine;

public class ArkaPlanHareket : MonoBehaviour
{
    public float akishizi = 2f;
    public float solSinir = -14.4f;
    public float sagIsinlanmaNoktasi = 14.4f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * akishizi * Time.deltaTime);

        if (transform.position.x < solSinir)
        {
            transform.position = new Vector3(sagIsinlanmaNoktasi, transform.position.y, transform.position.z);
        }
    }
}
