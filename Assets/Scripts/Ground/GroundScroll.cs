using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScroll : MonoBehaviour
{
    private SpriteRenderer[] tiles;
    [SerializeField]
    private float speed;
    private SpriteRenderer temp;
    // Start is called before the first frame update
    void Start()
    {
        tiles = GetComponentsInChildren<SpriteRenderer> ();
        speed = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < tiles.Length; i++)
        {
            if (tiles[i].transform.position.x <= -9.4)
            {
                temp = tiles[i];
                for (int j = 0; j < tiles.Length; j++)
                {
                    if (temp.transform.position.x < tiles[j].transform.position.x)
                    {
                        temp = tiles[j];
                    }
                }
                tiles[i].transform.position = new Vector2 (temp.transform.position.x + 5, -5);
            }
        }
        for (int i = 0; i < tiles.Length; i++)
        {
            tiles[i].transform.Translate (new Vector2 (-1, 0) * Time.deltaTime * speed);
        }
    }
}
