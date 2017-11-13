using UnityEngine;
using UnityEngine.UI;

public class LevelScript: MonoBehaviour
    {
        public static string levelValue = "1";
        Text level;


        // Use this for initialization
        void Start()
        {
            level = GetComponent<Text>();

        }

        // Update is called once per frame
        void Update()
        {
            level.text = "Level: " + levelValue;

        }
    }
