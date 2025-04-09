using UnityEngine;

public class TransformSpin : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, _rotationSpeed, 0);
    }
}
