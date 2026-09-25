using UnityEngine;

public class Camara : MonoBehaviour
{
    public Transform target; //esto es lo que el objeto de la camara seguira
    void LateUpdate()
    {
        transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);
    }
}
