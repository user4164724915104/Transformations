using UnityEngine;

public class TransformAll : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _scaleSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * _moveSpeed);

        transform.Rotate(0, _rotationSpeed, 0);

        float scaleChange = _scaleSpeed * Time.deltaTime;
        transform.localScale += new Vector3(scaleChange, scaleChange, scaleChange);
    }
}
