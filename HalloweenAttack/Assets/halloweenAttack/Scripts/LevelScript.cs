using UnityEngine;
using UnityEngine.UI;


/**
 * Gestioneaza numarul nivelului curent
 */
public class LevelScript: MonoBehaviour
    {

        /**
         * Nivelul curent
         */
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
