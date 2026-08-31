using UnityEngine;

public class EngelHareket : MonoBehaviour
{
    public float harekethizi = 5f;

    void Update()
    {
        transform.Translate(Vector3.left * harekethizi * Time.deltaTime);
        if(transform.position.x < -15f)
        {
            Destroy(gameObject);
        }
    }
}
