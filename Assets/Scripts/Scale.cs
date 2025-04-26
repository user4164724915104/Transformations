using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;
    private void Update()
    {
        float scaleChange = _scaleSpeed * Time.deltaTime;
        transform.localScale += Vector3.one * scaleChange;
    }
}
