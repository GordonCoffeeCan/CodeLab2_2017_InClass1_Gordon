using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    [SerializeField]
    private Sprite[] sprites;

	// Use this for initialization
	void Start () {
        InvokeRepeating("SpriteTime", 1, 1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void SpriteTime() {
        MakeSprite(GetComponent<NumberGenerator>().Next());
    }

    private void MakeSprite(int _num) {
        GameObject _goSprite = new GameObject();
        Sprite _sp = sprites[_num];
        _goSprite.AddComponent<SpriteRenderer>().sprite = _sp;
        _goSprite.AddComponent<Rigidbody2D>();
    }
}
