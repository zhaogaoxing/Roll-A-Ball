using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Move : MonoBehaviour {
    public Rigidbody ball;
    public int force = 5;
    public int score = 0;
    public Text text;
    public GameObject wintext;
	// Use this for initialization
	void Start () {
	ball = GetComponent<Rigidbody>();
    ShowScore(text);
	}
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        ball.AddForce(new Vector3(h,0,v)*force);
        if(Input.GetKey(KeyCode.J)){
            ball.AddForce(new Vector3(0,100,0));
        }
	}

    //碰撞检测
    void OnCollisionEnter(Collision collision) { 
    //collision.collider//获取碰撞到的游戏物体身体上的collider组件
        //string name = collision.collider.name;//获取碰撞到物体的名字
        //print(name);
        if(collision.collider.tag == "food"){
            Destroy(collision.collider.gameObject);
        }
    }

    void OnTriggerEnter(Collider collider) { 
    if(collider.tag == "food"){
        score++;
        ShowScore(text);
        if(score == 6){
            wintext.SetActive(true);
        }
        Destroy(collider.gameObject);
    }
    }
    void ShowScore(Text text) {
        text.text = text.text + score;
    }

}
