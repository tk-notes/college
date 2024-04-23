using UnityEngine;

public class Drag : MonoBehaviour {
    private Vector3 startPosition;
    private Rigidbody2D rb;
    public float dragSpeed = 0.1f;
    public float maxDragDistance = 2.0f;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnMouseDown() {
        startPosition = transform.position;
    }

    private void OnMouseDrag() {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = mousePosition - startPosition;
        float distance = Mathf.Clamp(direction.magnitude, 0, maxDragDistance);
        Vector3 newPosition = startPosition + direction.normalized * distance;
        rb.MovePosition(newPosition);
    }

    private void OnMouseUp() {
        Vector3 dragVector = transform.position - startPosition;
        float dragDistance = dragVector.magnitude;

        if (dragDistance > maxDragDistance) {
            float elasticForce = Mathf.Min(dragDistance * dragSpeed, maxDragDistance);
            Vector2 forceDirection = -dragVector.normalized;
            rb.AddForce(forceDirection * elasticForce, ForceMode2D.Impulse);
        } else {
            Vector2 forceDirection = -dragVector.normalized;
            rb.AddForce(forceDirection * 10.0f, ForceMode2D.Impulse);
        }
    }
}