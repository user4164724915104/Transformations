using UnityEngine;

public class TransformMove : MonoBehaviour
{
    [SerializeField] private Vector3 _moveSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += _moveSpeed;
    }
}
