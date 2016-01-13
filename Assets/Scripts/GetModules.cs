using UnityEngine;
using System.Collections;
using MySql.Data.MySqlClient;

public class GetModules : MonoBehaviour {

    public UIPopupList cbModulo;
    DataBase db = new DataBase();
	// Use this for initialization
	void Start ()
    {

        MySqlDataReader datos = db.Consultar("SELECT * FROM Module");

        while (datos.Read())
        {
            cbModulo.items.Add(datos["name"].ToString());
        }

            

    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
