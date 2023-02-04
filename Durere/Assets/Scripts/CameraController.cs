using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform PlayerTransform;

    private void LateUpdate()
    {
        transform.position = new Vector3(0f, PlayerTransform.position.y, -10f);
    }
}
