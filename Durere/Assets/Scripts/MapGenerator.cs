using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public GameObject Level;
    private float _mapVerticalOffset = 31.8f;
    private Vector3 _levelPosition = new Vector3(-7.69234f, 21.4f, 13.55575f);

    public void GenerateMap()
    {
        Instantiate(Level, _levelPosition, Quaternion.identity);
        _levelPosition.y -= _mapVerticalOffset;
    }
}
