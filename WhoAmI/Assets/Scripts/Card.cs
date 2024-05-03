using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private float _startYpos;
    private BoardController _board;

    private void Start()
    {
        _board = GetComponent<BoardController>();
        _rigidbody = GetComponent<Rigidbody>();

        _startYpos = 0;
    }

    private void OnMouseDrag()
    {
        Vector3 newWorldPosition = new Vector3(_board.CurrentMousePosition.x, _startYpos + 1, _board.CurrentMousePosition.z);

        var difference = newWorldPosition - transform.position;

        _rigidbody.velocity = 10 * difference;
        _rigidbody.rotation = Quaternion.Euler(new Vector3(_rigidbody.velocity.z, 0, _rigidbody.velocity.x));
    }
}
