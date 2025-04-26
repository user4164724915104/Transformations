using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    private void Update()
    {
        float rotationChange = _rotationSpeed * Time.deltaTime;
        transform.Rotate(0, rotationChange, 0);
    }
}
