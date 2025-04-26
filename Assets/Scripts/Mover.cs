using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    private void Update()
    {
        float moveChange = _moveSpeed * Time.deltaTime;
        transform.Translate(Vector3.forward * moveChange);
    }
}
