using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Speed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!_isOver)
        {
            Speed += Time.deltaTime * Accelocator;
            if (Speed >= MaxSpeed)
            {
                Speed = MaxSpeed;
            }
            this.transform.position += new Vector3(Mathf.Clamp(Input.GetAxis("Mouse X"), -0.15f, 0.15f), 0, Speed);
            this.transform.position = new Vector3(Mathf.Clamp(this.transform.position.x, -4.5f, 4.5f), this.transform.position.y, this.transform.position.z);
            Camera.main.transform.position += new Vector3(0, 0, Speed);
        }
        
       if (Input.GetMouseButtonDown(0))
        {
            _isOver = false;
            LoseText.gameObject.SetActive(false);
        }
    }
    void OnTriggerEnter(Collider obj)
    {
        if (obj.name == "enemy")
        {
            Debug.Log("lose");
            _isOver = true;
            Speed = 0;
            LoseText.gameObject.SetActive(true);
        }
    }

    private float Speed;
    public float Accelocator;
    public float MaxSpeed;

    public TextMeshProUGUI LoseText;
    private bool _isOver = false;

    
}
