using UnityEngine;

public class TransformScale : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float scaleChange = _scaleSpeed * Time.deltaTime;
        transform.localScale += new Vector3(scaleChange, scaleChange, scaleChange);
    }
}
