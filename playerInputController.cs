using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInputController : MonoBehaviour
{
    public float walkSpeed=0.1f;
    public float jumpHeight=0.4f;
    public bool allowedToMove = true;
    // Start is called before the first frame update
    public GameObject player;
    public Animator movingAnimation;
    public float [] rotationX;
    public float [] rotationY;
    public float [] rotationZ;
    public float [] positionX;
    public float [] positionY;
    public float [] positionZ;



    // public Transform [] initialPositions;
 
    void Start()
    {
        movingAnimation = player.GetComponent<Animator>();
        //get array that takes each child's initial position

        rotationX = new float [8];
        rotationY = new float [8];
        rotationZ = new float [8];
        positionX = new float [8];
        positionY = new float [8];
        positionZ = new float [8];

        int x=0;
        foreach (Transform child in transform)
        {
            rotationX [x] = child.transform.rotation.x;
            rotationY [x] = child.transform.rotation.y;
            rotationZ [x] = child.transform.rotation.z;
            positionX [x] = child.position.x;
            positionY [x] = child.position.y;
            positionZ [x] = child.position.z;

//            Debug.Log(child +": "+positionX[x] + " "+ positionY[x] + " "+ positionZ[x]);


            x++;
        }

        // initialPositions = new Transform[8];
        // int x = 0;
        // foreach (Transform child in transform)
        // {
        //     initialPositions [x] = child.transform;
        //     x++;
        // }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("right") && allowedToMove)
        {
            gameObject.transform.position=new Vector3(gameObject.transform.position.x+walkSpeed,gameObject.transform.position.y,gameObject.transform.position.z);
            movingAnimation.enabled = true;
        }
        

        else 
        {
            movingAnimation.enabled = false;
            //all body parts must be set to initial transform before movement.

            // int i = 0;
            // foreach (Transform child in transform)
            // {
            //     if (i == 7) break;
            //     child.transform.rotation = Quaternion.Euler(rotationX[i],rotationY[i], rotationZ[i]);
            //     child.transform.position = new Vector3(gameObject.transform.position.x+ positionX [i], gameObject.transform.position.y + positionY [i], gameObject.transform.position.z+positionZ [i]);
            //     i++;
            // }

            // int y = 0;
            // foreach (Transform child in transform)
            // {
            //     child.transform.rotation = initialPositions[y].rotation;
            //     child.transform.position = initialPositions[y].position;
            //     if(Input.GetKey("down"))
            //     {
            //         Debug.Log(System.Environment.NewLine + child +" R: "+child.transform.rotation.x + " " + initialPositions[y].rotation.x + " / "+ child.transform.rotation.y+" "+ initialPositions[y].rotation.y + " / "+ child.transform.rotation.z +" "+ initialPositions[y].rotation.z + System.Environment.NewLine + child +" P: "+child.transform.position.x + " " + initialPositions[y].position.x + " / "+ child.transform.position.y+" "+ initialPositions[y].position.y + " / "+ child.transform.position.z +" "+ initialPositions[y].position.z);
            //     }
            //     Debug.Log(child +": "+child.transform.rotation.x + " "+ child.transform.rotation.y + " "+ child.transform.rotation.z);
            //     Debug.Log(child +": "+initialPositions[y].rotation.x + " "+ initialPositions[y].rotation.y + " "+ initialPositions[y].rotation.z);
            //     y++;
            // }

            // body.transform.rotation = Quaternion.Euler(0,0,0);
            // head.transform.rotation = Quaternion.Euler(0,0,0);
            // legleft.transform.rotation = Quaternion.Euler(0,0,0);
            // legright.transform.rotation = Quaternion.Euler(0,0,0);
            // tail.transform.rotation = Quaternion.Euler(0,0,0);
            // armleft.transform.rotation = Quaternion.Euler(0,0,0);
            // armright.transform.rotation = Quaternion.Euler(0,0,0);
        }

        if (Input.GetKey("up") && allowedToMove){
            //inactive until timer is done possibly double jump option
            
            gameObject.transform.position=new Vector4(gameObject.transform.position.x,gameObject.transform.position.y+jumpHeight,gameObject.transform.position.z);

        }

    }


}
