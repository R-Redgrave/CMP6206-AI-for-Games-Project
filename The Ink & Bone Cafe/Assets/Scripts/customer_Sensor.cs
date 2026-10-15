using UnityEngine;

public class customer_Sensor : MonoBehaviour
{
    public float distance = 1.5f;
    public Vector3 boxsize = new Vector3(1f, 1f, 1f);
    public LayerMask customerLayer;
    public bool detected;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //void Start()
    //{

    //}

    // Update is called once per frame
    void Update()
    {
        Vector3 boxPosition = transform.position + transform.forward * distance;

        detected = Physics.CheckBox
            (
                boxPosition,
                boxsize / 2,
                transform.rotation,
                customerLayer
            );

        //Debug.Log("Sensor working: " + deteced);

        if (detected)
        {
            Debug.Log("Customer detected");
        }
    }
}
