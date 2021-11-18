using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemOUT : MonoBehaviour
{
    public Material[] mat;

    //public Renderer rend;

    public string itemName;

    public MeshRenderer meshRend;

    public Material[] newTexture;

    //public Material[] sharedMaterials;
    // Start is called before the first frame update
    void Start()
    {
        //meshRend.sharedMaterials[3] = newTexture;
        //meshRend.sharedMaterials[3] = newTexture;

        // mat[1] = meshRend.materials[1];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast (ray, out hit))

            {
                if (hit.transform.name == itemName)

                {

                    meshRend.sharedMaterial = newTexture[0];

                }
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))

            {
                if (hit.transform.name == itemName)

                {

                    meshRend.sharedMaterial = newTexture[1];

                }
            }
        }


    }

}
