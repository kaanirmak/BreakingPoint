using UnityEngine;

public class BoardController : MonoBehaviour
{
    [HideInInspector] public Vector3 CurrentMousePosition;

    public Camera mainCamera; // Kamara burada public olarak tan�mlan�yor

    void Start()
    {
        if (mainCamera == null)
        {
            mainCamera = Camera.main; // E�er mainCamera null ise, varsay�lan kamera atan�yor
            if (mainCamera == null)
            {
                Debug.LogError("Main camera is not found!");
                //Main camera is not found!
            }
        }
    }

    void Update()
    {
        if (mainCamera == null)
        {
            return;
        }

        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Debug.DrawLine(ray.origin, hit.point, Color.red);

            // Check if the hit collider is not null before accessing its layer
            if (hit.collider != null && hit.collider.gameObject.layer == LayerMask.NameToLayer("Table"))
            {
                CurrentMousePosition = hit.point;
            }
        }
    }
}
