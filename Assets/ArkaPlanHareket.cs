using UnityEngine;

public class ArkaPlanHareket : MonoBehaviour
{
    public float akishizi = 2f;
    public float solSinir = -15f;
    public float sagIsinlanmaNoktasi = 15f;

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
