using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderedNumberGenerator : NumberGenerator {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public int[] order;

    public int current = 0;

    public override int Next() {
        int resault = order[current % order.Length];

        current++;

        return resault;
    }
}
