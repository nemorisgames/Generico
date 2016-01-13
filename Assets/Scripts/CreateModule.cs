using UnityEngine;
using System.Collections;
using MySql.Data.MySqlClient;

public class CreateModule : MonoBehaviour {

    public UILabel texto;
    public UISprite iconoImagen;
    public Transform panelRoot;
    public string[] nombres;
    DataBase db = new DataBase();
    string usuario;
    // Use this for initialization
    void Start()
    {

       // texto.text = "";
        //Debug.Log("Usuario ");
        MySqlDataReader datos = db.Consultar("SELECT * FROM Structure");

      
       while (datos.Read())
        {
            //iconoImagen.spriteName = "check-naranjo";
            texto.text +=(string)datos["text"]+"\n";
        }

        for (int i = 0; i < nombres.Length; i++)
        {
            GameObject g = (GameObject)Instantiate(texto.gameObject);
            g.GetComponent<UILabel>().text = usuario;

            g.transform.parent = panelRoot;
            g.transform.localScale = Vector3.one;
            g.transform.localPosition = new Vector3(0f, i * -40f, 0f);
        }
    }

    // Update is called once per frame
    void Update () {
	
	}
}
