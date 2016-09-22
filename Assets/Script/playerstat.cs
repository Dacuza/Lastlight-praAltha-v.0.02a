using UnityEngine;
using System.Collections;

public class playerstat : MonoBehaviour {

   
    public int hp;
    public int stamina;
    public int damage;
    public int def;
    
    // Use this for initialization
	void Start () {

        
       // pstat = new Stat(hp,stamina,damage,def);
        Debug.Log(Stat.hp);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
