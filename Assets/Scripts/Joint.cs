using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Joint
{
	public string name{ get; set; }
	public float [] offset{ get; set; }
	public    float [] Jointmin{ get; set; }
	public float [] Jointmax{ get; set; }
	public float [] pose{ get; set;}
	public int parent{ get; set; }
	public List<Joint> child{ get; set;}
	public Joint()
	{
		name = "unnamed";
		offset = new float[3];
		offset [0] = 0f;
		offset [1] = 0f;
		offset [2] = 0f;
		Jointmin = new float[3];
		Jointmin [0] = -0.1f;
		Jointmin [1] = -0.1f;
		Jointmin [2] = -0.1f;
		Jointmax = new float[3];
		Jointmax [0] = -0.1f;
		Jointmax [1] = -0.1f;
		Jointmax [2] = -0.1f;

		pose = new float[3];
		pose [0] = 0;
		pose [1] = 0;
		pose [2] = 0;
	}
}
